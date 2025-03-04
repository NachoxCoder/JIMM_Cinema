using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace Mappers
{
    public class MapperFuncion
    {
        private readonly DAL.DAL_Xml _dalXml;
        private readonly MapperSala _mapperSala;

        public MapperFuncion()
        {
            _dalXml = new DAL.DAL_Xml();
        }


        public void Alta(BE_Funcion funcion)
        {
            var funciones = _dalXml.LeerXml<BE_Funcion>();
            funcion.ID = funciones.Any() ? funciones.Max(x => x.ID) + 1 : 1;
            funcion.Pelicula = funcion.Pelicula;
            funciones.Add(funcion);
            _dalXml.GuardarXml(funciones);
        }

        public void Baja(BE_Funcion funcion)
        {
            var funciones = _dalXml.LeerXml<BE_Funcion>();
            var funcionEncontrada = funciones.Find(x => x.ID == funcion.ID);
            if (funcionEncontrada != null)
            {
                funciones.Remove(funcionEncontrada);
                _dalXml.GuardarXml(funciones);
            }
        }

        public void Modificar(BE_Funcion funcion)
        {
            var funciones = _dalXml.LeerXml<BE_Funcion>();
            var funcionEncontrada = funciones.Find(x => x.ID == funcion.ID);
            if (funcionEncontrada != null)
            {
                funcionEncontrada.FechaFuncion = funcion.FechaFuncion;
                funcionEncontrada.HoraInicio = funcion.HoraInicio;
                funcionEncontrada.HoraFin = funcion.HoraFin;
                funcionEncontrada.Precio = funcion.Precio;
                funcionEncontrada.EstaActiva = funcion.EstaActiva;
                funcionEncontrada.Sala = funcion.Sala;
                _dalXml.GuardarXml(funciones);
            }
        }
        public List<BE_Funcion> Consultar()
        {
            return _dalXml.LeerXml<BE_Funcion>();
        }

        public bool ValidarDisponibilidadButaca(int idFuncion, string fila, int numero)
        {
            var boletos = _dalXml.LeerXml<BE_Boleto>();
            return !boletos.Any(x => x.Funcion.ID == idFuncion && x.Butacas.Any(b => b.Fila == fila && b.Numero == numero));
        }
    }
}
