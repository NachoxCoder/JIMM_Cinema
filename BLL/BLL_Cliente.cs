using BE;
using Mappers;
using System.Collections.Generic;
using System.Linq;

namespace BLL
{
    public class BLL_Cliente
    {
        private MapperCliente _mapperCliente;

        public BLL_Cliente() 
        {
            _mapperCliente = new MapperCliente();
        }

        public void Alta(BE_Cliente cliente)
        {
            _mapperCliente.Alta(cliente);
        }

        public bool Baja(BE_Cliente cliente)
        {
            var clienteExistente = ObtenerporDNI(cliente.DNI);
            if (clienteExistente == null)
            {
                return false;
            }
            _mapperCliente.Baja(cliente);
            return true;
        }

        public bool Modificar(BE_Cliente cliente)
        {
            var clienteExistente = ObtenerporDNI(cliente.DNI);
            if (clienteExistente == null)
            {
                return false;
            }
            _mapperCliente.Modificar(cliente);
            return true;
        }

        public List<BE_Cliente> Consultar()
        {
            return _mapperCliente.Consultar();
        }

        public BE_Cliente ObtenerporDNI(string dni)
        {
            return _mapperCliente.Consultar().FirstOrDefault(x => x.DNI == dni);
        }
    }
}
