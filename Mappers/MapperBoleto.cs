using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;

namespace Mappers
{
    public class MapperBoleto
    {
        private readonly DAL_Xml _dalXml;
        private readonly MapperCliente _mapperCliente;
        private readonly MapperFuncion _mapperFuncion;

        public MapperBoleto()
        {
            _dalXml = new DAL_Xml();
            _mapperCliente = new MapperCliente();
            _mapperFuncion = new MapperFuncion();
        }

        public void Alta(BE_Boleto boleto)
        {
            var boletos = _dalXml.LeerXml<BE_Boleto>();
            boleto.ID = boletos.Any() ? boletos.Max(x => x.ID) + 1 : 1;
            boletos.Add(boleto);
            _dalXml.GuardarXml(boletos);
        }

        public List<BE_Boleto> Consultar()
        {
            var boletos = _dalXml.LeerXml<BE_Boleto>();
            return boletos;
        }
    }
}
