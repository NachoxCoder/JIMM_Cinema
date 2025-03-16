using System.Drawing;
using System.Windows.Forms;

namespace Gestion_Cine
{
    partial class Fr_MenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peliculasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bitacoraToolStripMenuItem;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boletosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.membresiasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestorClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeInventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarOrdenDeCompraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeFacturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDePeliculasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeSalasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDePermisosYRolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeBackupsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.AutoToolTip = true;
            this.archivoToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesionToolStripMenuItem,
            this.salirSistemaToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar Sesion";
            this.cerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem_Click);
            // 
            // salirSistemaToolStripMenuItem
            // 
            this.salirSistemaToolStripMenuItem.Name = "salirSistemaToolStripMenuItem";
            this.salirSistemaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.salirSistemaToolStripMenuItem.Text = "Salir Sistema";
            this.salirSistemaToolStripMenuItem.Click += new System.EventHandler(this.salirSistemaToolStripMenuItem_Click);
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.boletosToolStripMenuItem,
            this.membresiasToolStripMenuItem,
            this.gestorClientesToolStripMenuItem});
            this.ventasToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Sienna;
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.ventasToolStripMenuItem.Text = "Ventas";
            // 
            // boletosToolStripMenuItem
            // 
            this.boletosToolStripMenuItem.Name = "boletosToolStripMenuItem";
            this.boletosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.boletosToolStripMenuItem.Text = "Boletos";
            this.boletosToolStripMenuItem.Click += new System.EventHandler(this.boletosToolStripMenuItem_Click);
            // 
            // membresiasToolStripMenuItem
            // 
            this.membresiasToolStripMenuItem.Name = "membresiasToolStripMenuItem";
            this.membresiasToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.membresiasToolStripMenuItem.Text = "Membresias";
            this.membresiasToolStripMenuItem.Click += new System.EventHandler(this.membresiasToolStripMenuItem_Click);
            // 
            // gestorClientesToolStripMenuItem
            // 
            this.gestorClientesToolStripMenuItem.Name = "gestorClientesToolStripMenuItem";
            this.gestorClientesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.gestorClientesToolStripMenuItem.Text = "Gestor Clientes";
            this.gestorClientesToolStripMenuItem.Click += new System.EventHandler(this.gestorClientesToolStripMenuItem_Click);
            // 
            // comprasToolStripMenuItem
            // 
            this.comprasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDeInventarioToolStripMenuItem,
            this.generarOrdenDeCompraToolStripMenuItem,
            this.gestionDeFacturasToolStripMenuItem});
            this.comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            this.comprasToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.comprasToolStripMenuItem.Text = "Compras";
            // 
            // gestionDeInventarioToolStripMenuItem
            // 
            this.gestionDeInventarioToolStripMenuItem.Name = "gestionDeInventarioToolStripMenuItem";
            this.gestionDeInventarioToolStripMenuItem.Size = new System.Drawing.Size(267, 26);
            this.gestionDeInventarioToolStripMenuItem.Text = "Gestion de Inventario";
            this.gestionDeInventarioToolStripMenuItem.Click += new System.EventHandler(this.gestionDeInventarioToolStripMenuItem_Click);
            // 
            // generarOrdenDeCompraToolStripMenuItem
            // 
            this.generarOrdenDeCompraToolStripMenuItem.Name = "generarOrdenDeCompraToolStripMenuItem";
            this.generarOrdenDeCompraToolStripMenuItem.Size = new System.Drawing.Size(267, 26);
            this.generarOrdenDeCompraToolStripMenuItem.Text = "Generar Orden de Compra";
            this.generarOrdenDeCompraToolStripMenuItem.Click += new System.EventHandler(this.generarOrdenDeCompraToolStripMenuItem_Click);
            // 
            // gestionDeFacturasToolStripMenuItem
            // 
            this.gestionDeFacturasToolStripMenuItem.Name = "gestionDeFacturasToolStripMenuItem";
            this.gestionDeFacturasToolStripMenuItem.Size = new System.Drawing.Size(267, 26);
            this.gestionDeFacturasToolStripMenuItem.Text = "Gestion de Facturas";
            this.gestionDeFacturasToolStripMenuItem.Click += new System.EventHandler(this.gestionDeFacturasToolStripMenuItem_Click);
            // 
            // administracionToolStripMenuItem
            // 
            this.administracionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDePeliculasToolStripMenuItem,
            this.gestionDeSalasToolStripMenuItem,
            this.dashboardToolStripMenuItem});
            this.administracionToolStripMenuItem.Name = "administracionToolStripMenuItem";
            this.administracionToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
            this.administracionToolStripMenuItem.Text = "Administración Cine";
            // 
            // gestionDePeliculasToolStripMenuItem
            // 
            this.gestionDePeliculasToolStripMenuItem.Name = "gestionDePeliculasToolStripMenuItem";
            this.gestionDePeliculasToolStripMenuItem.Size = new System.Drawing.Size(303, 26);
            this.gestionDePeliculasToolStripMenuItem.Text = "Gestion de Peliculas y Funciones";
            this.gestionDePeliculasToolStripMenuItem.Click += new System.EventHandler(this.gestionDePeliculasToolStripMenuItem_Click);
            // 
            // gestionDeSalasToolStripMenuItem
            // 
            this.gestionDeSalasToolStripMenuItem.Name = "gestionDeSalasToolStripMenuItem";
            this.gestionDeSalasToolStripMenuItem.Size = new System.Drawing.Size(303, 26);
            this.gestionDeSalasToolStripMenuItem.Text = "Gestion de Salas";
            this.gestionDeSalasToolStripMenuItem.Click += new System.EventHandler(this.gestionDeSalasToolStripMenuItem_Click);
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(303, 26);
            this.dashboardToolStripMenuItem.Text = "Dashboard";
            this.dashboardToolStripMenuItem.Click += new System.EventHandler(this.dashboardToolStripMenuItem_Click);
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDeUsuariosToolStripMenuItem,
            this.gestionDePermisosYRolesToolStripMenuItem,
            this.gestionDeBackupsToolStripMenuItem});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // gestionDeUsuariosToolStripMenuItem
            // 
            this.gestionDeUsuariosToolStripMenuItem.Name = "gestionDeUsuariosToolStripMenuItem";
            this.gestionDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(276, 26);
            this.gestionDeUsuariosToolStripMenuItem.Text = "Gestion de Usuarios";
            this.gestionDeUsuariosToolStripMenuItem.Click += new System.EventHandler(this.gestionDeUsuariosToolStripMenuItem_Click);
            // 
            // gestionDePermisosYRolesToolStripMenuItem
            // 
            this.gestionDePermisosYRolesToolStripMenuItem.Name = "gestionDePermisosYRolesToolStripMenuItem";
            this.gestionDePermisosYRolesToolStripMenuItem.Size = new System.Drawing.Size(276, 26);
            this.gestionDePermisosYRolesToolStripMenuItem.Text = "Gestion de Permisos y Roles";
            this.gestionDePermisosYRolesToolStripMenuItem.Click += new System.EventHandler(this.gestionDePermisosYRolesToolStripMenuItem_Click);
            // 
            // gestionDeBackupsToolStripMenuItem
            // 
            this.gestionDeBackupsToolStripMenuItem.Name = "gestionDeBackupsToolStripMenuItem";
            this.gestionDeBackupsToolStripMenuItem.Size = new System.Drawing.Size(276, 26);
            this.gestionDeBackupsToolStripMenuItem.Text = "Gestion de Backups";
            this.gestionDeBackupsToolStripMenuItem.Click += new System.EventHandler(this.gestionDeBackupsToolStripMenuItem_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.Sienna;
            this.menuStrip.ForeColor = System.Drawing.Color.White;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.ventasToolStripMenuItem,
            this.comprasToolStripMenuItem,
            this.administracionToolStripMenuItem,
            this.sistemaToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 28);
            this.menuStrip.TabIndex = 1;
            // 
            // Fr_MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Fr_MenuPrincipal";
            this.Text = "Fr_MenuPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private ToolStripMenuItem salirSistemaToolStripMenuItem;
        private ToolStripMenuItem ventasToolStripMenuItem;
        private ToolStripMenuItem boletosToolStripMenuItem;
        private ToolStripMenuItem membresiasToolStripMenuItem;
        private ToolStripMenuItem gestorClientesToolStripMenuItem;
        private ToolStripMenuItem comprasToolStripMenuItem;
        private ToolStripMenuItem gestionDeInventarioToolStripMenuItem;
        private ToolStripMenuItem generarOrdenDeCompraToolStripMenuItem;
        private ToolStripMenuItem gestionDeFacturasToolStripMenuItem;
        private ToolStripMenuItem administracionToolStripMenuItem;
        private ToolStripMenuItem gestionDePeliculasToolStripMenuItem;
        private ToolStripMenuItem gestionDeSalasToolStripMenuItem;
        private ToolStripMenuItem dashboardToolStripMenuItem;
        private ToolStripMenuItem sistemaToolStripMenuItem;
        private ToolStripMenuItem gestionDeUsuariosToolStripMenuItem;
        private ToolStripMenuItem gestionDePermisosYRolesToolStripMenuItem;
        private ToolStripMenuItem gestionDeBackupsToolStripMenuItem;
        private MenuStrip menuStrip;
    }
}