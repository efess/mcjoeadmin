using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace McJoeAdmin.DefaultAdminModule.XmlObjects
{
    public class LogonMessage
    {
        public string Message { get; protected set; }
        public string From { get; protected set; }
        public string To { get; protected set; }

        public LogonMessage(string pSender, string pReceiver, string pMessage)
        {
            From = pSender;
            To = pReceiver;
            Message = pMessage;
        }
    }
}
