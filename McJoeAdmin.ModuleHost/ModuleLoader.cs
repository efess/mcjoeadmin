using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using McJoeAdmin.Model;
using McJoeAdmin.Model.Events;

namespace McJoeAdmin.ModuleHost
{
    public class ModuleLoader : MarshalByRefObject
    {
        private string _wcfNamedPipe;
        private List<IMcAdminModule> _loadedModules;

        public ModuleLoader(string pWcfNamedPipe)
        {
            _wcfNamedPipe = pWcfNamedPipe;
        }

        public bool TryLoadModule(string pPath, out bool error)
        {
            //var moduleAssemblyInstance new ModuleAssemblyInstance(Assembly.LoadFile(pPath));
            error = false;
            bool moduleLoaded = false;

            var adminModuleType = typeof(IMcAdminModule);

            Assembly assembly = Assembly.LoadFrom(pPath);
            var types = assembly.GetTypes();

            // Find that there is an IMcAdminModule type in this assembly
            if (types.FirstOrDefault((type) => adminModuleType.IsAssignableFrom(type)
                                            && !type.IsInterface && !type.IsAbstract) != null)
            {
                try
                {
                    LoadTypes(assembly);
                    foreach (var mod in _loadedModules) { mod.ConnectToLocalhost(_wcfNamedPipe); moduleLoaded = true; }
                }
                catch { error = true; return false; } 
            }
            
            return moduleLoaded;
        }

        public bool Unload()
        {
            foreach (var mod in _loadedModules)
            {
                try
                {
                    mod.Unloading();
                }
                catch
                {
                    return false;
                }
            }

            return true;
        }

        private void LoadTypes(Assembly pAssembly)
        {
            _loadedModules = new List<IMcAdminModule>();

            var adminModuleType = typeof(IMcAdminModule);

            var types = pAssembly.GetTypes();

            foreach(var type in types.Where(type1 => !type1.IsAbstract
                && !type1.IsInterface
                && adminModuleType.IsAssignableFrom(type1)
                && types.FirstOrDefault(type2 => type2 != type1
                    && type1.IsAssignableFrom(type2)) == null))
            {
                var module = Activator.CreateInstance(type);
                _loadedModules.Add(module as IMcAdminModule);
            }
        }
    }
}
