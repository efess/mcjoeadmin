using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace McJoeAdmin.DefaultAdminModule.XmlObjects
{
    public class LogonMessage
    {
        [XmlElement()]
        public string Message { get;  set; }
        [XmlElement()]
        public string From { get;  set; }
        [XmlElement()]
        public string To { get;  set; }

        public LogonMessage()
        {
        }
        public LogonMessage(string pSender, string pReceiver, string pMessage)
        {
            From = pSender;
            To = pReceiver;
            Message = pMessage;
        }
    }
}
