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

        [XmlArray()]
        public List<LogonMessage> MessagesCollection;

        public void AddMessage(string pSender, string pReceiver, string pMessage)
        {
            var newMessage = new LogonMessage(pSender, pReceiver, pMessage);

            foreach(var dup in MessagesCollection
                .Where(msg => msg.From == newMessage.From && msg.To == newMessage.From))
                MessagesCollection.Remove(dup);

            MessagesCollection.Add(newMessage);
        }

        private LogonMessages _messages;
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
                list = MessagesCollection.Where(msg => msg.To == pTo);
            return list;
        }

        public void RemoveMessages(string pTo)
        {
            lock(MessagesCollection)
                foreach(var message in MessagesCollection.Where(msg => msg.To == pTo))
                    MessagesCollection.Remove(message);
        }

        public void Save()
        {
            SimpleXmlStorage.Save(_messages);
        }
    }
}
