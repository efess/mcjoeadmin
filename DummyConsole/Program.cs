using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading;

namespace DummyConsole
{
    public class Program
    {
        static ManualResetEvent waitHandle = new ManualResetEvent(false);
        static string[] _outputLines;
        static void Main(string[] args)
        {
            _outputLines = new string[]
            {
                "[INFO] <efess> !torches 3",
                "[INFO] <efess> !players",
                "[INFO] <efess> !torches 4.5",
                "[INFO] <efess> !lol",
                "[WARNING] Can't keep up! Did the system time change, or is the server overloaded?",
                "[INFO] efess [/69.119.8.191:49613] logged in with entity id 3732147",
                "[INFO] <efess> !tracks 31",
                "[INFO] Disconnecting redux06790 [/69.119.8.191:49714]: Took too long to log in",
                "[INFO] <redux06790> !mitch",
                "[INFO] redux06790 lost connection: disconnect.quitting",
                "[INFO] efess [/69.119.7.235:31007] logged in with entity id 1",
                "[INFO] <efess> !offlinemsg john hey whats up",
                "[INFO] <kevin> !offlinemsg john -- hey whats up",
                "[INFO] <kevin> !offlinemsg efess -- lolz.",
                "[INFO] <kevin> !calc (10+3)/3",
                "[INFO] <kevin> !calc 10243/64",
                "[INFO] <kevin> !calc 8^2 * 3 / (4+4) "
            };

            var read = new Thread(Read)
            {
                IsBackground = true
            };
            read.Start();
            var write = new Thread(Write)
                {
                    IsBackground = true
                };
            write.Start();

            waitHandle.WaitOne();
        }

        private static void Read()
        {
            while (true)
            {
                var check = Console.ReadLine();

                //Console.WriteLine(check);
                if (string.IsNullOrEmpty(check))
                    continue;

                switch (check.TrimEnd(new char[] {' ','\n', '\r'}).ToUpper())
                {
                    case "LIST":
                        Console.WriteLine(GetMcDateTimeNow() + " [INFO] Connected players: AngryRhetoric, efess");
                        break;
                    case "HELP":
                        Console.WriteLine(GetMcDateTimeNow() + " [INFO] \t kick <player>             removes a player from the server");
                        Console.WriteLine(GetMcDateTimeNow() + " [INFO] \t ban <player>              bans a player from the server");
                        Console.WriteLine(GetMcDateTimeNow() + " [INFO] \t pardon <player>           pardons a banned player so that they can connect again");
                        Console.WriteLine(GetMcDateTimeNow() + " [INFO] \t ban-ip <ip>               bans an IP address from the server");
                        Console.WriteLine(GetMcDateTimeNow() + " [INFO] \t pardon-ip <ip>            pardons a banned IP address so that they can connect again");
                        Console.WriteLine(GetMcDateTimeNow() + " [INFO] \t op <player>               turns a player into an op");
                        Console.WriteLine(GetMcDateTimeNow() + " [INFO] \t deop <player>             removes op status from a player");
                        Console.WriteLine(GetMcDateTimeNow() + " [INFO] \t tp <player1> <player2>    moves one player to the same location as another player");
                        Console.WriteLine(GetMcDateTimeNow() + " [INFO] \t give <player> <id> [num]  gives a player a resource");
                        Console.WriteLine(GetMcDateTimeNow() + " [INFO] \t tell <player> <message>   sends a private message to a player");
                        Console.WriteLine(GetMcDateTimeNow() + " [INFO] \t say <message>             broadcasts a message to all ");
                        Console.WriteLine(GetMcDateTimeNow() + " [INFO] \t time <add|set> <amount>   adds to or sets the world time (0-24000)");
                        break;

                }

                int wtf = 3;
                if(wtf == 3 && check.ToUpper().StartsWith("SAY "))
                {
                    Console.WriteLine(GetMcDateTimeNow() + " [INFO] [CONSOLE] " + check.Substring(4, check.Length - 4));
                }
            }
        }

        private static void OutputError()
        {
            throw new Exception("Trying this exception");
        }

        private static void Write()
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

            int number = rand.Next(0, _outputLines.Length);

            if (number < _outputLines.Length && number >= 0)
            {
                return string.Format("{0} {1}",GetMcDateTimeNow(), _outputLines[number]);;
            }

            return null;
        }

        private static string GetMcDateTimeNow()
        {
            return DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

    }
}
