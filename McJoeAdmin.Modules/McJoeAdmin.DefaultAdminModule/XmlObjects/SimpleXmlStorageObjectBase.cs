using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Xml;

namespace McJoeAdmin.DefaultAdminModule.XmlObjects
{
    public abstract class SimpleXmlStorageObjectBase
    {
        private string _xmlFile;
        internal abstract string XmlFile { get; }

        public SimpleXmlStorageObjectBase()
        {

        }

        private void EnsureFileExists()
        {
            if(!System.IO.File.Exists(_xmlFile))
                System.IO.File.Create(_xmlFile);
        }
    }
}
