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
        private ModuleHost.ModuleLoader _moduleHost;
        private ServiceHost _serviceHost;
        private ManualResetEvent _shutdownServer = new ManualResetEvent(false);

        private Action<McMessage> _messageOut;
        private string _searchPath = string.Empty;

        private ModuleManager(string pPath, Action<McMessage> pMessageOut)
        {
            _searchPath = pPath;
            _messageOut = pMessageOut;
            LoadServer();

            InitializeModuleDomain();
            LoadAllModules();

            _fileSystemWatcher = new FileSystemWatcher(pPath, DLL_EXTENSION_FILTER);
            _fileSystemWatcher.Created += (sender, e) => AssemblyCreated(e.FullPath);
            _fileSystemWatcher.Deleted += (sender, e) => AssemblyDeleted(e.FullPath);
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
            foreach (var module in _modules)
            {
                if (((ICommunicationObject)module).State == CommunicationState.Opened)
                    module.MessageIn(pMessage);
                else
                    _modules.Remove(module);
            }
        }

        internal void InitializeModuleDomain()
        {
            _moduleAppDomain = AppDomain.CreateDomain("Modules");
            _moduleAppDomain.Load(DLL_MODULE_HOST);
            BindingFlags flags = (BindingFlags.Public | BindingFlags.CreateInstance |
			       BindingFlags.Instance);

            var messageOut = new Action<McMessage>((mcm) => _messageOut(mcm));

            _moduleHost = _moduleAppDomain.CreateInstanceAndUnwrap(DLL_MODULE_HOST, "McJoeAdmin.ModuleHost.ModuleLoader", false, flags,
                null, null, null, null) as ModuleHost.ModuleLoader;
        }
        
        internal void LoadAllModules()
        {
            foreach (string str in Directory.GetFiles(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), DLL_EXTENSION_FILTER))
            {
                LoadModule(str);
            }
        }

        private void LoadModule(string str)
        {
            _moduleHost.TryLoadModule(str);
        }


        private void AssemblyCreated(string pPath)
        {
            LoadModule(pPath);
        }
        
        private void AssemblyDeleted(string pPath)
        {
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
                            new Uri(HOST_URI)
                    });

                _serviceHost.AddServiceEndpoint(typeof(IModuleManager),
                    new NetNamedPipeBinding(),
                    "Pipe");

                _serviceHost.Open();
                _shutdownServer.WaitOne();

            }).BeginInvoke(null, null);
        }

        #region IModuleManager Members

        private List<IMcAdminModule> _modules = new List<IMcAdminModule>();
        public void Subscribe()
        {
            var callback = OperationContext.Current.GetCallbackChannel<IMcAdminModule>();
            lock(_modules)
                if (!_modules.Contains(callback))
                    _modules.Add(callback);
        }

        public void MessageOut(McMessage pMessage)
        {
            _messageOut(pMessage);
        }

        #endregion
    }
}
