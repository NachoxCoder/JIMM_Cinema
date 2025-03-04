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
            pnlTop = new Panel();
            lblTitle = new Label();
            grpClient = new GroupBox();
            txtMembresiaCliente = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtNombreCliente = new TextBox();
            txtClientDNI = new TextBox();
            btnBuscarCliente = new Button();
            dgvFunciones = new DataGridView();
            panelButacas = new FlowLayoutPanel();
            lstBxButacasSeleccionadas = new ListBox();
            lblTotal = new Label();
            btnCompletarVenta = new Button();
            dgvPeliculas = new DataGridView();
            btnNuevoCliente = new Button();
            btnMembresia = new Button();
            cmbxMetodoPago = new ComboBox();
            label3 = new Label();
            pnlTop.SuspendLayout();
            grpClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFunciones).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPeliculas).BeginInit();
            SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.FromArgb(10, 18, 80);
            pnlTop.Controls.Add(lblTitle);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(1320, 60);
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
            lblTitle.Size = new Size(1320, 60);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "VENTA DE BOLETOS";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // grpClient
            // 
            grpClient.Controls.Add(txtMembresiaCliente);
            grpClient.Controls.Add(label2);
            grpClient.Controls.Add(label1);
            grpClient.Controls.Add(txtNombreCliente);
            grpClient.Controls.Add(txtClientDNI);
            grpClient.Controls.Add(btnBuscarCliente);
            grpClient.Location = new Point(12, 70);
            grpClient.Name = "grpClient";
            grpClient.Size = new Size(785, 96);
            grpClient.TabIndex = 1;
            grpClient.TabStop = false;
            grpClient.Text = "Datos del Cliente";
            // 
            // txtMembresiaCliente
            // 
            txtMembresiaCliente.Location = new Point(393, 60);
            txtMembresiaCliente.Name = "txtMembresiaCliente";
            txtMembresiaCliente.Size = new Size(386, 27);
            txtMembresiaCliente.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(302, 67);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 4;
            label2.Text = "Membresia";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(302, 20);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 3;
            label1.Text = "Nombre";
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Location = new Point(393, 17);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new Size(386, 27);
            txtNombreCliente.TabIndex = 2;
            // 
            // txtClientDNI
            // 
            txtClientDNI.Location = new Point(20, 40);
            txtClientDNI.Name = "txtClientDNI";
            txtClientDNI.Text = "DNI del Cliente";
            txtClientDNI.Size = new Size(180, 27);
            txtClientDNI.TabIndex = 0;
            // 
            // btnBuscarCliente
            // 
            btnBuscarCliente.Location = new Point(210, 39);
            btnBuscarCliente.Name = "btnBuscarCliente";
            btnBuscarCliente.Size = new Size(70, 27);
            btnBuscarCliente.TabIndex = 1;
            btnBuscarCliente.Text = "Buscar";
            btnBuscarCliente.Click += btnBuscarCliente_Click_1;
            // 
            // dgvFunciones
            // 
            dgvFunciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFunciones.ColumnHeadersHeight = 29;
            dgvFunciones.Location = new Point(693, 184);
            dgvFunciones.MultiSelect = false;
            dgvFunciones.Name = "dgvFunciones";
            dgvFunciones.RowHeadersWidth = 51;
            dgvFunciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFunciones.Size = new Size(600, 200);
            dgvFunciones.TabIndex = 2;
            dgvFunciones.SelectionChanged += dgvFunciones_SelectionChanged;
            // 
            // panelButacas
            // 
            panelButacas.BorderStyle = BorderStyle.FixedSingle;
            panelButacas.Location = new Point(12, 390);
            panelButacas.Name = "panelButacas";
            panelButacas.Size = new Size(1074, 395);
            panelButacas.TabIndex = 3;
            // 
            // lstBxButacasSeleccionadas
            // 
            lstBxButacasSeleccionadas.Location = new Point(1103, 394);
            lstBxButacasSeleccionadas.Name = "lstBxButacasSeleccionadas";
            lstBxButacasSeleccionadas.Size = new Size(190, 204);
            lstBxButacasSeleccionadas.TabIndex = 4;
            // 
            // lblTotal
            // 
            lblTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTotal.Location = new Point(1103, 608);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(190, 30);
            lblTotal.TabIndex = 5;
            lblTotal.Text = "Total: $0.00";
            lblTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnCompletarVenta
            // 
            btnCompletarVenta.BackColor = Color.Sienna;
            btnCompletarVenta.FlatStyle = FlatStyle.Flat;
            btnCompletarVenta.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCompletarVenta.ForeColor = Color.White;
            btnCompletarVenta.Location = new Point(1103, 745);
            btnCompletarVenta.Name = "btnCompletarVenta";
            btnCompletarVenta.Size = new Size(190, 40);
            btnCompletarVenta.TabIndex = 6;
            btnCompletarVenta.Text = "COMPLETAR VENTA";
            btnCompletarVenta.UseVisualStyleBackColor = false;
            btnCompletarVenta.Click += btnCompletarVenta_Click;
            // 
            // dgvPeliculas
            // 
            dgvPeliculas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPeliculas.Location = new Point(12, 184);
            dgvPeliculas.MultiSelect = false;
            dgvPeliculas.Name = "dgvPeliculas";
            dgvPeliculas.RowHeadersWidth = 51;
            dgvPeliculas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPeliculas.Size = new Size(642, 200);
            dgvPeliculas.TabIndex = 7;
            dgvPeliculas.SelectionChanged += dgvPeliculas_SelectionChanged;
            // 
            // btnNuevoCliente
            // 
            btnNuevoCliente.BackColor = Color.Sienna;
            btnNuevoCliente.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnNuevoCliente.ForeColor = Color.White;
            btnNuevoCliente.Location = new Point(834, 70);
            btnNuevoCliente.Name = "btnNuevoCliente";
            btnNuevoCliente.Size = new Size(169, 44);
            btnNuevoCliente.TabIndex = 8;
            btnNuevoCliente.Text = "Nuevo Cliente";
            btnNuevoCliente.UseVisualStyleBackColor = false;
            btnNuevoCliente.Click += btnNuevoCliente_Click;
            // 
            // btnMembresia
            // 
            btnMembresia.BackColor = Color.Sienna;
            btnMembresia.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnMembresia.ForeColor = Color.White;
            btnMembresia.Location = new Point(834, 123);
            btnMembresia.Name = "btnMembresia";
            btnMembresia.Size = new Size(169, 48);
            btnMembresia.TabIndex = 9;
            btnMembresia.Text = "Gestionar Membresia";
            btnMembresia.UseVisualStyleBackColor = false;
            btnMembresia.Click += btnMembresia_Click;
            // 
            // cmbxMetodoPago
            // 
            cmbxMetodoPago.FormattingEnabled = true;
            cmbxMetodoPago.Location = new Point(1103, 679);
            cmbxMetodoPago.Name = "cmbxMetodoPago";
            cmbxMetodoPago.Size = new Size(181, 28);
            cmbxMetodoPago.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1103, 656);
            label3.Name = "label3";
            label3.Size = new Size(120, 20);
            label3.TabIndex = 11;
            label3.Text = "Metodo de Pago";
            // 
            // Fr_VentaBoletos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1320, 833);
            Controls.Add(label3);
            Controls.Add(cmbxMetodoPago);
            Controls.Add(btnMembresia);
            Controls.Add(btnNuevoCliente);
            Controls.Add(dgvPeliculas);
            Controls.Add(pnlTop);
            Controls.Add(grpClient);
            Controls.Add(dgvFunciones);
            Controls.Add(panelButacas);
            Controls.Add(lstBxButacasSeleccionadas);
            Controls.Add(lblTotal);
            Controls.Add(btnCompletarVenta);
            Name = "Fr_VentaBoletos";
            Text = "Fr_VentaBoletos";
            pnlTop.ResumeLayout(false);
            grpClient.ResumeLayout(false);
            grpClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFunciones).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPeliculas).EndInit();
            ResumeLayout(false);
            PerformLayout();
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