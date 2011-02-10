using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace McJoeAdmin.Model
{
    public class LineOutputEventArgs : EventArgs
    {
        public string Data { get; private set; }

        public LineOutputEventArgs(string pData)
        {
            Data = pData;
        }
    }
}
