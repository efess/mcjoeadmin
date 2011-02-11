using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using McJoeAdmin.Model;

namespace McJoeAdmin.ModuleHost
{
    public class ModuleHost
    {
        private ModuleCollection _currentLoadedModules;

        public ModuleHost()
        {
            _currentLoadedModules = new ModuleCollection();
        }

        internal void TryLoadModule(string pPath)
        {
            //var moduleAssemblyInstance new ModuleAssemblyInstance(Assembly.LoadFile(pPath));

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
                    _currentLoadedModules.Add(new ModuleAssemblyInstance(assembly));
                }
            }
        }
    }
}
