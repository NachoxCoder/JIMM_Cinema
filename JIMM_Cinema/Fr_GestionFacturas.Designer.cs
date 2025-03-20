using System;
using System.Drawing;
using System.Windows.Forms;

namespace UI
{
    partial class Fr_GestionFacturas
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
            this.grpFactura = new System.Windows.Forms.GroupBox();
            this.btnModificarFactura = new System.Windows.Forms.Button();
            this.btnGuardarFactura = new System.Windows.Forms.Button();
            this.btnNuevaFactura = new System.Windows.Forms.Button();
            this.txtMontoFactura = new System.Windows.Forms.TextBox();
            this.dtpFechaFactura = new System.Windows.Forms.DateTimePicker();
            this.txtNumeroFactura = new System.Windows.Forms.TextBox();
            this.lblNumeroFactura = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.grpPago = new System.Windows.Forms.GroupBox();
            this.lblMetodoPago = new System.Windows.Forms.Label();
            this.cmbMetodoPago = new System.Windows.Forms.ComboBox();
            this.btnPagarFactura = new System.Windows.Forms.Button();
            this.dgvFacturas = new System.Windows.Forms.DataGridView();
            this.dgvOrdenesCompra = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlTop.SuspendLayout();
            this.grpFactura.SuspendLayout();
            this.grpPago.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenesCompra)).BeginInit();
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
            this.pnlTop.Size = new System.Drawing.Size(1233, 48);
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
            this.lblTitle.Size = new System.Drawing.Size(1233, 48);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "REGISTRO Y PAGO DE FACTURAS";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpFactura
            // 
            this.grpFactura.Controls.Add(this.btnModificarFactura);
            this.grpFactura.Controls.Add(this.btnGuardarFactura);
            this.grpFactura.Controls.Add(this.btnNuevaFactura);
            this.grpFactura.Controls.Add(this.txtMontoFactura);
            this.grpFactura.Controls.Add(this.dtpFechaFactura);
            this.grpFactura.Controls.Add(this.txtNumeroFactura);
            this.grpFactura.Controls.Add(this.lblNumeroFactura);
            this.grpFactura.Controls.Add(this.lblFecha);
            this.grpFactura.Controls.Add(this.lblMonto);
            this.grpFactura.Location = new System.Drawing.Point(12, 73);
            this.grpFactura.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpFactura.Name = "grpFactura";
            this.grpFactura.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpFactura.Size = new System.Drawing.Size(379, 225);
            this.grpFactura.TabIndex = 1;
            this.grpFactura.TabStop = false;
            this.grpFactura.Text = "Datos de la Factura";
            // 
            // btnModificarFactura
            // 
            this.btnModificarFactura.BackColor = System.Drawing.Color.Sienna;
            this.btnModificarFactura.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnModificarFactura.ForeColor = System.Drawing.Color.White;
            this.btnModificarFactura.Location = new System.Drawing.Point(257, 140);
            this.btnModificarFactura.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificarFactura.Name = "btnModificarFactura";
            this.btnModificarFactura.Size = new System.Drawing.Size(100, 28);
            this.btnModificarFactura.TabIndex = 11;
            this.btnModificarFactura.Text = "Modificar";
            this.btnModificarFactura.UseVisualStyleBackColor = false;
            this.btnModificarFactura.Click += new System.EventHandler(this.btnModificarFactura_Click);
            // 
            // btnGuardarFactura
            // 
            this.btnGuardarFactura.BackColor = System.Drawing.Color.Sienna;
            this.btnGuardarFactura.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnGuardarFactura.ForeColor = System.Drawing.Color.White;
            this.btnGuardarFactura.Location = new System.Drawing.Point(132, 140);
            this.btnGuardarFactura.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardarFactura.Name = "btnGuardarFactura";
            this.btnGuardarFactura.Size = new System.Drawing.Size(100, 28);
            this.btnGuardarFactura.TabIndex = 10;
            this.btnGuardarFactura.Text = "Guardar";
            this.btnGuardarFactura.UseVisualStyleBackColor = false;
            this.btnGuardarFactura.Click += new System.EventHandler(this.btnGuardarFactura_Click);
            // 
            // btnNuevaFactura
            // 
            this.btnNuevaFactura.BackColor = System.Drawing.Color.Sienna;
            this.btnNuevaFactura.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnNuevaFactura.ForeColor = System.Drawing.Color.White;
            this.btnNuevaFactura.Location = new System.Drawing.Point(7, 140);
            this.btnNuevaFactura.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNuevaFactura.Name = "btnNuevaFactura";
            this.btnNuevaFactura.Size = new System.Drawing.Size(100, 28);
            this.btnNuevaFactura.TabIndex = 4;
            this.btnNuevaFactura.Text = "Nuevo";
            this.btnNuevaFactura.UseVisualStyleBackColor = false;
            this.btnNuevaFactura.Click += new System.EventHandler(this.btnNuevaFactura_Click);
            // 
            // txtMontoFactura
            // 
            this.txtMontoFactura.Location = new System.Drawing.Point(98, 55);
            this.txtMontoFactura.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMontoFactura.Name = "txtMontoFactura";
            this.txtMontoFactura.Size = new System.Drawing.Size(237, 22);
            this.txtMontoFactura.TabIndex = 7;
            // 
            // dtpFechaFactura
            // 
            this.dtpFechaFactura.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFactura.Location = new System.Drawing.Point(120, 93);
            this.dtpFechaFactura.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFechaFactura.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpFechaFactura.Name = "dtpFechaFactura";
            this.dtpFechaFactura.Size = new System.Drawing.Size(215, 22);
            this.dtpFechaFactura.TabIndex = 6;
            // 
            // txtNumeroFactura
            // 
            this.txtNumeroFactura.Location = new System.Drawing.Point(98, 22);
            this.txtNumeroFactura.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumeroFactura.Name = "txtNumeroFactura";
            this.txtNumeroFactura.Size = new System.Drawing.Size(237, 22);
            this.txtNumeroFactura.TabIndex = 5;
            // 
            // lblNumeroFactura
            // 
            this.lblNumeroFactura.Location = new System.Drawing.Point(9, 24);
            this.lblNumeroFactura.Name = "lblNumeroFactura";
            this.lblNumeroFactura.Size = new System.Drawing.Size(72, 18);
            this.lblNumeroFactura.TabIndex = 0;
            this.lblNumeroFactura.Text = "Número:";
            // 
            // lblFecha
            // 
            this.lblFecha.Location = new System.Drawing.Point(7, 93);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(139, 18);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Fecha Emision:";
            // 
            // lblMonto
            // 
            this.lblMonto.Location = new System.Drawing.Point(7, 58);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(74, 18);
            this.lblMonto.TabIndex = 4;
            this.lblMonto.Text = "Monto:";
            // 
            // grpPago
            // 
            this.grpPago.Controls.Add(this.lblMetodoPago);
            this.grpPago.Controls.Add(this.cmbMetodoPago);
            this.grpPago.Controls.Add(this.btnPagarFactura);
            this.grpPago.Location = new System.Drawing.Point(12, 311);
            this.grpPago.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpPago.Name = "grpPago";
            this.grpPago.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpPago.Size = new System.Drawing.Size(379, 153);
            this.grpPago.TabIndex = 2;
            this.grpPago.TabStop = false;
            this.grpPago.Text = "Datos del Pago";
            // 
            // lblMetodoPago
            // 
            this.lblMetodoPago.Location = new System.Drawing.Point(20, 24);
            this.lblMetodoPago.Name = "lblMetodoPago";
            this.lblMetodoPago.Size = new System.Drawing.Size(100, 18);
            this.lblMetodoPago.TabIndex = 0;
            this.lblMetodoPago.Text = "Método:";
            // 
            // cmbMetodoPago
            // 
            this.cmbMetodoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMetodoPago.Location = new System.Drawing.Point(120, 22);
            this.cmbMetodoPago.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbMetodoPago.Name = "cmbMetodoPago";
            this.cmbMetodoPago.Size = new System.Drawing.Size(200, 24);
            this.cmbMetodoPago.TabIndex = 1;
            // 
            // btnPagarFactura
            // 
            this.btnPagarFactura.BackColor = System.Drawing.Color.Sienna;
            this.btnPagarFactura.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnPagarFactura.ForeColor = System.Drawing.Color.White;
            this.btnPagarFactura.Location = new System.Drawing.Point(12, 110);
            this.btnPagarFactura.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPagarFactura.Name = "btnPagarFactura";
            this.btnPagarFactura.Size = new System.Drawing.Size(100, 28);
            this.btnPagarFactura.TabIndex = 3;
            this.btnPagarFactura.Text = "Pagar";
            this.btnPagarFactura.UseVisualStyleBackColor = false;
            this.btnPagarFactura.Click += new System.EventHandler(this.btnPagarFactura_Click);
            // 
            // dgvFacturas
            // 
            this.dgvFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFacturas.Location = new System.Drawing.Point(478, 321);
            this.dgvFacturas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvFacturas.MultiSelect = false;
            this.dgvFacturas.Name = "dgvFacturas";
            this.dgvFacturas.RowHeadersWidth = 51;
            this.dgvFacturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFacturas.Size = new System.Drawing.Size(733, 143);
            this.dgvFacturas.TabIndex = 3;
            this.dgvFacturas.SelectionChanged += new System.EventHandler(this.dgvFacturas_SelectionChanged);
            // 
            // dgvOrdenesCompra
            // 
            this.dgvOrdenesCompra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrdenesCompra.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvOrdenesCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrdenesCompra.Location = new System.Drawing.Point(478, 80);
            this.dgvOrdenesCompra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvOrdenesCompra.MultiSelect = false;
            this.dgvOrdenesCompra.Name = "dgvOrdenesCompra";
            this.dgvOrdenesCompra.RowHeadersWidth = 51;
            this.dgvOrdenesCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrdenesCompra.Size = new System.Drawing.Size(733, 218);
            this.dgvOrdenesCompra.TabIndex = 4;
            this.dgvOrdenesCompra.SelectionChanged += new System.EventHandler(this.dgvOrdenesCompra_SelectionChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(478, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "Ordenes Compra";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(478, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "Facturas";
            // 
            // Fr_GestionFacturas
            // 
            this.AcceptButton = this.btnPagarFactura;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 474);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvOrdenesCompra);
            this.Controls.Add(this.dgvFacturas);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.grpFactura);
            this.Controls.Add(this.grpPago);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Fr_GestionFacturas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Fr_GestionFacturas";
            this.pnlTop.ResumeLayout(false);
            this.grpFactura.ResumeLayout(false);
            this.grpFactura.PerformLayout();
            this.grpPago.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenesCompra)).EndInit();
            this.ResumeLayout(false);

        }

        private Panel pnlTop;
        private Label lblTitle;
        private GroupBox grpFactura;
        private Label lblNumeroFactura;
        private Label lblFecha;
        private Label lblMonto;
        private GroupBox grpPago;
        private Label lblMetodoPago;
        private ComboBox cmbMetodoPago;
        private Button btnPagarFactura;

        #endregion

        private DateTimePicker dtpFechaFactura;
        private TextBox txtNumeroFactura;
        private DataGridView dgvFacturas;
        private TextBox txtMontoFactura;
        private Button btnNuevaFactura;
        private Button btnGuardarFactura;
        private DataGridView dgvOrdenesCompra;
        private Label label2;
        private Label label1;
        private Button btnModificarFactura;
    }
}