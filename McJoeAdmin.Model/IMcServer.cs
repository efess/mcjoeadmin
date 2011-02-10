using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace McJoeAdmin.Model
{
    public interface IMcServer
    {
        void Start();
        void Close();
        bool IsRunning { get; }
        void WriteInputLine(string pData);
        event LineOutputEventHandler ReadOutputLine;
        long CurrentMemoryUsage { get; }
    }
}
