using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mappers;
using BE;

namespace BLL
{
    public class BLL_Butaca
    {
        private readonly MapperButaca _mapperButaca;
        private readonly BLL_Sala gestorSala;

        public BLL_Butaca()
        {
            _mapperButaca = new MapperButaca();
            gestorSala = new BLL_Sala();
        }

        public void Alta(BE_Butaca butaca)
        {
            _mapperButaca.Alta(butaca);
        }

        public bool Baja(BE_Butaca butaca)
        {
            if (butaca.EstaDisponible())
            {
                _mapperButaca.Baja(butaca);
                return true;
            }
            return false;
        }   

        public List<BE_Butaca> Consultar()
        {
            return _mapperButaca.Consultar();
        }

        public List<BE_Butaca> ConsultarButacasDisponibles(int idSala)
        {
            var sala = gestorSala.Consultar().FirstOrDefault(x => x.ID == idSala);
            return sala?.Butacas?.Where(x => x.Disponible).ToList() ?? new List<BE_Butaca>();
        }

        public List<BE_Butaca> ConsultarButacasPorSala(int idSala)
        {
            return _mapperButaca.Consultar().Where(x => x.Sala.ID == idSala).ToList();
        }


        public void OcuparButaca(BE_Butaca butaca)
        {
            butaca.Disponible = false;
            gestorSala.ModificarButaca(butaca);
        }

        public void LiberarButaca(BE_Butaca butaca)
        {
            butaca.Disponible = true;
            gestorSala.ModificarButaca(butaca);
        }
    }
}
