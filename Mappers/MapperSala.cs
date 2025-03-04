using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BE;

namespace Mappers
{
    public class MapperSala
    {
        private readonly DAL_Xml _dalXml;

        public MapperSala()
        {
            _dalXml = new DAL_Xml();
        }

        public List<BE_Sala> Consultar()
        {
            return _dalXml.LeerXml<BE_Sala>();
        }

        public void Alta(BE_Sala sala)
        {
            try
            {
                var salas = _dalXml.LeerXml<BE_Sala>();
                if (salas.Any(s => s.Nombre == sala.Nombre))
                {
                    throw new Exception("Ya existe una sala con ese nombre");
                }
                sala.ID = salas.Any() ? salas.Max(x => x.ID) + 1 : 1;
                salas.Add(sala);
                _dalXml.GuardarXml(salas);
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        public void Baja(BE_Sala sala)
        {
            var salas = _dalXml.LeerXml<BE_Sala>();
            var salaEncontrada = salas.Find(x => x.ID == sala.ID);
            if (salaEncontrada != null)
            {
                salas.Remove(salaEncontrada);
                _dalXml.GuardarXml(salas);
            }
        }

        public void Modificar(BE_Sala sala)
        {
            var salas = _dalXml.LeerXml<BE_Sala>();
            var salaExistente = salas.Find(x => x.ID == sala.ID);
            if (salaExistente != null)
            {
                salaExistente.Nombre = sala.Nombre;
                salaExistente.Capacidad = sala.Capacidad;
                salaExistente.Tiene3D = sala.Tiene3D;
                _dalXml.GuardarXml(salas);
            }
        }

        public void ModificarButaca(BE_Butaca butaca)
        {
            var salas = _dalXml.LeerXml<BE_Sala>();
            var sala = salas.FirstOrDefault(x => x.Butacas.Any(b => b.ID == butaca.ID));

            if(sala != null)
            {
                var butacaExistente = sala.Butacas.First(b => b.ID == butaca.ID);
                butacaExistente.Disponible = butaca.Disponible;
                _dalXml.GuardarXml(salas);
            }
        }

        public BE_Sala ObtenerPorNombre(string nombre)
        {
            return Consultar().FirstOrDefault(x => x.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase));
        }
    }
}
