using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace McJoeAdmin.DefaultAdminModule.XmlObjects
{
    public class UserPrivilage
    {
        [XmlElement()]
        public Privilage Privilage { get; set; }
        [XmlElement()]
        public string Name { get; set; }
        [XmlElement()]
        public string AccessProvidedByName { get; set; }
        [XmlElement()]
        public DateTime AccessProvidedDate { get; set; }

        internal UserPrivilage(string pName, string pAccessProvidedByName, Privilage pPrivilage)
        {
            Privilage = pPrivilage;
            Name = pName;
            AccessProvidedByName = pAccessProvidedByName;
            AccessProvidedDate = DateTime.UtcNow;
        }
    }

    public enum Privilage
    {
        Administrator,
        Moderator,
        PowerUser,
        User,
        None
    }
}
