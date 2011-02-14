using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using McJoeAdmin.Model;
using System.ServiceModel;
using System.Text.RegularExpressions;
using System.Timers;
using McJoeAdmin.ModuleHost;

namespace McJoeAdmin.BasicAdminRulesModule
{
    [CallbackBehavior(ConcurrencyMode = ConcurrencyMode.Reentrant)]
    public class BasicAdminRules : McModuleBase
    {
        private const int STATE_REFRESH_PERIOD = 5000;

        // State vars
        private List<string> _currentPlayers;

        private Timer _timer = new Timer(STATE_REFRESH_PERIOD);

        public BasicAdminRules()
        {
            _currentPlayers = new List<string>();
            _timer.Elapsed += (sender, e) => RefreshState();

            _timer.Enabled = true;
        }

        // IMcAdminModule Implementation
        private AdminRules _currentAdminRules;
        public override void SetAdminRules(AdminRules pAdminRules)
        {
            _currentAdminRules = pAdminRules;
        }

        public override void MessageIn(McMessage pMessage)
        {
            var message = ProcessMessage(pMessage);
        }

        private McMessage ProcessMessage(McMessage pMessage)
        {
            var data = ReturnPlayerAndData(pMessage.Data);
            if (pMessage.Data.Contains("Connected players: "))
            {
                ParsePlayers(pMessage.Data.Remove(0,19));
            }
            else if (!string.IsNullOrEmpty(data.Item1)
                && data.Item2.ToUpper() == "!PLAYERS")
            {
                SendPlayerList(data.Item1);
            }
            return null;
        }

        private void ParsePlayers(string pPlayers)
        {
            lock (_currentPlayers)
            {
                _currentPlayers.Clear();
                foreach (var player in pPlayers.Split(new char[] { ' ' }))
                {
                    _currentPlayers.Add(player.Trim());
                }
            }
        }

        public void SendPlayerList(string pPlayer)
        {
            SendMessage("tell " + pPlayer + " Current Players:");

            for(int i = 0; i < _currentPlayers.Count; i++)
            {
                SendMessage("tell " + pPlayer + i + " " + _currentPlayers[i]);
            }
        }

        public void RefreshState()
        {
            SendMessage("list");
        }
    }
}
