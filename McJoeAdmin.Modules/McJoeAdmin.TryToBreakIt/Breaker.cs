using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using McJoeAdmin.ModuleHost;
using System.ServiceModel;

namespace McJoeAdmin.TryToBreakIt
{
    [CallbackBehavior(ConcurrencyMode = ConcurrencyMode.Reentrant)]
    public class Breaker : McModuleBase
    {
        public override string Name
        {
            get { return "Breaker"; }
        }
        public Breaker()
        {
            throw new Exception("Lolception");
        }


        public override void SetAdminRules(Model.AdminRules pRules)
        {
        }

        public override void MessageIn(Model.McMessage pMessage)
        {
        }
    }
}
