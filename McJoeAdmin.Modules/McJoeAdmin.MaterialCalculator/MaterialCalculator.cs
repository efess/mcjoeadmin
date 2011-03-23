using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using McJoeAdmin.ModuleHost;
using McJoeAdmin.Model;
using NCalc;

namespace McJoeAdmin.MaterialCalculator
{
    [CallbackBehavior(ConcurrencyMode = ConcurrencyMode.Reentrant)]
    public class MaterialCalculator : McModuleBase
    {
        public override string Name
        {
            get { return "Calculator"; }
        }

        public override void SetAdminRules(Model.AdminRules pRules)
        {
            
        }

        public override void MessageIn(Model.McMessage pMessage)
        {
            ProcessMessage(pMessage);
        }

        private void ProcessMessage(McMessage pMessage)
        {
            var message = new McEngineMessage(pMessage.Data);
            if (!string.IsNullOrEmpty(message.Name)
                && !string.IsNullOrEmpty(message.Command))
            {
                switch (message.Command.ToUpper())
                {
                    case "!TRACKS":
                        TrackCalc(message.SubMessage, message.Name);
                        break;
                    case "!TORCHES":
                        TorchCalc(message.SubMessage, message.Name);
                        break;
                    case "!CHESTS":
                        ChestCalc(message.SubMessage, message.Name);
                        break;
                    case "!TNT":
                        TNTCalc(message.SubMessage, message.Name);
                        break;
                    case "!BOOKSHELVES":
                        BookshelvesCalc(message.SubMessage, message.Name);
                        break;
                    case "!BRICKS":
                        BookshelvesCalc(message.SubMessage, message.Name);
                        break;
                    case "!CALC":
                        DoStringCalc(message.SubMessage, message.Name);
                        break;
                }
            }
        }
        private void DoStringCalc(string pParms, string pName)
        {
            try
            {
                var expression = new Expression(pParms);
                var evald = expression.Evaluate();
                SendMessage(string.Format("say Result: {0}", evald.ToString()));
            }
            catch
            {
                SendMessage(string.Format("tell {0} Sorry, can't evaluate that.", pName));
            }
        }

        private void BookshelvesCalc(string pParms, string pName)
        {
            DoCalculation(pParms, pName, new Action<int>(number =>
            {
                var gunpowder = 5 * number;
                var sand = 4 * number;

                SendMessage(string.Format("say {0} gunpowder and {1} sand"
                    , gunpowder
                    , sand));
            }));
        }

        private void TNTCalc(string pParms, string pName)
        {
            DoCalculation(pParms, pName, new Action<int>(number =>
            {
                var gunpowder = 5 * number;
                var sand = 4 * number;

                SendMessage(string.Format("say {0} gunpowder and {1} sand"
                    , gunpowder
                    , sand));
            }));
        }

        private void ChestCalc(string pParms, string pName)
        {
            DoCalculation(pParms, pName, new Action<int>(number =>
            {
                var planks = (int)Math.Ceiling((float)number / 8);
                var log = PlanksToLogs(planks);

                SendMessage(string.Format("say {0} plank(s) from {1} log(s)"
                    , planks
                    , log));
            }));
        }

        private void TrackCalc(string pParms, string pName)
        {
            DoCalculation(pParms, pName, new Action<int>(number =>
            {
                var sticks = (int)Math.Ceiling((float)number / 16);
                var iron = sticks * 6;
                var planks = SticksToPlanks(sticks);
                var log = PlanksToLogs(planks);

                SendMessage(string.Format("say {1} iron; {2}stick(s) from {3} plank(s) from {4} log(s)"
                    , pName
                    , iron
                    , sticks
                    , planks
                    , log));
            }));
        }

        private void TorchCalc(string pParms, string pName)
        {
            DoCalculation(pParms, pName, new Action<int>(number =>
                {
                    var coal = number;
                    var sticks = number;
                    var planks = SticksToPlanks(sticks);
                    var log = PlanksToLogs(planks);

                    SendMessage(string.Format("say {1} coal; {2}stick(s) from {3} plank(s) from {4} log(s)"
                        , pName
                        , coal
                        , sticks
                        , planks
                        , log));
                }));
        }
        private void DoCalculation(string pParam, string pName, Action<int> Calculation)
        {
            int number = 0;
            if (!int.TryParse(pParam, out number))
            {
                SendMessage(string.Format("tell {0} Proper command is !<item_plural> <number> ie. !Torches 3", pName));
            }
            else
            {
                try
                {
                    Calculation(number);
                }
                catch (Exception ex)
                {
                    SendMessage(string.Format("tell {0} lol that's a crazy number."));
                }
            }
        }
        private int SticksToPlanks(int pSticks)
        {
            return (int)Math.Ceiling((float)pSticks / 4) * 2;
        }

        private int PlanksToLogs(int pPlanks)
        {
            return (int)Math.Ceiling((float)pPlanks / 4);
        }

    }
}
