using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mappers;
using BE;

namespace BLL
{
    public class BLL_Bitacora
    {
        private readonly MapperBitacora _mapperBitacora;

        public BLL_Bitacora()
        {
            _mapperBitacora = new MapperBitacora();
        }

        public void LogEvent(string evento, BE_Usuario usuario)
        {
            var bitacora = new BE_Bitacora
            {
                Fecha = DateTime.Now,
                Evento = evento,
                Usuario = usuario
            };

            _mapperBitacora.Alta(bitacora);
        }

        public List<BE_Bitacora> Consultar()
        {
            return _mapperBitacora.Consultar();
        }

        public BE_Bitacora ConsultarPorID(int id)
        {
            return _mapperBitacora.ConsultarPorID(id);
        }

        public List<BE_Bitacora> ConsultarPorUsuario(BE_Usuario usuario)
        {
            return _mapperBitacora.Consultar().Where(x => x.Usuario != null && x.Usuario.ID == usuario.ID).ToList();
        }

        public List<BE_Bitacora> ConsultarPorFecha(DateTime desde, DateTime hasta)
        {
            return _mapperBitacora.Consultar().Where(x => x.Fecha.Date >= desde.Date && x.Fecha.Date <= hasta.Date).ToList();
        }
    }
}
