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
                    case "!LADDERS":
                        LaddersCalc(message.SubMessage, message.Name);
                        break;
                    case "!FENCES":
                        FencesCalc(message.SubMessage, message.Name);
                        break;
                    case "!ARROWS":
                        ArrowsCalc(message.SubMessage, message.Name);
                        break;

                    // DYES
                    case "!LIGHTGRAY":
                    case "!LIGHTGREY":
                        LightGrayCalc(message.SubMessage, message.Name);
                        break;
                    case "!GRAY":
                    case "!GREY":
                        GrayCalc(message.SubMessage, message.Name);
                        break;
                    case "!RED":
                        RedCalc(message.SubMessage, message.Name);
                        break;
                    case "!ORANGE":
                        OrangeCalc(message.SubMessage, message.Name);
                        break;
                    case "!YELLOW":
                        YellowCalc(message.SubMessage, message.Name);
                        break;
                    case "!LIMEGREEN":
                    case "!LIME":
                        LimeGreenCalc(message.SubMessage, message.Name);
                        break;
                    case "!CYAN":
                        CyanCalc(message.SubMessage, message.Name);
                        break;
                    case "!LIGHTBLUE":
                    case "!SKYBLUE":
                        LightBlueCalc(message.SubMessage, message.Name);
                        break;
                    case "!BLUE":
                        BlueCalc(message.SubMessage, message.Name);
                        break;
                    case "!PURPLE":
                        PurpleCalc(message.SubMessage, message.Name);
                        break;
                    case "!MAGENTA":
                    case "!LIGHTPURPLE":
                        MagentaCalc(message.SubMessage, message.Name);
                        break;
                    case "!PINK":
                        PinkCalc(message.SubMessage, message.Name);
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

        private void LightGrayCalc(string pParms, string pName)
        {
            DoCalculation(pParms, pName, new Action<int>(number =>
            {
                var inkSac = (int)Math.Ceiling((float)number / 3);
                var bonemeal = inkSac * 2;

                SendMessage(string.Format("say {0} Ink sac(s); {1} Bone meal(s)"
                    , inkSac
                    , bonemeal));
            }));
        }

        private void GrayCalc(string pParms, string pName)
        {
            DoCalculation(pParms, pName, new Action<int>(number =>
            {
                var inkSac = (int)Math.Ceiling((float)number / 2);
                var bonemeal = inkSac;

                SendMessage(string.Format("say {0} Ink sac(s); {1} Bone meal(s)"
                    , inkSac
                    , bonemeal));
            }));
        }

        private void RedCalc(string pParms, string pName)
        {
            DoCalculation(pParms, pName, new Action<int>(number =>
            {
                var rose = (int)Math.Ceiling((float)number / 2);
                SendMessage(string.Format("say {0} Rose(s)"
                    , rose));
            }));
        }

        private void OrangeCalc(string pParms, string pName)
        {
            DoCalculation(pParms, pName, new Action<int>(number =>
            {
                var rose = (int)Math.Ceiling((float)number / 4);
                SendMessage(string.Format("say {0} Rose(s); {0} Dandelion(s)"
                    , rose));
            }));
        }

        private void YellowCalc(string pParms, string pName)
        {
            DoCalculation(pParms, pName, new Action<int>(number =>
            {
                var dandelion = (int)Math.Ceiling((float)number / 2);
                SendMessage(string.Format("say {0} Dandelion(s)"
                    , dandelion));
            }));
        }

        private void LimeGreenCalc(string pParms, string pName)
        {
            DoCalculation(pParms, pName, new Action<int>(number =>
            {
                var cacti = (int)Math.Ceiling((float)number / 2);
                SendMessage(string.Format("say {0} Cactus(i); {0} Bonemeal(s)"
                    , cacti));
            }));
        }

        private void GreenCalc(string pParms, string pName)
        {
            DoCalculation(pParms, pName, new Action<int>(number =>
            {
                //var cacti = (int)Math.Ceiling((float)number / 2);
                SendMessage(string.Format("say {0} Cactus(i)"
                    , number));
            }));
        }

        private void CyanCalc(string pParms, string pName)
        {
            DoCalculation(pParms, pName, new Action<int>(number =>
            {
                var lapis = (int)Math.Ceiling((float)number / 2);
                SendMessage(string.Format("say {0} Cactus(i); {0} Lapis(s)"
                    , lapis));
            }));
        }

        private void LightBlueCalc(string pParms, string pName)
        {
            DoCalculation(pParms, pName, new Action<int>(number =>
            {
                var lapis = (int)Math.Ceiling((float)number / 2);
                SendMessage(string.Format("say {0} Lapis(i); {0} Bonemeal(s)"
                    , lapis));
            }));
        }
        private void BlueCalc(string pParms, string pName)
        {
            DoCalculation(pParms, pName, new Action<int>(number =>
            {
                SendMessage(string.Format("say {0} Lapis(i); {0} Bonemeal(s)"
                    , number));
            }));
        }
        private void PurpleCalc(string pParms, string pName)
        {
            DoCalculation(pParms, pName, new Action<int>(number =>
            {
                var lapis = (int)Math.Ceiling((float)number / 2);
                var rose = (int)Math.Ceiling((float)number / 4);

                SendMessage(string.Format("say {0} Lapis(i); {1} Rose(s)"
                    , lapis, rose));
            }));
        }
        private void MagentaCalc(string pParms, string pName)
        {
            DoCalculation(pParms, pName, new Action<int>(number =>
            {
                var lapis = (int)Math.Ceiling((float)number / 4);
                var bonemeal = (int)Math.Ceiling((float)number / 4);
                var rose = (int)Math.Ceiling((float)number / 8);

                SendMessage(string.Format("say {0} Lapis(i); {1} Rose(s); {2} Bonemeal(s)"
                    , lapis, rose, bonemeal));
            }));
        }
        private void PinkCalc(string pParms, string pName)
        {
            DoCalculation(pParms, pName, new Action<int>(number =>
            {
                var bonemeal = (int)Math.Ceiling((float)number / 2);
                var rose = (int)Math.Ceiling((float)number / 4);

                SendMessage(string.Format("say {0} Rose(s); {1} Bonemeal(s)"
                    , rose, bonemeal));
            }));
        }

        private void ArrowsCalc(string pParms, string pName)
        {
            DoCalculation(pParms, pName, new Action<int>(number =>
            {

                var flint = (int)Math.Ceiling((float)number / 4);
                var feather = flint;
                var stick = flint;
                var plank = SticksToPlanks(stick);
                var log = PlanksToLogs(plank);

                SendMessage(string.Format("say {0} flint(s); {1} feather(s); {2}stick(s) from {3} plank(s) from {4} log(s)"
                    , flint
                    , feather
                    , stick
                    , plank
                    , log));
            }));
        }

        private void BricksCalc(string pParms, string pName)
        {
            DoCalculation(pParms, pName, new Action<int>(number =>
            {
                var clayBricks = number * 4;
                var clay = number * 4;

                SendMessage(string.Format("say {0} Clay Bricks from {1} Clay peices"
                    , clayBricks
                    , clay));
            }));
        }

        private void LaddersCalc(string pParms, string pName)
        {
            DoCalculation(pParms, pName, new Action<int>(number =>
            {
                var sticks = number * 7;
                var planks = SticksToPlanks(sticks);
                var logs = PlanksToLogs(planks);

                SendMessage(string.Format("say {0} stick(s) from {1} plank(s) from {2} log(s)"
                    , sticks
                    , planks
                    , logs));
            }));
        }

        private void FencesCalc(string pParms, string pName)
        {
            DoCalculation(pParms, pName, new Action<int>(number =>
            {
                var sticks = (int)Math.Ceiling((float)number / 2) * 6;
                var planks = SticksToPlanks(sticks);
                var logs = PlanksToLogs(planks);

                SendMessage(string.Format("say {0} stick(s) from {1} plank(s) from {2} log(s)"
                    , sticks
                    , planks
                    , logs));
            }));
        }

        private void BookshelvesCalc(string pParms, string pName)
        {
            DoCalculation(pParms, pName, new Action<int>(number =>
            {
                var planks = number * 6;
                var logs = PlanksToLogs(planks);

                var books = number * 3;

                var paper = books * 3;
                var reeds = (int)Math.Ceiling((float)paper / 3) * 3;

                SendMessage(string.Format("say {0} Planks from {1} logs; {2} books from {3} papers from {4} reeds"
                    , planks
                    , logs
                    , books
                    , paper
                    , reeds));
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
