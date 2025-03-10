using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mappers;
using BE;
using Servicio;


namespace BLL
{
    public class BLL_Usuario
    {
        private readonly MapperUsuario _mapperUsuario;

        public BLL_Usuario()
        {
            _mapperUsuario = new MapperUsuario();
        }

        public void Alta(BE_Usuario usuario)
        {
            _mapperUsuario.Alta(usuario);
        }

        public void Baja(BE_Usuario usuario)
        {
            _mapperUsuario.Baja(usuario);
        }

        public void Modificar(BE_Usuario usuario)
        {
            _mapperUsuario.Modificar(usuario);
        }

        public List<BE_Usuario> Consultar()
        {
            return _mapperUsuario.Consultar();
        }

        public BE_Usuario ConsultarPorID(int id)
        {
            return _mapperUsuario.ConsultarPorID(id);
        }

        public BE_Usuario ConsultarPorUsername(string nombreUsuario)
        {
            return _mapperUsuario.ConsultarPorUsername(nombreUsuario);
        }

        public bool ValidarCredenciales(string username, string password)
        {
            if(string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                return false;
            }

            var usuario = ConsultarPorUsername(username);
            if(usuario != null)
            {
                string passwordDesencriptado = Encriptacion.DesencriptarPassword(usuario.Password);
                return passwordDesencriptado == password;
            }
            return false;
        }
    }
}
