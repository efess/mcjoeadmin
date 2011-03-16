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
        private const string MODULE_HOST_TYPE = "ModuleHost";
        private static string HOST_URI = "net.pipe://localhost";

        private static FileSystemWatcher _fileSystemWatcher;
        private static ModuleManager _instance;
        
        private ModuleHost.ModuleLoader _moduleLoader;
        private ServiceHost _serviceHost;
        private ManualResetEvent _shutdownServer = new ManualResetEvent(false);

        private string _wcfNamedPipe;
        private Action<McMessage> _messageOut;
        private string _searchPath = string.Empty;

        private List<IMcAdminModule> _modules = new List<IMcAdminModule>();
        private List<ModuleInstance> _loadedDomains = new List<ModuleInstance>();

        private ModuleManager(string pPath, Action<McMessage> pMessageOut)
        {
            _searchPath = pPath;
            _messageOut = pMessageOut;
            _wcfNamedPipe = new Random().Next(10000, 99999).ToString();

            LoadServer();

            LoadAllModules();

            _fileSystemWatcher = new FileSystemWatcher(pPath, DLL_EXTENSION_FILTER);
            _fileSystemWatcher.Created += (sender, e) => AssemblyCreated(e.FullPath, e.ChangeType);
            _fileSystemWatcher.Deleted += (sender, e) => AssemblyChanged(e.FullPath, e.ChangeType);
            _fileSystemWatcher.Changed += (sender, e) => AssemblyDeleted(e.FullPath, e.ChangeType);
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

        internal void LoadAllModules()
        {
            foreach (string str in Directory.GetFiles(
                Path.GetDirectoryName(
                    Assembly.GetExecutingAssembly().Location
                )
                , DLL_EXTENSION_FILTER))
            {
                System.Diagnostics.Debug.WriteLine("Trying to load module from assembly " + str);
                AddModule(str);
            }
        }

        private void AddModule(string pLocation)
        {
            var fileSize = new FileInfo(pLocation).Length;
            var instance = new ModuleInstance(pLocation, fileSize, _wcfNamedPipe);
            
            if(_loadedDomains.Any(mod => mod.Key == instance.Key))
                return;

            try
            {
                LoadModule(instance);
            }
            catch (RemotingException)// Not sure if this applies anymore.
            {
                throw;
                //lock (_modules)
                //    _modules.Clear();
                //AppDomain.Unload(_moduleAppDomain);
                //InitializeModuleDomain();
                //LoadAllModules();
            }
        }

        private void LoadModule(ModuleInstance pModule)
        {
            var moduleState = pModule.Load();

            var fileName = System.IO.Path.GetFileName(pModule.FileName);

            switch (moduleState)
            {
                case ModuleState.Loaded:
                    _messageOut(new McMessage(
                        string.Format("Adding Assembly {0}",
                            System.IO.Path.GetFileName(fileName)),
                            McMessageOrigin.Module, "INFO", DateTime.Now));

                    _loadedDomains.Add(pModule);
                    break;

                case ModuleState.LoadError:
                    _messageOut(new McMessage(
                        string.Format("Error while attempting to add Assembly {0}",
                            System.IO.Path.GetFileName(fileName)),
                            McMessageOrigin.Module, "INFO", DateTime.Now));
                    break;

                default:
                    _messageOut(new McMessage(
                        string.Format("No module types in Assembly {0}",
                            System.IO.Path.GetFileName(fileName)),
                            McMessageOrigin.Module, "INFO", DateTime.Now));
                    break;
            }
        }

        private void AssemblyCreated(string pPath, WatcherChangeTypes changeType)
        {
            System.Diagnostics.Debug.WriteLine("---->Assembly Created (" + changeType.ToString() + ") " + pPath + " ");
            FolderChange(pPath, changeType);
        }

        private void AssemblyChanged(string pPath, WatcherChangeTypes changeType)
        {
            System.Diagnostics.Debug.WriteLine("---->Assembly Changed (" + changeType.ToString()  + ") " + pPath + " ");
            FolderChange(pPath, changeType);
        }
        private void AssemblyDeleted(string pPath, WatcherChangeTypes changeType)
        {
            System.Diagnostics.Debug.WriteLine("---->Assembly Deleted (" + changeType.ToString() + ") " + pPath + " ");
            FolderChange(pPath, changeType);
        }

        private void FolderChange(string pPath, WatcherChangeTypes pChangeType)
        {
            switch (pChangeType)
            {
                case WatcherChangeTypes.Deleted:
                    RemoveModule(pPath);
                    break;
                case WatcherChangeTypes.Created:
                    AddModule(pPath);
                    break;
            }
        }

        private void RemoveModule(string pPath)
        {
            var instance = _loadedDomains.FirstOrDefault(mod => mod.FileName == pPath);
            var fileName = System.IO.Path.GetFileName(pPath);

            if (instance != null)
            {
                try
                {
                    instance.Unload();
                    _loadedDomains.Remove(instance);

                    _messageOut(new McMessage(
                        string.Format("Removed module: {0}", fileName),
                            McMessageOrigin.Module, "INFO", DateTime.Now));
                }
                catch (CannotUnloadAppDomainException ex)
                {
                    _messageOut(new McMessage(
                        string.Format("Error while attempting to unload app domain for {0}: {1}",fileName, ex.Message),
                            McMessageOrigin.Module, "ERROR", DateTime.Now));
                    _messageOut(new McMessage(
                        string.Format("Detail: {0}", ex.ToString()),
                            McMessageOrigin.Module, "ERROR", DateTime.Now));
                }
                catch (Exception ex) // Remoting exception?
                {
                    _messageOut(new McMessage(
                        string.Format("General error attempting to unload {0}: {1}", fileName, ex.Message),
                            McMessageOrigin.Module, "ERROR", DateTime.Now));
                    _messageOut(new McMessage(
                        string.Format("Detail: {0}", ex.ToString()),
                            McMessageOrigin.Module, "ERROR", DateTime.Now));
                    System.Diagnostics.Debugger.Break();
                }       
            }
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

        public void UnSuscribe(string pModuleName)
        {
            var callback = OperationContext.Current.GetCallbackChannel<IMcAdminModule>();

            lock (_modules)
                if (_modules.Contains(callback))
                {
                    _messageOut(new McMessage(
                        string.Format("UnSubscribing module {0}",
                            string.IsNullOrEmpty(pModuleName) ? "NoName" : pModuleName),
                            McMessageOrigin.Module, "INFO", DateTime.Now));
                    _modules.Remove(callback);
                }
        }

        public void MessageOut(McMessage pMessage)
        {
            _messageOut(pMessage);
        }

        #endregion
    }
}
