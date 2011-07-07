using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace McJoeAdmin.DefaultAdminModule.XmlObjects
{
    [XmlRoot()]
    public class UserPrivilages : SimpleXmlStorageObjectBase
    {
        private const string XML_FILE = "UserPrivilages.xml";

        internal override string XmlFile
        {
            get
            {
                return XML_FILE;
            }
        }

        [XmlArray()]
        public List<UserPrivilage> PrivilagesCollection;

        public void AddPrivilage(string pName, string pInitiatorName, Privilage pPrivilage)
        {
            lock (PrivilagesCollection)
            {
                var privilages = PrivilagesCollection.Where(prv =>
                    string.Compare(prv.Name, pName, true) == 0).ToArray();

                for (int i = privilages.Length - 1; i >= 0; i--)
                    PrivilagesCollection.Remove(privilages[i]);
            }

            PrivilagesCollection.Add(new UserPrivilage(pName, pInitiatorName, pPrivilage));
        }

        public Privilage? LookupPrivilage(string pName)
        {
            lock (PrivilagesCollection)
            {
                var privilage = PrivilagesCollection.FirstOrDefault(prv => string.Compare(prv.Name, pName, true) == 0);
                return privilage != null ? privilage.Privilage : (Privilage?) null;
            }
        }
    }
}
