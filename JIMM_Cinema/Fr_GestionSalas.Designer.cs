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
            pnlTop = new Panel();
            lblTitle = new Label();
            grpDatos = new GroupBox();
            chk3D = new CheckBox();
            numCapacidad = new NumericUpDown();
            txtNombreSala = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnGuardarSala = new Button();
            btnEliminarSala = new Button();
            dgvSalas = new DataGridView();
            label3 = new Label();
            groupBox1 = new GroupBox();
            numButacasPorFila = new NumericUpDown();
            numFilas = new NumericUpDown();
            label4 = new Label();
            btnModificarSala = new Button();
            btnNuevaSala = new Button();
            pnlTop.SuspendLayout();
            grpDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numCapacidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSalas).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numButacasPorFila).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numFilas).BeginInit();
            SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.FromArgb(10, 18, 80);
            pnlTop.Controls.Add(lblTitle);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(1115, 60);
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
            lblTitle.Size = new Size(1115, 60);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "GESTION DE SALAS";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // grpDatos
            // 
            grpDatos.Controls.Add(chk3D);
            grpDatos.Controls.Add(numCapacidad);
            grpDatos.Controls.Add(txtNombreSala);
            grpDatos.Controls.Add(label2);
            grpDatos.Controls.Add(label1);
            grpDatos.Location = new Point(12, 70);
            grpDatos.Name = "grpDatos";
            grpDatos.Size = new Size(438, 160);
            grpDatos.TabIndex = 1;
            grpDatos.TabStop = false;
            grpDatos.Text = "Datos de la Sala";
            // 
            // chk3D
            // 
            chk3D.AutoSize = true;
            chk3D.Location = new Point(6, 118);
            chk3D.Name = "chk3D";
            chk3D.Size = new Size(50, 24);
            chk3D.TabIndex = 4;
            chk3D.Text = "3D";
            chk3D.UseVisualStyleBackColor = true;
            // 
            // numCapacidad
            // 
            numCapacidad.Location = new Point(113, 69);
            numCapacidad.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            numCapacidad.Name = "numCapacidad";
            numCapacidad.Size = new Size(150, 27);
            numCapacidad.TabIndex = 3;
            // 
            // txtNombreSala
            // 
            txtNombreSala.Location = new Point(113, 30);
            txtNombreSala.Name = "txtNombreSala";
            txtNombreSala.Size = new Size(269, 27);
            txtNombreSala.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 76);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 1;
            label2.Text = "Capacidad";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 37);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // btnGuardarSala
            // 
            btnGuardarSala.BackColor = Color.Sienna;
            btnGuardarSala.FlatStyle = FlatStyle.Flat;
            btnGuardarSala.ForeColor = Color.White;
            btnGuardarSala.Location = new Point(125, 350);
            btnGuardarSala.Name = "btnGuardarSala";
            btnGuardarSala.Size = new Size(88, 40);
            btnGuardarSala.TabIndex = 3;
            btnGuardarSala.Text = "Guardar";
            btnGuardarSala.UseVisualStyleBackColor = false;
            btnGuardarSala.Click += btnGuardarSala_Click;
            // 
            // btnEliminarSala
            // 
            btnEliminarSala.BackColor = Color.Red;
            btnEliminarSala.FlatStyle = FlatStyle.Flat;
            btnEliminarSala.ForeColor = Color.White;
            btnEliminarSala.Location = new Point(366, 350);
            btnEliminarSala.Name = "btnEliminarSala";
            btnEliminarSala.Size = new Size(84, 40);
            btnEliminarSala.TabIndex = 4;
            btnEliminarSala.Text = "Eliminar";
            btnEliminarSala.UseVisualStyleBackColor = false;
            btnEliminarSala.Click += btnEliminarSala_Click;
            // 
            // dgvSalas
            // 
            dgvSalas.AllowUserToAddRows = false;
            dgvSalas.AllowUserToDeleteRows = false;
            dgvSalas.ColumnHeadersHeight = 29;
            dgvSalas.Location = new Point(465, 70);
            dgvSalas.MultiSelect = false;
            dgvSalas.Name = "dgvSalas";
            dgvSalas.ReadOnly = true;
            dgvSalas.RowHeadersWidth = 51;
            dgvSalas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSalas.Size = new Size(638, 456);
            dgvSalas.TabIndex = 5;
            dgvSalas.SelectionChanged += dgvSalas_SelectionChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 34);
            label3.Name = "label3";
            label3.Size = new Size(96, 20);
            label3.TabIndex = 2;
            label3.Text = "Numero Filas";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(numButacasPorFila);
            groupBox1.Controls.Add(numFilas);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(12, 236);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(438, 108);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Butacas";
            // 
            // numButacasPorFila
            // 
            numButacasPorFila.Location = new Point(187, 64);
            numButacasPorFila.Name = "numButacasPorFila";
            numButacasPorFila.Size = new Size(150, 27);
            numButacasPorFila.TabIndex = 5;
            // 
            // numFilas
            // 
            numFilas.Location = new Point(187, 26);
            numFilas.Name = "numFilas";
            numFilas.Size = new Size(150, 27);
            numFilas.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 71);
            label4.Name = "label4";
            label4.Size = new Size(172, 20);
            label4.TabIndex = 3;
            label4.Text = "Numero Butacas por Fila";
            // 
            // btnModificarSala
            // 
            btnModificarSala.BackColor = Color.Sienna;
            btnModificarSala.FlatStyle = FlatStyle.Flat;
            btnModificarSala.ForeColor = Color.White;
            btnModificarSala.Location = new Point(238, 350);
            btnModificarSala.Name = "btnModificarSala";
            btnModificarSala.Size = new Size(102, 40);
            btnModificarSala.TabIndex = 7;
            btnModificarSala.Text = "Modificar";
            btnModificarSala.UseVisualStyleBackColor = false;
            btnModificarSala.Click += btnModificar_Click;
            // 
            // btnNuevaSala
            // 
            btnNuevaSala.BackColor = Color.Sienna;
            btnNuevaSala.FlatStyle = FlatStyle.Flat;
            btnNuevaSala.ForeColor = Color.White;
            btnNuevaSala.Location = new Point(12, 350);
            btnNuevaSala.Name = "btnNuevaSala";
            btnNuevaSala.Size = new Size(88, 40);
            btnNuevaSala.TabIndex = 8;
            btnNuevaSala.Text = "Nueva";
            btnNuevaSala.UseVisualStyleBackColor = false;
            btnNuevaSala.Click += btnNuevaSala_Click;
            // 
            // Fr_GestionSalas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1115, 538);
            Controls.Add(btnNuevaSala);
            Controls.Add(btnModificarSala);
            Controls.Add(groupBox1);
            Controls.Add(pnlTop);
            Controls.Add(grpDatos);
            Controls.Add(btnGuardarSala);
            Controls.Add(btnEliminarSala);
            Controls.Add(dgvSalas);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Fr_GestionSalas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de Salas";
            pnlTop.ResumeLayout(false);
            grpDatos.ResumeLayout(false);
            grpDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numCapacidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSalas).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numButacasPorFila).EndInit();
            ((System.ComponentModel.ISupportInitialize)numFilas).EndInit();
            ResumeLayout(false);
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