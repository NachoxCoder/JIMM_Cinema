using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using BE;
using DAL;

namespace Mappers
{
    public class MapperFacturaProveedor
    {
        private readonly DAL_Xml _dal_Xml;

        public MapperFacturaProveedor()
        {
            _dal_Xml = new DAL_Xml();
        }

        public void Alta(BE_FacturaProveedor factura)
        {
            try
            {
                List<BE_FacturaProveedor> facturas = _dal_Xml.LeerXml<BE_FacturaProveedor>();

                if (facturas.Any(f => f.NumeroFactura == factura.NumeroFactura && f.Proveedor.ID == factura.Proveedor.ID))
                {
                    throw new Exception("Ya existe una factura con el mismo ID para este Proveedor");
                }

                factura.ID = facturas.Any() ? facturas.Max(f => f.ID) + 1 : 1;
                facturas.Add(factura);
                _dal_Xml.GuardarXml(facturas);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al guardar factura de proveedor", ex);
            }
        }

        public void Baja(BE_FacturaProveedor factura)
        {
            try
            {
                List<BE_FacturaProveedor> facturas = _dal_Xml.LeerXml<BE_FacturaProveedor>();
                var facturaExistente = facturas.FirstOrDefault(f => f.ID == factura.ID && f.Proveedor.ID == factura.Proveedor.ID);

                if(facturaExistente == null)
                {
                    throw new Exception("No existe una factura con el ID ingresado");
                }

                facturas.Remove(facturaExistente);
                _dal_Xml.GuardarXml(facturas);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar factura de proveedor", ex);
            }
        }

        public void Modificar(BE_FacturaProveedor factura)
        {
            try
            {
                List<BE_FacturaProveedor> facturas = _dal_Xml.LeerXml<BE_FacturaProveedor>();
                var facturaExistente = facturas.FirstOrDefault(f => f.ID == factura.ID && f.Proveedor.ID == factura.Proveedor.ID);

                if (facturaExistente == null)
                {
                    throw new Exception("No existe una factura con el ID ingresado");
                }

                facturaExistente.Monto = factura.Monto;
                facturaExistente.FechaEmision = factura.FechaEmision;
                facturaExistente.MetodoPago = factura.MetodoPago;
                facturaExistente.EstaPagada = factura.EstaPagada;

                _dal_Xml.GuardarXml(facturas);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar factura de proveedor", ex);
            }
        }

        public List<BE_FacturaProveedor> Consultar()
        {
            try
            {
                return _dal_Xml.LeerXml<BE_FacturaProveedor>();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar facturas de proveedor", ex);
            }
        }

        public List<BE_FacturaProveedor> ConsultarPorProveedor(BE_Proveedor proveedor)
        {
            try
            {
                return Consultar().Where(f => f.Proveedor.ID == proveedor.ID).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar facturas de proveedor", ex);
            }
        }
    }
}
