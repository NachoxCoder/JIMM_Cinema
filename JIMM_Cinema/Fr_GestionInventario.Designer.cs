using System.Drawing;
using System.Windows.Forms;

namespace UI
{
    partial class Fr_GestionInventario
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
            chkProductoActivo = new CheckBox();
            lblNombre = new Label();
            txtNombreProducto = new TextBox();
            lblDescripcion = new Label();
            txtDescripcionProducto = new TextBox();
            lblStock = new Label();
            numStockProducto = new NumericUpDown();
            lblPrecio = new Label();
            numPrecioProducto = new NumericUpDown();
            btnGuardarProducto = new Button();
            btnEliminarProducto = new Button();
            dgvProductos = new DataGridView();
            lblAlerta = new Label();
            groupBox1 = new GroupBox();
            btnNuevoProducto = new Button();
            btnModificarProducto = new Button();
            groupBox2 = new GroupBox();
            btnNuevoProveedor = new Button();
            btnModificarProveedor = new Button();
            dgvProveedor = new DataGridView();
            btnEliminarProveedor = new Button();
            btnGuardarProveedor = new Button();
            groupBox3 = new GroupBox();
            chkProveedorActivo = new CheckBox();
            txtEmailProveedor = new TextBox();
            txtDireccionProveedor = new TextBox();
            label2 = new Label();
            txtRazonSocial = new TextBox();
            label3 = new Label();
            txtCuit = new TextBox();
            label4 = new Label();
            label5 = new Label();
            btnGenerarOrdenCompra = new Button();
            pnlTop.SuspendLayout();
            grpDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numStockProducto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPrecioProducto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProveedor).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.FromArgb(10, 18, 80);
            pnlTop.Controls.Add(lblTitle);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(1329, 60);
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
            lblTitle.Size = new Size(1329, 60);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "GESTIÓN DE INVENTARIO";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // grpDatos
            // 
            grpDatos.Controls.Add(chkProductoActivo);
            grpDatos.Controls.Add(lblNombre);
            grpDatos.Controls.Add(txtNombreProducto);
            grpDatos.Controls.Add(lblDescripcion);
            grpDatos.Controls.Add(txtDescripcionProducto);
            grpDatos.Controls.Add(lblStock);
            grpDatos.Controls.Add(numStockProducto);
            grpDatos.Controls.Add(lblPrecio);
            grpDatos.Controls.Add(numPrecioProducto);
            grpDatos.Location = new Point(18, 302);
            grpDatos.Name = "grpDatos";
            grpDatos.Size = new Size(397, 225);
            grpDatos.TabIndex = 1;
            grpDatos.TabStop = false;
            grpDatos.Text = "Datos del Producto";
            // 
            // chkProductoActivo
            // 
            chkProductoActivo.AutoSize = true;
            chkProductoActivo.Checked = true;
            chkProductoActivo.CheckState = CheckState.Checked;
            chkProductoActivo.Location = new Point(20, 191);
            chkProductoActivo.Name = "chkProductoActivo";
            chkProductoActivo.Size = new Size(137, 24);
            chkProductoActivo.TabIndex = 8;
            chkProductoActivo.Text = "Producto Activo";
            chkProductoActivo.UseVisualStyleBackColor = true;
            // 
            // lblNombre
            // 
            lblNombre.Location = new Point(20, 30);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(100, 23);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(120, 27);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(260, 27);
            txtNombreProducto.TabIndex = 1;
            // 
            // lblDescripcion
            // 
            lblDescripcion.Location = new Point(20, 70);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(100, 23);
            lblDescripcion.TabIndex = 2;
            lblDescripcion.Text = "Descripción:";
            // 
            // txtDescripcionProducto
            // 
            txtDescripcionProducto.Location = new Point(120, 67);
            txtDescripcionProducto.Name = "txtDescripcionProducto";
            txtDescripcionProducto.Size = new Size(260, 27);
            txtDescripcionProducto.TabIndex = 3;
            // 
            // lblStock
            // 
            lblStock.Location = new Point(20, 110);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(100, 23);
            lblStock.TabIndex = 4;
            lblStock.Text = "Stock:";
            // 
            // numStockProducto
            // 
            numStockProducto.Location = new Point(120, 107);
            numStockProducto.Name = "numStockProducto";
            numStockProducto.Size = new Size(120, 27);
            numStockProducto.TabIndex = 5;
            // 
            // lblPrecio
            // 
            lblPrecio.Location = new Point(20, 150);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(100, 23);
            lblPrecio.TabIndex = 6;
            lblPrecio.Text = "Precio:";
            // 
            // numPrecioProducto
            // 
            numPrecioProducto.DecimalPlaces = 2;
            numPrecioProducto.Location = new Point(120, 147);
            numPrecioProducto.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numPrecioProducto.Name = "numPrecioProducto";
            numPrecioProducto.Size = new Size(120, 27);
            numPrecioProducto.TabIndex = 7;
            // 
            // btnGuardarProducto
            // 
            btnGuardarProducto.BackColor = Color.FromArgb(10, 18, 80);
            btnGuardarProducto.FlatStyle = FlatStyle.Flat;
            btnGuardarProducto.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnGuardarProducto.ForeColor = Color.White;
            btnGuardarProducto.Location = new Point(421, 369);
            btnGuardarProducto.Name = "btnGuardarProducto";
            btnGuardarProducto.Size = new Size(190, 40);
            btnGuardarProducto.TabIndex = 2;
            btnGuardarProducto.Text = "Guardar";
            btnGuardarProducto.UseVisualStyleBackColor = false;
            btnGuardarProducto.Click += btnGuardarProducto_Click;
            // 
            // btnEliminarProducto
            // 
            btnEliminarProducto.BackColor = Color.Red;
            btnEliminarProducto.FlatStyle = FlatStyle.Flat;
            btnEliminarProducto.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEliminarProducto.ForeColor = Color.White;
            btnEliminarProducto.Location = new Point(421, 481);
            btnEliminarProducto.Name = "btnEliminarProducto";
            btnEliminarProducto.Size = new Size(190, 40);
            btnEliminarProducto.TabIndex = 3;
            btnEliminarProducto.Text = "Eliminar";
            btnEliminarProducto.UseVisualStyleBackColor = false;
            btnEliminarProducto.Click += btnEliminarProducto_Click;
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AllowUserToDeleteRows = false;
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductos.ColumnHeadersHeight = 29;
            dgvProductos.Location = new Point(18, 35);
            dgvProductos.MultiSelect = false;
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.Size = new Size(616, 254);
            dgvProductos.TabIndex = 4;
            dgvProductos.SelectionChanged += dgvProductos_SelectionChanged;
            // 
            // lblAlerta
            // 
            lblAlerta.AutoSize = true;
            lblAlerta.Location = new Point(12, 617);
            lblAlerta.Name = "lblAlerta";
            lblAlerta.Size = new Size(123, 20);
            lblAlerta.TabIndex = 5;
            lblAlerta.Text = "Alerta Bajo Stock";
            lblAlerta.Click += lblAlerta_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnNuevoProducto);
            groupBox1.Controls.Add(btnModificarProducto);
            groupBox1.Controls.Add(dgvProductos);
            groupBox1.Controls.Add(btnGuardarProducto);
            groupBox1.Controls.Add(btnEliminarProducto);
            groupBox1.Controls.Add(grpDatos);
            groupBox1.Location = new Point(12, 66);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(648, 535);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Productos";
            // 
            // btnNuevoProducto
            // 
            btnNuevoProducto.BackColor = Color.FromArgb(10, 18, 80);
            btnNuevoProducto.FlatStyle = FlatStyle.Flat;
            btnNuevoProducto.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnNuevoProducto.ForeColor = Color.White;
            btnNuevoProducto.Location = new Point(421, 311);
            btnNuevoProducto.Name = "btnNuevoProducto";
            btnNuevoProducto.Size = new Size(190, 40);
            btnNuevoProducto.TabIndex = 7;
            btnNuevoProducto.Text = "Nuevo";
            btnNuevoProducto.UseVisualStyleBackColor = false;
            btnNuevoProducto.Click += btnNuevoProducto_Click;
            // 
            // btnModificarProducto
            // 
            btnModificarProducto.BackColor = Color.FromArgb(10, 18, 80);
            btnModificarProducto.FlatStyle = FlatStyle.Flat;
            btnModificarProducto.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnModificarProducto.ForeColor = Color.White;
            btnModificarProducto.Location = new Point(421, 425);
            btnModificarProducto.Name = "btnModificarProducto";
            btnModificarProducto.Size = new Size(190, 40);
            btnModificarProducto.TabIndex = 6;
            btnModificarProducto.Text = "Modificar";
            btnModificarProducto.UseVisualStyleBackColor = false;
            btnModificarProducto.Click += btnModificarProducto_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnNuevoProveedor);
            groupBox2.Controls.Add(btnModificarProveedor);
            groupBox2.Controls.Add(dgvProveedor);
            groupBox2.Controls.Add(btnEliminarProveedor);
            groupBox2.Controls.Add(btnGuardarProveedor);
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Location = new Point(669, 66);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(648, 535);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Proveedores";
            // 
            // btnNuevoProveedor
            // 
            btnNuevoProveedor.BackColor = Color.FromArgb(10, 18, 80);
            btnNuevoProveedor.FlatStyle = FlatStyle.Flat;
            btnNuevoProveedor.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnNuevoProveedor.ForeColor = Color.White;
            btnNuevoProveedor.Location = new Point(421, 315);
            btnNuevoProveedor.Name = "btnNuevoProveedor";
            btnNuevoProveedor.Size = new Size(190, 40);
            btnNuevoProveedor.TabIndex = 8;
            btnNuevoProveedor.Text = "Nuevo";
            btnNuevoProveedor.UseVisualStyleBackColor = false;
            btnNuevoProveedor.Click += btnNuevoProveedor_Click;
            // 
            // btnModificarProveedor
            // 
            btnModificarProveedor.BackColor = Color.FromArgb(10, 18, 80);
            btnModificarProveedor.FlatStyle = FlatStyle.Flat;
            btnModificarProveedor.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnModificarProveedor.ForeColor = Color.White;
            btnModificarProveedor.Location = new Point(421, 425);
            btnModificarProveedor.Name = "btnModificarProveedor";
            btnModificarProveedor.Size = new Size(190, 40);
            btnModificarProveedor.TabIndex = 7;
            btnModificarProveedor.Text = "Modificar";
            btnModificarProveedor.UseVisualStyleBackColor = false;
            btnModificarProveedor.Click += btnModificarProveedor_Click;
            // 
            // dgvProveedor
            // 
            dgvProveedor.AllowUserToAddRows = false;
            dgvProveedor.AllowUserToDeleteRows = false;
            dgvProveedor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProveedor.ColumnHeadersHeight = 29;
            dgvProveedor.Location = new Point(18, 35);
            dgvProveedor.MultiSelect = false;
            dgvProveedor.Name = "dgvProveedor";
            dgvProveedor.ReadOnly = true;
            dgvProveedor.RowHeadersWidth = 51;
            dgvProveedor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProveedor.Size = new Size(616, 254);
            dgvProveedor.TabIndex = 4;
            dgvProveedor.SelectionChanged += dgvProveedor_SelectionChanged;
            // 
            // btnEliminarProveedor
            // 
            btnEliminarProveedor.BackColor = Color.Red;
            btnEliminarProveedor.FlatStyle = FlatStyle.Flat;
            btnEliminarProveedor.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEliminarProveedor.ForeColor = Color.White;
            btnEliminarProveedor.Location = new Point(421, 484);
            btnEliminarProveedor.Name = "btnEliminarProveedor";
            btnEliminarProveedor.Size = new Size(190, 40);
            btnEliminarProveedor.TabIndex = 3;
            btnEliminarProveedor.Text = "Eliminar";
            btnEliminarProveedor.UseVisualStyleBackColor = false;
            btnEliminarProveedor.Click += btnEliminarProveedor_Click;
            // 
            // btnGuardarProveedor
            // 
            btnGuardarProveedor.BackColor = Color.FromArgb(10, 18, 80);
            btnGuardarProveedor.FlatStyle = FlatStyle.Flat;
            btnGuardarProveedor.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnGuardarProveedor.ForeColor = Color.White;
            btnGuardarProveedor.Location = new Point(421, 369);
            btnGuardarProveedor.Name = "btnGuardarProveedor";
            btnGuardarProveedor.Size = new Size(190, 40);
            btnGuardarProveedor.TabIndex = 2;
            btnGuardarProveedor.Text = "Guardar";
            btnGuardarProveedor.UseVisualStyleBackColor = false;
            btnGuardarProveedor.Click += btnGuardarProveedor_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(chkProveedorActivo);
            groupBox3.Controls.Add(txtEmailProveedor);
            groupBox3.Controls.Add(txtDireccionProveedor);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(txtRazonSocial);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(txtCuit);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label5);
            groupBox3.Location = new Point(18, 302);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(397, 225);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Datos del Proveedor";
            // 
            // chkProveedorActivo
            // 
            chkProveedorActivo.AutoSize = true;
            chkProveedorActivo.Checked = true;
            chkProveedorActivo.CheckState = CheckState.Checked;
            chkProveedorActivo.Location = new Point(20, 191);
            chkProveedorActivo.Name = "chkProveedorActivo";
            chkProveedorActivo.Size = new Size(145, 24);
            chkProveedorActivo.TabIndex = 9;
            chkProveedorActivo.Text = "Proveedor Activo";
            chkProveedorActivo.UseVisualStyleBackColor = true;
            // 
            // txtEmailProveedor
            // 
            txtEmailProveedor.Location = new Point(120, 150);
            txtEmailProveedor.Name = "txtEmailProveedor";
            txtEmailProveedor.Size = new Size(260, 27);
            txtEmailProveedor.TabIndex = 8;
            // 
            // txtDireccionProveedor
            // 
            txtDireccionProveedor.Location = new Point(120, 110);
            txtDireccionProveedor.Name = "txtDireccionProveedor";
            txtDireccionProveedor.Size = new Size(260, 27);
            txtDireccionProveedor.TabIndex = 7;
            // 
            // label2
            // 
            label2.Location = new Point(20, 30);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 0;
            label2.Text = "Razon Social:";
            // 
            // txtRazonSocial
            // 
            txtRazonSocial.Location = new Point(120, 27);
            txtRazonSocial.Name = "txtRazonSocial";
            txtRazonSocial.Size = new Size(260, 27);
            txtRazonSocial.TabIndex = 1;
            // 
            // label3
            // 
            label3.Location = new Point(20, 70);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 2;
            label3.Text = "CUIT:";
            // 
            // txtCuit
            // 
            txtCuit.Location = new Point(120, 67);
            txtCuit.Name = "txtCuit";
            txtCuit.Size = new Size(260, 27);
            txtCuit.TabIndex = 3;
            // 
            // label4
            // 
            label4.Location = new Point(20, 110);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 4;
            label4.Text = "Direccion:";
            // 
            // label5
            // 
            label5.Location = new Point(20, 150);
            label5.Name = "label5";
            label5.Size = new Size(100, 23);
            label5.TabIndex = 6;
            label5.Text = "Email:";
            // 
            // btnGenerarOrdenCompra
            // 
            btnGenerarOrdenCompra.BackColor = Color.Sienna;
            btnGenerarOrdenCompra.FlatStyle = FlatStyle.Flat;
            btnGenerarOrdenCompra.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnGenerarOrdenCompra.ForeColor = Color.White;
            btnGenerarOrdenCompra.Location = new Point(1127, 607);
            btnGenerarOrdenCompra.Name = "btnGenerarOrdenCompra";
            btnGenerarOrdenCompra.Size = new Size(190, 40);
            btnGenerarOrdenCompra.TabIndex = 7;
            btnGenerarOrdenCompra.Text = "Nueva Orden Compra";
            btnGenerarOrdenCompra.UseVisualStyleBackColor = false;
            btnGenerarOrdenCompra.Click += btnGenerarOrdenCompra_Click;
            // 
            // Fr_GestionInventario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1329, 655);
            Controls.Add(btnGenerarOrdenCompra);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(lblAlerta);
            Controls.Add(pnlTop);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Fr_GestionInventario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de Inventario";
            pnlTop.ResumeLayout(false);
            grpDatos.ResumeLayout(false);
            grpDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numStockProducto).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPrecioProducto).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProveedor).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private Panel pnlTop;
        private Label lblTitle;
        private GroupBox grpDatos;
        private Label lblNombre;
        private TextBox txtNombreProducto;
        private Label lblDescripcion;
        private TextBox txtDescripcionProducto;
        private Label lblStock;
        private NumericUpDown numStockProducto;
        private Label lblPrecio;
        private NumericUpDown numPrecioProducto;
        private Button btnGuardarProducto;
        private Button btnEliminarProducto;
        private DataGridView dgvProductos;

        #endregion

        private Label lblAlerta;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView dgvProveedor;
        private Button btnEliminarProveedor;
        private Button btnGuardarProveedor;
        private GroupBox groupBox3;
        private Label label2;
        private TextBox txtRazonSocial;
        private Label label3;
        private TextBox txtCuit;
        private Label label4;
        private Label label5;
        private CheckBox chkProductoActivo;
        private CheckBox chkProveedorActivo;
        private TextBox txtEmailProveedor;
        private TextBox txtDireccionProveedor;
        private Button btnModificarProducto;
        private Button btnModificarProveedor;
        private Button btnGenerarOrdenCompra;
        private Button btnNuevoProducto;
        private Button btnNuevoProveedor;
    }
}