using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BE_FacturaProveedor
    {
        [Browsable(false)]
        public int ID { get; set; }
        public string NumeroFactura{ get; set; }
        [Browsable(false)]
        public BE_Proveedor Proveedor { get; set; }
        public decimal Monto { get; set; }
        public DateTime FechaEmision { get; set; }
        public string MetodoPago { get; set; }
        public bool EstaPagada { get; set; }

        public BE_FacturaProveedor()
        {
        }

        public override string ToString()
        {
            return $"Factura N° {NumeroFactura} - {FechaEmision:dd/MM/yyyy} - Total: ${Monto:N2}";
        }
    }
}
