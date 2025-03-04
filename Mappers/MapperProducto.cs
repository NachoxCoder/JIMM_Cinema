using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BE;

namespace Mappers
{
     public class MapperProducto
    {
        private readonly DAL_Xml _dalXml;

        public MapperProducto()
        {
            _dalXml = new DAL_Xml();
        }

        public void Alta(BE_Producto producto)
        {
            List<BE_Producto> productos = _dalXml.LeerXml<BE_Producto>();
            if (productos.Any(p => p.NombreProducto == producto.NombreProducto))
            {
                throw new Exception("Ya existe una producto con ese Nombre");
            }
            producto.ID = productos.Any() ? productos.Max(x => x.ID) + 1 : 1;
            productos.Add(producto);
            _dalXml.GuardarXml(productos);
        }

        public void Baja(BE_Producto producto)
        {
            List<BE_Producto> productos = _dalXml.LeerXml<BE_Producto>();
            var productoEncontrado = productos.Find(x => x.ID == producto.ID);
            if(productoEncontrado != null)
            {
                productos.Remove(productoEncontrado);
                _dalXml.GuardarXml(productos);
            }
        }

        public void Modificar(BE_Producto producto)
        {
            List<BE_Producto> productos = _dalXml.LeerXml<BE_Producto>();
            var productoEncontrado = productos.Find(x => x.ID == producto.ID);
            if (productoEncontrado != null)
            {
                productoEncontrado.NombreProducto = producto.NombreProducto;
                productoEncontrado.DescripcionProducto = producto.DescripcionProducto;
                productoEncontrado.PrecioProducto = producto.PrecioProducto;
                productoEncontrado.Stock = producto.Stock;
                _dalXml.GuardarXml(productos);
            }
        }

        public List<BE_Producto> Consultar()
        {
            return _dalXml.LeerXml<BE_Producto>();
        }

        public BE_Producto ConsultarPorID(int id)
        {
            return Consultar().FirstOrDefault(x => x.ID == id);
        }
    }
}
