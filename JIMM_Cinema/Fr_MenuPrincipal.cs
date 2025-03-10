using BE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using UI;
using JIMM_Cinema;

namespace Gestion_Cine
{
    public partial class Fr_MenuPrincipal : Form
    {
        private BE_Usuario usuarioActual;
        private readonly BLL_Permiso gestorPermiso;
        private Form frLogin;
        public Fr_MenuPrincipal(BE_Usuario usuario, Form FrLogin)
        {
            InitializeComponent();
            usuarioActual = usuario;
            gestorPermiso = new BLL_Permiso();
            this.Load += Fr_MenuPrincipal_Load;
            frLogin = FrLogin;
        }

        private void Fr_MenuPrincipal_Load(object sender, EventArgs e)
        {
            CargarMenuSegunPermisos();
            Text = $"Bienvenido {usuarioActual.Nombre} {usuarioActual.Apellido}";
        }

        private void CargarMenuSegunPermisos()
        {
            //Cargar los permisos del usuario
            /*
            usuarioActual.listaPermisos = gestorPermiso.ListarPermisosUsuario(usuarioActual);

            //Configurar el Menu de acuerdo a los permisos que posee el usuario logeado
            foreach (ToolStripMenuItem menuItem in menuStrip.Items)
            {
                bool tienePermiso = false;
                foreach (ToolStripMenuItem subItem in menuItem.DropDownItems)
                {
                    if (usuarioActual.TienePermiso(subItem.Tag?.ToString()))
                    {
                        subItem.Visible = true;
                        tienePermiso = true;
                    }
                    else
                    {
                        subItem.Visible = false;
                    }
                }
                menuItem.Visible = tienePermiso || menuItem.Text == "Archivo";
            }*/
        }

        private void CargarForm(Form form)
        {
            form.MdiParent = this;
            form.Show();
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            frLogin.Show();
        }

        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gestorClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new Fr_GestionCliente();
            CargarForm(form);
        }

        private void membresiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new Fr_GestionMembresia();
            CargarForm(form);
        }

        private void boletosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new Fr_VentaBoletos();
            CargarForm(form);
        }

        private void gestionDePeliculasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new Fr_GestionPeliculas();
            CargarForm(form);
        }

        private void gestionDeSalasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new Fr_GestionSalas();
            CargarForm(form);
        }

        private void gestionDeInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new Fr_GestionInventario();
            CargarForm(form);
        }

        private void generarOrdenDeCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new Fr_GenerarOrdenCompra();
            CargarForm(form);
        }

        private void gestionDeFacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new Fr_GestionFacturas();
            CargarForm(form);
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new Fr_Dashboard();
            CargarForm(form);
        }

        private void gestionDeEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new Fr_GestionUsuarios(usuarioActual);
            CargarForm(form);
        }

        private void gestionDePermisosYRolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new Fr_GestionPermisos(usuarioActual);
            CargarForm(form);
        }

        private void gestionDeBackupsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new Fr_GestionBackupRestore(usuarioActual);
            CargarForm(form);
        }

    }
}
