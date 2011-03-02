using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Meebey.SmartIrc4net;
using System.Text.RegularExpressions;
using System.ServiceModel;
using McJoeAdmin.ModuleHost;
using McJoeAdmin.Model;
using System.Configuration;

namespace McJoeAdmin.IrcBot
{
    [CallbackBehavior(ConcurrencyMode = ConcurrencyMode.Reentrant)]
    public class IrcBot : McModuleBase
    {
        IrcBotConfig _config;
        IrcClient _ircClient;

        public override string Name
        {
            get { return "IrcBot"; }
        }

        public IrcBot()
        {
            _config = ConfigurationManager.GetSection("IrcBotConfig") as IrcBotConfig;
            
            InitializeClient();
        }

        public override void SetAdminRules(AdminRules pRules)
        {
            throw new NotImplementedException();
        }

        private void InitializeClient()
        {
            _ircClient = new IrcClient();
            _ircClient.OnReadLine += (sender, e) => IrcRawOutput(e.Line.ToString());
            _ircClient.OnConnected += (sender, e) => ConnectedOk();

            new Action(() => 
                {
                    System.Threading.Thread.CurrentThread.Name = "Stupid Listen thread... WTF?";
                    while(true)
                    {
                        _ircClient.Listen();
                        System.Threading.Thread.Sleep(100);
                    }
                }).BeginInvoke(null, null);

            _ircClient.Connect(_config.Server, _config.Port);
            
            _ircClient.AutoRejoin = true;
            _ircClient.Login(_config.BotNick, _config.BotNick);
            

            _ircClient.OnConnectionError += (sender, e) => System.Diagnostics.Debug.WriteLine(e.ToString());
            _ircClient.OnChannelMessage += (sender, e) => ChannelMessage(e.Data);
        }
        private void IrcRawOutput(string pMessage)
        {
            System.Diagnostics.Debug.WriteLine(pMessage);
        }

        private void ConnectedOk()
        {
            _ircClient.RfcJoin(_config.Channel);
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
            if (!_ircClient.IsConnected)
                return;

            var playerMessage = new McPlayerMessage(pMessage.Data);
            if(!string.IsNullOrEmpty(playerMessage.Name))
            {
                _ircClient.SendMessage(SendType.Message, _config.Channel, pMessage.Data);
            }
        }
    }
}
