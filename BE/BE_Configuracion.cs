using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BE_Configuracion
    {
        public int ID { get; set; }
        public string Clave { get; set; }
        public string Valor { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaModificacion { get; set; }
    }
}
