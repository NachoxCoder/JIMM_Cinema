using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;

namespace Mappers
{
    public class MapperUsuario
    {
        private readonly DAL_Xml _dalXml;

        public MapperUsuario()
        {
            _dalXml = new DAL_Xml();
        }

        public void Alta(BE_Usuario usuario)
        {
            List<BE_Usuario> usuarios = _dalXml.LeerXml<BE_Usuario>();
            if (usuarios.Any(p => p.Username == usuario.Username))
            {
                throw new Exception("Ya existe un usuario con ese Username");
            }
            usuario.ID = usuarios.Any() ? usuarios.Max(x => x.ID) + 1 : 1;
            usuarios.Add(usuario);
            _dalXml.GuardarXml(usuarios);
        }

        public void Baja(BE_Usuario usuario)
        {
            List<BE_Usuario> usuarios = _dalXml.LeerXml<BE_Usuario>();
            var usuarioEncontrado = usuarios.Find(x => x.ID == usuario.ID);
            if (usuarioEncontrado != null)
            {
                usuarios.Remove(usuarioEncontrado);
                _dalXml.GuardarXml(usuarios);
            }
            else
            {
                throw new Exception("No se encontro el usuario");
            }
        }

        public void Modificar(BE_Usuario usuario)
        {
            List<BE_Usuario> usuarios = _dalXml.LeerXml<BE_Usuario>();
            var empleadoExistente = usuarios.Find(x => x.ID == usuario.ID);

            if (empleadoExistente != null)
            {
                var usuarioExistente = usuarios.FirstOrDefault(e =>
                    e.Username == usuario.Username && e.ID != usuario.ID);

                if (usuarioExistente != null)
                {
                    throw new Exception("Ya existe un empleado con ese nombre de usuario");
                }

                empleadoExistente.Username = usuario.Username;
                empleadoExistente.Password = usuario.Password;
                empleadoExistente.Nombre = usuario.Nombre;
                empleadoExistente.Apellido = usuario.Apellido;
                empleadoExistente.Area = usuario.Area;

                _dalXml.GuardarXml(usuarios);
            }
            else
            {
                throw new Exception("No se encontro el usuario");
            }
        }

        public List<BE_Usuario> Consultar()
        {
            return _dalXml.LeerXml<BE_Usuario>();
        }

        public BE_Usuario ConsultarPorID(int id)
        {
            return Consultar().FirstOrDefault(x => x.ID == id);
        }

        public BE_Usuario ConsultarPorUsername(string username)
        {
            return Consultar().FirstOrDefault(x => x.Username == username);
        }
    }
}
