using Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace BLL
{
     public class BLL_Producto
    {
        private readonly MapperProducto _mapperProducto;

        public BLL_Producto()
        {
            _mapperProducto = new MapperProducto();
        }

        public void Alta(BE_Producto producto)
        {
            _mapperProducto.Alta(producto);
        }

        public void Baja(BE_Producto producto)
        {
            _mapperProducto.Baja(producto);
        }

        public void Modificar(BE_Producto producto)
        {
            _mapperProducto.Modificar(producto);
        }

        public List<BE_Producto> Consultar()
        {
            return _mapperProducto.Consultar();
        }

        public List<BE_Producto> ConsultarConStockBajo()
        {
            return _mapperProducto.Consultar().Where(x => x.EstaActivo && x.TieneBajoStock()).ToList();
        }

        public BE_Producto ConsultarPorID(int id)
        {
            return _mapperProducto.ConsultarPorID(id);
        }

        public List<BE_Producto> ListarProductosBajoStock()
        {
            return ConsultarConStockBajo();
        }
    }
}
