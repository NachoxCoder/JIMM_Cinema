using System.Xml.Serialization;
using System.Xml;
using System.Collections.Generic;
using System.IO;

namespace DAL
{
    public class DAL_Xml
    {
        private readonly string Carpeta = "DATA";

        public void GuardarXml<T>(List<T> lista)
        {
            XmlWriterSettings xmlWriterSettings = new XmlWriterSettings()
            {
                Indent = true,
                OmitXmlDeclaration = true
            };

            XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
            ns.Add("", "");

            string fileName = Path.Combine(Carpeta, $"{typeof(T).Name}.xml");

            if (!Directory.Exists(Carpeta))
            {
                Directory.CreateDirectory(Carpeta);
            }

            using (XmlWriter writer = XmlWriter.Create(fileName, xmlWriterSettings))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<T>));
                xmlSerializer.Serialize(writer, lista);
            }
        }

        public List<T> LeerXml<T>()
        {
            if (!Directory.Exists(Carpeta))
            {
                Directory.CreateDirectory(Carpeta);
            }

            List<T> lista = null;
            string fileName = Path.Combine(Carpeta, $"{typeof(T).Name}.xml");

            if (!File.Exists(fileName))
            {
                return new List<T>();
            }

            using (XmlReader reader = XmlReader.Create(fileName))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<T>));
                lista = (List<T>)xmlSerializer.Deserialize(reader);
            }

            return lista;
        }
    }
}
