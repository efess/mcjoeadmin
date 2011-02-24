﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace McJoeAdmin.Model
{
    public class McPlayerMessage
    {
        public string Name { get; private set; }
        public bool IsLoggingIn { get; private set; }
        public bool IsDisconnecting { get; private set; }
        public string Command { get; private set; }
        public string SubMessage { get; private set; }
        public string RawMessage { get; private set; }

        public McPlayerMessage(string pMessage)
        {
            RawMessage = pMessage;

            Regex reg = new Regex("<(.+)> (!.+?) (.+)");
            var match = reg.Match(pMessage);
            var groups = match.Groups;
            if (groups.Count == 4)
            {
                Name = groups[1].Value.Trim();
                Command = groups[2].Value.Trim();
                SubMessage = groups[3].Value.Trim();
                return;
            }


            reg = new Regex("<(.+)> (.+)");
            match = reg.Match(pMessage);
            groups = match.Groups;
            if (groups.Count == 3)
            {
                Name = groups[1].Value.Trim();
                SubMessage = groups[2].Value.Trim();
                return;
            }
            //Jagmatt [/72.200.148.166:61422] logged in with entity id 28397
            reg = new Regex("(.+) \\[(.+)\\] logged in with entity id (.+)");

            match = reg.Match(pMessage);
            groups = match.Groups;
            if (groups.Count == 4)
            {
                IsLoggingIn = true;
                Name = groups[1].Value.ToString();
                return;
            }
        }
    }
}
