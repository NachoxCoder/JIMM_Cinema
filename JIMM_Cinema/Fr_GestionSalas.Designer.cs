using System.Drawing;
using System.Windows.Forms;

namespace UI
{
    partial class Fr_GestionSalas
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
            this.chk3D = new System.Windows.Forms.CheckBox();
            this.numCapacidad = new System.Windows.Forms.NumericUpDown();
            this.txtNombreSala = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuardarSala = new System.Windows.Forms.Button();
            this.btnEliminarSala = new System.Windows.Forms.Button();
            this.dgvSalas = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numButacasPorFila = new System.Windows.Forms.NumericUpDown();
            this.numFilas = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.btnModificarSala = new System.Windows.Forms.Button();
            this.btnNuevaSala = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            this.grpDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCapacidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalas)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numButacasPorFila)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFilas)).BeginInit();
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
            this.pnlTop.Size = new System.Drawing.Size(1115, 48);
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
            this.lblTitle.Size = new System.Drawing.Size(1115, 48);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "GESTION DE SALAS";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpDatos
            // 
            this.grpDatos.Controls.Add(this.chk3D);
            this.grpDatos.Controls.Add(this.numCapacidad);
            this.grpDatos.Controls.Add(this.txtNombreSala);
            this.grpDatos.Controls.Add(this.label2);
            this.grpDatos.Controls.Add(this.label1);
            this.grpDatos.Location = new System.Drawing.Point(12, 56);
            this.grpDatos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDatos.Size = new System.Drawing.Size(438, 128);
            this.grpDatos.TabIndex = 1;
            this.grpDatos.TabStop = false;
            this.grpDatos.Text = "Datos de la Sala";
            // 
            // chk3D
            // 
            this.chk3D.AutoSize = true;
            this.chk3D.Location = new System.Drawing.Point(6, 94);
            this.chk3D.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chk3D.Name = "chk3D";
            this.chk3D.Size = new System.Drawing.Size(46, 20);
            this.chk3D.TabIndex = 4;
            this.chk3D.Text = "3D";
            this.chk3D.UseVisualStyleBackColor = true;
            // 
            // numCapacidad
            // 
            this.numCapacidad.Location = new System.Drawing.Point(113, 55);
            this.numCapacidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numCapacidad.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numCapacidad.Name = "numCapacidad";
            this.numCapacidad.Size = new System.Drawing.Size(150, 22);
            this.numCapacidad.TabIndex = 3;
            // 
            // txtNombreSala
            // 
            this.txtNombreSala.Location = new System.Drawing.Point(113, 24);
            this.txtNombreSala.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombreSala.Name = "txtNombreSala";
            this.txtNombreSala.Size = new System.Drawing.Size(269, 22);
            this.txtNombreSala.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Capacidad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // btnGuardarSala
            // 
            this.btnGuardarSala.BackColor = System.Drawing.Color.Sienna;
            this.btnGuardarSala.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarSala.ForeColor = System.Drawing.Color.White;
            this.btnGuardarSala.Location = new System.Drawing.Point(125, 280);
            this.btnGuardarSala.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardarSala.Name = "btnGuardarSala";
            this.btnGuardarSala.Size = new System.Drawing.Size(88, 32);
            this.btnGuardarSala.TabIndex = 3;
            this.btnGuardarSala.Text = "Guardar";
            this.btnGuardarSala.UseVisualStyleBackColor = false;
            this.btnGuardarSala.Click += new System.EventHandler(this.btnGuardarSala_Click);
            // 
            // btnEliminarSala
            // 
            this.btnEliminarSala.BackColor = System.Drawing.Color.Red;
            this.btnEliminarSala.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarSala.ForeColor = System.Drawing.Color.White;
            this.btnEliminarSala.Location = new System.Drawing.Point(366, 280);
            this.btnEliminarSala.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarSala.Name = "btnEliminarSala";
            this.btnEliminarSala.Size = new System.Drawing.Size(84, 32);
            this.btnEliminarSala.TabIndex = 4;
            this.btnEliminarSala.Text = "Eliminar";
            this.btnEliminarSala.UseVisualStyleBackColor = false;
            this.btnEliminarSala.Click += new System.EventHandler(this.btnEliminarSala_Click);
            // 
            // dgvSalas
            // 
            this.dgvSalas.AllowUserToAddRows = false;
            this.dgvSalas.AllowUserToDeleteRows = false;
            this.dgvSalas.ColumnHeadersHeight = 29;
            this.dgvSalas.Location = new System.Drawing.Point(465, 56);
            this.dgvSalas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvSalas.MultiSelect = false;
            this.dgvSalas.Name = "dgvSalas";
            this.dgvSalas.ReadOnly = true;
            this.dgvSalas.RowHeadersWidth = 51;
            this.dgvSalas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSalas.Size = new System.Drawing.Size(638, 365);
            this.dgvSalas.TabIndex = 5;
            this.dgvSalas.SelectionChanged += new System.EventHandler(this.dgvSalas_SelectionChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Numero Filas";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numButacasPorFila);
            this.groupBox1.Controls.Add(this.numFilas);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 189);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(438, 86);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Butacas";
            // 
            // numButacasPorFila
            // 
            this.numButacasPorFila.Location = new System.Drawing.Point(187, 51);
            this.numButacasPorFila.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numButacasPorFila.Name = "numButacasPorFila";
            this.numButacasPorFila.Size = new System.Drawing.Size(150, 22);
            this.numButacasPorFila.TabIndex = 5;
            // 
            // numFilas
            // 
            this.numFilas.Location = new System.Drawing.Point(187, 21);
            this.numFilas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numFilas.Name = "numFilas";
            this.numFilas.Size = new System.Drawing.Size(150, 22);
            this.numFilas.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Numero Butacas por Fila";
            // 
            // btnModificarSala
            // 
            this.btnModificarSala.BackColor = System.Drawing.Color.Sienna;
            this.btnModificarSala.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarSala.ForeColor = System.Drawing.Color.White;
            this.btnModificarSala.Location = new System.Drawing.Point(238, 280);
            this.btnModificarSala.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificarSala.Name = "btnModificarSala";
            this.btnModificarSala.Size = new System.Drawing.Size(102, 32);
            this.btnModificarSala.TabIndex = 7;
            this.btnModificarSala.Text = "Modificar";
            this.btnModificarSala.UseVisualStyleBackColor = false;
            this.btnModificarSala.Click += new System.EventHandler(this.btnModificarSala_Click);
            // 
            // btnNuevaSala
            // 
            this.btnNuevaSala.BackColor = System.Drawing.Color.Sienna;
            this.btnNuevaSala.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaSala.ForeColor = System.Drawing.Color.White;
            this.btnNuevaSala.Location = new System.Drawing.Point(12, 280);
            this.btnNuevaSala.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNuevaSala.Name = "btnNuevaSala";
            this.btnNuevaSala.Size = new System.Drawing.Size(88, 32);
            this.btnNuevaSala.TabIndex = 8;
            this.btnNuevaSala.Text = "Nueva";
            this.btnNuevaSala.UseVisualStyleBackColor = false;
            this.btnNuevaSala.Click += new System.EventHandler(this.btnNuevaSala_Click);
            // 
            // Fr_GestionSalas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 430);
            this.Controls.Add(this.btnNuevaSala);
            this.Controls.Add(this.btnModificarSala);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.grpDatos);
            this.Controls.Add(this.btnGuardarSala);
            this.Controls.Add(this.btnEliminarSala);
            this.Controls.Add(this.dgvSalas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Fr_GestionSalas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Salas";
            this.pnlTop.ResumeLayout(false);
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCapacidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numButacasPorFila)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFilas)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.Button btnGuardarSala;
        private System.Windows.Forms.Button btnEliminarSala;
        private System.Windows.Forms.DataGridView dgvSalas;
        #endregion

        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtNombreSala;
        private GroupBox groupBox1;
        private Label label4;
        private CheckBox chk3D;
        private NumericUpDown numCapacidad;
        private NumericUpDown numButacasPorFila;
        private NumericUpDown numFilas;
        private Button btnModificarSala;
        private Button btnNuevaSala;
    }
}