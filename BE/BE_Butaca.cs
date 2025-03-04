using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
     public class BE_Butaca
    {
        public int ID { get; set; }
        public string Fila { get; set; }
        public int Numero { get; set; }
        public bool Disponible { get; set; }
        public BE_Sala Sala { get; set; }

        public BE_Butaca()
        {
        }

        public override string ToString()
        {
            return $"Fila {Fila} - Asiento {Numero}";
        }

        public bool EstaDisponible()
        {
            return Disponible;
        }
    }
}
