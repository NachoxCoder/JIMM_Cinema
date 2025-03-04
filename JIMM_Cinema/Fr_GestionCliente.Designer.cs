using System.Drawing;
using System.Windows.Forms;

namespace Gestion_Cine
{
    partial class Fr_GestionCliente
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
            btnGuardar = new Button();
            btnEliminar = new Button();
            groupBox1 = new GroupBox();
            dtpFechaNacimiento = new DateTimePicker();
            txtDireccion = new TextBox();
            txtTelefono = new TextBox();
            txtEmail = new TextBox();
            txtDNI = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            label8 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnModificar = new Button();
            dgvClientes = new DataGridView();
            btnNuevoCliente = new Button();
            pnlTop.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.FromArgb(10, 18, 80);
            pnlTop.Controls.Add(lblTitle);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(1139, 60);
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
            lblTitle.Size = new Size(1139, 60);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "GESTION DE CLIENTES";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(10, 18, 80);
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(115, 437);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 40);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click_1;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Red;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(318, 437);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 40);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click_1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtpFechaNacimiento);
            groupBox1.Controls.Add(txtDireccion);
            groupBox1.Controls.Add(txtTelefono);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtDNI);
            groupBox1.Controls.Add(txtApellido);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 70);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(400, 361);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos Cliente";
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Format = DateTimePickerFormat.Short;
            dtpFechaNacimiento.Location = new Point(103, 304);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(282, 27);
            dtpFechaNacimiento.TabIndex = 13;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(103, 248);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(282, 27);
            txtDireccion.TabIndex = 12;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(103, 206);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(282, 27);
            txtTelefono.TabIndex = 9;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(103, 164);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(282, 27);
            txtEmail.TabIndex = 11;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(103, 123);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(282, 27);
            txtDNI.TabIndex = 10;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(103, 78);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(282, 27);
            txtApellido.TabIndex = 9;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(103, 33);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(282, 27);
            txtNombre.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 309);
            label8.Name = "label8";
            label8.Size = new Size(80, 20);
            label8.TabIndex = 7;
            label8.Text = "Fecha Nac.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 255);
            label6.Name = "label6";
            label6.Size = new Size(72, 20);
            label6.TabIndex = 5;
            label6.Text = "Direccion";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 213);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 4;
            label5.Text = "Telefono";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(4, 171);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 3;
            label4.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 130);
            label3.Name = "label3";
            label3.Size = new Size(35, 20);
            label3.TabIndex = 2;
            label3.Text = "DNI";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(4, 81);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 1;
            label2.Text = "Apellido";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 40);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.FromArgb(10, 18, 80);
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.ForeColor = Color.White;
            btnModificar.Location = new Point(215, 437);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(97, 40);
            btnModificar.TabIndex = 6;
            btnModificar.Text = "MODIFICAR";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(418, 70);
            dgvClientes.MultiSelect = false;
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.Size = new Size(709, 407);
            dgvClientes.TabIndex = 7;
            dgvClientes.SelectionChanged += dgvClientes_SelectionChanged_1;
            // 
            // btnNuevoCliente
            // 
            btnNuevoCliente.BackColor = Color.FromArgb(10, 18, 80);
            btnNuevoCliente.FlatStyle = FlatStyle.Flat;
            btnNuevoCliente.ForeColor = Color.White;
            btnNuevoCliente.Location = new Point(12, 437);
            btnNuevoCliente.Name = "btnNuevoCliente";
            btnNuevoCliente.Size = new Size(94, 40);
            btnNuevoCliente.TabIndex = 8;
            btnNuevoCliente.Text = "NUEVO";
            btnNuevoCliente.UseVisualStyleBackColor = false;
            btnNuevoCliente.Click += btnNuevoCliente_Click;
            // 
            // Fr_GestionCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1139, 489);
            Controls.Add(btnNuevoCliente);
            Controls.Add(dgvClientes);
            Controls.Add(btnModificar);
            Controls.Add(groupBox1);
            Controls.Add(pnlTop);
            Controls.Add(btnGuardar);
            Controls.Add(btnEliminar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Fr_GestionCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de Clientes";
            Load += Fr_GestionCliente_Load_1;
            pnlTop.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;

        #endregion

        private GroupBox groupBox1;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox2;
        private TextBox txtDireccion;
        private TextBox txtTelefono;
        private TextBox txtEmail;
        private TextBox txtDNI;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private DateTimePicker dtpFechaNacimiento;
        private Button btnModificar;
        private DataGridView dgvClientes;
        private Button btnNuevoCliente;
    }
}