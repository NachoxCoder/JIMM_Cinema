using System.Drawing;
using System.Windows.Forms;

namespace UI
{
    partial class Fr_GestionPermisos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlTrees = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnRemoverPermisoUsuario = new System.Windows.Forms.Button();
            this.btnAsignarPermisoUsuario = new System.Windows.Forms.Button();
            this.btnAsignarRolUsuario = new System.Windows.Forms.Button();
            this.btnRemoverRolUsuario = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAsignarPermiso = new System.Windows.Forms.Button();
            this.btnQuitarPermiso = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCrearRol = new System.Windows.Forms.Button();
            this.btnEliminarRol = new System.Windows.Forms.Button();
            this.txtNombreRol = new System.Windows.Forms.TextBox();
            this.grpUsuarios = new System.Windows.Forms.GroupBox();
            this.tvUsuarios = new System.Windows.Forms.TreeView();
            this.grpRoles = new System.Windows.Forms.GroupBox();
            this.tvRoles = new System.Windows.Forms.TreeView();
            this.grpPermisos = new System.Windows.Forms.GroupBox();
            this.tvPermisos = new System.Windows.Forms.TreeView();
            this.grpRolesPermisos = new System.Windows.Forms.GroupBox();
            this.tvRolesPermisos = new System.Windows.Forms.TreeView();
            this.grpUsuariosPermisos = new System.Windows.Forms.GroupBox();
            this.tvUsuariosPermisos = new System.Windows.Forms.TreeView();
            this.pnlTop.SuspendLayout();
            this.pnlTrees.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpUsuarios.SuspendLayout();
            this.grpRoles.SuspendLayout();
            this.grpPermisos.SuspendLayout();
            this.grpRolesPermisos.SuspendLayout();
            this.grpUsuariosPermisos.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(18)))), ((int)(((byte)(80)))));
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1200, 48);
            this.pnlTop.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Sienna;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1200, 48);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "GESTIÓN DE PERMISOS";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlTrees
            // 
            this.pnlTrees.Controls.Add(this.groupBox3);
            this.pnlTrees.Controls.Add(this.groupBox2);
            this.pnlTrees.Controls.Add(this.groupBox1);
            this.pnlTrees.Controls.Add(this.grpUsuarios);
            this.pnlTrees.Controls.Add(this.grpRoles);
            this.pnlTrees.Controls.Add(this.grpPermisos);
            this.pnlTrees.Controls.Add(this.grpRolesPermisos);
            this.pnlTrees.Controls.Add(this.grpUsuariosPermisos);
            this.pnlTrees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTrees.Location = new System.Drawing.Point(0, 0);
            this.pnlTrees.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlTrees.Name = "pnlTrees";
            this.pnlTrees.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.pnlTrees.Size = new System.Drawing.Size(1200, 560);
            this.pnlTrees.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnRemoverPermisoUsuario);
            this.groupBox3.Controls.Add(this.btnAsignarPermisoUsuario);
            this.groupBox3.Controls.Add(this.btnAsignarRolUsuario);
            this.groupBox3.Controls.Add(this.btnRemoverRolUsuario);
            this.groupBox3.Location = new System.Drawing.Point(10, 440);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(293, 89);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Usuario";
            // 
            // btnRemoverPermisoUsuario
            // 
            this.btnRemoverPermisoUsuario.Location = new System.Drawing.Point(147, 54);
            this.btnRemoverPermisoUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoverPermisoUsuario.Name = "btnRemoverPermisoUsuario";
            this.btnRemoverPermisoUsuario.Size = new System.Drawing.Size(140, 31);
            this.btnRemoverPermisoUsuario.TabIndex = 6;
            this.btnRemoverPermisoUsuario.Text = "Remover Permiso";
            this.btnRemoverPermisoUsuario.Click += new System.EventHandler(this.btnRemoverPermisoUsuario_Click);
            // 
            // btnAsignarPermisoUsuario
            // 
            this.btnAsignarPermisoUsuario.Location = new System.Drawing.Point(147, 22);
            this.btnAsignarPermisoUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAsignarPermisoUsuario.Name = "btnAsignarPermisoUsuario";
            this.btnAsignarPermisoUsuario.Size = new System.Drawing.Size(140, 28);
            this.btnAsignarPermisoUsuario.TabIndex = 5;
            this.btnAsignarPermisoUsuario.Text = "Asignar Permiso";
            this.btnAsignarPermisoUsuario.Click += new System.EventHandler(this.btnAsignarPermisoUsuario_Click);
            // 
            // btnAsignarRolUsuario
            // 
            this.btnAsignarRolUsuario.Location = new System.Drawing.Point(6, 22);
            this.btnAsignarRolUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAsignarRolUsuario.Name = "btnAsignarRolUsuario";
            this.btnAsignarRolUsuario.Size = new System.Drawing.Size(135, 28);
            this.btnAsignarRolUsuario.TabIndex = 3;
            this.btnAsignarRolUsuario.Text = "Asignar Rol";
            this.btnAsignarRolUsuario.Click += new System.EventHandler(this.btnAsignarRolUsuario_Click);
            // 
            // btnRemoverRolUsuario
            // 
            this.btnRemoverRolUsuario.Location = new System.Drawing.Point(6, 54);
            this.btnRemoverRolUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoverRolUsuario.Name = "btnRemoverRolUsuario";
            this.btnRemoverRolUsuario.Size = new System.Drawing.Size(135, 31);
            this.btnRemoverRolUsuario.TabIndex = 4;
            this.btnRemoverRolUsuario.Text = "Remover Rol";
            this.btnRemoverRolUsuario.Click += new System.EventHandler(this.btnRemoverRolUsuario_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAsignarPermiso);
            this.groupBox2.Controls.Add(this.btnQuitarPermiso);
            this.groupBox2.Location = new System.Drawing.Point(822, 440);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(336, 89);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Permiso";
            // 
            // btnAsignarPermiso
            // 
            this.btnAsignarPermiso.Location = new System.Drawing.Point(6, 22);
            this.btnAsignarPermiso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAsignarPermiso.Name = "btnAsignarPermiso";
            this.btnAsignarPermiso.Size = new System.Drawing.Size(183, 28);
            this.btnAsignarPermiso.TabIndex = 3;
            this.btnAsignarPermiso.Text = "Asignar Permiso a Rol";
            this.btnAsignarPermiso.Click += new System.EventHandler(this.btnAsignarPermiso_Click);
            // 
            // btnQuitarPermiso
            // 
            this.btnQuitarPermiso.Location = new System.Drawing.Point(6, 54);
            this.btnQuitarPermiso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQuitarPermiso.Name = "btnQuitarPermiso";
            this.btnQuitarPermiso.Size = new System.Drawing.Size(183, 31);
            this.btnQuitarPermiso.TabIndex = 4;
            this.btnQuitarPermiso.Text = "Remover Permiso a Rol";
            this.btnQuitarPermiso.Click += new System.EventHandler(this.btnQuitarPermiso_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCrearRol);
            this.groupBox1.Controls.Add(this.btnEliminarRol);
            this.groupBox1.Controls.Add(this.txtNombreRol);
            this.groupBox1.Location = new System.Drawing.Point(380, 440);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(366, 89);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rol";
            // 
            // btnCrearRol
            // 
            this.btnCrearRol.Location = new System.Drawing.Point(6, 21);
            this.btnCrearRol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCrearRol.Name = "btnCrearRol";
            this.btnCrearRol.Size = new System.Drawing.Size(100, 29);
            this.btnCrearRol.TabIndex = 1;
            this.btnCrearRol.Text = "Crear Rol";
            this.btnCrearRol.Click += new System.EventHandler(this.btnCrearRol_Click);
            // 
            // btnEliminarRol
            // 
            this.btnEliminarRol.Location = new System.Drawing.Point(6, 54);
            this.btnEliminarRol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarRol.Name = "btnEliminarRol";
            this.btnEliminarRol.Size = new System.Drawing.Size(100, 31);
            this.btnEliminarRol.TabIndex = 2;
            this.btnEliminarRol.Text = "Eliminar Rol";
            this.btnEliminarRol.Click += new System.EventHandler(this.btnEliminarRol_Click);
            // 
            // txtNombreRol
            // 
            this.txtNombreRol.Location = new System.Drawing.Point(112, 21);
            this.txtNombreRol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombreRol.Name = "txtNombreRol";
            this.txtNombreRol.Size = new System.Drawing.Size(248, 22);
            this.txtNombreRol.TabIndex = 0;
            this.txtNombreRol.Text = "Nombre del nuevo rol";
            // 
            // grpUsuarios
            // 
            this.grpUsuarios.Controls.Add(this.tvUsuarios);
            this.grpUsuarios.Location = new System.Drawing.Point(10, 53);
            this.grpUsuarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpUsuarios.Name = "grpUsuarios";
            this.grpUsuarios.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpUsuarios.Size = new System.Drawing.Size(220, 383);
            this.grpUsuarios.TabIndex = 0;
            this.grpUsuarios.TabStop = false;
            this.grpUsuarios.Text = "Usuarios";
            // 
            // tvUsuarios
            // 
            this.tvUsuarios.Location = new System.Drawing.Point(3, 21);
            this.tvUsuarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tvUsuarios.Name = "tvUsuarios";
            this.tvUsuarios.Size = new System.Drawing.Size(211, 347);
            this.tvUsuarios.TabIndex = 0;
            // 
            // grpRoles
            // 
            this.grpRoles.Controls.Add(this.tvRoles);
            this.grpRoles.Location = new System.Drawing.Point(251, 53);
            this.grpRoles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpRoles.Name = "grpRoles";
            this.grpRoles.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpRoles.Size = new System.Drawing.Size(220, 383);
            this.grpRoles.TabIndex = 1;
            this.grpRoles.TabStop = false;
            this.grpRoles.Text = "Roles";
            // 
            // tvRoles
            // 
            this.tvRoles.Location = new System.Drawing.Point(4, 21);
            this.tvRoles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tvRoles.Name = "tvRoles";
            this.tvRoles.Size = new System.Drawing.Size(211, 347);
            this.tvRoles.TabIndex = 1;
            // 
            // grpPermisos
            // 
            this.grpPermisos.Controls.Add(this.tvPermisos);
            this.grpPermisos.Location = new System.Drawing.Point(477, 53);
            this.grpPermisos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpPermisos.Name = "grpPermisos";
            this.grpPermisos.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpPermisos.Size = new System.Drawing.Size(220, 383);
            this.grpPermisos.TabIndex = 2;
            this.grpPermisos.TabStop = false;
            this.grpPermisos.Text = "Permisos";
            // 
            // tvPermisos
            // 
            this.tvPermisos.Location = new System.Drawing.Point(6, 19);
            this.tvPermisos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tvPermisos.Name = "tvPermisos";
            this.tvPermisos.Size = new System.Drawing.Size(211, 349);
            this.tvPermisos.TabIndex = 2;
            // 
            // grpRolesPermisos
            // 
            this.grpRolesPermisos.Controls.Add(this.tvRolesPermisos);
            this.grpRolesPermisos.Location = new System.Drawing.Point(703, 53);
            this.grpRolesPermisos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpRolesPermisos.Name = "grpRolesPermisos";
            this.grpRolesPermisos.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpRolesPermisos.Size = new System.Drawing.Size(220, 383);
            this.grpRolesPermisos.TabIndex = 3;
            this.grpRolesPermisos.TabStop = false;
            this.grpRolesPermisos.Text = "Roles y sus Permisos";
            // 
            // tvRolesPermisos
            // 
            this.tvRolesPermisos.Location = new System.Drawing.Point(0, 21);
            this.tvRolesPermisos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tvRolesPermisos.Name = "tvRolesPermisos";
            this.tvRolesPermisos.Size = new System.Drawing.Size(211, 347);
            this.tvRolesPermisos.TabIndex = 3;
            // 
            // grpUsuariosPermisos
            // 
            this.grpUsuariosPermisos.Controls.Add(this.tvUsuariosPermisos);
            this.grpUsuariosPermisos.Location = new System.Drawing.Point(929, 53);
            this.grpUsuariosPermisos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpUsuariosPermisos.Name = "grpUsuariosPermisos";
            this.grpUsuariosPermisos.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpUsuariosPermisos.Size = new System.Drawing.Size(229, 383);
            this.grpUsuariosPermisos.TabIndex = 4;
            this.grpUsuariosPermisos.TabStop = false;
            this.grpUsuariosPermisos.Text = "Usuarios y sus Roles y Permisos";
            // 
            // tvUsuariosPermisos
            // 
            this.tvUsuariosPermisos.Location = new System.Drawing.Point(0, 21);
            this.tvUsuariosPermisos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tvUsuariosPermisos.Name = "tvUsuariosPermisos";
            this.tvUsuariosPermisos.Size = new System.Drawing.Size(223, 347);
            this.tvUsuariosPermisos.TabIndex = 3;
            // 
            // Fr_GestionPermisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 560);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlTrees);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Fr_GestionPermisos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Permisos";
            this.pnlTop.ResumeLayout(false);
            this.pnlTrees.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpUsuarios.ResumeLayout(false);
            this.grpRoles.ResumeLayout(false);
            this.grpPermisos.ResumeLayout(false);
            this.grpRolesPermisos.ResumeLayout(false);
            this.grpUsuariosPermisos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private Panel pnlTop;
        private Label lblTitle;
        private Panel pnlTrees;
        private GroupBox grpUsuarios;
        private GroupBox grpRoles;
        private GroupBox grpPermisos;
        private GroupBox grpRolesPermisos;
        private GroupBox grpUsuariosPermisos;
        private TextBox txtNombreRol;
        private Button btnCrearRol;
        private Button btnEliminarRol;
        private Button btnAsignarPermiso;
        private Button btnQuitarPermiso;


        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button btnAsignarRolUsuario;
        private Button btnRemoverRolUsuario;
        private Button btnRemoverPermisoUsuario;
        private Button btnAsignarPermisoUsuario;
        private TreeView tvUsuarios;
        private TreeView tvRoles;
        private TreeView tvPermisos;
        private TreeView tvRolesPermisos;
        private TreeView tvUsuariosPermisos;
    }
}