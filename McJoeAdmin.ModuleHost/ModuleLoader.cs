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

        //public ModuleHost(Action<McMessage> pMessageOutPipe)
        public ModuleLoader()
        {
            //if (pMessageOutPipe == null)
            //    throw new ArgumentNullException("pMessageOutPipe");
            
            //_messageOut = pMessageOutPipe;
            _currentLoadedModules = new ModuleCollection();
        }


        public void TryLoadModule(string pPath)
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
                    var instance = new ModuleAssemblyInstance(assembly);
                    _currentLoadedModules.Add(instance);
                }
            }
        }
    }
}
