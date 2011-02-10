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

                Console.WriteLine(check);

                if (check.ToUpper().Contains("ERROR"))
                    new Action(OutputError).BeginInvoke(null, null);
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
                Console.WriteLine("Outputing something... the time is " + DateTime.Now.ToString("HH:mm"));
                System.Threading.Thread.Sleep(5000);
            }
        }
    }
}
