using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using McJoeAdmin.Model;
using System.ServiceModel;

namespace McJoeAdmin.BasicAdminRulesModule
{
    [CallbackBehavior(ConcurrencyMode = ConcurrencyMode.Reentrant)]
    public class BasicAdminRules : IMcAdminModule
    {
        public BasicAdminRules()
        {
            ConnectToHost();
        }

        // IMcAdminModule Implementation
        private AdminRules _currentAdminRules;
        private IModuleManager _hostProxy;

        public void SetAdminRules(AdminRules pAdminRules)
        {
            _currentAdminRules = pAdminRules;
        }

        public void MessageIn(McMessage pMessage)
        {
            var message = ProcessMessage(pMessage);
            
            _hostProxy.MessageOut(message);
        }

        private McMessage ProcessMessage(McMessage pMessage)
        {
            return new McMessage("FROM MODULE " + pMessage.Data, McMessageOrigin.AdminRule);
        }

        private void ConnectToHost()
        {
            DuplexChannelFactory<IModuleManager> pipeFactory =
                new DuplexChannelFactory<IModuleManager>(this,
                     new NetNamedPipeBinding(),
                     new EndpointAddress(
                        "net.pipe://localhost/Pipe"));

            _hostProxy = pipeFactory.CreateChannel();
            _hostProxy.Subscribe();
        }
    }
}
