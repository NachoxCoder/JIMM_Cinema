using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BE_Proveedor
    {
        public BE_Proveedor()
        {
            Productos = new List<BE_Producto>();
            EstaActivo = true;
        }

        [Browsable(false)]
        public int ID { get; set; }
        public string RazonSocial { get; set; }
        public string CUIT { get; set; }
        public string DireccionProveedor { get; set; }
        public string EmailProveedor { get; set; }
        public bool EstaActivo { get; set; }
        public virtual List<BE_Producto> Productos { get; set; }

        public override string ToString()
        {
            return $"{RazonSocial} ({CUIT})";
        }   
    }
}
