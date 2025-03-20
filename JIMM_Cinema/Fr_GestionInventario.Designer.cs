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
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.chkProductoActivo = new System.Windows.Forms.CheckBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcionProducto = new System.Windows.Forms.TextBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.numStockProducto = new System.Windows.Forms.NumericUpDown();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.numPrecioProducto = new System.Windows.Forms.NumericUpDown();
            this.btnGuardarProducto = new System.Windows.Forms.Button();
            this.btnEliminarProducto = new System.Windows.Forms.Button();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.lblAlerta = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNuevoProducto = new System.Windows.Forms.Button();
            this.btnModificarProducto = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnNuevoProveedor = new System.Windows.Forms.Button();
            this.btnModificarProveedor = new System.Windows.Forms.Button();
            this.dgvProveedor = new System.Windows.Forms.DataGridView();
            this.btnEliminarProveedor = new System.Windows.Forms.Button();
            this.btnGuardarProveedor = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkProveedorActivo = new System.Windows.Forms.CheckBox();
            this.txtEmailProveedor = new System.Windows.Forms.TextBox();
            this.txtDireccionProveedor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCuit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGenerarOrdenCompra = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            this.grpDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStockProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedor)).BeginInit();
            this.groupBox3.SuspendLayout();
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
            this.pnlTop.Size = new System.Drawing.Size(1329, 48);
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
            this.lblTitle.Size = new System.Drawing.Size(1329, 48);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "GESTIÓN DE INVENTARIO";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpDatos
            // 
            this.grpDatos.Controls.Add(this.chkProductoActivo);
            this.grpDatos.Controls.Add(this.lblNombre);
            this.grpDatos.Controls.Add(this.txtNombreProducto);
            this.grpDatos.Controls.Add(this.lblDescripcion);
            this.grpDatos.Controls.Add(this.txtDescripcionProducto);
            this.grpDatos.Controls.Add(this.lblStock);
            this.grpDatos.Controls.Add(this.numStockProducto);
            this.grpDatos.Controls.Add(this.lblPrecio);
            this.grpDatos.Controls.Add(this.numPrecioProducto);
            this.grpDatos.Location = new System.Drawing.Point(18, 242);
            this.grpDatos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDatos.Size = new System.Drawing.Size(397, 180);
            this.grpDatos.TabIndex = 1;
            this.grpDatos.TabStop = false;
            this.grpDatos.Text = "Datos del Producto";
            // 
            // chkProductoActivo
            // 
            this.chkProductoActivo.AutoSize = true;
            this.chkProductoActivo.Checked = true;
            this.chkProductoActivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkProductoActivo.Location = new System.Drawing.Point(20, 153);
            this.chkProductoActivo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkProductoActivo.Name = "chkProductoActivo";
            this.chkProductoActivo.Size = new System.Drawing.Size(123, 20);
            this.chkProductoActivo.TabIndex = 8;
            this.chkProductoActivo.Text = "Producto Activo";
            this.chkProductoActivo.UseVisualStyleBackColor = true;
            // 
            // lblNombre
            // 
            this.lblNombre.Location = new System.Drawing.Point(20, 24);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(100, 18);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(120, 22);
            this.txtNombreProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(260, 22);
            this.txtNombreProducto.TabIndex = 1;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Location = new System.Drawing.Point(20, 56);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(100, 18);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // txtDescripcionProducto
            // 
            this.txtDescripcionProducto.Location = new System.Drawing.Point(120, 54);
            this.txtDescripcionProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescripcionProducto.Name = "txtDescripcionProducto";
            this.txtDescripcionProducto.Size = new System.Drawing.Size(260, 22);
            this.txtDescripcionProducto.TabIndex = 3;
            // 
            // lblStock
            // 
            this.lblStock.Location = new System.Drawing.Point(20, 88);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(100, 18);
            this.lblStock.TabIndex = 4;
            this.lblStock.Text = "Stock:";
            // 
            // numStockProducto
            // 
            this.numStockProducto.Location = new System.Drawing.Point(120, 86);
            this.numStockProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numStockProducto.Name = "numStockProducto";
            this.numStockProducto.Size = new System.Drawing.Size(120, 22);
            this.numStockProducto.TabIndex = 5;
            // 
            // lblPrecio
            // 
            this.lblPrecio.Location = new System.Drawing.Point(20, 120);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(100, 18);
            this.lblPrecio.TabIndex = 6;
            this.lblPrecio.Text = "Precio:";
            // 
            // numPrecioProducto
            // 
            this.numPrecioProducto.DecimalPlaces = 2;
            this.numPrecioProducto.Location = new System.Drawing.Point(120, 118);
            this.numPrecioProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numPrecioProducto.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numPrecioProducto.Name = "numPrecioProducto";
            this.numPrecioProducto.Size = new System.Drawing.Size(120, 22);
            this.numPrecioProducto.TabIndex = 7;
            // 
            // btnGuardarProducto
            // 
            this.btnGuardarProducto.BackColor = System.Drawing.Color.Sienna;
            this.btnGuardarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarProducto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnGuardarProducto.ForeColor = System.Drawing.Color.White;
            this.btnGuardarProducto.Location = new System.Drawing.Point(421, 295);
            this.btnGuardarProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardarProducto.Name = "btnGuardarProducto";
            this.btnGuardarProducto.Size = new System.Drawing.Size(190, 32);
            this.btnGuardarProducto.TabIndex = 2;
            this.btnGuardarProducto.Text = "Guardar";
            this.btnGuardarProducto.UseVisualStyleBackColor = false;
            this.btnGuardarProducto.Click += new System.EventHandler(this.btnGuardarProducto_Click);
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.BackColor = System.Drawing.Color.Red;
            this.btnEliminarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarProducto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEliminarProducto.ForeColor = System.Drawing.Color.White;
            this.btnEliminarProducto.Location = new System.Drawing.Point(421, 385);
            this.btnEliminarProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(190, 32);
            this.btnEliminarProducto.TabIndex = 3;
            this.btnEliminarProducto.Text = "Eliminar";
            this.btnEliminarProducto.UseVisualStyleBackColor = false;
            this.btnEliminarProducto.Click += new System.EventHandler(this.btnEliminarProducto_Click);
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductos.ColumnHeadersHeight = 29;
            this.dgvProductos.Location = new System.Drawing.Point(18, 28);
            this.dgvProductos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvProductos.MultiSelect = false;
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.RowHeadersWidth = 51;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(616, 203);
            this.dgvProductos.TabIndex = 4;
            this.dgvProductos.SelectionChanged += new System.EventHandler(this.dgvProductos_SelectionChanged);
            // 
            // lblAlerta
            // 
            this.lblAlerta.AutoSize = true;
            this.lblAlerta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlerta.Location = new System.Drawing.Point(12, 494);
            this.lblAlerta.Name = "lblAlerta";
            this.lblAlerta.Size = new System.Drawing.Size(179, 25);
            this.lblAlerta.TabIndex = 5;
            this.lblAlerta.Text = "Alerta Bajo Stock";
            this.lblAlerta.Click += new System.EventHandler(this.lblAlerta_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNuevoProducto);
            this.groupBox1.Controls.Add(this.btnModificarProducto);
            this.groupBox1.Controls.Add(this.dgvProductos);
            this.groupBox1.Controls.Add(this.btnGuardarProducto);
            this.groupBox1.Controls.Add(this.btnEliminarProducto);
            this.groupBox1.Controls.Add(this.grpDatos);
            this.groupBox1.Location = new System.Drawing.Point(12, 53);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(648, 428);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Productos";
            // 
            // btnNuevoProducto
            // 
            this.btnNuevoProducto.BackColor = System.Drawing.Color.Sienna;
            this.btnNuevoProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoProducto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnNuevoProducto.ForeColor = System.Drawing.Color.White;
            this.btnNuevoProducto.Location = new System.Drawing.Point(421, 249);
            this.btnNuevoProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNuevoProducto.Name = "btnNuevoProducto";
            this.btnNuevoProducto.Size = new System.Drawing.Size(190, 32);
            this.btnNuevoProducto.TabIndex = 7;
            this.btnNuevoProducto.Text = "Nuevo";
            this.btnNuevoProducto.UseVisualStyleBackColor = false;
            this.btnNuevoProducto.Click += new System.EventHandler(this.btnNuevoProducto_Click);
            // 
            // btnModificarProducto
            // 
            this.btnModificarProducto.BackColor = System.Drawing.Color.Sienna;
            this.btnModificarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarProducto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnModificarProducto.ForeColor = System.Drawing.Color.White;
            this.btnModificarProducto.Location = new System.Drawing.Point(421, 340);
            this.btnModificarProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificarProducto.Name = "btnModificarProducto";
            this.btnModificarProducto.Size = new System.Drawing.Size(190, 32);
            this.btnModificarProducto.TabIndex = 6;
            this.btnModificarProducto.Text = "Modificar";
            this.btnModificarProducto.UseVisualStyleBackColor = false;
            this.btnModificarProducto.Click += new System.EventHandler(this.btnModificarProducto_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnNuevoProveedor);
            this.groupBox2.Controls.Add(this.btnModificarProveedor);
            this.groupBox2.Controls.Add(this.dgvProveedor);
            this.groupBox2.Controls.Add(this.btnEliminarProveedor);
            this.groupBox2.Controls.Add(this.btnGuardarProveedor);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(669, 53);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(648, 428);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Proveedores";
            // 
            // btnNuevoProveedor
            // 
            this.btnNuevoProveedor.BackColor = System.Drawing.Color.Sienna;
            this.btnNuevoProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoProveedor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnNuevoProveedor.ForeColor = System.Drawing.Color.White;
            this.btnNuevoProveedor.Location = new System.Drawing.Point(421, 252);
            this.btnNuevoProveedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNuevoProveedor.Name = "btnNuevoProveedor";
            this.btnNuevoProveedor.Size = new System.Drawing.Size(190, 32);
            this.btnNuevoProveedor.TabIndex = 8;
            this.btnNuevoProveedor.Text = "Nuevo";
            this.btnNuevoProveedor.UseVisualStyleBackColor = false;
            this.btnNuevoProveedor.Click += new System.EventHandler(this.btnNuevoProveedor_Click);
            // 
            // btnModificarProveedor
            // 
            this.btnModificarProveedor.BackColor = System.Drawing.Color.Sienna;
            this.btnModificarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarProveedor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnModificarProveedor.ForeColor = System.Drawing.Color.White;
            this.btnModificarProveedor.Location = new System.Drawing.Point(421, 340);
            this.btnModificarProveedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificarProveedor.Name = "btnModificarProveedor";
            this.btnModificarProveedor.Size = new System.Drawing.Size(190, 32);
            this.btnModificarProveedor.TabIndex = 7;
            this.btnModificarProveedor.Text = "Modificar";
            this.btnModificarProveedor.UseVisualStyleBackColor = false;
            this.btnModificarProveedor.Click += new System.EventHandler(this.btnModificarProveedor_Click);
            // 
            // dgvProveedor
            // 
            this.dgvProveedor.AllowUserToAddRows = false;
            this.dgvProveedor.AllowUserToDeleteRows = false;
            this.dgvProveedor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProveedor.ColumnHeadersHeight = 29;
            this.dgvProveedor.Location = new System.Drawing.Point(18, 28);
            this.dgvProveedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvProveedor.MultiSelect = false;
            this.dgvProveedor.Name = "dgvProveedor";
            this.dgvProveedor.ReadOnly = true;
            this.dgvProveedor.RowHeadersWidth = 51;
            this.dgvProveedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProveedor.Size = new System.Drawing.Size(616, 203);
            this.dgvProveedor.TabIndex = 4;
            this.dgvProveedor.SelectionChanged += new System.EventHandler(this.dgvProveedor_SelectionChanged);
            // 
            // btnEliminarProveedor
            // 
            this.btnEliminarProveedor.BackColor = System.Drawing.Color.Red;
            this.btnEliminarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarProveedor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEliminarProveedor.ForeColor = System.Drawing.Color.White;
            this.btnEliminarProveedor.Location = new System.Drawing.Point(421, 387);
            this.btnEliminarProveedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarProveedor.Name = "btnEliminarProveedor";
            this.btnEliminarProveedor.Size = new System.Drawing.Size(190, 32);
            this.btnEliminarProveedor.TabIndex = 3;
            this.btnEliminarProveedor.Text = "Eliminar";
            this.btnEliminarProveedor.UseVisualStyleBackColor = false;
            this.btnEliminarProveedor.Click += new System.EventHandler(this.btnEliminarProveedor_Click);
            // 
            // btnGuardarProveedor
            // 
            this.btnGuardarProveedor.BackColor = System.Drawing.Color.Sienna;
            this.btnGuardarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarProveedor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnGuardarProveedor.ForeColor = System.Drawing.Color.White;
            this.btnGuardarProveedor.Location = new System.Drawing.Point(421, 295);
            this.btnGuardarProveedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardarProveedor.Name = "btnGuardarProveedor";
            this.btnGuardarProveedor.Size = new System.Drawing.Size(190, 32);
            this.btnGuardarProveedor.TabIndex = 2;
            this.btnGuardarProveedor.Text = "Guardar";
            this.btnGuardarProveedor.UseVisualStyleBackColor = false;
            this.btnGuardarProveedor.Click += new System.EventHandler(this.btnGuardarProveedor_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkProveedorActivo);
            this.groupBox3.Controls.Add(this.txtEmailProveedor);
            this.groupBox3.Controls.Add(this.txtDireccionProveedor);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtRazonSocial);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtCuit);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(18, 242);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(397, 180);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos del Proveedor";
            // 
            // chkProveedorActivo
            // 
            this.chkProveedorActivo.AutoSize = true;
            this.chkProveedorActivo.Checked = true;
            this.chkProveedorActivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkProveedorActivo.Location = new System.Drawing.Point(20, 153);
            this.chkProveedorActivo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkProveedorActivo.Name = "chkProveedorActivo";
            this.chkProveedorActivo.Size = new System.Drawing.Size(133, 20);
            this.chkProveedorActivo.TabIndex = 9;
            this.chkProveedorActivo.Text = "Proveedor Activo";
            this.chkProveedorActivo.UseVisualStyleBackColor = true;
            // 
            // txtEmailProveedor
            // 
            this.txtEmailProveedor.Location = new System.Drawing.Point(120, 120);
            this.txtEmailProveedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmailProveedor.Name = "txtEmailProveedor";
            this.txtEmailProveedor.Size = new System.Drawing.Size(260, 22);
            this.txtEmailProveedor.TabIndex = 8;
            // 
            // txtDireccionProveedor
            // 
            this.txtDireccionProveedor.Location = new System.Drawing.Point(120, 88);
            this.txtDireccionProveedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDireccionProveedor.Name = "txtDireccionProveedor";
            this.txtDireccionProveedor.Size = new System.Drawing.Size(260, 22);
            this.txtDireccionProveedor.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(20, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Razon Social:";
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(120, 22);
            this.txtRazonSocial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(260, 22);
            this.txtRazonSocial.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(20, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "CUIT:";
            // 
            // txtCuit
            // 
            this.txtCuit.Location = new System.Drawing.Point(120, 54);
            this.txtCuit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.Size = new System.Drawing.Size(260, 22);
            this.txtCuit.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(20, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Direccion:";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(20, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Email:";
            // 
            // btnGenerarOrdenCompra
            // 
            this.btnGenerarOrdenCompra.BackColor = System.Drawing.Color.Sienna;
            this.btnGenerarOrdenCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarOrdenCompra.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnGenerarOrdenCompra.ForeColor = System.Drawing.Color.White;
            this.btnGenerarOrdenCompra.Location = new System.Drawing.Point(1127, 486);
            this.btnGenerarOrdenCompra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGenerarOrdenCompra.Name = "btnGenerarOrdenCompra";
            this.btnGenerarOrdenCompra.Size = new System.Drawing.Size(190, 32);
            this.btnGenerarOrdenCompra.TabIndex = 7;
            this.btnGenerarOrdenCompra.Text = "Nueva Orden Compra";
            this.btnGenerarOrdenCompra.UseVisualStyleBackColor = false;
            this.btnGenerarOrdenCompra.Click += new System.EventHandler(this.btnGenerarOrdenCompra_Click);
            // 
            // Fr_GestionInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 524);
            this.Controls.Add(this.btnGenerarOrdenCompra);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblAlerta);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Fr_GestionInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Inventario";
            this.pnlTop.ResumeLayout(false);
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStockProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedor)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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