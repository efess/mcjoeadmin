using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace McJoeAdmin.InformationLookup.UrbanDictionary
{
    public class UDScreenScraper
    {
        public virtual UDDefinition ScreenScrape(string pHtml)
        {
            return new UDDefinition(string.Empty, 0, 0, string.Empty);
        }
    }
}
