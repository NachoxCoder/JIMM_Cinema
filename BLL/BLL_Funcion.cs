using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mappers;
using BE;

namespace BLL
{
    public class BLL_Funcion
    {
        private readonly MapperFuncion _mapperFuncion;

        public BLL_Funcion()
        {
            _mapperFuncion = new MapperFuncion();
        }

        public bool Alta(BE_Funcion funcion)
        {
            try
            {
                ValidarHorarios(funcion);
                _mapperFuncion.Alta(funcion);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Baja(BE_Funcion funcion)
        {
            try
            {
                _mapperFuncion.Baja(funcion);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Modificar(BE_Funcion funcion)
        {
            try
            {
                if (!ValidarHorarios(funcion))
                {
                    return false;
                }
                _mapperFuncion.Modificar(funcion);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<BE_Funcion> Consultar()
        {
            return _mapperFuncion.Consultar();
        }

        public List<BE_Funcion> ConsultarFuncionesPorPelicula(BE_Pelicula pelicula)
        {
            if(pelicula == null)
                return new List<BE_Funcion>();

            return _mapperFuncion.Consultar().Where(x => x.Pelicula.ID == pelicula.ID).ToList();
        }

        public List<BE_Funcion> ConsultarFuncionesDisponibles(int idSala)
        {
            return _mapperFuncion.Consultar().Where(x => x.FechaFuncion >= DateTime.Today && x.EstaActiva)
                .OrderBy(x => x.FechaFuncion).ThenBy(x => x.HoraInicio).ToList();
        }

        public bool ValidarDisponibilidad(BE_Funcion funcion, string fila, int numero)
        {
            return _mapperFuncion.ValidarDisponibilidadButaca(funcion.ID, fila, numero);
        }

        public bool ValidarHorarios(BE_Funcion funcion)
        {
            TimeSpan duracionMaxima = TimeSpan.FromMinutes(funcion.Pelicula.Duracion + 30);
            TimeSpan duracionFuncion = funcion.HoraFin - funcion.HoraInicio;

            if (duracionFuncion > duracionMaxima)
            {
                throw new Exception($"La duración de la funcion, debe ser igual o menor" +
                    $" a la duracion de la pelicula + 30 minutos: {duracionMaxima.TotalMinutes} .");
            }

            var funcionesExistentes = _mapperFuncion.Consultar().Where(x => x.Sala.ID == funcion.Sala.ID &&
                      x.ID != funcion.ID).ToList();

            var solapamiento = funcionesExistentes.FirstOrDefault(f => f.SeSolapaCon(funcion));
            if (solapamiento != null)
            {
                throw new Exception($"La función se solapa con: {solapamiento.Pelicula.Titulo} " +
                    $"({solapamiento.HoraInicio:hh\\:mm} - {solapamiento.HoraFin:hh\\:mm})");
            }

            return true;
        }
    }
}
