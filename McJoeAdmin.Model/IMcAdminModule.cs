using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace McJoeAdmin.Model
{
    public interface IMcAdminModule
    {
        void SetAdminRules(AdminRules pAdminRules);
        
        void ConnectToLocalhost(string pPipe);

        [OperationContract(IsOneWay = true)]
        void MessageIn(McMessage pMessage);

        [OperationContract(IsOneWay = true)]
        void Unloading();
    }
}
