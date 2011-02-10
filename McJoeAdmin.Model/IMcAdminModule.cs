using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace McJoeAdmin.Model
{
    public interface IMcAdminModule
    {
        void MessageIn(McMessage pMessage);
        Action<McMessage> MessageOut { set; }
        void SetAdminRules(AdminRules pAdminRules);
    }
}
