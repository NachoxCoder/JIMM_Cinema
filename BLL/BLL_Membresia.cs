using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using Mappers;

namespace BLL
{
    public class BLL_Membresia
    {
        private MapperMembresia _mapperMembresia;
        private readonly BLL_Cliente _gestorCliente;

        public BLL_Membresia()
        {
            _mapperMembresia = new MapperMembresia();
            _gestorCliente = new BLL_Cliente();
        }
        public bool Alta(BE_Membresia membresia)
        {
            try
            {
                var cliente = _gestorCliente.ObtenerporDNI(membresia.Cliente.DNI);
                if(cliente == null)
                {
                    return false;
                }

                var membresias = _mapperMembresia.Consultar();
                var membresiaCliente = membresias.Where(x => x.Cliente.DNI == membresia.Cliente.DNI);

                if(membresiaCliente.Any(m => m.EstaActiva && m.ID != membresia.ID))
                {
                    throw new Exception ("El cliente ya tiene una membresia activa");
                }

                if (membresia.ID == 0)
                {
                    membresia.FechaInicio = DateTime.Today;
                    membresia.FechaFin = DateTime.Today.AddMonths(1);
                    membresia.EstaActiva = true;
                    _mapperMembresia.Alta(membresia);
                }
                else
                {
                    _mapperMembresia.Modificar(membresia);
                }
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool CancelarMembresia(BE_Membresia membresia)
        {
            try
            {
                membresia.EstaActiva = false;
                membresia.FechaFin = DateTime.Today;
                _mapperMembresia.Modificar(membresia);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cancelar la membresia", ex);
            }
        }
        public void Baja(BE_Membresia membresia)
        {
            _mapperMembresia.Baja(membresia);
        }

        public List<BE_Membresia> Consultar()
        {
            return _mapperMembresia.Consultar();
        }

        public List<BE_Membresia> ConsultarPorCliente(int idCliente)
        {
            return _mapperMembresia.Consultar().Where(x => x.Cliente.ID == idCliente)
                .OrderByDescending(x => x.FechaInicio).ToList();
        }
    }
}
