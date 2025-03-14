using System.Drawing;
using System.Windows.Forms;

namespace UI
{
    partial class Fr_GestionPeliculas
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
            this.dgvPeliculas = new System.Windows.Forms.DataGridView();
            this.dgvFunciones = new System.Windows.Forms.DataGridView();
            this.btnGuardarPelicula = new System.Windows.Forms.Button();
            this.btnEliminarPelicula = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_NuevaPelicula = new System.Windows.Forms.Button();
            this.chkPeliculaActiva = new System.Windows.Forms.CheckBox();
            this.numDuracion = new System.Windows.Forms.NumericUpDown();
            this.txtSinopsis = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnModificarPelicula = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnNuevaFuncion = new System.Windows.Forms.Button();
            this.chkFuncionActiva = new System.Windows.Forms.CheckBox();
            this.dtpHoraFin = new System.Windows.Forms.DateTimePicker();
            this.dtpHoraInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.numPrecio = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbSala = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEliminarFuncion = new System.Windows.Forms.Button();
            this.btnModificarFuncion = new System.Windows.Forms.Button();
            this.btnGuardarFuncion = new System.Windows.Forms.Button();
            this.txtRating = new System.Windows.Forms.TextBox();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeliculas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunciones)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDuracion)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecio)).BeginInit();
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
            this.pnlTop.Size = new System.Drawing.Size(1357, 48);
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
            this.lblTitle.Size = new System.Drawing.Size(1357, 48);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "GESTION DE PELICULAS Y FUNCIONES";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvPeliculas
            // 
            this.dgvPeliculas.AllowUserToAddRows = false;
            this.dgvPeliculas.AllowUserToDeleteRows = false;
            this.dgvPeliculas.ColumnHeadersHeight = 29;
            this.dgvPeliculas.Location = new System.Drawing.Point(6, 21);
            this.dgvPeliculas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvPeliculas.MultiSelect = false;
            this.dgvPeliculas.Name = "dgvPeliculas";
            this.dgvPeliculas.ReadOnly = true;
            this.dgvPeliculas.RowHeadersWidth = 51;
            this.dgvPeliculas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPeliculas.Size = new System.Drawing.Size(665, 302);
            this.dgvPeliculas.TabIndex = 3;
            this.dgvPeliculas.SelectionChanged += new System.EventHandler(this.dgvPeliculas_SelectionChanged);
            // 
            // dgvFunciones
            // 
            this.dgvFunciones.AllowUserToAddRows = false;
            this.dgvFunciones.AllowUserToDeleteRows = false;
            this.dgvFunciones.ColumnHeadersHeight = 29;
            this.dgvFunciones.Location = new System.Drawing.Point(13, 21);
            this.dgvFunciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvFunciones.MultiSelect = false;
            this.dgvFunciones.Name = "dgvFunciones";
            this.dgvFunciones.ReadOnly = true;
            this.dgvFunciones.RowHeadersWidth = 51;
            this.dgvFunciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFunciones.Size = new System.Drawing.Size(623, 302);
            this.dgvFunciones.TabIndex = 4;
            this.dgvFunciones.SelectionChanged += new System.EventHandler(this.dgvFunciones_SelectionChanged);
            // 
            // btnGuardarPelicula
            // 
            this.btnGuardarPelicula.BackColor = System.Drawing.Color.Sienna;
            this.btnGuardarPelicula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarPelicula.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnGuardarPelicula.ForeColor = System.Drawing.Color.White;
            this.btnGuardarPelicula.Location = new System.Drawing.Point(166, 451);
            this.btnGuardarPelicula.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardarPelicula.Name = "btnGuardarPelicula";
            this.btnGuardarPelicula.Size = new System.Drawing.Size(151, 32);
            this.btnGuardarPelicula.TabIndex = 7;
            this.btnGuardarPelicula.Text = "Guardar Pelicula";
            this.btnGuardarPelicula.UseVisualStyleBackColor = false;
            this.btnGuardarPelicula.Click += new System.EventHandler(this.btnGuardarPelicula_Click);
            // 
            // btnEliminarPelicula
            // 
            this.btnEliminarPelicula.BackColor = System.Drawing.Color.Red;
            this.btnEliminarPelicula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarPelicula.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEliminarPelicula.ForeColor = System.Drawing.Color.White;
            this.btnEliminarPelicula.Location = new System.Drawing.Point(524, 450);
            this.btnEliminarPelicula.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarPelicula.Name = "btnEliminarPelicula";
            this.btnEliminarPelicula.Size = new System.Drawing.Size(155, 32);
            this.btnEliminarPelicula.TabIndex = 8;
            this.btnEliminarPelicula.Text = "Eliminar Pelicula";
            this.btnEliminarPelicula.UseVisualStyleBackColor = false;
            this.btnEliminarPelicula.Click += new System.EventHandler(this.btnEliminarPelicula_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_NuevaPelicula);
            this.groupBox1.Controls.Add(this.chkPeliculaActiva);
            this.groupBox1.Controls.Add(this.numDuracion);
            this.groupBox1.Controls.Add(this.txtSinopsis);
            this.groupBox1.Controls.Add(this.txtTitulo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnModificarPelicula);
            this.groupBox1.Controls.Add(this.dgvPeliculas);
            this.groupBox1.Controls.Add(this.btnEliminarPelicula);
            this.groupBox1.Controls.Add(this.btnGuardarPelicula);
            this.groupBox1.Location = new System.Drawing.Point(0, 53);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(685, 488);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Peliculas";
            // 
            // btn_NuevaPelicula
            // 
            this.btn_NuevaPelicula.BackColor = System.Drawing.Color.Sienna;
            this.btn_NuevaPelicula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NuevaPelicula.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_NuevaPelicula.ForeColor = System.Drawing.Color.White;
            this.btn_NuevaPelicula.Location = new System.Drawing.Point(12, 451);
            this.btn_NuevaPelicula.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_NuevaPelicula.Name = "btn_NuevaPelicula";
            this.btn_NuevaPelicula.Size = new System.Drawing.Size(137, 32);
            this.btn_NuevaPelicula.TabIndex = 19;
            this.btn_NuevaPelicula.Text = "Nueva Pelicula";
            this.btn_NuevaPelicula.UseVisualStyleBackColor = false;
            this.btn_NuevaPelicula.Click += new System.EventHandler(this.btn_NuevaPelicula_Click);
            // 
            // chkPeliculaActiva
            // 
            this.chkPeliculaActiva.AutoSize = true;
            this.chkPeliculaActiva.Checked = true;
            this.chkPeliculaActiva.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPeliculaActiva.Location = new System.Drawing.Point(554, 422);
            this.chkPeliculaActiva.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkPeliculaActiva.Name = "chkPeliculaActiva";
            this.chkPeliculaActiva.Size = new System.Drawing.Size(66, 20);
            this.chkPeliculaActiva.TabIndex = 18;
            this.chkPeliculaActiva.Text = "Activa";
            this.chkPeliculaActiva.UseVisualStyleBackColor = true;
            // 
            // numDuracion
            // 
            this.numDuracion.Location = new System.Drawing.Point(86, 417);
            this.numDuracion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numDuracion.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numDuracion.Name = "numDuracion";
            this.numDuracion.Size = new System.Drawing.Size(150, 22);
            this.numDuracion.TabIndex = 17;
            // 
            // txtSinopsis
            // 
            this.txtSinopsis.Location = new System.Drawing.Point(86, 359);
            this.txtSinopsis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSinopsis.Multiline = true;
            this.txtSinopsis.Name = "txtSinopsis";
            this.txtSinopsis.Size = new System.Drawing.Size(569, 54);
            this.txtSinopsis.TabIndex = 16;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(86, 333);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(569, 22);
            this.txtTitulo.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(246, 422);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Rating";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 422);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Duracion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 362);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Sinopsis";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 338);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Titulo";
            // 
            // btnModificarPelicula
            // 
            this.btnModificarPelicula.BackColor = System.Drawing.Color.Sienna;
            this.btnModificarPelicula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarPelicula.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnModificarPelicula.ForeColor = System.Drawing.Color.White;
            this.btnModificarPelicula.Location = new System.Drawing.Point(338, 451);
            this.btnModificarPelicula.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificarPelicula.Name = "btnModificarPelicula";
            this.btnModificarPelicula.Size = new System.Drawing.Size(166, 32);
            this.btnModificarPelicula.TabIndex = 9;
            this.btnModificarPelicula.Text = "Modificar Pelicula";
            this.btnModificarPelicula.UseVisualStyleBackColor = false;
            this.btnModificarPelicula.Click += new System.EventHandler(this.btnModificarPelicula_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnNuevaFuncion);
            this.groupBox2.Controls.Add(this.chkFuncionActiva);
            this.groupBox2.Controls.Add(this.dtpHoraFin);
            this.groupBox2.Controls.Add(this.dtpHoraInicio);
            this.groupBox2.Controls.Add(this.dtpFecha);
            this.groupBox2.Controls.Add(this.numPrecio);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.cmbSala);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnEliminarFuncion);
            this.groupBox2.Controls.Add(this.btnModificarFuncion);
            this.groupBox2.Controls.Add(this.btnGuardarFuncion);
            this.groupBox2.Controls.Add(this.dgvFunciones);
            this.groupBox2.Location = new System.Drawing.Point(691, 53);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(654, 488);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Funciones";
            // 
            // btnNuevaFuncion
            // 
            this.btnNuevaFuncion.BackColor = System.Drawing.Color.Sienna;
            this.btnNuevaFuncion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaFuncion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnNuevaFuncion.ForeColor = System.Drawing.Color.White;
            this.btnNuevaFuncion.Location = new System.Drawing.Point(13, 451);
            this.btnNuevaFuncion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNuevaFuncion.Name = "btnNuevaFuncion";
            this.btnNuevaFuncion.Size = new System.Drawing.Size(137, 32);
            this.btnNuevaFuncion.TabIndex = 22;
            this.btnNuevaFuncion.Text = "Nueva Funcion";
            this.btnNuevaFuncion.UseVisualStyleBackColor = false;
            this.btnNuevaFuncion.Click += new System.EventHandler(this.btnNuevaFuncion_Click);
            // 
            // chkFuncionActiva
            // 
            this.chkFuncionActiva.AutoSize = true;
            this.chkFuncionActiva.Checked = true;
            this.chkFuncionActiva.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFuncionActiva.Location = new System.Drawing.Point(564, 402);
            this.chkFuncionActiva.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkFuncionActiva.Name = "chkFuncionActiva";
            this.chkFuncionActiva.Size = new System.Drawing.Size(66, 20);
            this.chkFuncionActiva.TabIndex = 20;
            this.chkFuncionActiva.Text = "Activa";
            this.chkFuncionActiva.UseVisualStyleBackColor = true;
            // 
            // dtpHoraFin
            // 
            this.dtpHoraFin.CustomFormat = "HH:mm";
            this.dtpHoraFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHoraFin.Location = new System.Drawing.Point(532, 336);
            this.dtpHoraFin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpHoraFin.Name = "dtpHoraFin";
            this.dtpHoraFin.ShowUpDown = true;
            this.dtpHoraFin.Size = new System.Drawing.Size(85, 22);
            this.dtpHoraFin.TabIndex = 21;
            // 
            // dtpHoraInicio
            // 
            this.dtpHoraInicio.CustomFormat = "HH:mm";
            this.dtpHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHoraInicio.Location = new System.Drawing.Point(322, 336);
            this.dtpHoraInicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpHoraInicio.Name = "dtpHoraInicio";
            this.dtpHoraInicio.ShowUpDown = true;
            this.dtpHoraInicio.Size = new System.Drawing.Size(85, 22);
            this.dtpHoraInicio.TabIndex = 20;
            this.dtpHoraInicio.ValueChanged += new System.EventHandler(this.dtpHoraDesde_ValueChanged);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(66, 334);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(114, 22);
            this.dtpFecha.TabIndex = 19;
            // 
            // numPrecio
            // 
            this.numPrecio.Location = new System.Drawing.Point(366, 402);
            this.numPrecio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numPrecio.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numPrecio.Name = "numPrecio";
            this.numPrecio.Size = new System.Drawing.Size(160, 22);
            this.numPrecio.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(309, 404);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 16);
            this.label10.TabIndex = 17;
            this.label10.Text = "Precio";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 404);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "Sala";
            // 
            // cmbSala
            // 
            this.cmbSala.FormattingEnabled = true;
            this.cmbSala.Location = new System.Drawing.Point(56, 402);
            this.cmbSala.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbSala.Name = "cmbSala";
            this.cmbSala.Size = new System.Drawing.Size(218, 24);
            this.cmbSala.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(461, 341);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Hora Fin";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(234, 340);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Hora Inicio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 338);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Fecha";
            // 
            // btnEliminarFuncion
            // 
            this.btnEliminarFuncion.BackColor = System.Drawing.Color.Red;
            this.btnEliminarFuncion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarFuncion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEliminarFuncion.ForeColor = System.Drawing.Color.White;
            this.btnEliminarFuncion.Location = new System.Drawing.Point(492, 450);
            this.btnEliminarFuncion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarFuncion.Name = "btnEliminarFuncion";
            this.btnEliminarFuncion.Size = new System.Drawing.Size(156, 32);
            this.btnEliminarFuncion.TabIndex = 10;
            this.btnEliminarFuncion.Text = "Eliminar Funcion";
            this.btnEliminarFuncion.UseVisualStyleBackColor = false;
            this.btnEliminarFuncion.Click += new System.EventHandler(this.btnEliminarFuncion_Click);
            // 
            // btnModificarFuncion
            // 
            this.btnModificarFuncion.BackColor = System.Drawing.Color.Sienna;
            this.btnModificarFuncion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarFuncion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnModificarFuncion.ForeColor = System.Drawing.Color.White;
            this.btnModificarFuncion.Location = new System.Drawing.Point(319, 451);
            this.btnModificarFuncion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificarFuncion.Name = "btnModificarFuncion";
            this.btnModificarFuncion.Size = new System.Drawing.Size(167, 32);
            this.btnModificarFuncion.TabIndex = 11;
            this.btnModificarFuncion.Text = "Modificar Funcion";
            this.btnModificarFuncion.UseVisualStyleBackColor = false;
            this.btnModificarFuncion.Click += new System.EventHandler(this.btnModificarFuncion_Click);
            // 
            // btnGuardarFuncion
            // 
            this.btnGuardarFuncion.BackColor = System.Drawing.Color.Sienna;
            this.btnGuardarFuncion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarFuncion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnGuardarFuncion.ForeColor = System.Drawing.Color.White;
            this.btnGuardarFuncion.Location = new System.Drawing.Point(160, 451);
            this.btnGuardarFuncion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardarFuncion.Name = "btnGuardarFuncion";
            this.btnGuardarFuncion.Size = new System.Drawing.Size(153, 32);
            this.btnGuardarFuncion.TabIndex = 10;
            this.btnGuardarFuncion.Text = "Guardar Funcion";
            this.btnGuardarFuncion.UseVisualStyleBackColor = false;
            this.btnGuardarFuncion.Click += new System.EventHandler(this.btnGuardarFuncion_Click);
            // 
            // txtRating
            // 
            this.txtRating.Location = new System.Drawing.Point(304, 471);
            this.txtRating.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRating.Name = "txtRating";
            this.txtRating.Size = new System.Drawing.Size(200, 22);
            this.txtRating.TabIndex = 18;
            // 
            // Fr_GestionPeliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1357, 550);
            this.Controls.Add(this.txtRating);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Fr_GestionPeliculas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Películas y Funciones";
            this.pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeliculas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunciones)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDuracion)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvPeliculas;
        private System.Windows.Forms.DataGridView dgvFunciones;

        #endregion

        private Button btnGuardarPelicula;
        private Button btnEliminarPelicula;
        private GroupBox groupBox1;
        private Button btnModificarPelicula;
        private GroupBox groupBox2;
        private Button btnEliminarFuncion;
        private Button btnModificarFuncion;
        private Button btnGuardarFuncion;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label7;
        private Label label6;
        private NumericUpDown numPrecio;
        private Label label10;
        private Label label9;
        private ComboBox cmbSala;
        private Label label8;
        private CheckBox chkPeliculaActiva;
        private NumericUpDown numDuracion;
        private TextBox txtSinopsis;
        private TextBox txtTitulo;
        private TextBox txtRating;
        private DateTimePicker dtpHoraInicio;
        private DateTimePicker dtpFecha;
        private DateTimePicker dtpHoraFin;
        private Button btn_NuevaPelicula;
        private CheckBox chkFuncionActiva;
        private Button btnNuevaFuncion;
    }
}