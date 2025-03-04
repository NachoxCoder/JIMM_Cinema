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
    public class BE_Membresia
    {
        public BE_Membresia()
        {
            Cliente = new BE_Cliente();
            EstaActiva = true;
        }
        [Browsable(false)]
        public int ID { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public decimal CostoMensual { get; set; }
        public TipoMembresia Tipo { get; set; }
        public bool EstaActiva { get; set; }
        [Browsable(false)]
        public BE_Cliente Cliente { get; set; }
    }

    public enum TipoMembresia
    {
        Plata,
        Oro,
        Premium
    }
}
