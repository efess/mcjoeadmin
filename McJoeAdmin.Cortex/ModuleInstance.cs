using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using McJoeAdmin.Model;
using McJoeAdmin.ModuleHost;
using System.Runtime.Remoting.Lifetime;

namespace McJoeAdmin.Cortex
{
    internal class ModuleInstance
    {
        private const string DLL_MODULE_HOST = "McJoeAdmin.ModuleHost";

        public AppDomain TheAppDomain { get; private set; }

        public long Size { get; private set; }
        public string FileName { get; private set; }

        public string Key { get { return CreateKey(FileName, Size); } }

        private ModuleLoader _loader;
        private string _wcfPipe;

        private static string CreateKey(string pFileName, long pSize)
        {
            return pFileName + "@" + pSize.ToString();
        }

        internal ModuleInstance(string pFileName, long pSize, string pWcfPipe)
        {
            FileName = pFileName;
            Size = pSize;

            _wcfPipe = pWcfPipe;           
        }

        internal ModuleState Load()
        {
            AppDomainSetup ads = new AppDomainSetup();
            ads.ShadowCopyFiles = "true"; // In order to prevent local locking of DLL files

            TheAppDomain = AppDomain.CreateDomain(Key, null, ads);

            BindingFlags flags = (BindingFlags.Public | BindingFlags.CreateInstance |
                   BindingFlags.Instance);

            _loader = TheAppDomain.CreateInstanceAndUnwrap(
                DLL_MODULE_HOST,
                "McJoeAdmin.ModuleHost.ModuleLoader",
                false,
                flags,
                null,
                new object[] { _wcfPipe },
                null,
                null) as ModuleHost.ModuleLoader;
            
            bool error;
            if (_loader.TryLoadModule(FileName, out error))
                return ModuleState.Loaded;
            else if(error)
                return ModuleState.LoadError;
            else 
                return ModuleState.NoTypesToLoad;
        }

        public void Unload()
        {
            if (_loader == null)
                throw new InvalidOperationException("Cannot unload before load is called");

            _loader.Unload();

            AppDomain.Unload(TheAppDomain);
        }
    }
}
