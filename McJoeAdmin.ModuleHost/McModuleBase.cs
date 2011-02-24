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
        private const int WCF_RETRY = 3;
        private string _pipe;
        private bool _isConnected;

        public abstract string Name { get; }

        public McModuleBase()
        {
            _isConnected = false;
        }

        public abstract void SetAdminRules(AdminRules pRules);
        public abstract void MessageIn(McMessage pMessage);

        private IModuleManager _hostProxy;

        protected virtual void SendMessage(string pMessage)
        {
            if(_isConnected)
                _hostProxy.MessageOut(new McMessage(pMessage, McMessageOrigin.Module, this.GetType().Name, DateTime.Now));
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

        public void ConnectToLocalhost(string pPipe)
        {
            _pipe = pPipe;
            ConnectToHost();
        }

        private void ConnectToHost()
        {
            DuplexChannelFactory<IModuleManager> pipeFactory =
                new DuplexChannelFactory<IModuleManager>(this,
                     new NetNamedPipeBinding()
                     {
                         CloseTimeout = new TimeSpan(0,0,30),
                         OpenTimeout = new TimeSpan(0,0,30),
                         ReceiveTimeout = TimeSpan.MaxValue,
                         SendTimeout = new TimeSpan(0,0,30)
                     },
                     new EndpointAddress(
                        "net.pipe://localhost/" + _pipe));

            int retryTimes = 0;
            bool needsRetry = false;
            Exception ex = null;

            do
            {
                try
                {
                    _hostProxy = pipeFactory.CreateChannel();
                    _hostProxy.Subscribe(Name);
                    
                    _isConnected = true;
                }
                catch(Exception e)
                {
                    ex = e;
                    needsRetry = true;
                }
            }
            while (needsRetry && ++retryTimes < WCF_RETRY);

            if (!_isConnected &&
                ex != null)
            {
                throw ex;
            }

        }
    }
}
