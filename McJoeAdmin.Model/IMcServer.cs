using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using McJoeAdmin.Model.Events;

namespace McJoeAdmin.Model
{
    public interface IMcServer
    {
        void Start();
        void Close();
        bool IsRunning { get; }
        void WriteInputLine(string pData);
        event McMessageEventHandler ReadOutputLine;
        long CurrentMemoryUsage { get; }
        float CurrentCpuUsage { get; }
        string StartupString { get; }
    }
}
