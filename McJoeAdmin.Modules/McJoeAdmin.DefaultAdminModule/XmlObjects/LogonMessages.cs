using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace McJoeAdmin.DefaultAdminModule.XmlObjects
{
    [XmlRoot()]
    public class LogonMessages : SimpleXmlStorageObjectBase
    {
        public const string XML_FILE = "LogonMessages.xml";

        internal override string XmlFile
        {
            get { return XML_FILE; }
        }

        public LogonMessages()
        {
            MessagesCollection = new List<LogonMessage>();
        }

        [XmlArray()]
        public List<LogonMessage> MessagesCollection;

        public void AddMessage(string pSender, string pReceiver, string pMessage)
        {
            var newMessage = new LogonMessage(pSender, pReceiver, pMessage);

            lock(MessagesCollection)
            {
                var dups = MessagesCollection
                    .Where(msg => string.Compare(msg.From, newMessage.From, true) == 0 
                        && string.Compare(msg.To, newMessage.To, true) == 0).ToArray();
                for (int i = dups.Length - 1; i >= 0; i--)
                {
                    MessagesCollection.Remove(dups[i]);
                }

            }

            MessagesCollection.Add(newMessage);
        }

        public static LogonMessages LoadInstance()
        {
            var messages = SimpleXmlStorage.Load<LogonMessages>();
            if (messages == null)
                messages = new LogonMessages();
            return messages;
        }

        public IEnumerable<LogonMessage> GetMessages(string pTo)
        {
            IEnumerable<LogonMessage> list = null;
            lock(MessagesCollection)
                list = MessagesCollection.Where(msg => string.Compare(msg.To, pTo, true) == 0);
            return list;
        }

        public void RemoveMessages(string pTo)
        {
            lock(MessagesCollection)
                foreach(var message in MessagesCollection.Where(msg => string.Compare(msg.To, pTo, true) == 0).ToArray())
                    MessagesCollection.Remove(message);
        }

        public void Save()
        {
            SimpleXmlStorage.Save(this);
        }
    }
}
