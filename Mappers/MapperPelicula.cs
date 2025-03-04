using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace Mappers
{
    public class MapperPelicula
    {
        private readonly DAL_Xml _dalXml;

        public MapperPelicula()
        {
            _dalXml = new DAL_Xml();
        }

        public void Alta(BE_Pelicula pelicula)
        {
            try
            {
                var peliculas = _dalXml.LeerXml<BE_Pelicula>();
                if(peliculas.Any(p => p.Titulo == pelicula.Titulo))
                {
                    throw new Exception("Ya existe una pelicula con ese titulo");
                }
                pelicula.ID = peliculas.Any() ? peliculas.Max(x => x.ID) + 1 : 1;
                peliculas.Add(pelicula);
                _dalXml.GuardarXml(peliculas);
            }
            catch (Exception ex)
            {

                throw new Exception($"Error al guardar la pelicula: {ex.Message}", ex);
            }

        }

        public void Baja(BE_Pelicula pelicula)
        {
            var peliculas = _dalXml.LeerXml<BE_Pelicula>();
            var peliculaEncontrada = peliculas.Find(x => x.ID == pelicula.ID);
            if (peliculaEncontrada != null)
            {
                peliculas.Remove(peliculaEncontrada);
                _dalXml.GuardarXml(peliculas);
            }
        }

        public void Modificar(BE_Pelicula pelicula)
        {
            var peliculas = _dalXml.LeerXml<BE_Pelicula>();
            var peliculaEncontrada = peliculas.Find(x => x.ID == pelicula.ID);
            if (peliculaEncontrada != null)
            {
                peliculaEncontrada.Titulo = pelicula.Titulo;
                peliculaEncontrada.Sinopsis = pelicula.Sinopsis;
                peliculaEncontrada.Duracion = pelicula.Duracion;
                peliculaEncontrada.EstaActiva = pelicula.EstaActiva;
                peliculaEncontrada.Sinopsis = pelicula.Sinopsis;
                _dalXml.GuardarXml(peliculas);
            }
        }

        public List<BE_Pelicula> Consultar()
        {
            return _dalXml.LeerXml<BE_Pelicula>();
        }
    }
}
