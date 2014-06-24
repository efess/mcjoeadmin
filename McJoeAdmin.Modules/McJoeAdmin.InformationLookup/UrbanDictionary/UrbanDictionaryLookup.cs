using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace McJoeAdmin.InformationLookup.UrbanDictionary
{
    public class UrbanDictionaryLookup
    {
        private const string LOOKUP_URL = @"http://www.urbandictionary.com/define.php?term={0}";

        public UDDefinition Lookup(string pWord)
        {
            var html = GetDefinition(pWord);

            return GetScreenScraper().ScreenScrape(html);
        }

        protected virtual string GetDefinition(string pWord)
        {
            var request = System.Net.HttpWebRequest.Create(
                string.Format(LOOKUP_URL, pWord));

            var response = request.GetResponse();
            var stream = response.GetResponseStream();

            var streamReader = new System.IO.StreamReader(stream);

            return streamReader.ReadToEnd();
        }

        protected virtual UDScreenScraper GetScreenScraper()
        {
            return new UDScreenScraper();
        }
    }
}
