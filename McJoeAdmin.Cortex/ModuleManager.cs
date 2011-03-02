using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using McJoeAdmin.Model;
using McJoeAdmin.ModuleHost;
using System.Reflection;
using System.IO;
using System.ServiceModel;
using System.Threading;
using System.Runtime.Remoting;

namespace McJoeAdmin.Cortex
{
    [ServiceBehavior(InstanceContextMode=InstanceContextMode.Single)]
    internal class ModuleManager : IModuleManager
    {
        private const string DLL_EXTENSION_FILTER = "*.dll";
        private const string DLL_MODULE_HOST = "McJoeAdmin.ModuleHost";
        private const string MODULE_HOST_TYPE = "ModuleHost";
        private static string HOST_URI = "net.pipe://localhost";

        private static FileSystemWatcher _fileSystemWatcher;
        private static ModuleManager _instance;
        private AppDomain _moduleAppDomain;
        private ModuleHost.ModuleLoader _moduleLoader;
        private ServiceHost _serviceHost;
        private ManualResetEvent _shutdownServer = new ManualResetEvent(false);

        private string _wcfNamedPipe;
        private Action<McMessage> _messageOut;
        private string _searchPath = string.Empty;

        private ModuleManager(string pPath, Action<McMessage> pMessageOut)
        {
            _searchPath = pPath;
            _messageOut = pMessageOut;
            _wcfNamedPipe = new Random().Next(10000, 99999).ToString();

            LoadServer();

            InitializeModuleDomain();
            LoadAllModules();

            _fileSystemWatcher = new FileSystemWatcher(pPath, DLL_EXTENSION_FILTER);
            _fileSystemWatcher.Created += (sender, e) => AssemblyCreated(e.FullPath);
            _fileSystemWatcher.Deleted += (sender, e) => AssemblyDeleted(e.FullPath);
            _fileSystemWatcher.Changed += (sender, e) => AssemblyDeleted(e.FullPath);
            _fileSystemWatcher.EnableRaisingEvents = true;
        }

        //internal void SetAdminRules(AdminRules pRules)
        //{
        //    _currentAdminRules = pRules;
        //}

        internal static ModuleManager GetInstance(string pPath, Action<McMessage> pMessageOut)
        {
            if (_instance == null)
            {
                if(string.IsNullOrEmpty(pPath))
                    throw new ArgumentNullException("pPath");
                if (string.IsNullOrEmpty(pPath))
                    throw new ArgumentNullException("pMessageOut");
                
                _instance = new ModuleManager(pPath, pMessageOut);
                
            }
            return _instance;
        }


        public void SendMessageToModuleHost(McMessage pMessage)
        {
            lock(_modules)
                for(int i = _modules.Count - 1; i >= 0; i--)
                {
                    var module = _modules[i];

                    if (((ICommunicationObject)module).State == CommunicationState.Opened)
                        module.MessageIn(pMessage);
                    else
                    {
                        _messageOut(new McMessage(
                            string.Format("Module was in {0} State, unloading",
                                ((ICommunicationObject)module).State.ToString()),
                                McMessageOrigin.Module, "ERROR",DateTime.Now));
                        _modules.RemoveAt(i);
                    }
                }
        }

        internal void InitializeModuleDomain()
        {
            AppDomainSetup ads = new AppDomainSetup();
            ads.ShadowCopyFiles = "true"; // In order to prevent local locking of DLL files
            _moduleAppDomain = AppDomain.CreateDomain("Modules", null, ads);
            BindingFlags flags = (BindingFlags.Public | BindingFlags.CreateInstance |
			       BindingFlags.Instance);

            var messageOut = new Action<McMessage>((mcm) => _messageOut(mcm));

            _moduleLoader = _moduleAppDomain.CreateInstanceAndUnwrap(
                DLL_MODULE_HOST, 
                "McJoeAdmin.ModuleHost.ModuleLoader", 
                false, 
                flags,
                null, 
                new object[]{_wcfNamedPipe}, 
                null, 
                null) as ModuleHost.ModuleLoader;
        }
        
        internal void LoadAllModules()
        {
            foreach (string str in Directory.GetFiles(
                Path.GetDirectoryName(
                    Assembly.GetExecutingAssembly().Location
                )
                , DLL_EXTENSION_FILTER))
            {
                System.Diagnostics.Debug.WriteLine("Trying to load module in file " + str);
                LoadModule(str);
            }
        }

        private void LoadModule(string str)
        {
            bool error;
            if (_moduleLoader.TryLoadModule(str, out error))
            {
                _messageOut(new McMessage(
                    string.Format("Adding Assembly {0}",
                        System.IO.Path.GetFileName(str)),
                        McMessageOrigin.Module, "INFO", DateTime.Now));
            }
            else if (error)
            {
                _messageOut(new McMessage(
                    string.Format("Error while attempting to add Assembly {0}",
                        System.IO.Path.GetFileName(str)),
                        McMessageOrigin.Module, "INFO", DateTime.Now));
            }
        }


        private void AssemblyCreated(string pPath)
        {
            System.Diagnostics.Debug.WriteLine("---->Assembly Created " + pPath);

            try
            {
                LoadModule(pPath);
            }
            catch (RemotingException)
            {
                lock (_modules)
                    _modules.Clear();
                AppDomain.Unload(_moduleAppDomain);
                InitializeModuleDomain();
                LoadAllModules();
            }
        }
        
        private void AssemblyDeleted(string pPath)
        {
            System.Diagnostics.Debug.WriteLine("---->Assembly Deleted " + pPath);
            lock(_modules)
                _modules.Clear();
            AppDomain.Unload(_moduleAppDomain);
            InitializeModuleDomain();
            LoadAllModules();
        }

        private void LoadServer()
        {
            new Action(() =>
            {
                _serviceHost = new ServiceHost(this,
                    new Uri[]{
                            new Uri(new Uri(HOST_URI), _wcfNamedPipe)
                    });

                _serviceHost.AddServiceEndpoint(typeof(IModuleManager),
                    new NetNamedPipeBinding()
                    {
                        SendTimeout = new TimeSpan(0,0,30),
                        ReceiveTimeout = TimeSpan.MaxValue                        
                    },
                    new Uri(new Uri(HOST_URI), _wcfNamedPipe));

                _serviceHost.Open();
                _shutdownServer.WaitOne();

            }).BeginInvoke(null, null);
        }

        #region IModuleManager Members

        private List<IMcAdminModule> _modules = new List<IMcAdminModule>();
        public void Subscribe(string pModuleName)
        {
            var callback = OperationContext.Current.GetCallbackChannel<IMcAdminModule>();

            lock(_modules)
                if (!_modules.Contains(callback))
                {
                    _messageOut(new McMessage(
                        string.Format("Subscribing module {0}",
                            string.IsNullOrEmpty(pModuleName) ? "NoName" : pModuleName),
                            McMessageOrigin.Module, "INFO", DateTime.Now));
                    _modules.Add(callback);
                }
        }

        public void MessageOut(McMessage pMessage)
        {
            _messageOut(pMessage);
        }

        #endregion
    }
}
