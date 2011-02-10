using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using McJoeAdmin.Model;
using System.Reflection;
using System.IO;

namespace McJoeAdmin.Cortex
{
    internal static class ModuleLoader
    {
        internal static List<ModuleAssemblyInstance> LoadModules()
        {
            var moduleList = new List<ModuleAssemblyInstance>();

            var adminModuleType = typeof(IMcAdminModule);
            var currentLoadedAssemblies = AppDomain.CurrentDomain.GetAssemblies().ToList();
            foreach (string str in Directory.GetFiles(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)))
            {
                if (currentLoadedAssemblies.Find((asm) => asm.Location == str) == null)
                {
                    Assembly assembly = Assembly.LoadFile(str);
                    if (assembly.GetTypes().FirstOrDefault((type) => adminModuleType.IsAssignableFrom(type)
                        && !type.IsInterface) != null)
                        moduleList.Add(new ModuleAssemblyInstance(assembly));
                }
            }

            return moduleList;
        }
    }
}
