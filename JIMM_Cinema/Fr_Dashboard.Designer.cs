﻿namespace JIMM_Cinema
{
    partial class Fr_Dashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.chartAnalisisIngresos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnMes = new System.Windows.Forms.Button();
            this.btn30Dias = new System.Windows.Forms.Button();
            this.btnSemana = new System.Windows.Forms.Button();
            this.btnHoy = new System.Windows.Forms.Button();
            this.lblBoletosVendidos = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDescargarPDF = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.lblTotalRecaudado = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.chartPeliculas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblNuevasMembresias = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.chartOcupacion = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvProductosLowStock = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.chartTotalMembresias = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartAnalisisIngresos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPeliculas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartOcupacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosLowStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTotalMembresias)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(101, 22);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(121, 22);
            this.dtpFechaDesde.TabIndex = 0;
            this.dtpFechaDesde.ValueChanged += new System.EventHandler(this.DtpFecha_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.chartAnalisisIngresos);
            this.groupBox1.Controls.Add(this.btnMes);
            this.groupBox1.Controls.Add(this.btn30Dias);
            this.groupBox1.Controls.Add(this.btnSemana);
            this.groupBox1.Controls.Add(this.btnHoy);
            this.groupBox1.Controls.Add(this.lblBoletosVendidos);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnDescargarPDF);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpFechaHasta);
            this.groupBox1.Controls.Add(this.lblTotalRecaudado);
            this.groupBox1.Controls.Add(this.dtpFechaDesde);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.chartPeliculas);
            this.groupBox1.Controls.Add(this.lblNuevasMembresias);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.chartOcupacion);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1803, 486);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fecha Reporte";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1093, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "Analisis de Ingresos";
            // 
            // chartAnalisisIngresos
            // 
            chartArea1.Name = "ChartArea1";
            this.chartAnalisisIngresos.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartAnalisisIngresos.Legends.Add(legend1);
            this.chartAnalisisIngresos.Location = new System.Drawing.Point(1096, 117);
            this.chartAnalisisIngresos.Name = "chartAnalisisIngresos";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartAnalisisIngresos.Series.Add(series1);
            this.chartAnalisisIngresos.Size = new System.Drawing.Size(699, 349);
            this.chartAnalisisIngresos.TabIndex = 20;
            this.chartAnalisisIngresos.Text = "chartAnalisisIngresos";
            // 
            // btnMes
            // 
            this.btnMes.BackColor = System.Drawing.Color.Sienna;
            this.btnMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMes.Location = new System.Drawing.Point(766, 22);
            this.btnMes.Name = "btnMes";
            this.btnMes.Size = new System.Drawing.Size(144, 39);
            this.btnMes.TabIndex = 19;
            this.btnMes.Text = "Este Mes";
            this.btnMes.UseVisualStyleBackColor = false;
            this.btnMes.Click += new System.EventHandler(this.btnMes_Click);
            // 
            // btn30Dias
            // 
            this.btn30Dias.BackColor = System.Drawing.Color.Sienna;
            this.btn30Dias.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn30Dias.Location = new System.Drawing.Point(590, 22);
            this.btn30Dias.Name = "btn30Dias";
            this.btn30Dias.Size = new System.Drawing.Size(144, 39);
            this.btn30Dias.TabIndex = 18;
            this.btn30Dias.Text = "Ultimos 30 Dias";
            this.btn30Dias.UseVisualStyleBackColor = false;
            this.btn30Dias.Click += new System.EventHandler(this.btn30Dias_Click);
            // 
            // btnSemana
            // 
            this.btnSemana.BackColor = System.Drawing.Color.Sienna;
            this.btnSemana.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSemana.Location = new System.Drawing.Point(418, 22);
            this.btnSemana.Name = "btnSemana";
            this.btnSemana.Size = new System.Drawing.Size(144, 39);
            this.btnSemana.TabIndex = 17;
            this.btnSemana.Text = "Ultimos 7 Dias";
            this.btnSemana.UseVisualStyleBackColor = false;
            this.btnSemana.Click += new System.EventHandler(this.btnSemana_Click);
            // 
            // btnHoy
            // 
            this.btnHoy.BackColor = System.Drawing.Color.Sienna;
            this.btnHoy.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoy.Location = new System.Drawing.Point(247, 22);
            this.btnHoy.Name = "btnHoy";
            this.btnHoy.Size = new System.Drawing.Size(144, 39);
            this.btnHoy.TabIndex = 16;
            this.btnHoy.Text = "Hoy";
            this.btnHoy.UseVisualStyleBackColor = false;
            this.btnHoy.Click += new System.EventHandler(this.btnHoy_Click);
            // 
            // lblBoletosVendidos
            // 
            this.lblBoletosVendidos.AutoSize = true;
            this.lblBoletosVendidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoletosVendidos.ForeColor = System.Drawing.Color.Sienna;
            this.lblBoletosVendidos.Location = new System.Drawing.Point(80, 151);
            this.lblBoletosVendidos.Name = "lblBoletosVendidos";
            this.lblBoletosVendidos.Size = new System.Drawing.Size(37, 39);
            this.lblBoletosVendidos.TabIndex = 8;
            this.lblBoletosVendidos.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(2, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(218, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Cantidad de Boletos Vendidos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha Hasta";
            // 
            // btnDescargarPDF
            // 
            this.btnDescargarPDF.BackColor = System.Drawing.Color.Sienna;
            this.btnDescargarPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescargarPDF.Location = new System.Drawing.Point(6, 427);
            this.btnDescargarPDF.Name = "btnDescargarPDF";
            this.btnDescargarPDF.Size = new System.Drawing.Size(166, 39);
            this.btnDescargarPDF.TabIndex = 14;
            this.btnDescargarPDF.Text = "Descargar PDF";
            this.btnDescargarPDF.UseVisualStyleBackColor = false;
            this.btnDescargarPDF.Click += new System.EventHandler(this.btnDescargarPDF_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fecha Desde";
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(101, 56);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(121, 22);
            this.dtpFechaHasta.TabIndex = 1;
            this.dtpFechaHasta.ValueChanged += new System.EventHandler(this.DtpFecha_ValueChanged);
            // 
            // lblTotalRecaudado
            // 
            this.lblTotalRecaudado.AutoSize = true;
            this.lblTotalRecaudado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRecaudado.ForeColor = System.Drawing.Color.Sienna;
            this.lblTotalRecaudado.Location = new System.Drawing.Point(2, 319);
            this.lblTotalRecaudado.Name = "lblTotalRecaudado";
            this.lblTotalRecaudado.Size = new System.Drawing.Size(37, 39);
            this.lblTotalRecaudado.TabIndex = 12;
            this.lblTotalRecaudado.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(703, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Porcentaje Ocupacion Salas";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(2, 289);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(201, 16);
            this.label9.TabIndex = 11;
            this.label9.Text = "Total Recaudado en Ventas";
            // 
            // chartPeliculas
            // 
            chartArea2.Name = "ChartArea1";
            this.chartPeliculas.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartPeliculas.Legends.Add(legend2);
            this.chartPeliculas.Location = new System.Drawing.Point(226, 117);
            this.chartPeliculas.Name = "chartPeliculas";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartPeliculas.Series.Add(series2);
            this.chartPeliculas.Size = new System.Drawing.Size(474, 349);
            this.chartPeliculas.TabIndex = 2;
            this.chartPeliculas.Text = "chart1";
            // 
            // lblNuevasMembresias
            // 
            this.lblNuevasMembresias.AutoSize = true;
            this.lblNuevasMembresias.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevasMembresias.ForeColor = System.Drawing.Color.Sienna;
            this.lblNuevasMembresias.Location = new System.Drawing.Point(80, 236);
            this.lblNuevasMembresias.Name = "lblNuevasMembresias";
            this.lblNuevasMembresias.Size = new System.Drawing.Size(37, 39);
            this.lblNuevasMembresias.TabIndex = 10;
            this.lblNuevasMembresias.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(223, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Peliculas mas Vistas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Nuevas Membresias";
            // 
            // chartOcupacion
            // 
            chartArea3.Name = "ChartArea1";
            this.chartOcupacion.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartOcupacion.Legends.Add(legend3);
            this.chartOcupacion.Location = new System.Drawing.Point(710, 117);
            this.chartOcupacion.Name = "chartOcupacion";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartOcupacion.Series.Add(series3);
            this.chartOcupacion.Size = new System.Drawing.Size(375, 349);
            this.chartOcupacion.TabIndex = 6;
            this.chartOcupacion.Text = "chart1";
            // 
            // dgvProductosLowStock
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvProductosLowStock.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProductosLowStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Sienna;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductosLowStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProductosLowStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductosLowStock.EnableHeadersVisualStyles = false;
            this.dgvProductosLowStock.Location = new System.Drawing.Point(12, 526);
            this.dgvProductosLowStock.MultiSelect = false;
            this.dgvProductosLowStock.Name = "dgvProductosLowStock";
            this.dgvProductosLowStock.RowHeadersVisible = false;
            this.dgvProductosLowStock.RowHeadersWidth = 51;
            this.dgvProductosLowStock.RowTemplate.Height = 24;
            this.dgvProductosLowStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductosLowStock.Size = new System.Drawing.Size(812, 281);
            this.dgvProductosLowStock.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 507);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(132, 16);
            this.label11.TabIndex = 15;
            this.label11.Text = "Productos Low Stock";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(994, 507);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Total Membresias Activas";
            // 
            // chartTotalMembresias
            // 
            chartArea4.Name = "ChartArea1";
            this.chartTotalMembresias.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartTotalMembresias.Legends.Add(legend4);
            this.chartTotalMembresias.Location = new System.Drawing.Point(997, 526);
            this.chartTotalMembresias.Name = "chartTotalMembresias";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartTotalMembresias.Series.Add(series4);
            this.chartTotalMembresias.Size = new System.Drawing.Size(606, 281);
            this.chartTotalMembresias.TabIndex = 17;
            this.chartTotalMembresias.Text = "chartTotalMembresias";
            // 
            // Fr_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1827, 845);
            this.Controls.Add(this.chartTotalMembresias);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dgvProductosLowStock);
            this.Name = "Fr_Dashboard";
            this.Text = " ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Fr_Dashboard_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartAnalisisIngresos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPeliculas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartOcupacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosLowStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTotalMembresias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPeliculas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartOcupacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblBoletosVendidos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblNuevasMembresias;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTotalRecaudado;
        private System.Windows.Forms.DataGridView dgvProductosLowStock;
        private System.Windows.Forms.Button btnDescargarPDF;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTotalMembresias;
        private System.Windows.Forms.Button btnSemana;
        private System.Windows.Forms.Button btnHoy;
        private System.Windows.Forms.Button btnMes;
        private System.Windows.Forms.Button btn30Dias;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAnalisisIngresos;
    }
}