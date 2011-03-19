using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace McJoeAdmin.Controls
{
    public struct GraphSample
    {
        public long XValue { get; private set; }
        public long YValue { get; private set; }
        
        public GraphSample(long pXValue, long pYValue)
            : this()
        {
            XValue = pXValue;
            YValue = pYValue;
        }
    }
}
