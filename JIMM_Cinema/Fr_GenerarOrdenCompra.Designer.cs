using System.Drawing;
using System.Windows.Forms;

namespace UI
{
    partial class Fr_GenerarOrdenCompra
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
            grpProveedor = new GroupBox();
            lblProveedor = new Label();
            cmbProveedor = new ComboBox();
            grpProducto = new GroupBox();
            lblProducto = new Label();
            cmbProducto = new ComboBox();
            lblCantidad = new Label();
            numCantidad = new NumericUpDown();
            btnAgregarProducto = new Button();
            dgvOrdenCompra = new DataGridView();
            lblTotal = new Label();
            btnGuardar = new Button();
            btnRemover = new Button();
            pnlTop.SuspendLayout();
            grpProveedor.SuspendLayout();
            grpProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrdenCompra).BeginInit();
            SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.FromArgb(10, 18, 80);
            pnlTop.Controls.Add(lblTitle);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(800, 60);
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
            lblTitle.Size = new Size(800, 60);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "GENERAR ORDEN DE COMPRA";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // grpProveedor
            // 
            grpProveedor.Controls.Add(lblProveedor);
            grpProveedor.Controls.Add(cmbProveedor);
            grpProveedor.Location = new Point(12, 70);
            grpProveedor.Name = "grpProveedor";
            grpProveedor.Size = new Size(776, 80);
            grpProveedor.TabIndex = 1;
            grpProveedor.TabStop = false;
            grpProveedor.Text = "Datos del Proveedor";
            // 
            // lblProveedor
            // 
            lblProveedor.Location = new Point(20, 30);
            lblProveedor.Name = "lblProveedor";
            lblProveedor.Size = new Size(100, 23);
            lblProveedor.TabIndex = 0;
            lblProveedor.Text = "Proveedor:";
            // 
            // cmbProveedor
            // 
            cmbProveedor.Location = new Point(120, 27);
            cmbProveedor.Name = "cmbProveedor";
            cmbProveedor.Size = new Size(300, 28);
            cmbProveedor.TabIndex = 1;
            cmbProveedor.SelectedIndexChanged += cmbProveedor_SelectedIndexChanged;
            // 
            // grpProducto
            // 
            grpProducto.Controls.Add(btnRemover);
            grpProducto.Controls.Add(lblProducto);
            grpProducto.Controls.Add(cmbProducto);
            grpProducto.Controls.Add(lblCantidad);
            grpProducto.Controls.Add(numCantidad);
            grpProducto.Controls.Add(btnAgregarProducto);
            grpProducto.Location = new Point(12, 160);
            grpProducto.Name = "grpProducto";
            grpProducto.Size = new Size(776, 120);
            grpProducto.TabIndex = 2;
            grpProducto.TabStop = false;
            grpProducto.Text = "Agregar Productos";
            // 
            // lblProducto
            // 
            lblProducto.Location = new Point(20, 30);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(100, 23);
            lblProducto.TabIndex = 0;
            lblProducto.Text = "Producto:";
            // 
            // cmbProducto
            // 
            cmbProducto.Location = new Point(120, 25);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new Size(326, 28);
            cmbProducto.TabIndex = 1;
            // 
            // lblCantidad
            // 
            lblCantidad.Location = new Point(20, 70);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(84, 23);
            lblCantidad.TabIndex = 2;
            lblCantidad.Text = "Cantidad:";
            // 
            // numCantidad
            // 
            numCantidad.Location = new Point(120, 70);
            numCantidad.Name = "numCantidad";
            numCantidad.Size = new Size(120, 27);
            numCantidad.TabIndex = 3;
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.BackColor = Color.FromArgb(10, 18, 80);
            btnAgregarProducto.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAgregarProducto.ForeColor = Color.White;
            btnAgregarProducto.Location = new Point(486, 70);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(120, 34);
            btnAgregarProducto.TabIndex = 6;
            btnAgregarProducto.Text = "Agregar";
            btnAgregarProducto.UseVisualStyleBackColor = false;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // dgvOrdenCompra
            // 
            dgvOrdenCompra.AllowUserToAddRows = false;
            dgvOrdenCompra.AllowUserToDeleteRows = false;
            dgvOrdenCompra.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrdenCompra.ColumnHeadersHeight = 29;
            dgvOrdenCompra.Location = new Point(12, 290);
            dgvOrdenCompra.MultiSelect = false;
            dgvOrdenCompra.Name = "dgvOrdenCompra";
            dgvOrdenCompra.ReadOnly = true;
            dgvOrdenCompra.RowHeadersWidth = 51;
            dgvOrdenCompra.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrdenCompra.Size = new Size(776, 200);
            dgvOrdenCompra.TabIndex = 3;
            // 
            // lblTotal
            // 
            lblTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTotal.Location = new Point(12, 500);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(776, 30);
            lblTotal.TabIndex = 4;
            lblTotal.Text = "Total: $ 0.00";
            lblTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Sienna;
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(668, 540);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(120, 40);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnRemover
            // 
            btnRemover.BackColor = Color.Red;
            btnRemover.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRemover.ForeColor = Color.White;
            btnRemover.Location = new Point(625, 70);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(120, 34);
            btnRemover.TabIndex = 7;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = false;
            btnRemover.Click += btnRemover_Click;
            // 
            // Fr_GenerarOrdenCompra
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 600);
            Controls.Add(pnlTop);
            Controls.Add(grpProveedor);
            Controls.Add(grpProducto);
            Controls.Add(dgvOrdenCompra);
            Controls.Add(lblTotal);
            Controls.Add(btnGuardar);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Fr_GenerarOrdenCompra";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fr_GenerarOrdenCompra";
            Load += Fr_GenerarOrdenCompra_Load;
            pnlTop.ResumeLayout(false);
            grpProveedor.ResumeLayout(false);
            grpProducto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrdenCompra).EndInit();
            ResumeLayout(false);
        }

        private Panel pnlTop;
        private Label lblTitle;
        private GroupBox grpProveedor;
        private Label lblProveedor;
        private ComboBox cmbProveedor;
        private GroupBox grpProducto;
        private Label lblProducto;
        private ComboBox cmbProducto;
        private Label lblCantidad;
        private NumericUpDown numCantidad;
        private Button btnAgregarProducto;
        private DataGridView dgvOrdenCompra;
        private Label lblTotal;
        private Button btnGuardar;

        #endregion

        private Button btnRemover;
    }
}