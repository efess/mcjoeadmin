using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace McJoeAdmin.IrcBot
{
    public class IrcBotConfig : ConfigurationSection
    {
        public static void CreateDefaultSection()
        {
            //if (ConfigurationManager.GetSection("IrcBotConfig") == null)
            //    Configu.Sections["IrcBotConfig"] = new IrcBotConfig();
        }

        [ConfigurationProperty("server",DefaultValue="irc.dal.net")]
        public string Server {
            get
            {
                return (string)this["server"];
            }
            set
            {
                this["server"] = value;
            }
        }
        [ConfigurationProperty("port", DefaultValue = "6664")]
        public int Port
        {
            get
            {
                return (int)this["port"];
            }
            set
            {
                this["port"] = value;
            }
        }
        [ConfigurationProperty("botnick", DefaultValue = "McJoeBot")]
        public string BotNick
        {
            get
            {
                return (string)this["botnick"];
            }
            set
            {
                this["botnick"] = value;
            }
        }
        [ConfigurationProperty("channel", DefaultValue = "#mcjoeadmin")]
        public string Channel
        {

            get
            {
                return (string)this["channel"];
            }
            set
            {
                this["channel"] = value;
            }
        }
    }
}
