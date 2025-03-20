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
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpCliente = new System.Windows.Forms.GroupBox();
            this.lblDNI = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.grpMembresia = new System.Windows.Forms.GroupBox();
            this.txtCostoMensual = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMetodoPago = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cmbTipoMembresia = new System.Windows.Forms.ComboBox();
            this.btnAsignarMembresia = new System.Windows.Forms.Button();
            this.btnRemoverMembresia = new System.Windows.Forms.Button();
            this.dgvMembresias = new System.Windows.Forms.DataGridView();
            this.pnlTop.SuspendLayout();
            this.grpCliente.SuspendLayout();
            this.grpMembresia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembresias)).BeginInit();
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
            this.pnlTop.Size = new System.Drawing.Size(1174, 48);
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
            this.lblTitle.Size = new System.Drawing.Size(1174, 48);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "GESTIÓN DE MEMBRESÍAS";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpCliente
            // 
            this.grpCliente.Controls.Add(this.lblDNI);
            this.grpCliente.Controls.Add(this.txtDNI);
            this.grpCliente.Controls.Add(this.btnBuscarCliente);
            this.grpCliente.Controls.Add(this.lblNombre);
            this.grpCliente.Controls.Add(this.txtNombre);
            this.grpCliente.Location = new System.Drawing.Point(12, 56);
            this.grpCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpCliente.Name = "grpCliente";
            this.grpCliente.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpCliente.Size = new System.Drawing.Size(400, 96);
            this.grpCliente.TabIndex = 1;
            this.grpCliente.TabStop = false;
            this.grpCliente.Text = "Datos del Cliente";
            // 
            // lblDNI
            // 
            this.lblDNI.Location = new System.Drawing.Point(9, 19);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(42, 22);
            this.lblDNI.TabIndex = 0;
            this.lblDNI.Text = "DNI:";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(73, 19);
            this.txtDNI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(200, 22);
            this.txtDNI.TabIndex = 1;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Location = new System.Drawing.Point(296, 18);
            this.btnBuscarCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(84, 25);
            this.btnBuscarCliente.TabIndex = 2;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click_1);
            // 
            // lblNombre
            // 
            this.lblNombre.Location = new System.Drawing.Point(6, 61);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(61, 18);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(73, 57);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(307, 22);
            this.txtNombre.TabIndex = 4;
            // 
            // grpMembresia
            // 
            this.grpMembresia.Controls.Add(this.txtCostoMensual);
            this.grpMembresia.Controls.Add(this.label2);
            this.grpMembresia.Controls.Add(this.label1);
            this.grpMembresia.Controls.Add(this.cmbMetodoPago);
            this.grpMembresia.Controls.Add(this.lblTipo);
            this.grpMembresia.Controls.Add(this.cmbTipoMembresia);
            this.grpMembresia.Location = new System.Drawing.Point(12, 160);
            this.grpMembresia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpMembresia.Name = "grpMembresia";
            this.grpMembresia.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpMembresia.Size = new System.Drawing.Size(400, 149);
            this.grpMembresia.TabIndex = 2;
            this.grpMembresia.TabStop = false;
            this.grpMembresia.Text = "Nueva Membresía";
            // 
            // txtCostoMensual
            // 
            this.txtCostoMensual.Enabled = false;
            this.txtCostoMensual.Location = new System.Drawing.Point(120, 58);
            this.txtCostoMensual.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCostoMensual.Name = "txtCostoMensual";
            this.txtCostoMensual.Size = new System.Drawing.Size(260, 22);
            this.txtCostoMensual.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(20, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Costo Mensual:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(20, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Metodo Pago:";
            // 
            // cmbMetodoPago
            // 
            this.cmbMetodoPago.Location = new System.Drawing.Point(120, 96);
            this.cmbMetodoPago.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbMetodoPago.Name = "cmbMetodoPago";
            this.cmbMetodoPago.Size = new System.Drawing.Size(260, 24);
            this.cmbMetodoPago.TabIndex = 3;
            // 
            // lblTipo
            // 
            this.lblTipo.Location = new System.Drawing.Point(20, 24);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(100, 18);
            this.lblTipo.TabIndex = 0;
            this.lblTipo.Text = "Tipo:";
            // 
            // cmbTipoMembresia
            // 
            this.cmbTipoMembresia.Location = new System.Drawing.Point(120, 22);
            this.cmbTipoMembresia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbTipoMembresia.Name = "cmbTipoMembresia";
            this.cmbTipoMembresia.Size = new System.Drawing.Size(260, 24);
            this.cmbTipoMembresia.TabIndex = 1;
            this.cmbTipoMembresia.SelectedIndexChanged += new System.EventHandler(this.cmbTipoMembresia_SelectedIndexChanged);
            // 
            // btnAsignarMembresia
            // 
            this.btnAsignarMembresia.BackColor = System.Drawing.Color.Sienna;
            this.btnAsignarMembresia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsignarMembresia.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignarMembresia.ForeColor = System.Drawing.Color.White;
            this.btnAsignarMembresia.Location = new System.Drawing.Point(0, 428);
            this.btnAsignarMembresia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAsignarMembresia.Name = "btnAsignarMembresia";
            this.btnAsignarMembresia.Size = new System.Drawing.Size(190, 32);
            this.btnAsignarMembresia.TabIndex = 3;
            this.btnAsignarMembresia.Text = "ASIGNAR";
            this.btnAsignarMembresia.UseVisualStyleBackColor = false;
            this.btnAsignarMembresia.Click += new System.EventHandler(this.btnAsignarMembresia_Click);
            // 
            // btnRemoverMembresia
            // 
            this.btnRemoverMembresia.BackColor = System.Drawing.Color.Red;
            this.btnRemoverMembresia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoverMembresia.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoverMembresia.ForeColor = System.Drawing.Color.White;
            this.btnRemoverMembresia.Location = new System.Drawing.Point(222, 428);
            this.btnRemoverMembresia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoverMembresia.Name = "btnRemoverMembresia";
            this.btnRemoverMembresia.Size = new System.Drawing.Size(190, 32);
            this.btnRemoverMembresia.TabIndex = 4;
            this.btnRemoverMembresia.Text = "REMOVER";
            this.btnRemoverMembresia.UseVisualStyleBackColor = false;
            this.btnRemoverMembresia.Click += new System.EventHandler(this.btnRemoverMembresia_Click_1);
            // 
            // dgvMembresias
            // 
            this.dgvMembresias.AllowUserToAddRows = false;
            this.dgvMembresias.AllowUserToDeleteRows = false;
            this.dgvMembresias.ColumnHeadersHeight = 29;
            this.dgvMembresias.Location = new System.Drawing.Point(430, 56);
            this.dgvMembresias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvMembresias.MultiSelect = false;
            this.dgvMembresias.Name = "dgvMembresias";
            this.dgvMembresias.ReadOnly = true;
            this.dgvMembresias.RowHeadersWidth = 51;
            this.dgvMembresias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMembresias.Size = new System.Drawing.Size(732, 404);
            this.dgvMembresias.TabIndex = 5;
            // 
            // Fr_GestionMembresia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 492);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.grpCliente);
            this.Controls.Add(this.grpMembresia);
            this.Controls.Add(this.btnAsignarMembresia);
            this.Controls.Add(this.btnRemoverMembresia);
            this.Controls.Add(this.dgvMembresias);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Fr_GestionMembresia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Membresías";
            this.pnlTop.ResumeLayout(false);
            this.grpCliente.ResumeLayout(false);
            this.grpCliente.PerformLayout();
            this.grpMembresia.ResumeLayout(false);
            this.grpMembresia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembresias)).EndInit();
            this.ResumeLayout(false);

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

        private Label label1;
        private ComboBox cmbMetodoPago;
        private TextBox txtCostoMensual;
        private Label label2;
    }
}