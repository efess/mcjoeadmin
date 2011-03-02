using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using McJoeAdmin.ModuleHost;
using McJoeAdmin.Model;

namespace McJoeAdmin.BackupUtility
{
    [CallbackBehavior(ConcurrencyMode = ConcurrencyMode.Reentrant)]
    public class Backuper : McModuleBase
    {
        public override string Name
        {
            get { return "IrcBot"; }
        }

        public override void SetAdminRules(AdminRules pRules)
        {
            throw new NotImplementedException();
        }

        public override void MessageIn(McMessage pMessage)
        {
            
        }
    }
}
