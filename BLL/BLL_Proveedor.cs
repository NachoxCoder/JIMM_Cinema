using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using Mappers;

namespace BLL
{
    public class BLL_Proveedor
    {
        private readonly MapperProveedor _mapperProveedor;
        private readonly BLL_Producto _gestorProducto;

        public BLL_Proveedor()
        {
            _mapperProveedor = new MapperProveedor();
            _gestorProducto = new BLL_Producto();
        }

        public void Alta(BE_Proveedor proveedor)
        {
            _mapperProveedor.Alta(proveedor);
        }

        public void Baja(BE_Proveedor proveedor)
        {
            var proveedorExistente = _mapperProveedor.ConsultarPorID(proveedor.ID);
            if (proveedorExistente == null)
                throw new Exception("No se encontró el proveedor");

            var productos = proveedor.Productos;
            foreach (var producto in productos)
            {
                _gestorProducto.Baja(producto);
            }

            _mapperProveedor.Baja(proveedor);
        }

        public void Modificar(BE_Proveedor proveedor)
        {
            var proveedorExistente = _mapperProveedor.ConsultarPorID(proveedor.ID);
            if (proveedorExistente == null)
                throw new Exception("No se encontró el proveedor");
            _mapperProveedor.Modificar(proveedor);
        }

        public List<BE_Proveedor> Consultar()
        {
            return _mapperProveedor.Consultar();
        }

        public BE_Proveedor ConsultarPorID(int id)
        {
            return _mapperProveedor.ConsultarPorID(id);
        }

        public BE_Proveedor ConsultarPorCUIT(string cuit)
        {
            return _mapperProveedor.ConsultarPorCUIT(cuit);
        }

        public List<BE_Proveedor> ConsultarProveedoresActivos()
        {
            return _mapperProveedor.Consultar().Where(x => x.EstaActivo).ToList();
        }

        public void AgregarProducto(BE_Proveedor proveedor, BE_Producto producto)
        {
            if(!proveedor.Productos.Contains(producto))
            {
                proveedor.Productos.Add(producto);
                _mapperProveedor.Modificar(proveedor);
            }
        }

        public void RemoverProducto(BE_Proveedor proveedor, BE_Producto producto)
        {
            if (proveedor.Productos.Contains(producto))
            {
                proveedor.Productos.Remove(producto);
                _mapperProveedor.Modificar(proveedor);
            }
        }

        public void ActualizarProductos(BE_Producto producto)
        {
            var proveedores = _mapperProveedor.Consultar();
            var proveedor = proveedores.FirstOrDefault(x => x.Productos.Any(p => p.ID == producto.ID));

            if(proveedor != null)
            {
                var productoExistente = proveedor.Productos.FirstOrDefault(x => x.ID == producto.ID);
                if (productoExistente != null)
                {
                    productoExistente.NombreProducto = producto.NombreProducto;
                    productoExistente.DescripcionProducto = producto.DescripcionProducto;
                    productoExistente.PrecioProducto = producto.PrecioProducto;
                    productoExistente.Stock = producto.Stock;
                    _mapperProveedor.Modificar(proveedor);
                }
            }
        }
    }
}
