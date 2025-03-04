using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BE;

namespace Mappers
{
    public class MapperProveedor
    {
        private readonly DAL_Xml _dalXml;

        public MapperProveedor()
        {
            _dalXml = new DAL_Xml();
        }

        public void Alta(BE_Proveedor proveedor)
        {
            List<BE_Proveedor> proveedores = _dalXml.LeerXml<BE_Proveedor>();

            if(proveedores.Any(p => p.CUIT == proveedor.CUIT))
            {
                throw new Exception("Ya existe un proveedor con el CUIT ingresado");
            }

            proveedor.ID = proveedores.Any() ? proveedores.Max(x => x.ID) + 1 : 1;
            proveedores.Add(proveedor);
            _dalXml.GuardarXml(proveedores);
        }

        public void Baja(BE_Proveedor proveedor)
        {
            List<BE_Proveedor> proveedores = _dalXml.LeerXml<BE_Proveedor>();
            var proveedorEncontrado = proveedores.Find(x => x.ID == proveedor.ID);
            if(proveedorEncontrado != null)
            {
                proveedores.Remove(proveedorEncontrado);
                _dalXml.GuardarXml(proveedores);
            }
        }

        public List<BE_Proveedor> Consultar()
        {
            return _dalXml.LeerXml<BE_Proveedor>();
        }

        public void Modificar(BE_Proveedor proveedor)
        {
            List<BE_Proveedor> proveedores = _dalXml.LeerXml<BE_Proveedor>();
            var proveedorExistente = proveedores.Find(x => x.ID == proveedor.ID);
            if (proveedorExistente != null)
            {
                proveedorExistente.RazonSocial = proveedor.RazonSocial;
                proveedorExistente.CUIT = proveedor.CUIT;
                proveedorExistente.DireccionProveedor = proveedor.DireccionProveedor;
                proveedorExistente.EmailProveedor = proveedor.EmailProveedor;
                proveedorExistente.EstaActivo = proveedor.EstaActivo;
                proveedorExistente.Productos = proveedor.Productos;
                _dalXml.GuardarXml(proveedores);
            }
        }

        public BE_Proveedor ConsultarPorID(int id)
        {
            return Consultar().FirstOrDefault(x => x.ID == id);
        }

        public BE_Proveedor ConsultarPorCUIT(string cuit)
        {
            return Consultar().FirstOrDefault(x => x.CUIT == cuit);
        }
    }
}
