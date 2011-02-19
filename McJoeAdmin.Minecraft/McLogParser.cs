using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using McJoeAdmin.Model;

namespace McJoeAdmin.Minecraft
{
    public static class McLogParser
    {
        public static McMessage Parse(string pLine)
        {

            DateTime dateObject = new DateTime(1990,1,1);
            string messageType = string.Empty;
            string data = pLine;

            // Lazzy try
            try
            {
                var date = pLine.Substring(0, 19);
                dateObject = DateTime.Parse(date);

                var index = pLine.IndexOf(']');
                messageType = pLine.Substring(21, index - 21);
                data = pLine.Substring(index + 2, pLine.Length - (index + 2));

            }catch{}

            return new McMessage(data, McMessageOrigin.ServerProcess, messageType, dateObject);
        }
    }
}
