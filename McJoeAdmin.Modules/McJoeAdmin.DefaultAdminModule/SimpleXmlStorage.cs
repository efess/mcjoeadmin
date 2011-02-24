using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using McJoeAdmin.DefaultAdminModule.XmlObjects;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace McJoeAdmin.DefaultAdminModule
{
    public static class SimpleXmlStorage
    {
        private const string XML_SUB_DIRECTORY = "xml";

        public static T Load<T>() 
            where T : SimpleXmlStorageObjectBase, new()
        {
            var xmlObject = new T();
            
            var xmlFileName = GetPath(xmlObject);

            using (var xmlReader = XmlReader.Create(xmlFileName))
            {
                var serializer = new XmlSerializer(xmlObject.GetType());
                return serializer.Deserialize(xmlReader) as T;
            }
        }
            

        public static void Save(SimpleXmlStorageObjectBase pXmlObject)
        {
            var xmlFileName = GetPath(pXmlObject);
            using (var xmlWriter = XmlWriter.Create(xmlFileName))
            {
                var serializer = new XmlSerializer(pXmlObject.GetType());
                serializer.Serialize(xmlWriter, pXmlObject);
            }
        }
        private static string GetPath(SimpleXmlStorageObjectBase xmlStorageObject) 
        {
            
            var fileName =
                System.IO.Path.Combine(
                    System.IO.Path.Combine(
                        System.IO.Path.GetDirectoryName(
                            System.Reflection.Assembly.GetExecutingAssembly().Location),
                            XML_SUB_DIRECTORY), xmlStorageObject.XmlFile);

            if (!File.Exists(fileName))
                File.Create(fileName);

            return fileName;
        }
    }
}
