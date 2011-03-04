using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace McJoeAdmin.Model
{
    public interface IView
    {
        void OutputConsoleText(McMessage pOutput);
        void ServerInformation(ServerInformation pServerInformation);

        Action<string> InputText {  set; }
        Action StartServer { set; }
        Action ShutdownServer { set; }
        Func<bool> IsRunning { set; }
        Action<int> SetUpdateInterval { set; }

    }
}
