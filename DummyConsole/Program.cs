using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DummyConsole
{
    public class Program
    {

        static void Main(string[] args)
        {
            new Action(OutputSomething).BeginInvoke(null, null);

            while(true)
            {
                var check = Console.ReadLine();

                //Console.WriteLine(check);
                switch (check.TrimEnd(new char[] {' ','\n', '\r'}).ToUpper())
                {
                    case "LIST":
                        Console.WriteLine(GetMcDateTimeNow() + " [INFO] Connected players: AngryRhetoric, efess");
                        break;

                }
            }
        }

        private static void OutputError()
        {
            throw new Exception("Trying this exception");
        }

        private static void OutputSomething()
        {
            while (true)
            {
                string str = RandomMinecraftString();

                if (str != null)
                    Console.WriteLine(str);
                 
                System.Threading.Thread.Sleep(3000);
            }
        }

        private static string RandomMinecraftString()
        {
            Random rand = new Random((int)(DateTime.Now.Ticks % int.MaxValue));
            
            int number = rand.Next(0, 15);

            switch (number)
            {
                case 0:
                    return GetMcDateTimeNow() + " [INFO] <efess> Lol message";

                case 2:
                    return GetMcDateTimeNow() + " [INFO] <efess> !players";

                case 3:
                    return GetMcDateTimeNow() + " [INFO] <efess> !memory";
                case 4:
                    return GetMcDateTimeNow() + " [INFO] <efess> !lol";
                case 5:
                    return GetMcDateTimeNow() + " [WARNING] Can't keep up! Did the system time change, or is the server overloaded?";

                case 6:
                    return GetMcDateTimeNow() + " [INFO] efess [/69.119.8.191:49613] logged in with entity id 3732147";
                case 7:
                    return GetMcDateTimeNow() + " [INFO] <efess> !coffee";
                case 8:
                    return GetMcDateTimeNow() + " [INFO] Disconnecting redux06790 [/69.119.8.191:49714]: Took too long to log in";
                case 9:
                    return GetMcDateTimeNow() + " [INFO] <redux06790> !mitch";
                case 10:
                    return GetMcDateTimeNow() + " [INFO] redux06790 lost connection: disconnect.quitting";
                case 11:
                    return GetMcDateTimeNow() + " [INFO] efess [/69.119.7.235:31007] logged in with entity id 1";
                case 12:
                    return GetMcDateTimeNow() + " [INFO] <efess> !offlinemsg john hey whats up";
                case 13:
                    return GetMcDateTimeNow() + " [INFO] <kevin> !offlinemsg john -- hey whats up";
                case 14:
                    return GetMcDateTimeNow() + " [INFO] <kevin> !offlinemsg efess -- lolz.";
            }
            return null;
        }

        private static string GetMcDateTimeNow()
        {
            return DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

    }
}
