using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace McJoeAdmin.Model.Events
{
    public class McMessageEventArgs
    {
        public McMessage Message { get; private set; }
        public McMessageEventArgs(McMessage pMessage)
        {
            Message = pMessage;
        }
    }
}
