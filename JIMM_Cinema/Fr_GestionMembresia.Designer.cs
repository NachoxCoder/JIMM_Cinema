using System.Drawing;
using System.Windows.Forms;

namespace UI
{
    partial class Fr_GestionMembresia
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
            grpCliente = new GroupBox();
            lblDNI = new Label();
            txtDNI = new TextBox();
            btnBuscarCliente = new Button();
            lblNombre = new Label();
            txtNombre = new TextBox();
            grpMembresia = new GroupBox();
            lblTipo = new Label();
            cmbTipoMembresia = new ComboBox();
            btnAsignarMembresia = new Button();
            btnRemoverMembresia = new Button();
            dgvMembresias = new DataGridView();
            pnlTop.SuspendLayout();
            grpCliente.SuspendLayout();
            grpMembresia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMembresias).BeginInit();
            SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.FromArgb(10, 18, 80);
            pnlTop.Controls.Add(lblTitle);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(995, 60);
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
            lblTitle.Size = new Size(995, 60);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "GESTIÓN DE MEMBRESÍAS";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // grpCliente
            // 
            grpCliente.Controls.Add(lblDNI);
            grpCliente.Controls.Add(txtDNI);
            grpCliente.Controls.Add(btnBuscarCliente);
            grpCliente.Controls.Add(lblNombre);
            grpCliente.Controls.Add(txtNombre);
            grpCliente.Location = new Point(12, 70);
            grpCliente.Name = "grpCliente";
            grpCliente.Size = new Size(400, 120);
            grpCliente.TabIndex = 1;
            grpCliente.TabStop = false;
            grpCliente.Text = "Datos del Cliente";
            // 
            // lblDNI
            // 
            lblDNI.Location = new Point(20, 30);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(74, 23);
            lblDNI.TabIndex = 0;
            lblDNI.Text = "DNI:";
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(100, 27);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(200, 27);
            txtDNI.TabIndex = 1;
            // 
            // btnBuscarCliente
            // 
            btnBuscarCliente.Location = new Point(310, 26);
            btnBuscarCliente.Name = "btnBuscarCliente";
            btnBuscarCliente.Size = new Size(70, 27);
            btnBuscarCliente.TabIndex = 2;
            btnBuscarCliente.Text = "Buscar";
            btnBuscarCliente.Click += btnBuscarCliente_Click_1;
            // 
            // lblNombre
            // 
            lblNombre.Location = new Point(20, 65);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(74, 23);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(100, 62);
            txtNombre.Name = "txtNombre";
            txtNombre.ReadOnly = true;
            txtNombre.Size = new Size(280, 27);
            txtNombre.TabIndex = 4;
            // 
            // grpMembresia
            // 
            grpMembresia.Controls.Add(lblTipo);
            grpMembresia.Controls.Add(cmbTipoMembresia);
            grpMembresia.Location = new Point(12, 200);
            grpMembresia.Name = "grpMembresia";
            grpMembresia.Size = new Size(400, 100);
            grpMembresia.TabIndex = 2;
            grpMembresia.TabStop = false;
            grpMembresia.Text = "Nueva Membresía";
            // 
            // lblTipo
            // 
            lblTipo.Location = new Point(20, 30);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(100, 23);
            lblTipo.TabIndex = 0;
            lblTipo.Text = "Tipo:";
            // 
            // cmbTipoMembresia
            // 
            cmbTipoMembresia.Location = new Point(120, 27);
            cmbTipoMembresia.Name = "cmbTipoMembresia";
            cmbTipoMembresia.Size = new Size(260, 28);
            cmbTipoMembresia.TabIndex = 1;
            // 
            // btnAsignarMembresia
            // 
            btnAsignarMembresia.BackColor = Color.Sienna;
            btnAsignarMembresia.FlatStyle = FlatStyle.Flat;
            btnAsignarMembresia.ForeColor = Color.White;
            btnAsignarMembresia.Location = new Point(12, 320);
            btnAsignarMembresia.Name = "btnAsignarMembresia";
            btnAsignarMembresia.Size = new Size(190, 40);
            btnAsignarMembresia.TabIndex = 3;
            btnAsignarMembresia.Text = "ASIGNAR";
            btnAsignarMembresia.UseVisualStyleBackColor = false;
            btnAsignarMembresia.Click += btnAsignarMembresia_Click;
            // 
            // btnRemoverMembresia
            // 
            btnRemoverMembresia.BackColor = Color.Red;
            btnRemoverMembresia.FlatStyle = FlatStyle.Flat;
            btnRemoverMembresia.ForeColor = Color.White;
            btnRemoverMembresia.Location = new Point(222, 320);
            btnRemoverMembresia.Name = "btnRemoverMembresia";
            btnRemoverMembresia.Size = new Size(190, 40);
            btnRemoverMembresia.TabIndex = 4;
            btnRemoverMembresia.Text = "REMOVER";
            btnRemoverMembresia.UseVisualStyleBackColor = false;
            btnRemoverMembresia.Click += btnRemoverMembresia_Click_1;
            // 
            // dgvMembresias
            // 
            dgvMembresias.AllowUserToAddRows = false;
            dgvMembresias.AllowUserToDeleteRows = false;
            dgvMembresias.ColumnHeadersHeight = 29;
            dgvMembresias.Location = new Point(430, 70);
            dgvMembresias.MultiSelect = false;
            dgvMembresias.Name = "dgvMembresias";
            dgvMembresias.ReadOnly = true;
            dgvMembresias.RowHeadersWidth = 51;
            dgvMembresias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMembresias.Size = new Size(550, 290);
            dgvMembresias.TabIndex = 5;
            // 
            // Fr_GestionMembresia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(995, 381);
            Controls.Add(pnlTop);
            Controls.Add(grpCliente);
            Controls.Add(grpMembresia);
            Controls.Add(btnAsignarMembresia);
            Controls.Add(btnRemoverMembresia);
            Controls.Add(dgvMembresias);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Fr_GestionMembresia";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de Membresías";
            pnlTop.ResumeLayout(false);
            grpCliente.ResumeLayout(false);
            grpCliente.PerformLayout();
            grpMembresia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMembresias).EndInit();
            ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpCliente;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.GroupBox grpMembresia;
        private System.Windows.Forms.ComboBox cmbTipoMembresia;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.CheckBox chkActiva;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.Button btnAsignarMembresia;
        private System.Windows.Forms.Button btnRemoverMembresia;
        private System.Windows.Forms.DataGridView dgvMembresias;
    

        #endregion
    }
}