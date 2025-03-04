using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace Mappers
{
    public class MapperOrdenCompra
    {
        private readonly DAL_Xml _dalXml;

        public MapperOrdenCompra()
        {
            _dalXml = new DAL_Xml();
        }

        public void Alta(BE_OrdenCompra ordenCompra)
        {
            List<BE_OrdenCompra> ordenesCompra = _dalXml.LeerXml<BE_OrdenCompra>();
            ordenCompra.ID = ordenesCompra.Any() ? ordenesCompra.Max(x => x.ID) + 1 : 1;
            ordenesCompra.Add(ordenCompra);
            _dalXml.GuardarXml(ordenesCompra);
        }

        public void Baja(BE_OrdenCompra ordenCompra)
        {
            List<BE_OrdenCompra> ordenesCompra = _dalXml.LeerXml<BE_OrdenCompra>();
            var ordenCompraEncontrada = ordenesCompra.FirstOrDefault(x => x.ID == ordenCompra.ID);
            if (ordenCompraEncontrada != null)
            {
                ordenesCompra.Remove(ordenCompraEncontrada);
                _dalXml.GuardarXml(ordenesCompra);
            }
        }

        public void Modificar(BE_OrdenCompra ordenCompra)
        {
            List<BE_OrdenCompra> ordenesCompra = _dalXml.LeerXml<BE_OrdenCompra>();
            var ordenCompraExistente = ordenesCompra.Find(x => x.ID == ordenCompra.ID);
            if (ordenCompraExistente != null)
            {
                ordenCompraExistente.Facturas = ordenCompra.Facturas;
                _dalXml.GuardarXml(ordenesCompra);
            }
        }

        public List<BE_OrdenCompra> Consultar()
        {
            return _dalXml.LeerXml<BE_OrdenCompra>();
        }

        public BE_OrdenCompra ConsultarPorID(int id)
        {
            return Consultar().FirstOrDefault(x => x.ID == id);
        }
    }
}
