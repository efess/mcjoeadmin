using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using McJoeAdmin.ModuleHost;
using System.ServiceModel;

namespace McJoeAdmin.InformationLookup
{
    [CallbackBehavior(ConcurrencyMode = ConcurrencyMode.Reentrant)]
    public class LookupProcessor : McModuleBase
    {
    }
}
