using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mappers;
using BE;

namespace BLL
{
    public class BLL_Permiso
    {
        private readonly MapperPermiso _mapperPermiso;
        private readonly MapperUsuario _mapperUsuario;

        public BLL_Permiso()
        {
            _mapperPermiso = new MapperPermiso();
            _mapperUsuario = new MapperUsuario();
        }

        public List<BE_Componente> ListarRoles()
        {
            return _mapperPermiso.ObtenerRoles();
        }

        public List<BE_Componente> ListarPermisos()
        {
            return _mapperPermiso.ObtenerPermisos().Where(x => !x.EsRol).ToList();
        }

        public List<BE_Componente> ListarPermisosUsuario(BE_Usuario usuario)
        {
            return _mapperPermiso.ObtenerPermisosUsuario(usuario);
        }

        public bool Guardar(BE_Componente componente)
        {
            _mapperPermiso.Guardar(componente);
            return true;
        }

        public bool Eliminar(BE_Componente componente)
        {
            var usuariosConElRol = _mapperUsuario.Consultar().Where(x => x.listaPermisos.Any(y => y.ID == componente.ID)).ToList();
            foreach (var usuario in usuariosConElRol)
            {
                BorrarPermisoUsuario(usuario, componente);
            }
            _mapperPermiso.Eliminar(componente);
            return true;
        }

        public bool AsignarPermisoARol(BE_Rol rol, BE_Permiso permiso)
        {
            rol.AgregarHijo(permiso);
            _mapperPermiso.Modificar(rol);
            return true;
        }

        public bool EliminarPermisoDeRol(BE_Rol rol, BE_Permiso permiso)
        {
            rol.RemoverHijo(permiso);
            _mapperPermiso.Modificar(rol);
            return true;
        }

        public bool AsignarRolAUsuario(BE_Usuario usuario, BE_Rol rol)
        {
            if (usuario.listaPermisos.Any(p => p.ID == rol.ID))
            {
                return false;
            }
            usuario.listaPermisos.Add(rol);
            _mapperUsuario.Modificar(usuario);
            return true;
        }

        public bool RemoverRolDeUsuario(BE_Usuario usuario, BE_Rol rol)
        {
            var rolARemover = usuario.listaPermisos.FirstOrDefault(p => p.ID == rol.ID);
            if (rolARemover != null)
            {
                usuario.listaPermisos.Remove(rolARemover);
                _mapperUsuario.Modificar(usuario);
                return true;
            }
            return false;
        }

        public bool AsignarPermisoUsuario(BE_Usuario usuario, BE_Permiso permiso)
        {
            if (usuario.listaPermisos.Any(p => p.ID == permiso.ID))
            {
                return false;
            }
            usuario.listaPermisos.Add(permiso);
            _mapperUsuario.Modificar(usuario);
            return true;
        }

        public bool BorrarPermisoUsuario(BE_Usuario usuario, BE_Componente permiso)
        {
            var permisoARemover = usuario.listaPermisos.FirstOrDefault(p => p.ID == permiso.ID);
            if (permisoARemover != null)
            {
                usuario.listaPermisos.Remove(permisoARemover);
                _mapperUsuario.Modificar(usuario);
                return true;
            }
            return false;
        }
    }
}
