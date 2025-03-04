using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BE
{
    public class BE_OrdenCompra
    {
        public BE_OrdenCompra()
        {
            Items = new List<ItemOrdenCompra>();
            Facturas = new List<BE_FacturaProveedor>();
            FechaOrdenCompra = DateTime.Now;
        }
        [Browsable(false)]
        public int ID { get; set; }
        public DateTime FechaOrdenCompra { get; set; }
        [XmlIgnore]
        public decimal TotalOrdenCompra
        {
            get
            {
                decimal total = 0;
                foreach (var item in Items)
                {
                    total += item.Producto.PrecioProducto * item.Cantidad;
                }
                return total;
            }
        }
        public BE_Proveedor Proveedor { get; set; }
        public List<BE_FacturaProveedor> Facturas { get; set; }
        public List<ItemOrdenCompra> Items { get; set; }
        [XmlIgnore]
        public Dictionary<BE_Producto, int> ProductosCantidad
        {
            get
            {
                var dic = new Dictionary<BE_Producto, int>();
                foreach (var item in Items)
                {
                    dic[item.Producto] = item.Cantidad;
                }
                return dic;
            }
            set
            {
                Items = new List<ItemOrdenCompra>();
                foreach (var kvp in value)
                {
                    Items.Add(new ItemOrdenCompra { Producto = kvp.Key, Cantidad = kvp.Value });
                }
            }
        }
    }

    public class ItemOrdenCompra
    {
        public BE_Producto Producto { get; set; }
        public int Cantidad { get; set; }
    }
}
