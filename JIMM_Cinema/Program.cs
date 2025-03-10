using Gestion_Cine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI;
using BLL;
using BE;
using Servicio;

namespace JIMM_Cinema
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            List<Enum_Permisos> listaPermisos =
                Enum.GetValues(typeof(Enum_Permisos)).Cast<Enum_Permisos>().ToList();

            BLL_Permiso gestorPermiso = new BLL_Permiso();

            List<BE_Componente> permisos = gestorPermiso.ListarPermisos();

            foreach (var permiso in listaPermisos)
            {
                BE_Permiso permisoNuevo = new BE_Permiso(permiso.ToString());
                permisos.Add(permisoNuevo);
            }

            BE_Usuario usuarioAdmin = new BE_Usuario();
            usuarioAdmin.Username = "admin";
            usuarioAdmin.Password = Encriptacion.EncriptarPassword("admin");
            usuarioAdmin.listaPermisos.AddRange(permisos);

            BLL_Usuario gestorUsuario = new BLL_Usuario();
            
            if (gestorUsuario.ConsultarPorUsername(usuarioAdmin.Username) == null)
            {
                gestorUsuario.Alta(usuarioAdmin);
            }

            Application.Run(new Fr_Login());
        }
    }
}
