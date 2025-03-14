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

            if (usuarios.Any(p => string.Equals(p.Username, usuario.Username, StringComparison.OrdinalIgnoreCase)))
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
            var usuarioEncontrado = usuarios.FirstOrDefault(x => x.ID == usuario.ID);

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
            var empleadoExistente = usuarios.FirstOrDefault(e => e.ID == usuario.ID);

            if (empleadoExistente == null)
            {
                throw new Exception("No se encontro el usuario");
            }

            var usuarioExistente = usuarios.FirstOrDefault(e =>
                    string.Equals(e.Username, usuario.Username, StringComparison.OrdinalIgnoreCase) && e.ID != usuario.ID);
            if (usuarioExistente != null)
            {
                throw new Exception("Ya existe un usuario con ese Username");
            }

            empleadoExistente.Username = usuario.Username;
            empleadoExistente.Nombre = usuario.Nombre;
            empleadoExistente.Apellido = usuario.Apellido;
            empleadoExistente.Area = usuario.Area;
            empleadoExistente.Password = usuario.Password;

            if(usuario.listaPermisos != null)
            {
                empleadoExistente.listaPermisos = usuario.listaPermisos;
            }

            _dalXml.GuardarXml(usuarios);
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
            if (string.IsNullOrWhiteSpace(username))
                return null;

            return Consultar().FirstOrDefault(x =>
                string.Equals(x.Username, username, StringComparison.OrdinalIgnoreCase));
        }
    }
}
