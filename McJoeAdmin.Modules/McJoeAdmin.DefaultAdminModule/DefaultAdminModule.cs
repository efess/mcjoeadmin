﻿using System.Collections.Generic;
using System.ServiceModel;
using McJoeAdmin.ModuleHost;
using System.Timers;
using McJoeAdmin.Model;
using McJoeAdmin.DefaultAdminModule.XmlObjects;
using System.Text.RegularExpressions;
using System.Linq;

namespace McJoeAdmin.DefaultAdminModule
{
    [CallbackBehavior(ConcurrencyMode = ConcurrencyMode.Reentrant)]
    public class DefaultAdminModule : McModuleBase
    {
        // State vars
        private List<string> _currentPlayers;
        private LogonMessages _logonMessages;

        public DefaultAdminModule()
        {
            _currentPlayers = new List<string>();
            _logonMessages = LogonMessages.LoadInstance();
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
            if (pMessage.Type == Constants.SPECIAL_MESSAGE_TYPE)
            {
                if(pMessage.Data == Constants.SPECIAL_MESSAGE_DATA_SHUTDOWN)
                {
                    SendMessage("save-all");
                    SendMessage("stop");
                }
                return null;
            }

            var playerMessage = new McPlayerMessage(pMessage.Data);

            if (playerMessage.IsLoggingIn)
            {
                SendOfflineMessages(playerMessage);
            }

            var data = ReturnPlayerAndData(pMessage.Data);
            if (data.Item1 == null)
            {
                // Not a player message
                if (pMessage.Data.Contains("Connected players: "))
                {
                    ParsePlayers(pMessage.Data.Remove(0, 19));
                }
                else if (pMessage.Data.Contains("lost connection:")
                    || pMessage.Data.Contains("logged in with"))
                {
                    SendMessage("list");
                }
            }
            else if(playerMessage.Command != null)
            {
                switch (playerMessage.Command.ToUpper())
                {
                    case "!OFFLINEMSG":
                        AddAfkMessage(playerMessage);
                        break;
                    case "!PLAYERS":
                        SendPlayerList(data.Item1);
                        SendMessage("list");
                        break;
                    case "!DERP":
                        SendMessage("say Derpy derp. De derp de duttidy da, derpy derpy doo.");
                        break;
                    case "!NIGGER":
                        SendMessage("say A fully grown niglet");
                        break;
                    case "!BOOBS":
                        SendMessage("sa Things that guys like to play with");
                        break;
                }
            }

            return null;
        }

        private void SendOfflineMessages(McPlayerMessage pMessage)
        {
            bool hasMsg = false;
            var messages = _logonMessages.GetMessages(pMessage.Name).ToArray();
            foreach (var msg in messages)
            {
                hasMsg = true;

                SendMessage(string.Format("tell {0} Offline Msg from {1}: {2}", msg.To, msg.From, msg.Message));
            }

            if (hasMsg)
                _logonMessages.RemoveMessages(pMessage.Name);
        }

        private void AddAfkMessage(McPlayerMessage pData)
        {
            //!addafkmsg john hey whats up
            var sender = pData.Name;
            
            Regex reg = new Regex("(.+?) (.+)");

            var match = reg.Match(pData.SubMessage);

            var groups = match.Groups;
            if (groups.Count == 3)
            {
                _logonMessages.AddMessage(sender, groups[1].Value.Trim(), groups[2].Value.Trim());
                _logonMessages.Save();
            }
            else
            {
                SendMessage("tell {0} Correct syntax is \"!offlinemsg <recipient> <message>\"");
                return;
            }
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
                SendMessage("tell " + pPlayer + " " + i + " " + _currentPlayers[i]);
            }
        }

        public void RefreshState()
        {
            SendMessage("list");
        }

    }
}
