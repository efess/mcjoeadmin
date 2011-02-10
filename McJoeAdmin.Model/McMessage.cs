using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace McJoeAdmin.Model
{
    public class McMessage
    {
        public string Data { get; private set; }
        public McMessageOrigin Origin { get; private set; }

        public McMessage(string pData, McMessageOrigin pOrigin)
        {
            Data = pData;
            Origin = pOrigin;
        }
    }
}
