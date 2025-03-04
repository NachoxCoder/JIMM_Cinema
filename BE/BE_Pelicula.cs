using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace BE
{
    public class BE_Pelicula
    {
        public BE_Pelicula()
        { 
            EstaActiva = true;
        }

        //Propiedades de la clase
        [Browsable(false)]
        public int ID { get; set; }
        public string Titulo { get; set; }
        public string Sinopsis { get; set; }
        public int Duracion { get; set; }
        public string Rating { get; set; }
        public bool EstaActiva { get; set; }
    }
}
