using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace McJoeAdmin.Cortex
{
    internal class ModuleAssemblyInstance
    {
        private Assembly _assembly;
        internal ModuleAssemblyInstance(Assembly pAssembly)
        {
            _assembly = pAssembly;
        }
    }
}
