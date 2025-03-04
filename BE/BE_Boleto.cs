using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BE_Boleto
    {
        public BE_Boleto()
        {
            Butacas = new List<BE_Butaca>();
        }

        public int ID { get; set; }
        public BE_Cliente Cliente { get; set; }
        public BE_Funcion Funcion { get; set; }
        public DateTime FechaVenta { get; set; }
        public decimal Precio { get; set; }
        public List <BE_Butaca> Butacas { get; set; }
        public MetodoPago Metodo { get; set; }

        public enum MetodoPago
        {
            Efectivo,
            TarjetaDebito,
            TarjetaCredito,
            CodigoQR,
            Transferencia
        }
    }
}
