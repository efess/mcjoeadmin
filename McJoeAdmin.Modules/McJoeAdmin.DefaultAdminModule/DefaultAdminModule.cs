using System.Collections.Generic;
using System.ServiceModel;
using McJoeAdmin.ModuleHost;
using System.Timers;
using McJoeAdmin.Model;
using McJoeAdmin.DefaultAdminModule.XmlObjects;
using System.Text.RegularExpressions;
using System.Linq;
using System;

namespace McJoeAdmin.DefaultAdminModule
{
    [CallbackBehavior(ConcurrencyMode = ConcurrencyMode.Reentrant)]
    public class DefaultAdminModule : McModuleBase
    {
        // Fkn Hardcoded command list
        private List<SupportedUserCommand> _supportedUserCommands;

        // State vars
        private List<string> _currentPlayers;
        private LogonMessages _logonMessages;
        private UserPrivilages _userPrivilages;

        // TODO: Make this configurable
        private Privilage _defaultPrivilage = Privilage.User; 
        
        private bool _shuttingDown;

        public DefaultAdminModule()
        {
            _currentPlayers = new List<string>();
            _logonMessages = SimpleXmlStorage.Load<LogonMessages>() ?? new LogonMessages();
            InitializeSupportedUserCommands();
        }

        public override string Name
        {
            get { return "DefaultAdminModule"; }
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
                    _shuttingDown = true;
                    SendMessage("save-all");
                }
                return null;
            }

            var engineMessage = new McEngineMessage(pMessage.Data);

            if (engineMessage.IsLoggingIn)
            {
                SendWelcomeMessage(engineMessage.Name);
                SendOfflineMessages(engineMessage);
                RefreshState();
            }

            if (engineMessage.Name == null)
            {
                // Not a player message
                if (engineMessage.RawMessage.StartsWith("Connected players: "))
                {
                    ParsePlayers(engineMessage.RawMessage.Remove(0, 19));
                }
                else if (pMessage.Data.Contains("lost connection")
                    || pMessage.Data.Contains("logged in with"))
                {
                    RefreshState();
                }
                else if (pMessage.Data.StartsWith("CONSOLE: Save complete.") && _shuttingDown)
                {
                    SendMessage("stop");
                }
            }
            else if(engineMessage.Command != null)
            {
                var privilage = _userPrivilages.LookupPrivilage(engineMessage.Name)
                    ?? _defaultPrivilage;

                ProcessUserMessage(engineMessage, privilage);
            }

            return null;
        }

        private void ProcessUserMessage(McEngineMessage pMessage, Privilage pUserPrivilage)
        {
            foreach(var commandWrapper in _supportedUserCommands.Where(sc => pUserPrivilage >= sc.PrivilageRequired 
                && string.Compare(pMessage.Command, sc.CommandName, true) == 0))
            {
                commandWrapper.Command(pMessage);
            }
                

            //switch (pMessage.Command.ToUpper())
            //{
            //    case "!OFFLINEMSG":
            //        AddAfkMessage(pMessage);
            //        break;
            //    case "!PLAYERS":
            //        SendPlayerList(pMessage);
            //        break;
            //    case "!DERP":
            //        SendMessage("say Derpy derp. De derp de duttidy da, derpy derpy doo.");
            //        break;
            //    case "!NIGGER":
            //        SendMessage("say A fully grown niglet");
            //        break;
            //    case "!BOOBS":
            //        SendMessage("say Things that guys like to play with");
            //        break;
            //}
        }

        private void InitializeSupportedUserCommands()
        {
            var sc = _supportedUserCommands;
            sc.Add(new SupportedUserCommand(Privilage.None, "!nigger", "Dirty Mouth", new Action<McEngineMessage>((m)=> SendMessage("say A fully grown niglet"))));
            sc.Add(new SupportedUserCommand(Privilage.None, "!boobs", "Dirty Mouth", new Action<McEngineMessage>((m) => SendMessage("say Things that guys like to play with"))));
            sc.Add(new SupportedUserCommand(Privilage.None, "!boobs", "Dirty Mouth", new Action<McEngineMessage>((m) => SendMessage("say Derpy derp. De derp de duttidy da, derpy derpy doo."))));
            sc.Add(new SupportedUserCommand(Privilage.None, "!offlinemsg", "Send an offline message to a user", new Action<McEngineMessage>(AddAfkMessage)));
            sc.Add(new SupportedUserCommand(Privilage.None, "!players", "View list of connected players", new Action<McEngineMessage>(SendPlayerList)));
        }

        private void SendWelcomeMessage(string pPlayerName)
        {
            SendMessage(string.Format("tell {0} Welcome to Efess's minecraft server", pPlayerName));
            SendMessage(string.Format("tell {0} Wiki: mcdev.myxwiki.org", pPlayerName));
        }

        private void SendOfflineMessages(McEngineMessage pMessage)
        {
            bool hasMsg = false;
            var messages = _logonMessages.GetMessages(pMessage.Name).ToArray();
            foreach (var msg in messages)
            {
                hasMsg = true;

                SendMessage(string.Format("tell {0} Offline Msg from {1}: {2}", msg.To, msg.From, msg.Message));
            }

            if (hasMsg)
            {
                _logonMessages.RemoveMessages(pMessage.Name);
                SimpleXmlStorage.Save(_logonMessages);
            }
        }

        private void AddAfkMessage(McEngineMessage pData)
        {
            //!addafkmsg john hey whats up
            var sender = pData.Name;
            
            Regex reg = new Regex("(.+?) (.+)");

            var match = reg.Match(pData.SubMessage);

            var groups = match.Groups;
            if (groups.Count == 3)
            {
                _logonMessages.AddMessage(sender, groups[1].Value.Trim(), groups[2].Value.Trim());
                SimpleXmlStorage.Save(_logonMessages);
                SendMessage(string.Format("tell {0} Offline Message to {1} saved", sender, groups[1].Value.Trim()));
            }
            else
            {
                SendMessage(string.Format("tell {0} Correct syntax is \"!offlinemsg <recipient> <message>\"", sender));
                return;
            }
        }

        private void ParsePlayers(string pPlayers)
        {
            lock (_currentPlayers)
            {
                _currentPlayers.Clear();
                foreach (var player in pPlayers.Split(new char[] { ',' },System.StringSplitOptions.RemoveEmptyEntries))
                {
                    _currentPlayers.Add(player.Trim());
                }
            }
        }

        public void SendPlayerList(McEngineMessage pMessage)
        {
            var player = pMessage.Name;
            SendMessage("tell " + player + " Current Players:");

            for(int i = 0; i < _currentPlayers.Count; i++)
            {
                SendMessage("tell " + player + " " + i + " " + _currentPlayers[i]);
            }
            
            RefreshState();
        }

        public void RefreshState()
        {
            SendMessage("list");
        }

    }
}
