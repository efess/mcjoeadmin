using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using McJoeAdmin.Model;
using System.Collections.ObjectModel;

namespace McJoeAdmin.Cortex
{
    internal class ModuleCollection : Collection<ModuleAssemblyInstance>
    {
        public void Add(ModuleAssemblyInstance pInstance)
        {
            if(pInstance != null)
                this.Insert(this.Count, pInstance);
        }

        public McMessage ProcessMessage(McMessage pMessage)
        {
            return pMessage;
        }
    }
}
