using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;

namespace Mappers
{
    public class MapperPermiso
    {
        private readonly DAL_Xml _dalXml;

        public MapperPermiso()
        {
            _dalXml = new DAL_Xml();
        }

        public List<BE_Componente> ObtenerPermisos()
        {
            var permisos = _dalXml.LeerXml<BE_Permiso>();
            return permisos.Cast<BE_Componente>().ToList();
        }

        public List<BE_Componente> ObtenerRoles()
        {
            var roles = _dalXml.LeerXml<BE_Rol>();
            return roles.Cast<BE_Componente>().ToList();
        }

        public void Guardar(BE_Componente componente)
        {
            if (componente is BE_Rol rol)
            {
                var roles = _dalXml.LeerXml<BE_Rol>();
                if (roles.Any(x => x.Nombre == rol.Nombre && x.ID != rol.ID))
                {
                    throw new Exception("Ya existe un rol con ese nombre");
                }

                if (rol.ID == 0)
                {
                    rol.ID = roles.Any() ? roles.Max(x => x.ID) + 1 : 1;
                    roles.Add(rol);
                }
                else
                {
                    var rolExistente = roles.FirstOrDefault(x => x.ID == rol.ID);
                    if (rolExistente != null)
                    {
                        roles.Remove(rolExistente);
                        roles.Add(rol);
                    }
                    else
                    {
                        rol.ID = roles.Any() ? roles.Max(x => x.ID) + 1 : 1;
                        roles.Add(rol);
                    }
                }
                _dalXml.GuardarXml(roles);
            }
            else if (componente is BE_Permiso permiso)
            {
                var permisos = _dalXml.LeerXml<BE_Permiso>();
                if (permisos.Any(x => x.Nombre == permiso.Nombre && x.ID != permiso.ID))
                {
                    throw new Exception("Ya existe un permiso con ese nombre");
                }

                if (permiso.ID == 0)
                {
                    permiso.ID = permisos.Any() ? permisos.Max(x => x.ID) + 1 : 1;
                    permisos.Add(permiso);
                }
                else
                {
                    var permisoExistente = permisos.FirstOrDefault(x => x.ID == permiso.ID);
                    if (permisoExistente != null)
                    {
                        permisos.Remove(permisoExistente);
                        permisos.Add(permiso);
                    }
                    else
                    {
                        permiso.ID = permisos.Any() ? permisos.Max(x => x.ID) + 1 : 1;
                        permisos.Add(permiso);
                    }
                }
                _dalXml.GuardarXml(permisos);
            }
        }

        public void Eliminar(BE_Componente componente)
        {
            if (componente is BE_Rol rol)
            {
                var roles = _dalXml.LeerXml<BE_Rol>();
                var rolARemover = roles.FirstOrDefault(x => x.ID == rol.ID);
                if (rolARemover != null)
                {
                    roles.Remove(rolARemover);
                    _dalXml.GuardarXml(roles);
                }
            }
            else if (componente is BE_Permiso permiso)
            {
                var permisos = _dalXml.LeerXml<BE_Permiso>();
                var permisoARemover = permisos.FirstOrDefault(x => x.ID == permiso.ID);
                if (permisoARemover != null)
                {
                    permisos.Remove(permisoARemover);
                    _dalXml.GuardarXml(permisos);
                }

                var roles = _dalXml.LeerXml<BE_Rol>();
                foreach (var r in roles)
                {
                    var permisoEnRol = r.ObtenerHijos().FirstOrDefault(x => x.ID == permiso.ID);
                    if (permisoEnRol != null)
                    {
                        r.RemoverHijo(permisoEnRol);
                    }
                }
                _dalXml.GuardarXml(roles);
            }
        }

        public void Modificar(BE_Componente componente)
        {
            if (componente is BE_Rol rol)
            {
                var roles = _dalXml.LeerXml<BE_Rol>();
                var rolExistente = roles.FirstOrDefault(x => x.ID == rol.ID);
                if (rolExistente != null)
                {
                    roles.Remove(rolExistente);
                    roles.Add(rol);
                    _dalXml.GuardarXml(roles);
                }
            }
            else if (componente is BE_Permiso permiso)
            {
                var permisos = _dalXml.LeerXml<BE_Permiso>();
                var permisoExistente = permisos.FirstOrDefault(x => x.ID == permiso.ID);
                if (permisoExistente != null)
                {
                    permisos.Remove(permisoExistente);
                    permisos.Add(permiso);
                    _dalXml.GuardarXml(permisos);
                }
            }
        }

        public List<BE_Componente> ObtenerPermisosUsuario(BE_Usuario usuario)
        {
            var usuarioMapper = new MapperUsuario();
            var usuarioAux = usuarioMapper.Consultar().FirstOrDefault(x => x.ID == usuario.ID);

            if(usuarioAux == null)
            {
                return new List<BE_Componente>();
            }

            var componentes = usuarioAux.listaPermisos.Select(x => x.ID).ToList();

            var roles = _dalXml.LeerXml<BE_Rol>();
            var permisos = _dalXml.LeerXml<BE_Permiso>();

            var rolesAsignados = roles.Where(x => componentes.Contains(x.ID)).Cast<BE_Componente>().ToList();
            var permisosAsignados = permisos.Where(x => componentes.Contains(x.ID)).Cast<BE_Componente>().ToList();

            return rolesAsignados.Concat(permisosAsignados).ToList();
        }
    }
}
