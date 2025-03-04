using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using Mappers;

namespace BLL
{
    public class BLL_OrdenCompra
    {
        private readonly MapperOrdenCompra _mapperOrdenCompra;
        private readonly BLL_Producto _gestorProducto;
        private readonly BLL_Proveedor _gestorProveedor;

        public BLL_OrdenCompra()
        {
            _mapperOrdenCompra = new MapperOrdenCompra();
            _gestorProducto = new BLL_Producto();
            _gestorProveedor = new BLL_Proveedor();
        }

        public void Alta(BE_OrdenCompra ordenCompra)
        {
            _mapperOrdenCompra.Alta(ordenCompra);
        }

        public void Baja(BE_OrdenCompra ordenCompra)
        {
            var ordenCompraExistente = _mapperOrdenCompra.ConsultarPorID(ordenCompra.ID);
            if (ordenCompraExistente == null)
                throw new Exception("No se encontró la orden de compra");

            _mapperOrdenCompra.Baja(ordenCompra);
        }

        public void Modificar(BE_OrdenCompra ordenCompra)
        {
            var ordenCompraExistente = _mapperOrdenCompra.ConsultarPorID(ordenCompra.ID);
            if (ordenCompraExistente == null)
                throw new Exception("No se encontró la orden Compra");
            _mapperOrdenCompra.Modificar(ordenCompra);
        }

        public List<BE_OrdenCompra> Consultar()
        {
            return _mapperOrdenCompra.Consultar();
        }

        public BE_OrdenCompra ConsultarPorID(int id)
        {
            return _mapperOrdenCompra.ConsultarPorID(id);
        }

        public List<BE_OrdenCompra> ConsultarPorProveedor(int proveedorID)
        {
            return _mapperOrdenCompra.Consultar().Where(x => x.Proveedor.ID == proveedorID).ToList();
        }

        public decimal CalcularTotal(Dictionary<BE_Producto, int> productos)
        {
            decimal total = 0;
            foreach (var item in productos)
            {
                total += item.Key.PrecioProducto * item.Value;
            }
            return total;
        }

        public void AgregarFactura(BE_OrdenCompra ordenCompra, BE_FacturaProveedor factura)
        {
            if (ordenCompra.Facturas == null)
                ordenCompra.Facturas = new List<BE_FacturaProveedor>();

            var facturaExistente = ordenCompra.Facturas.FirstOrDefault(x => x.ID == factura.ID);
            if(facturaExistente != null)
                throw new Exception("La factura ya fue agregada a la orden de compra");

            ordenCompra.Facturas.Add(factura);
            _mapperOrdenCompra.Modificar(ordenCompra);
        }

        public void ActualizarFactura(BE_FacturaProveedor factura)
        {
            var ordenesCompra = _mapperOrdenCompra.Consultar();
            var ordenCompra = ordenesCompra.FirstOrDefault(x => x.Facturas.Any(p => p.ID == factura.ID));

            if (ordenCompra != null)
            {
                var facturaExistente = ordenCompra.Facturas.FirstOrDefault(x => x.ID == factura.ID);
                if (facturaExistente != null)
                {
                    facturaExistente.NumeroFactura = factura.NumeroFactura;
                    facturaExistente.Monto = factura.Monto;
                    facturaExistente.FechaEmision = factura.FechaEmision;
                    facturaExistente.MetodoPago = factura.MetodoPago;
                    facturaExistente.EstaPagada = factura.EstaPagada;
                    _mapperOrdenCompra.Modificar(ordenCompra);
                }
            }
        }
    }
}

