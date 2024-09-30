namespace ProyectoTaller2.C_Presentacion.Administrador
{
    partial class ListarVentas
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnAplicar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.lblVentas = new System.Windows.Forms.Label();
            this.dgbDetalleProductos = new System.Windows.Forms.DataGridView();
            this.ColFechaAlta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNroVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColVendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantProductos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecioTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVerDetalle = new System.Windows.Forms.DataGridViewButtonColumn();
            this.testDetalle = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgbDetalleProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.panelHeader.Controls.Add(this.testDetalle);
            this.panelHeader.Controls.Add(this.btnAplicar);
            this.panelHeader.Controls.Add(this.btnBuscar);
            this.panelHeader.Controls.Add(this.textBox2);
            this.panelHeader.Controls.Add(this.comboBox2);
            this.panelHeader.Controls.Add(this.textBox1);
            this.panelHeader.Controls.Add(this.comboBox1);
            this.panelHeader.Controls.Add(this.label1);
            this.panelHeader.Controls.Add(this.lblBuscar);
            this.panelHeader.Controls.Add(this.lblVentas);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(880, 100);
            this.panelHeader.TabIndex = 1;
            // 
            // btnAplicar
            // 
            this.btnAplicar.Location = new System.Drawing.Point(784, 53);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(75, 23);
            this.btnAplicar.TabIndex = 9;
            this.btnAplicar.Text = "Aplicar";
            this.btnAplicar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(784, 21);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(677, 55);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 7;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(574, 54);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(97, 21);
            this.comboBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(677, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(574, 20);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(97, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.label1.Location = new System.Drawing.Point(481, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Filtrar por:";
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.lblBuscar.Location = new System.Drawing.Point(481, 18);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(87, 21);
            this.lblBuscar.TabIndex = 2;
            this.lblBuscar.Text = "Buscar por:";
            // 
            // lblVentas
            // 
            this.lblVentas.AutoSize = true;
            this.lblVentas.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblVentas.Location = new System.Drawing.Point(12, 18);
            this.lblVentas.Name = "lblVentas";
            this.lblVentas.Size = new System.Drawing.Size(89, 32);
            this.lblVentas.TabIndex = 1;
            this.lblVentas.Text = "Ventas";
            // 
            // dgbDetalleProductos
            // 
            this.dgbDetalleProductos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(247)))));
            this.dgbDetalleProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgbDetalleProductos.ColumnHeadersHeight = 40;
            this.dgbDetalleProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgbDetalleProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColFechaAlta,
            this.ColNroVenta,
            this.ColVendedor,
            this.colCliente,
            this.colCantProductos,
            this.colPrecioTotal,
            this.colVerDetalle});
            this.dgbDetalleProductos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgbDetalleProductos.Location = new System.Drawing.Point(3, 106);
            this.dgbDetalleProductos.Name = "dgbDetalleProductos";
            this.dgbDetalleProductos.RowHeadersVisible = false;
            this.dgbDetalleProductos.Size = new System.Drawing.Size(865, 462);
            this.dgbDetalleProductos.TabIndex = 10;
            // 
            // ColFechaAlta
            // 
            this.ColFechaAlta.HeaderText = "Fecha";
            this.ColFechaAlta.Name = "ColFechaAlta";
            this.ColFechaAlta.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColNroVenta
            // 
            this.ColNroVenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColNroVenta.HeaderText = "Nro Venta";
            this.ColNroVenta.Name = "ColNroVenta";
            this.ColNroVenta.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColNroVenta.Width = 74;
            // 
            // ColVendedor
            // 
            this.ColVendedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColVendedor.HeaderText = "Vendedor";
            this.ColVendedor.Name = "ColVendedor";
            // 
            // colCliente
            // 
            this.colCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCliente.HeaderText = "Cliente";
            this.colCliente.Name = "colCliente";
            // 
            // colCantProductos
            // 
            this.colCantProductos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colCantProductos.HeaderText = "Cantidad de productos";
            this.colCantProductos.Name = "colCantProductos";
            this.colCantProductos.Width = 127;
            // 
            // colPrecioTotal
            // 
            this.colPrecioTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colPrecioTotal.HeaderText = "Precio total";
            this.colPrecioTotal.Name = "colPrecioTotal";
            this.colPrecioTotal.Width = 79;
            // 
            // colVerDetalle
            // 
            this.colVerDetalle.HeaderText = "VerDetalle";
            this.colVerDetalle.Name = "colVerDetalle";
            this.colVerDetalle.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colVerDetalle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colVerDetalle.Text = "Ver detalle";
            this.colVerDetalle.Width = 80;
            // 
            // testDetalle
            // 
            this.testDetalle.Location = new System.Drawing.Point(283, 51);
            this.testDetalle.Name = "testDetalle";
            this.testDetalle.Size = new System.Drawing.Size(75, 23);
            this.testDetalle.TabIndex = 10;
            this.testDetalle.Text = "testDetalle";
            this.testDetalle.UseVisualStyleBackColor = true;
            this.testDetalle.Click += new System.EventHandler(this.testDetalle_Click);
            // 
            // ListarVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(880, 600);
            this.Controls.Add(this.dgbDetalleProductos);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListarVentas";
            this.Text = "ListarVentas";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgbDetalleProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button btnAplicar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Label lblVentas;
        private System.Windows.Forms.DataGridView dgbDetalleProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFechaAlta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNroVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColVendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecioTotal;
        private System.Windows.Forms.DataGridViewButtonColumn colVerDetalle;
        private System.Windows.Forms.Button testDetalle;
    }
}