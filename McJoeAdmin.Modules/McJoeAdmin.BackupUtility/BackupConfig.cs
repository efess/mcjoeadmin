using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace McJoeAdmin.BackupUtility
{
    public class BackupConfig : ConfigurationSection
    {
        /// <summary>
        /// Minutes between backups
        /// </summary>
        [ConfigurationProperty("interval", DefaultValue = 60)]
        public int Interval
        {
            get
            {
                return (int)this["interval"];
            }
            set
            {
                this["interval"] = value;
            }
        }

        /// <summary>
        /// Path where backups are stored
        /// </summary>
        [ConfigurationProperty("path", DefaultValue = "c:\\minecraft\\backup")]
        public string Path
        {
            get
            {
                return (string)this["path"];
            }
            set
            {
                this["path"] = value;
            }
        }

    }
}
