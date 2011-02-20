using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace McJoeAdmin.Model
{
    public class ServerInformation
    {
        public string MemoryUsage { get; private set; }
        public string CpuUsage { get; private set; }
        public string StartupString { get; private set; }

        public ServerInformation(string pMemoryUsage, string pCpuUsage, string pStartupString)
        {
            MemoryUsage = pMemoryUsage;
            CpuUsage = pCpuUsage;
            StartupString = pStartupString;
        }
    }
}
