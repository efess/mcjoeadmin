using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using McJoeAdmin.Model;

namespace McJoeAdmin.BasicAdminRulesModule
{
    public class BasicAdminRules : IMcAdminModule
    {
        public BasicAdminRules()
        {
            MessageOut = null;
        }

        // IMcAdminModule Implementation
        private Action<McMessage> _messageOut;
        private AdminRules _currentAdminRules;

        public Action<McMessage> MessageOut
        {
            set
            {
                if (value == null)
                    _messageOut = (mc) => { };
                else _messageOut = value;
            }
        }
        public void SetAdminRules(AdminRules pAdminRules)
        {
            _currentAdminRules = pAdminRules;
        }

        public void MessageIn(McMessage pMessage)
        {
            var message = ProcessMessage(pMessage);
            if (message != null)
                _messageOut(message);
        }

        private McMessage ProcessMessage(McMessage pMessage)
        {
            return pMessage;
        }
    }
}
