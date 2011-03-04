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
using System.Threading;

namespace McJoeAdmin.IrcBot
{
    [CallbackBehavior(ConcurrencyMode = ConcurrencyMode.Reentrant)]
    public class IrcBot : McModuleBase, IDisposable
    {
        IrcBotConfig _config;
        IrcClient _ircClient;

        System.Timers.Timer _updateTimer;

        public override string Name
        {
            get { return "IrcBot"; }
        }

        public IrcBot()
        {
            AppDomain.CurrentDomain.DomainUnload += (sender, e) => UnloadAppDomain();
            
            _config = ConfigurationManager.GetSection("IrcBotConfig") as IrcBotConfig;

            InitializeClient();

            _updateTimer = new System.Timers.Timer(100);
            _updateTimer.Elapsed += (sender, e) => Listen();
            _updateTimer.Enabled = true;
        }

        public override void SetAdminRules(AdminRules pRules)
        {
            throw new NotImplementedException();
        }

        private bool _isUnloading = false;
        private bool _isListening = false;
        private void Listen()
        {
            if (!_ircClient.IsConnected
                || _isListening
                || _isUnloading)
                return;

            _isListening = true;

            _ircClient.Listen();

            _isListening = false;
        }

        private void UnloadAppDomain()
        {
            _updateTimer.Enabled = false;

            if(_ircClient.IsConnected)
                _ircClient.Disconnect();

            _ircClient = null;
        }


        private void InitializeClient()
        {
            _ircClient = new IrcClient();
            _ircClient.OnReadLine += (sender, e) => IrcRawOutput(e.Line.ToString());
            _ircClient.OnConnected += (sender, e) => ConnectedOk();

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
                SendMessage(string.Format("say [{0}@IRC]: {1}", pMessage.Nick, groups[1].Value.Trim()));
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

        public void Dispose()
        {
            if (_updateTimer != null)
                _updateTimer.Enabled = false;
            if (_ircClient != null)
            {
                if (_ircClient.IsConnected)
                    _ircClient.Disconnect();
                _ircClient = null;
            }
        }

    }
}
