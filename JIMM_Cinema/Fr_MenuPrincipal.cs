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
            usuarioActual.listaPermisos = gestorPermiso.ListarPermisosUsuario(usuarioActual);

            ConfigurarMenu();

            foreach(ToolStripMenuItem menuItem in menuStrip.Items)
            {
                bool tienePermiso = false;
                foreach(ToolStripItem item in menuItem.DropDownItems)
                {
                    if (item is ToolStripMenuItem subItem)
                    {
                        string permisoRequerido = subItem.Tag?.ToString();
                        if(string.IsNullOrEmpty(permisoRequerido) || usuarioActual.TienePermiso(permisoRequerido))
                        {
                            subItem.Visible = true;
                            tienePermiso = true;
                        }
                        else
                        {
                            subItem.Visible = false;
                        }
                    }
                }

                menuItem.Visible = tienePermiso || menuItem.Text == "Archivo";
            }
        }

        private void ConfigurarMenu()
        {
            boletosToolStripMenuItem.Tag = "VentaBoletos";
            membresiasToolStripMenuItem.Tag = "GestorMembresias";
            gestorClientesToolStripMenuItem.Tag = "GestionClientes";

            // Compras menu
            gestionDeInventarioToolStripMenuItem.Tag = "GestionIvnentario";
            generarOrdenDeCompraToolStripMenuItem.Tag = "GestionOrdenCompras";
            gestionDeFacturasToolStripMenuItem.Tag = "GestionFactuas";

            // Administracion menu
            gestionDePeliculasToolStripMenuItem.Tag = "GestionPeliculas";
            gestionDeSalasToolStripMenuItem.Tag = "GestionSalas";
            dashboardToolStripMenuItem.Tag = "GestionDashboard";

            // Sistema menu
            gestionDeUsuariosToolStripMenuItem.Tag = "GestionUsuarios";
            gestionDePermisosYRolesToolStripMenuItem.Tag = "GestionPermisos";
            gestionDeBackupsToolStripMenuItem.Tag = "GestionBitacora";

            // Archivo menu
            cerrarSesionToolStripMenuItem.Tag = string.Empty;
            salirSistemaToolStripMenuItem.Tag = string.Empty;
        }

        private void CargarForm(Form form)
        {
            form.MdiParent = this;
            form.Show();
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

        private void gestionDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                Fr_Login form = new Fr_Login();
                form.Show();
                form.FormClosing += loginCerrar;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void salirSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginCerrar(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
