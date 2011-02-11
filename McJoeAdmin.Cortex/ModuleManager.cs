using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using McJoeAdmin.Model;
using System.Reflection;
using System.IO;

namespace McJoeAdmin.Cortex
{
    internal class ModuleManager
    {
        private const string DLL_EXTENSION_FILTER = "*.dll";
        private const string DLL_MODULE_HOST = "McJoeAdmin.ModuleHost";
        private const string MODULE_HOST_TYPE = "ModuleHost";
        private static FileSystemWatcher _fileSystemWatcher;
        private static ModuleManager _instance;
        private AppDomain _moduleAppDomain;
        private object _moduleHost;
        
        private string _searchPath = string.Empty;

        private ModuleManager(string pPath)
        {
            _searchPath = pPath;

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

        internal static ModuleManager GetInstance(string pPath)
        {
            if (_instance == null)
            {
                if(string.IsNullOrEmpty(pPath))
                    throw new ArgumentNullException("pPath");
                
                _instance = new ModuleManager(pPath);
            }
            return _instance;
        }

        internal void InitializeModuleDomain()
        {
            _moduleAppDomain = AppDomain.CreateDomain("Modules");
            _moduleAppDomain.Load(DLL_MODULE_HOST);
            BindingFlags flags = (BindingFlags.Public | BindingFlags.CreateInstance |
			       BindingFlags.Instance);

            _moduleHost = _moduleAppDomain.CreateInstance(DLL_MODULE_HOST, "McJoeAdmin.ModuleHost.ModuleHost", false, flags, 
				null, null, null, null, null);
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
            
            _moduleHost.GetType().GetMethod("TryLoadModule").Invoke(_moduleHost, new object[] {str});
        }


        private void AssemblyCreated(string pPath)
        {
            LoadModule(pPath);
        }
        
        private void AssemblyDeleted(string pPath)
        {
            AppDomain.Unload(_moduleAppDomain);
            InitializeModuleDomain();
            LoadAllModules();
        }
    }
}
