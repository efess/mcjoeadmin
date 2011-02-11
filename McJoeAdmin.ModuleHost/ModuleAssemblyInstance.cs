using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using McJoeAdmin.Model;

namespace McJoeAdmin.ModuleHost
{
    internal class ModuleAssemblyInstance
    {
        private Assembly _assembly;
        private List<IMcAdminModule> _adminModules;

        internal ModuleAssemblyInstance(Assembly pAssembly)
        {
            if (pAssembly == null)
                throw new ArgumentNullException("pAssembly");

            _assembly = pAssembly;
            LoadTypes();
        }

        private void LoadTypes()
        {
            _adminModules = new List<IMcAdminModule>();

            var adminModuleType = typeof(IMcAdminModule);

            var types = _assembly.GetTypes();

            foreach(var type in types.Where(type1 => !type1.IsAbstract
                && !type1.IsInterface
                && adminModuleType.IsAssignableFrom(type1)
                && types.FirstOrDefault(type2 => type2 != type1
                    && type1.IsAssignableFrom(type2)) == null))
            {
                _adminModules.Add(
                    Activator.CreateInstance(type) as IMcAdminModule);
            }
        }

        public string Path
        {
            get
            {
                return _assembly.Location;
            }
        }

        public IEnumerator<IMcAdminModule> AdminMoudles()
        {
            return _adminModules.GetEnumerator();
        }
    }
}
