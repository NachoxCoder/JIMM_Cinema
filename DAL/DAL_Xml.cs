using System.Xml.Serialization;
using System.Xml;
using System.Collections.Generic;
using System.IO;

namespace DAL
{
    public class DAL_Xml
    {
        //Instanciamos la variable que contendra el nombre de la carpeta donde se almacenaran los archivos .Xml
        private readonly string Carpeta = "DATA";

        //Serializador que permite la creacion de un archivo Xml por cada clase
        public void GuardarXml<T>(List<T> lista)
        {
            //Esquema a aplicar para cada archivo xml
            XmlWriterSettings xmlWriterSettings = new XmlWriterSettings()
            {
                Indent = true,
                OmitXmlDeclaration = true
            };

            XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
            ns.Add("", "");

            //Instanciamos el nombre del archivo utilizando el nombre de la respectiva clase
            string fileName = Path.Combine(Carpeta, $"{typeof(T).Name}.xml");

            //Si la carpeta DATA(para almacenar todos los xml) no existe la creo
            if (!Directory.Exists(Carpeta))
            {
                Directory.CreateDirectory(Carpeta);
            }

            //Por ultimo creo o reescribo el archivo xml correspondiente a la clase
            using (XmlWriter writer = XmlWriter.Create(fileName, xmlWriterSettings))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<T>));
                xmlSerializer.Serialize(writer, lista);
            }
        }

        //Deserializador que permite obtener la data presente en cada uno de los archivos xml
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

            //Retorna los datos obtenidos del Xml correspondiente a la clase como una lista
            using (XmlReader reader = XmlReader.Create(fileName))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<T>));
                lista = (List<T>)xmlSerializer.Deserialize(reader);
            }

            return lista;
        }
    }
}
