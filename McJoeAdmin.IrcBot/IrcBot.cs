using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Meebey.SmartIrc4net;
using System.Text.RegularExpressions;
using System.ServiceModel;
using McJoeAdmin.ModuleHost;
using McJoeAdmin.Model;

namespace McJoeAdmin.IrcBot
{
    [CallbackBehavior(ConcurrencyMode = ConcurrencyMode.Reentrant)]
    public class IrcBot : McModuleBase
    {
        IrcClient _ircClient;
        private string _channelName = "#mcjoeadmin";
        public override string Name
        {
            get { return "IrcBot"; }
        }
        public IrcBot()
        {
            InitializeClient();
        }

        public override void SetAdminRules(AdminRules pRules)
        {
            throw new NotImplementedException();
        }

        private void InitializeClient()
        {
            _ircClient = new IrcClient();
            
            _ircClient.Connect("irc.dal.net", 6664);
            _ircClient.AutoRejoin = true;
            _ircClient.Login("McJoeAdminBot", "Joe");
            _ircClient.RfcJoin(_channelName);

            _ircClient.OnConnectionError += (sender, e) => System.Diagnostics.Debug.WriteLine(e.ToString());
            _ircClient.OnChannelMessage += (sender, e) => ChannelMessage(e.Data);
            _ircClient.OnReadLine += (sender, e) => System.Diagnostics.Debug.WriteLine(e.Line.ToString());
        }

        private void ChannelMessage(IrcMessageData pMessage)
        {
            Regex reg = new Regex("!mc (.+)");

            var match = reg.Match(pMessage.RawMessage);

            var groups = match.Groups;
            if (groups.Count == 2)
            {
                SendMessage(string.Format("[{0}@IRC]: {1}", pMessage.Nick, groups[1].Value.Trim()));
            }
        }

        public override void MessageIn(McJoeAdmin.Model.McMessage pMessage)
        {
            if (!_ircClient.IsJoined(_channelName)
                || !_ircClient.IsConnected)
                return;
            var playerMessage = new McPlayerMessage(pMessage.Data);
            if(!string.IsNullOrEmpty(playerMessage.Name))
            {
                _ircClient.SendMessage(SendType.Message, _channelName, pMessage.Data);
            }
        }
    }
}
