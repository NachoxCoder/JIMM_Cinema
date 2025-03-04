using Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace BLL
{
    public class BLL_FacturaProveedor
    {
        private readonly MapperFacturaProveedor _mapperFacturaProveedor;
        private readonly BLL_OrdenCompra _gestorOrdenCompra;

        public BLL_FacturaProveedor()
        {
            _mapperFacturaProveedor = new MapperFacturaProveedor();
            _gestorOrdenCompra = new BLL_OrdenCompra();
        }

        public void Alta(BE_FacturaProveedor factura)
        {
            try
            {
                _mapperFacturaProveedor.Alta(factura);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al guardar factura de proveedor", ex);
            }
        }

        public List<BE_FacturaProveedor> Consultar()
        {
            try
            {
                return _mapperFacturaProveedor.Consultar();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar facturas de proveedor", ex);
            }
        }

        public void Modificar(BE_FacturaProveedor factura)
        {
            try
            {
                var facturaExistente = _mapperFacturaProveedor.Consultar().FirstOrDefault(x => x.ID == factura.ID);

                if(facturaExistente == null)
                {
                    throw new Exception("No se encontró la factura");
                }
                if(facturaExistente.EstaPagada)
                {
                    throw new Exception("No se puede modificar una factura que ya fue pagada");
                }

                _mapperFacturaProveedor.Modificar(factura);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar factura de proveedor", ex);
            }
        }

        public BE_FacturaProveedor ProcesarPago(BE_FacturaProveedor factura, string metodoPago, BE_OrdenCompra ordenCompra)
        {
            try
            {
                if (factura == null)
                    throw new ArgumentNullException(nameof(factura), "La factura no puede ser nula");

                if (ordenCompra == null)
                    throw new ArgumentNullException(nameof(ordenCompra), "La orden de compra no puede ser nula");

                if (string.IsNullOrWhiteSpace(metodoPago))
                    throw new ArgumentException("Debe seleccionar un método de pago");

                if (factura.EstaPagada)
                    throw new InvalidOperationException("La factura ya está pagada");

                var facturaActualizada = new BE_FacturaProveedor
                {
                    ID = factura.ID,
                    NumeroFactura = factura.NumeroFactura,
                    Proveedor = factura.Proveedor,
                    Monto = factura.Monto,
                    FechaEmision = factura.FechaEmision,
                    MetodoPago = metodoPago,
                    EstaPagada = true
                };

                _mapperFacturaProveedor.Modificar(facturaActualizada);

                var facturaEnOrden = ordenCompra.Facturas.FirstOrDefault(f => f.ID == factura.ID);
                if (facturaEnOrden != null)
                {
                    facturaEnOrden.MetodoPago = metodoPago;
                    facturaEnOrden.EstaPagada = true;
                    _gestorOrdenCompra.Modificar(ordenCompra);
                }

                return facturaActualizada;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al procesar el pago de la factura", ex);
            }
        }
    }
}
