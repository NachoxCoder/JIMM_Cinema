using System.Drawing;
using System.Windows.Forms;

namespace UI
{
    partial class Fr_GestionUsuarios
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
            pnlTop = new Panel();
            lblTitle = new Label();
            grpDatos = new GroupBox();
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            btnMostrarPassword = new Button();
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblApellido = new Label();
            txtApellido = new TextBox();
            lblArea = new Label();
            txtArea = new TextBox();
            dgvUsuarios = new DataGridView();
            btnGuardar = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnNuevoUsuario = new Button();
            pnlTop.SuspendLayout();
            grpDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.FromArgb(10, 18, 80);
            pnlTop.Controls.Add(lblTitle);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(1022, 60);
            pnlTop.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.Sienna;
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(1022, 60);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "GESTION DE USUARIOS";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // grpDatos
            // 
            grpDatos.Controls.Add(lblUsername);
            grpDatos.Controls.Add(txtUsername);
            grpDatos.Controls.Add(lblPassword);
            grpDatos.Controls.Add(txtPassword);
            grpDatos.Controls.Add(btnMostrarPassword);
            grpDatos.Controls.Add(lblNombre);
            grpDatos.Controls.Add(txtNombre);
            grpDatos.Controls.Add(lblApellido);
            grpDatos.Controls.Add(txtApellido);
            grpDatos.Controls.Add(lblArea);
            grpDatos.Controls.Add(txtArea);
            grpDatos.Location = new Point(12, 70);
            grpDatos.Name = "grpDatos";
            grpDatos.Size = new Size(417, 300);
            grpDatos.TabIndex = 1;
            grpDatos.TabStop = false;
            grpDatos.Text = "Datos del Usuario";
            // 
            // lblUsername
            // 
            lblUsername.Location = new Point(20, 30);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(100, 23);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Usuario:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(130, 30);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(250, 27);
            txtUsername.TabIndex = 1;
            // 
            // lblPassword
            // 
            lblPassword.Location = new Point(20, 70);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(100, 23);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Contraseña:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(130, 70);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(250, 27);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnMostrarPassword
            // 
            btnMostrarPassword.FlatStyle = FlatStyle.Flat;
            btnMostrarPassword.Location = new Point(385, 70);
            btnMostrarPassword.Name = "btnMostrarPassword";
            btnMostrarPassword.Size = new Size(30, 27);
            btnMostrarPassword.TabIndex = 4;
            btnMostrarPassword.Text = "👁";
            btnMostrarPassword.MouseDown += btnMostrarPassword_MouseDown;
            btnMostrarPassword.MouseUp += btnMostrarPassword_MouseUp;
            // 
            // lblNombre
            // 
            lblNombre.Location = new Point(20, 110);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(100, 23);
            lblNombre.TabIndex = 5;
            lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(130, 110);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(250, 27);
            txtNombre.TabIndex = 6;
            // 
            // lblApellido
            // 
            lblApellido.Location = new Point(20, 150);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(100, 23);
            lblApellido.TabIndex = 7;
            lblApellido.Text = "Apellido:";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(130, 150);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(250, 27);
            txtApellido.TabIndex = 8;
            // 
            // lblArea
            // 
            lblArea.Location = new Point(20, 190);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(100, 23);
            lblArea.TabIndex = 9;
            lblArea.Text = "Área:";
            // 
            // txtArea
            // 
            txtArea.Location = new Point(130, 190);
            txtArea.Name = "txtArea";
            txtArea.Size = new Size(250, 27);
            txtArea.TabIndex = 10;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.AllowUserToDeleteRows = false;
            dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsuarios.ColumnHeadersHeight = 29;
            dgvUsuarios.Location = new Point(450, 70);
            dgvUsuarios.MultiSelect = false;
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.RowHeadersWidth = 51;
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.Size = new Size(550, 350);
            dgvUsuarios.TabIndex = 2;
            dgvUsuarios.SelectionChanged += dgvUsuarios_SelectionChanged;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Sienna;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(111, 380);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(90, 40);
            btnGuardar.TabIndex = 3;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Red;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(329, 380);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(98, 40);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.Sienna;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnModificar.ForeColor = Color.White;
            btnModificar.Location = new Point(214, 380);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(98, 40);
            btnModificar.TabIndex = 5;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnNuevoUsuario
            // 
            btnNuevoUsuario.BackColor = Color.Sienna;
            btnNuevoUsuario.FlatStyle = FlatStyle.Flat;
            btnNuevoUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnNuevoUsuario.ForeColor = Color.White;
            btnNuevoUsuario.Location = new Point(12, 380);
            btnNuevoUsuario.Name = "btnNuevoUsuario";
            btnNuevoUsuario.Size = new Size(88, 40);
            btnNuevoUsuario.TabIndex = 6;
            btnNuevoUsuario.Text = "Nuevo";
            btnNuevoUsuario.UseVisualStyleBackColor = false;
            btnNuevoUsuario.Click += btnNuevoUsuario_Click;
            // 
            // Fr_GestionUsuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1022, 432);
            Controls.Add(btnNuevoUsuario);
            Controls.Add(pnlTop);
            Controls.Add(grpDatos);
            Controls.Add(dgvUsuarios);
            Controls.Add(btnGuardar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Fr_GestionUsuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de Usuarios";
            pnlTop.ResumeLayout(false);
            grpDatos.ResumeLayout(false);
            grpDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
        }

        private Panel pnlTop;
        private Label lblTitle;
        private GroupBox grpDatos;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtArea;
        private Label lblUsername;
        private Label lblPassword;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblArea;
        private Button btnMostrarPassword;
        private DataGridView dgvUsuarios;
        private Button btnGuardar;
        private Button btnEliminar;
        private Button btnModificar;

        #endregion

        private Button btnNuevoUsuario;
    }
}