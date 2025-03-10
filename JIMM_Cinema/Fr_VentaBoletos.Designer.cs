using System.Drawing;
using System.Windows.Forms;

namespace UI
{
    partial class Fr_VentaBoletos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpClient;
        private System.Windows.Forms.TextBox txtClientDNI;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.DataGridView dgvFunciones;
        private System.Windows.Forms.FlowLayoutPanel panelButacas;
        private System.Windows.Forms.ListBox lstBxButacasSeleccionadas;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnCompletarVenta;

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
            this.grpClient = new System.Windows.Forms.GroupBox();
            this.txtMembresiaCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtClientDNI = new System.Windows.Forms.TextBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.dgvFunciones = new System.Windows.Forms.DataGridView();
            this.panelButacas = new System.Windows.Forms.FlowLayoutPanel();
            this.lstBxButacasSeleccionadas = new System.Windows.Forms.ListBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnCompletarVenta = new System.Windows.Forms.Button();
            this.dgvPeliculas = new System.Windows.Forms.DataGridView();
            this.btnNuevoCliente = new System.Windows.Forms.Button();
            this.btnMembresia = new System.Windows.Forms.Button();
            this.cmbxMetodoPago = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlTop.SuspendLayout();
            this.grpClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeliculas)).BeginInit();
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
            this.pnlTop.Size = new System.Drawing.Size(1320, 48);
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
            this.lblTitle.Size = new System.Drawing.Size(1320, 48);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "VENTA DE BOLETOS";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpClient
            // 
            this.grpClient.Controls.Add(this.txtMembresiaCliente);
            this.grpClient.Controls.Add(this.label2);
            this.grpClient.Controls.Add(this.label1);
            this.grpClient.Controls.Add(this.txtNombreCliente);
            this.grpClient.Controls.Add(this.txtClientDNI);
            this.grpClient.Controls.Add(this.btnBuscarCliente);
            this.grpClient.Location = new System.Drawing.Point(12, 56);
            this.grpClient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpClient.Name = "grpClient";
            this.grpClient.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpClient.Size = new System.Drawing.Size(785, 77);
            this.grpClient.TabIndex = 1;
            this.grpClient.TabStop = false;
            this.grpClient.Text = "Datos del Cliente";
            // 
            // txtMembresiaCliente
            // 
            this.txtMembresiaCliente.Location = new System.Drawing.Point(393, 48);
            this.txtMembresiaCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMembresiaCliente.Name = "txtMembresiaCliente";
            this.txtMembresiaCliente.Size = new System.Drawing.Size(386, 22);
            this.txtMembresiaCliente.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(302, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Membresia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(302, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(393, 14);
            this.txtNombreCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(386, 22);
            this.txtNombreCliente.TabIndex = 2;
            // 
            // txtClientDNI
            // 
            this.txtClientDNI.Location = new System.Drawing.Point(20, 32);
            this.txtClientDNI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtClientDNI.Name = "txtClientDNI";
            this.txtClientDNI.Size = new System.Drawing.Size(180, 22);
            this.txtClientDNI.TabIndex = 0;
            this.txtClientDNI.Text = "DNI del Cliente";
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Location = new System.Drawing.Point(210, 31);
            this.btnBuscarCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(86, 23);
            this.btnBuscarCliente.TabIndex = 1;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // dgvFunciones
            // 
            this.dgvFunciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFunciones.ColumnHeadersHeight = 29;
            this.dgvFunciones.Location = new System.Drawing.Point(693, 147);
            this.dgvFunciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvFunciones.MultiSelect = false;
            this.dgvFunciones.Name = "dgvFunciones";
            this.dgvFunciones.RowHeadersWidth = 51;
            this.dgvFunciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFunciones.Size = new System.Drawing.Size(600, 160);
            this.dgvFunciones.TabIndex = 2;
            this.dgvFunciones.SelectionChanged += new System.EventHandler(this.dgvFunciones_SelectionChanged);
            // 
            // panelButacas
            // 
            this.panelButacas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelButacas.Location = new System.Drawing.Point(12, 312);
            this.panelButacas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelButacas.Name = "panelButacas";
            this.panelButacas.Size = new System.Drawing.Size(1074, 483);
            this.panelButacas.TabIndex = 3;
            // 
            // lstBxButacasSeleccionadas
            // 
            this.lstBxButacasSeleccionadas.ItemHeight = 16;
            this.lstBxButacasSeleccionadas.Location = new System.Drawing.Point(1103, 315);
            this.lstBxButacasSeleccionadas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstBxButacasSeleccionadas.Name = "lstBxButacasSeleccionadas";
            this.lstBxButacasSeleccionadas.Size = new System.Drawing.Size(190, 164);
            this.lstBxButacasSeleccionadas.TabIndex = 4;
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(1103, 486);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(190, 24);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "Total: $0.00";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCompletarVenta
            // 
            this.btnCompletarVenta.BackColor = System.Drawing.Color.Sienna;
            this.btnCompletarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompletarVenta.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCompletarVenta.ForeColor = System.Drawing.Color.White;
            this.btnCompletarVenta.Location = new System.Drawing.Point(1103, 596);
            this.btnCompletarVenta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCompletarVenta.Name = "btnCompletarVenta";
            this.btnCompletarVenta.Size = new System.Drawing.Size(190, 32);
            this.btnCompletarVenta.TabIndex = 6;
            this.btnCompletarVenta.Text = "COMPLETAR VENTA";
            this.btnCompletarVenta.UseVisualStyleBackColor = false;
            this.btnCompletarVenta.Click += new System.EventHandler(this.btnCompletarVenta_Click);
            // 
            // dgvPeliculas
            // 
            this.dgvPeliculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeliculas.Location = new System.Drawing.Point(12, 147);
            this.dgvPeliculas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvPeliculas.MultiSelect = false;
            this.dgvPeliculas.Name = "dgvPeliculas";
            this.dgvPeliculas.RowHeadersWidth = 51;
            this.dgvPeliculas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPeliculas.Size = new System.Drawing.Size(642, 160);
            this.dgvPeliculas.TabIndex = 7;
            this.dgvPeliculas.SelectionChanged += new System.EventHandler(this.dgvPeliculas_SelectionChanged);
            // 
            // btnNuevoCliente
            // 
            this.btnNuevoCliente.BackColor = System.Drawing.Color.Sienna;
            this.btnNuevoCliente.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnNuevoCliente.ForeColor = System.Drawing.Color.White;
            this.btnNuevoCliente.Location = new System.Drawing.Point(834, 56);
            this.btnNuevoCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNuevoCliente.Name = "btnNuevoCliente";
            this.btnNuevoCliente.Size = new System.Drawing.Size(190, 35);
            this.btnNuevoCliente.TabIndex = 8;
            this.btnNuevoCliente.Text = "Nuevo Cliente";
            this.btnNuevoCliente.UseVisualStyleBackColor = false;
            this.btnNuevoCliente.Click += new System.EventHandler(this.btnNuevoCliente_Click);
            // 
            // btnMembresia
            // 
            this.btnMembresia.BackColor = System.Drawing.Color.Sienna;
            this.btnMembresia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnMembresia.ForeColor = System.Drawing.Color.White;
            this.btnMembresia.Location = new System.Drawing.Point(834, 98);
            this.btnMembresia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMembresia.Name = "btnMembresia";
            this.btnMembresia.Size = new System.Drawing.Size(190, 38);
            this.btnMembresia.TabIndex = 9;
            this.btnMembresia.Text = "Gestionar Membresia";
            this.btnMembresia.UseVisualStyleBackColor = false;
            this.btnMembresia.Click += new System.EventHandler(this.btnMembresia_Click);
            // 
            // cmbxMetodoPago
            // 
            this.cmbxMetodoPago.FormattingEnabled = true;
            this.cmbxMetodoPago.Location = new System.Drawing.Point(1103, 543);
            this.cmbxMetodoPago.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbxMetodoPago.Name = "cmbxMetodoPago";
            this.cmbxMetodoPago.Size = new System.Drawing.Size(181, 24);
            this.cmbxMetodoPago.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1103, 525);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Metodo de Pago";
            // 
            // Fr_VentaBoletos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 806);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbxMetodoPago);
            this.Controls.Add(this.btnMembresia);
            this.Controls.Add(this.btnNuevoCliente);
            this.Controls.Add(this.dgvPeliculas);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.grpClient);
            this.Controls.Add(this.dgvFunciones);
            this.Controls.Add(this.panelButacas);
            this.Controls.Add(this.lstBxButacasSeleccionadas);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnCompletarVenta);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Fr_VentaBoletos";
            this.Text = "Fr_VentaBoletos";
            this.pnlTop.ResumeLayout(false);
            this.grpClient.ResumeLayout(false);
            this.grpClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeliculas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvPeliculas;
        private Label label1;
        private TextBox txtNombreCliente;
        private Label label2;
        private TextBox txtMembresiaCliente;
        private Button btnNuevoCliente;
        private Button btnMembresia;
        private ComboBox cmbxMetodoPago;
        private Label label3;
    }
}