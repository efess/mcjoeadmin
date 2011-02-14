﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace McJoeAdmin.Model
{
    [DataContract]
    public class McMessage
    {
        [DataMember]
        public string Data { get; private set; }
        [DataMember]
        public McMessageOrigin Origin { get; private set; }

        public McMessage(string pData, McMessageOrigin pOrigin)
        {
            Data = pData;
            Origin = pOrigin;
        }
    }
}
