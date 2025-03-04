using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BE_Producto
    {
        public  BE_Producto()
        {
        }

        [Browsable(false)]
        public int ID { get; set; }
        public string NombreProducto { get; set; }
        public string DescripcionProducto { get; set; }
        public decimal PrecioProducto { get; set; }
        public int Stock { get; set; }
        public bool EstaActivo { get; set; }

        public bool TieneBajoStock()
        {
            return Stock < 10;
        }
    }
}
