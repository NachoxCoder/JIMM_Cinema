using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BE_Bitacora
    {
        public int ID { get; set; }
        public DateTime Fecha { get; set; }
        public string Evento { get; set; }
        public BE_Usuario Usuario { get; set; }

        public BE_Bitacora()
        {
            Fecha = DateTime.Now;
            Evento = string.Empty;
        }
        public BE_Bitacora(DateTime fecha, string evento, BE_Usuario usuario)
        {
            Fecha = fecha;
            Evento = evento;
            Usuario = usuario;
        }
    }
}
