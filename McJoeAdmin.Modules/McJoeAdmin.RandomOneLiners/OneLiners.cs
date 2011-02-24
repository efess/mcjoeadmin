using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using McJoeAdmin.Model;
using McJoeAdmin.ModuleHost;
using System.ServiceModel;

namespace McJoeAdmin.RandomOneLiners
{
    [CallbackBehavior(ConcurrencyMode = ConcurrencyMode.Reentrant)]
    public class OneLiners : McModuleBase
    {
        private string[] _oneLiners;
        private string[] _tooMuchCoffee;

        public override string Name { get { return "One Liners"; } }

        public OneLiners()
            : base()
        {
            _oneLiners = OneLinerList.Data.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            _tooMuchCoffee = TooMuchCoffee.Data.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
        }

        public override void MessageIn(McMessage pMessage)
        {
            var data = ReturnPlayerAndData(pMessage.Data);
            if (!string.IsNullOrEmpty(data.Item1))
            {
                if (data.Item2.ToUpper() == "!LOL")
                {
                    ReturnRandomItem(_oneLiners);
                }
                else if (data.Item2.ToUpper() == "!COFFEE")
                {
                    ReturnRandomItem(_tooMuchCoffee);
                }
            }
        }
        public override void SetAdminRules(AdminRules pRules)
        {
            throw new NotImplementedException();
        }

        private void ReturnRandomItem(string[] pArray)
        {
            Random rand = new Random();
            int number = rand.Next(0,pArray.Length);
            SendMessage("say " + pArray[number]);
        }
    }
}
