using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace McJoeAdmin.Model
{
    [ServiceContract(Namespace = "http://www.McJoeAdmin.com/HostPipe", CallbackContract = typeof(IMcAdminModule))]
    public interface IModuleManager
    {
        [OperationContract]
        void Subscribe();

        [OperationContract]
        void MessageOut(McMessage pMessage);
    }
}
