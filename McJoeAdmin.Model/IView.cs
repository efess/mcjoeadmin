using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace McJoeAdmin.Model
{
    public interface IView
    {
        void OutputConsoleText(string pOutput);
        Action<string> InputText {  set; }
        Action StartServer { set; }
        Action ShutdownServer { set; }
        Func<bool> IsRunning { set; }
        Func<long> MemoryUsed { set; }
    }
}
