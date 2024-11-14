namespace ProyectoTaller2.C_Presentacion.Administrador
{
    partial class EstadisticasVentas
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lvlVendedoresActivos = new System.Windows.Forms.Label();
            this.lblGanancias = new System.Windows.Forms.Label();
            this.lblVentasTotales = new System.Windows.Forms.Label();
            this.lblEstadisticasGenerales = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnFiltrarG = new System.Windows.Forms.Button();
            this.dtpGHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpGDesde = new System.Windows.Forms.DateTimePicker();
            this.lblFiltroPeriodo = new System.Windows.Forms.Label();
            this.lblEstadisticasVentas = new System.Windows.Forms.Label();
            this.chartVentasGenerales = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.btnBuscarV = new System.Windows.Forms.Button();
            this.cbxVendedores = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chartGnanaciasVendedor = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartVentasVendedores = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnFiltrarP = new System.Windows.Forms.Button();
            this.dtpPHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpPDesde = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCategoriaMasVendida = new System.Windows.Forms.Label();
            this.lblProductoMasVendido = new System.Windows.Forms.Label();
            this.chartCategoriaMasVendida = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartProductoMasVendido = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelHeader.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartVentasGenerales)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGnanaciasVendedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartVentasVendedores)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCategoriaMasVendida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartProductoMasVendido)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.panelHeader.Controls.Add(this.lvlVendedoresActivos);
            this.panelHeader.Controls.Add(this.lblGanancias);
            this.panelHeader.Controls.Add(this.lblVentasTotales);
            this.panelHeader.Controls.Add(this.lblEstadisticasGenerales);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(880, 109);
            this.panelHeader.TabIndex = 3;
            // 
            // lvlVendedoresActivos
            // 
            this.lvlVendedoresActivos.AutoSize = true;
            this.lvlVendedoresActivos.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.lvlVendedoresActivos.Location = new System.Drawing.Point(492, 77);
            this.lvlVendedoresActivos.Name = "lvlVendedoresActivos";
            this.lvlVendedoresActivos.Size = new System.Drawing.Size(146, 21);
            this.lvlVendedoresActivos.TabIndex = 5;
            this.lvlVendedoresActivos.Text = "Vendedores Activos:";
            // 
            // lblGanancias
            // 
            this.lblGanancias.AutoSize = true;
            this.lblGanancias.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.lblGanancias.Location = new System.Drawing.Point(229, 77);
            this.lblGanancias.Name = "lblGanancias";
            this.lblGanancias.Size = new System.Drawing.Size(140, 21);
            this.lblGanancias.TabIndex = 4;
            this.lblGanancias.Text = "Ganancias Totales:";
            // 
            // lblVentasTotales
            // 
            this.lblVentasTotales.AutoSize = true;
            this.lblVentasTotales.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.lblVentasTotales.Location = new System.Drawing.Point(18, 77);
            this.lblVentasTotales.Name = "lblVentasTotales";
            this.lblVentasTotales.Size = new System.Drawing.Size(114, 21);
            this.lblVentasTotales.TabIndex = 3;
            this.lblVentasTotales.Text = "Ventas Totales:";
            // 
            // lblEstadisticasGenerales
            // 
            this.lblEstadisticasGenerales.AutoSize = true;
            this.lblEstadisticasGenerales.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblEstadisticasGenerales.Location = new System.Drawing.Point(12, 18);
            this.lblEstadisticasGenerales.Name = "lblEstadisticasGenerales";
            this.lblEstadisticasGenerales.Size = new System.Drawing.Size(264, 32);
            this.lblEstadisticasGenerales.TabIndex = 1;
            this.lblEstadisticasGenerales.Text = "Estadisticas Generales";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 115);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(856, 464);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnFiltrarG);
            this.tabPage1.Controls.Add(this.dtpGHasta);
            this.tabPage1.Controls.Add(this.dtpGDesde);
            this.tabPage1.Controls.Add(this.lblFiltroPeriodo);
            this.tabPage1.Controls.Add(this.lblEstadisticasVentas);
            this.tabPage1.Controls.Add(this.chartVentasGenerales);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(848, 438);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnFiltrarG
            // 
            this.btnFiltrarG.Location = new System.Drawing.Point(500, 381);
            this.btnFiltrarG.Name = "btnFiltrarG";
            this.btnFiltrarG.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrarG.TabIndex = 10;
            this.btnFiltrarG.Text = "Filtrar";
            this.btnFiltrarG.UseVisualStyleBackColor = true;
            this.btnFiltrarG.Click += new System.EventHandler(this.btnFiltrarG_Click);
            // 
            // dtpGHasta
            // 
            this.dtpGHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpGHasta.Location = new System.Drawing.Point(407, 382);
            this.dtpGHasta.Name = "dtpGHasta";
            this.dtpGHasta.Size = new System.Drawing.Size(77, 20);
            this.dtpGHasta.TabIndex = 9;
            // 
            // dtpGDesde
            // 
            this.dtpGDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpGDesde.Location = new System.Drawing.Point(315, 382);
            this.dtpGDesde.Name = "dtpGDesde";
            this.dtpGDesde.Size = new System.Drawing.Size(77, 20);
            this.dtpGDesde.TabIndex = 8;
            // 
            // lblFiltroPeriodo
            // 
            this.lblFiltroPeriodo.AutoSize = true;
            this.lblFiltroPeriodo.Font = new System.Drawing.Font("Franklin Gothic Medium", 11F);
            this.lblFiltroPeriodo.Location = new System.Drawing.Point(179, 382);
            this.lblFiltroPeriodo.Name = "lblFiltroPeriodo";
            this.lblFiltroPeriodo.Size = new System.Drawing.Size(130, 20);
            this.lblFiltroPeriodo.TabIndex = 7;
            this.lblFiltroPeriodo.Text = "Filtrar por periodo:";
            // 
            // lblEstadisticasVentas
            // 
            this.lblEstadisticasVentas.AutoSize = true;
            this.lblEstadisticasVentas.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblEstadisticasVentas.Location = new System.Drawing.Point(220, 15);
            this.lblEstadisticasVentas.Name = "lblEstadisticasVentas";
            this.lblEstadisticasVentas.Size = new System.Drawing.Size(369, 30);
            this.lblEstadisticasVentas.TabIndex = 7;
            this.lblEstadisticasVentas.Text = "Promedio de ganancias mensuales";
            // 
            // chartVentasGenerales
            // 
            chartArea1.Name = "ChartArea1";
            this.chartVentasGenerales.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartVentasGenerales.Legends.Add(legend1);
            this.chartVentasGenerales.Location = new System.Drawing.Point(23, 59);
            this.chartVentasGenerales.Name = "chartVentasGenerales";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartVentasGenerales.Series.Add(series1);
            this.chartVentasGenerales.Size = new System.Drawing.Size(809, 300);
            this.chartVentasGenerales.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblVendedor);
            this.tabPage2.Controls.Add(this.btnBuscarV);
            this.tabPage2.Controls.Add(this.cbxVendedores);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.chartGnanaciasVendedor);
            this.tabPage2.Controls.Add(this.chartVentasVendedores);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(848, 438);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Vendedores";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Font = new System.Drawing.Font("Franklin Gothic Medium", 11F);
            this.lblVendedor.Location = new System.Drawing.Point(469, 28);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(74, 20);
            this.lblVendedor.TabIndex = 13;
            this.lblVendedor.Text = "Vendedor:";
            // 
            // btnBuscarV
            // 
            this.btnBuscarV.Location = new System.Drawing.Point(747, 27);
            this.btnBuscarV.Name = "btnBuscarV";
            this.btnBuscarV.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarV.TabIndex = 11;
            this.btnBuscarV.Text = "Buscar";
            this.btnBuscarV.UseVisualStyleBackColor = true;
            this.btnBuscarV.Click += new System.EventHandler(this.btnBuscarV_Click);
            // 
            // cbxVendedores
            // 
            this.cbxVendedores.FormattingEnabled = true;
            this.cbxVendedores.Location = new System.Drawing.Point(555, 27);
            this.cbxVendedores.Name = "cbxVendedores";
            this.cbxVendedores.Size = new System.Drawing.Size(186, 21);
            this.cbxVendedores.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(480, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Estadisticas del vendedor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(47, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Vendedor con mas ventas";
            // 
            // chartGnanaciasVendedor
            // 
            chartArea2.Name = "ChartArea1";
            this.chartGnanaciasVendedor.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartGnanaciasVendedor.Legends.Add(legend2);
            this.chartGnanaciasVendedor.Location = new System.Drawing.Point(451, 111);
            this.chartGnanaciasVendedor.Name = "chartGnanaciasVendedor";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartGnanaciasVendedor.Series.Add(series2);
            this.chartGnanaciasVendedor.Size = new System.Drawing.Size(413, 307);
            this.chartGnanaciasVendedor.TabIndex = 1;
            this.chartGnanaciasVendedor.Text = "chart2";
            // 
            // chartVentasVendedores
            // 
            chartArea3.Name = "ChartArea1";
            this.chartVentasVendedores.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartVentasVendedores.Legends.Add(legend3);
            this.chartVentasVendedores.Location = new System.Drawing.Point(6, 111);
            this.chartVentasVendedores.Name = "chartVentasVendedores";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartVentasVendedores.Series.Add(series3);
            this.chartVentasVendedores.Size = new System.Drawing.Size(450, 307);
            this.chartVentasVendedores.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnFiltrarP);
            this.tabPage3.Controls.Add(this.dtpPHasta);
            this.tabPage3.Controls.Add(this.dtpPDesde);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.lblCategoriaMasVendida);
            this.tabPage3.Controls.Add(this.lblProductoMasVendido);
            this.tabPage3.Controls.Add(this.chartCategoriaMasVendida);
            this.tabPage3.Controls.Add(this.chartProductoMasVendido);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(848, 438);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Productos";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnFiltrarP
            // 
            this.btnFiltrarP.Location = new System.Drawing.Point(547, 20);
            this.btnFiltrarP.Name = "btnFiltrarP";
            this.btnFiltrarP.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrarP.TabIndex = 14;
            this.btnFiltrarP.Text = "Filtrar";
            this.btnFiltrarP.UseVisualStyleBackColor = true;
            this.btnFiltrarP.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtpPHasta
            // 
            this.dtpPHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPHasta.Location = new System.Drawing.Point(451, 21);
            this.dtpPHasta.Name = "dtpPHasta";
            this.dtpPHasta.Size = new System.Drawing.Size(77, 20);
            this.dtpPHasta.TabIndex = 13;
            // 
            // dtpPDesde
            // 
            this.dtpPDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPDesde.Location = new System.Drawing.Point(359, 21);
            this.dtpPDesde.Name = "dtpPDesde";
            this.dtpPDesde.Size = new System.Drawing.Size(77, 20);
            this.dtpPDesde.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 11F);
            this.label5.Location = new System.Drawing.Point(223, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Filtrar por periodo:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblCategoriaMasVendida
            // 
            this.lblCategoriaMasVendida.AutoSize = true;
            this.lblCategoriaMasVendida.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblCategoriaMasVendida.Location = new System.Drawing.Point(515, 73);
            this.lblCategoriaMasVendida.Name = "lblCategoriaMasVendida";
            this.lblCategoriaMasVendida.Size = new System.Drawing.Size(215, 25);
            this.lblCategoriaMasVendida.TabIndex = 4;
            this.lblCategoriaMasVendida.Text = "Categoria Mas vendida";
            // 
            // lblProductoMasVendido
            // 
            this.lblProductoMasVendido.AutoSize = true;
            this.lblProductoMasVendido.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblProductoMasVendido.Location = new System.Drawing.Point(60, 73);
            this.lblProductoMasVendido.Name = "lblProductoMasVendido";
            this.lblProductoMasVendido.Size = new System.Drawing.Size(214, 25);
            this.lblProductoMasVendido.TabIndex = 2;
            this.lblProductoMasVendido.Text = "Producto mas vendido";
            // 
            // chartCategoriaMasVendida
            // 
            chartArea4.Name = "ChartArea1";
            this.chartCategoriaMasVendida.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartCategoriaMasVendida.Legends.Add(legend4);
            this.chartCategoriaMasVendida.Location = new System.Drawing.Point(420, 113);
            this.chartCategoriaMasVendida.Name = "chartCategoriaMasVendida";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartCategoriaMasVendida.Series.Add(series4);
            this.chartCategoriaMasVendida.Size = new System.Drawing.Size(413, 307);
            this.chartCategoriaMasVendida.TabIndex = 3;
            this.chartCategoriaMasVendida.Text = "chart3";
            // 
            // chartProductoMasVendido
            // 
            chartArea5.Name = "ChartArea1";
            this.chartProductoMasVendido.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chartProductoMasVendido.Legends.Add(legend5);
            this.chartProductoMasVendido.Location = new System.Drawing.Point(1, 113);
            this.chartProductoMasVendido.Name = "chartProductoMasVendido";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chartProductoMasVendido.Series.Add(series5);
            this.chartProductoMasVendido.Size = new System.Drawing.Size(413, 307);
            this.chartProductoMasVendido.TabIndex = 2;
            this.chartProductoMasVendido.Text = "chart4";
            // 
            // EstadisticasVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(880, 600);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EstadisticasVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EstadisticasVentas";
            this.Load += new System.EventHandler(this.EstadisticasVentas_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartVentasGenerales)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGnanaciasVendedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartVentasVendedores)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCategoriaMasVendida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartProductoMasVendido)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblEstadisticasGenerales;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartVentasGenerales;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGnanaciasVendedor;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartVentasVendedores;
        private System.Windows.Forms.Label lblCategoriaMasVendida;
        private System.Windows.Forms.Label lblProductoMasVendido;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCategoriaMasVendida;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartProductoMasVendido;
        private System.Windows.Forms.Label lblGanancias;
        private System.Windows.Forms.Label lblVentasTotales;
        private System.Windows.Forms.Label lvlVendedoresActivos;
        private System.Windows.Forms.Button btnFiltrarG;
        private System.Windows.Forms.DateTimePicker dtpGHasta;
        private System.Windows.Forms.DateTimePicker dtpGDesde;
        private System.Windows.Forms.Label lblFiltroPeriodo;
        private System.Windows.Forms.Label lblEstadisticasVentas;
        private System.Windows.Forms.Button btnBuscarV;
        private System.Windows.Forms.ComboBox cbxVendedores;
        private System.Windows.Forms.Button btnFiltrarP;
        private System.Windows.Forms.DateTimePicker dtpPHasta;
        private System.Windows.Forms.DateTimePicker dtpPDesde;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblVendedor;
    }
}