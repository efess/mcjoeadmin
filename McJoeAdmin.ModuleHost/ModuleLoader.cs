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
        private ModuleCollection _currentLoadedModules;
        private string _wcfNamedPipe;

        public ModuleLoader(string pWcfNamedPipe)
        {
            _wcfNamedPipe = pWcfNamedPipe;
            _currentLoadedModules = new ModuleCollection();
        }


        public bool TryLoadModule(string pPath, out bool error)
        {
            //var moduleAssemblyInstance new ModuleAssemblyInstance(Assembly.LoadFile(pPath));
            error = false;

            if (AppDomain.CurrentDomain.GetAssemblies().ToList().Find((asm) => asm.Location == pPath) == null
                && _currentLoadedModules.FirstOrDefault((im) => im.Path == pPath) == null)
            {
                var adminModuleType = typeof(IMcAdminModule);

                Assembly assembly = Assembly.LoadFrom(pPath);
                var types = assembly.GetTypes();

                // Find that there is an IMcAdminModule type in this assembly
                if (types.FirstOrDefault((type) => adminModuleType.IsAssignableFrom(type)
                                             && !type.IsInterface && !type.IsAbstract) != null)
                {
                    try
                    {
                        var instance = new ModuleAssemblyInstance(assembly);
                        foreach (var mod in instance.AdminModules()) { mod.ConnectToLocalhost(_wcfNamedPipe); }
                        _currentLoadedModules.Add(instance);

                        return true;
                    }
                    catch { error = true; } 
                }
            }
            return false;
        }
    }
}
