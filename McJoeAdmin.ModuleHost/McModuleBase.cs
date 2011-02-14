using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using McJoeAdmin.Model;
using System.ServiceModel;
using System.Text.RegularExpressions;

namespace McJoeAdmin.ModuleHost
{
    public abstract class McModuleBase : IMcAdminModule
    {
        public McModuleBase()
        {
            ConnectToHost();
        }

        public abstract void SetAdminRules(AdminRules pRules);
        public abstract void MessageIn(McMessage pMessage);

        private IModuleManager _hostProxy;

        protected virtual void SendMessage(string pMessage)
        {
            _hostProxy.MessageOut(new McMessage(pMessage, McMessageOrigin.AdminRule, this.GetType().Name, DateTime.Now));
        }

        protected virtual Tuple<string, string> ReturnPlayerAndData(string pData)
        {
            Regex reg = new Regex("<(.+)> (.+)");

            var match = reg.Match(pData);
            var groups = match.Groups;
            if (groups.Count == 3)
                return new Tuple<string, string>(groups[1].Value.Trim(), groups[2].Value.Trim());

            return new Tuple<string, string>(null, pData);
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
