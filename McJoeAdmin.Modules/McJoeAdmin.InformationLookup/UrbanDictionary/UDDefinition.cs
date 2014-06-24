using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace McJoeAdmin.InformationLookup.UrbanDictionary
{
    public class UDDefinition
    {
        public string Word { get; private set; }
        public int UpVotes { get; private set; }
        public int DownVotes { get; private set; }
        public string Definition { get; private set; }

        public UDDefinition(string pWord, int pUpVotes, int pDownVotes, string pDefinition)
        {
            Word = pWord;
            UpVotes = pUpVotes;
            DownVotes = pDownVotes;
            Definition = pDefinition;
        }
    }
}
