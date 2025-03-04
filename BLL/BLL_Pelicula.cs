using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using Mappers;

namespace BLL
{
    public class BLL_Pelicula
    {
        private readonly MapperPelicula _mapperPelicula;
        private readonly BLL_Funcion gestorFuncion;

        public BLL_Pelicula()
        {
            _mapperPelicula = new MapperPelicula();
            gestorFuncion = new BLL_Funcion();
        }

        public bool Alta(BE_Pelicula pelicula)
        {
            try
            {
                _mapperPelicula.Alta(pelicula);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Baja(BE_Pelicula pelicula)
        {
            try
            {
                var peliculaExistente = ObtenerporId(pelicula.ID);
                if (peliculaExistente == null)
                {
                    return false;
                }

                //Elimino las funciones asociadas a la pelicula
                var funcionesAsociadas = gestorFuncion.ConsultarFuncionesPorPelicula(pelicula);
                foreach (var funcion in funcionesAsociadas)
                {
                    gestorFuncion.Baja(funcion);
                }

                _mapperPelicula.Baja(pelicula);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Modificar(BE_Pelicula pelicula)
        {
            try
            {
                _mapperPelicula.Modificar(pelicula);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<BE_Pelicula> Consultar()
        {
            return _mapperPelicula.Consultar();
        }

        public List<BE_Pelicula> ConsultarPeliculasActivas()
        {
            return _mapperPelicula.Consultar().Where(x => x.EstaActiva).ToList();
        }

        public BE_Pelicula ObtenerporId(int id)
        {
            return _mapperPelicula.Consultar().FirstOrDefault(x => x.ID == id);
        }
    }
}
