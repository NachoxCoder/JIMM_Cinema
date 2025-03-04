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
            pnlTop = new Panel();
            lblTitle = new Label();
            grpFactura = new GroupBox();
            btnModificarFactura = new Button();
            btnGuardarFactura = new Button();
            btnNuevaFactura = new Button();
            txtMontoFactura = new TextBox();
            dtpFechaFactura = new DateTimePicker();
            txtNumeroFactura = new TextBox();
            lblNumeroFactura = new Label();
            lblFecha = new Label();
            lblMonto = new Label();
            grpPago = new GroupBox();
            lblMetodoPago = new Label();
            cmbMetodoPago = new ComboBox();
            btnPagarFactura = new Button();
            dgvFacturas = new DataGridView();
            dgvOrdenesCompra = new DataGridView();
            label2 = new Label();
            label1 = new Label();
            pnlTop.SuspendLayout();
            grpFactura.SuspendLayout();
            grpPago.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFacturas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrdenesCompra).BeginInit();
            SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.FromArgb(10, 18, 80);
            pnlTop.Controls.Add(lblTitle);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(1233, 60);
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
            lblTitle.Size = new Size(1233, 60);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "REGISTRO Y PAGO DE FACTURAS";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // grpFactura
            // 
            grpFactura.Controls.Add(btnModificarFactura);
            grpFactura.Controls.Add(btnGuardarFactura);
            grpFactura.Controls.Add(btnNuevaFactura);
            grpFactura.Controls.Add(txtMontoFactura);
            grpFactura.Controls.Add(dtpFechaFactura);
            grpFactura.Controls.Add(txtNumeroFactura);
            grpFactura.Controls.Add(lblNumeroFactura);
            grpFactura.Controls.Add(lblFecha);
            grpFactura.Controls.Add(lblMonto);
            grpFactura.Location = new Point(12, 91);
            grpFactura.Name = "grpFactura";
            grpFactura.Size = new Size(379, 281);
            grpFactura.TabIndex = 1;
            grpFactura.TabStop = false;
            grpFactura.Text = "Datos de la Factura";
            // 
            // btnModificarFactura
            // 
            btnModificarFactura.BackColor = Color.Sienna;
            btnModificarFactura.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnModificarFactura.ForeColor = Color.White;
            btnModificarFactura.Location = new Point(257, 175);
            btnModificarFactura.Name = "btnModificarFactura";
            btnModificarFactura.Size = new Size(100, 35);
            btnModificarFactura.TabIndex = 11;
            btnModificarFactura.Text = "Modificar";
            btnModificarFactura.UseVisualStyleBackColor = false;
            btnModificarFactura.Click += btnModificarFactura_Click;
            // 
            // btnGuardarFactura
            // 
            btnGuardarFactura.BackColor = Color.Sienna;
            btnGuardarFactura.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnGuardarFactura.ForeColor = Color.White;
            btnGuardarFactura.Location = new Point(132, 175);
            btnGuardarFactura.Name = "btnGuardarFactura";
            btnGuardarFactura.Size = new Size(100, 35);
            btnGuardarFactura.TabIndex = 10;
            btnGuardarFactura.Text = "Guardar";
            btnGuardarFactura.UseVisualStyleBackColor = false;
            btnGuardarFactura.Click += btnGuardarFactura_Click;
            // 
            // btnNuevaFactura
            // 
            btnNuevaFactura.BackColor = Color.Sienna;
            btnNuevaFactura.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnNuevaFactura.ForeColor = Color.White;
            btnNuevaFactura.Location = new Point(7, 175);
            btnNuevaFactura.Name = "btnNuevaFactura";
            btnNuevaFactura.Size = new Size(100, 35);
            btnNuevaFactura.TabIndex = 4;
            btnNuevaFactura.Text = "Nuevo";
            btnNuevaFactura.UseVisualStyleBackColor = false;
            btnNuevaFactura.Click += btnNuevaFactura_Click;
            // 
            // txtMontoFactura
            // 
            txtMontoFactura.Location = new Point(98, 69);
            txtMontoFactura.Name = "txtMontoFactura";
            txtMontoFactura.Size = new Size(237, 27);
            txtMontoFactura.TabIndex = 7;
            // 
            // dtpFechaFactura
            // 
            dtpFechaFactura.Format = DateTimePickerFormat.Short;
            dtpFechaFactura.Location = new Point(120, 116);
            dtpFechaFactura.MinDate = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            dtpFechaFactura.Name = "dtpFechaFactura";
            dtpFechaFactura.Size = new Size(215, 27);
            dtpFechaFactura.TabIndex = 6;
            // 
            // txtNumeroFactura
            // 
            txtNumeroFactura.Location = new Point(98, 27);
            txtNumeroFactura.Name = "txtNumeroFactura";
            txtNumeroFactura.Size = new Size(237, 27);
            txtNumeroFactura.TabIndex = 5;
            // 
            // lblNumeroFactura
            // 
            lblNumeroFactura.Location = new Point(9, 30);
            lblNumeroFactura.Name = "lblNumeroFactura";
            lblNumeroFactura.Size = new Size(72, 23);
            lblNumeroFactura.TabIndex = 0;
            lblNumeroFactura.Text = "Número:";
            // 
            // lblFecha
            // 
            lblFecha.Location = new Point(7, 116);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(139, 23);
            lblFecha.TabIndex = 2;
            lblFecha.Text = "Fecha Emision:";
            // 
            // lblMonto
            // 
            lblMonto.Location = new Point(7, 72);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(74, 23);
            lblMonto.TabIndex = 4;
            lblMonto.Text = "Monto:";
            // 
            // grpPago
            // 
            grpPago.Controls.Add(lblMetodoPago);
            grpPago.Controls.Add(cmbMetodoPago);
            grpPago.Controls.Add(btnPagarFactura);
            grpPago.Location = new Point(12, 389);
            grpPago.Name = "grpPago";
            grpPago.Size = new Size(379, 191);
            grpPago.TabIndex = 2;
            grpPago.TabStop = false;
            grpPago.Text = "Datos del Pago";
            // 
            // lblMetodoPago
            // 
            lblMetodoPago.Location = new Point(20, 30);
            lblMetodoPago.Name = "lblMetodoPago";
            lblMetodoPago.Size = new Size(100, 23);
            lblMetodoPago.TabIndex = 0;
            lblMetodoPago.Text = "Método:";
            // 
            // cmbMetodoPago
            // 
            cmbMetodoPago.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMetodoPago.Location = new Point(120, 27);
            cmbMetodoPago.Name = "cmbMetodoPago";
            cmbMetodoPago.Size = new Size(200, 28);
            cmbMetodoPago.TabIndex = 1;
            // 
            // btnPagarFactura
            // 
            btnPagarFactura.BackColor = Color.Sienna;
            btnPagarFactura.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnPagarFactura.ForeColor = Color.White;
            btnPagarFactura.Location = new Point(20, 156);
            btnPagarFactura.Name = "btnPagarFactura";
            btnPagarFactura.Size = new Size(100, 35);
            btnPagarFactura.TabIndex = 3;
            btnPagarFactura.Text = "Pagar";
            btnPagarFactura.UseVisualStyleBackColor = false;
            btnPagarFactura.Click += btnPagarFactura_Click;
            // 
            // dgvFacturas
            // 
            dgvFacturas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFacturas.Location = new Point(478, 401);
            dgvFacturas.MultiSelect = false;
            dgvFacturas.Name = "dgvFacturas";
            dgvFacturas.RowHeadersWidth = 51;
            dgvFacturas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFacturas.Size = new Size(733, 179);
            dgvFacturas.TabIndex = 3;
            dgvFacturas.SelectionChanged += dgvFacturas_SelectionChanged;
            // 
            // dgvOrdenesCompra
            // 
            dgvOrdenesCompra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrdenesCompra.Location = new Point(478, 100);
            dgvOrdenesCompra.MultiSelect = false;
            dgvOrdenesCompra.Name = "dgvOrdenesCompra";
            dgvOrdenesCompra.RowHeadersWidth = 51;
            dgvOrdenesCompra.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrdenesCompra.Size = new Size(733, 272);
            dgvOrdenesCompra.TabIndex = 4;
            dgvOrdenesCompra.SelectionChanged += dgvOrdenesCompra_SelectionChanged;
            // 
            // label2
            // 
            label2.Location = new Point(478, 74);
            label2.Name = "label2";
            label2.Size = new Size(132, 23);
            label2.TabIndex = 12;
            label2.Text = "Ordenes Compra";
            // 
            // label1
            // 
            label1.Location = new Point(478, 375);
            label1.Name = "label1";
            label1.Size = new Size(132, 23);
            label1.TabIndex = 13;
            label1.Text = "Facturas";
            // 
            // Fr_GestionFacturas
            // 
            AcceptButton = btnPagarFactura;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1233, 592);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(dgvOrdenesCompra);
            Controls.Add(dgvFacturas);
            Controls.Add(pnlTop);
            Controls.Add(grpFactura);
            Controls.Add(grpPago);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Fr_GestionFacturas";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Fr_GestionFacturas";
            Load += Fr_GestionFacturas_Load;
            pnlTop.ResumeLayout(false);
            grpFactura.ResumeLayout(false);
            grpFactura.PerformLayout();
            grpPago.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvFacturas).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrdenesCompra).EndInit();
            ResumeLayout(false);
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