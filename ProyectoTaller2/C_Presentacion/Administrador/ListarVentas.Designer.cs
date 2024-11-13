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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.tbxBuscar = new System.Windows.Forms.TextBox();
            this.cbxBuscarPor = new System.Windows.Forms.ComboBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.lblVentas = new System.Windows.Forms.Label();
            this.gridListaVentas = new System.Windows.Forms.DataGridView();
            this.ColFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNroVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColVendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMetodoPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecioTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVerDetalle = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridListaVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.panelHeader.Controls.Add(this.btnBuscar);
            this.panelHeader.Controls.Add(this.tbxBuscar);
            this.panelHeader.Controls.Add(this.cbxBuscarPor);
            this.panelHeader.Controls.Add(this.lblBuscar);
            this.panelHeader.Controls.Add(this.lblVentas);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(880, 100);
            this.panelHeader.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(783, 36);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // tbxBuscar
            // 
            this.tbxBuscar.Location = new System.Drawing.Point(677, 39);
            this.tbxBuscar.Name = "tbxBuscar";
            this.tbxBuscar.Size = new System.Drawing.Size(100, 20);
            this.tbxBuscar.TabIndex = 5;
            this.tbxBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxBuscar_KeyPress);
            // 
            // cbxBuscarPor
            // 
            this.cbxBuscarPor.FormattingEnabled = true;
            this.cbxBuscarPor.Items.AddRange(new object[] {
            "Nro Venta",
            "Dni Vendedor",
            "Dni Cliente"});
            this.cbxBuscarPor.Location = new System.Drawing.Point(574, 39);
            this.cbxBuscarPor.Name = "cbxBuscarPor";
            this.cbxBuscarPor.Size = new System.Drawing.Size(97, 21);
            this.cbxBuscarPor.TabIndex = 4;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.lblBuscar.Location = new System.Drawing.Point(481, 39);
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
            // gridListaVentas
            // 
            this.gridListaVentas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(247)))));
            this.gridListaVentas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridListaVentas.ColumnHeadersHeight = 40;
            this.gridListaVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridListaVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColFecha,
            this.ColNroVenta,
            this.ColVendedor,
            this.colCliente,
            this.colMetodoPago,
            this.colPrecioTotal,
            this.colVerDetalle});
            this.gridListaVentas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridListaVentas.Location = new System.Drawing.Point(3, 106);
            this.gridListaVentas.Name = "gridListaVentas";
            this.gridListaVentas.RowHeadersVisible = false;
            this.gridListaVentas.Size = new System.Drawing.Size(865, 462);
            this.gridListaVentas.TabIndex = 10;
            this.gridListaVentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridListaVentas_CellContentClick);
            // 
            // ColFecha
            // 
            this.ColFecha.HeaderText = "Fecha";
            this.ColFecha.Name = "ColFecha";
            this.ColFecha.Resizable = System.Windows.Forms.DataGridViewTriState.False;
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
            // colMetodoPago
            // 
            this.colMetodoPago.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colMetodoPago.HeaderText = "Metodo pago";
            this.colMetodoPago.Name = "colMetodoPago";
            this.colMetodoPago.Width = 88;
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
            this.colVerDetalle.UseColumnTextForButtonValue = true;
            this.colVerDetalle.Width = 80;
            // 
            // ListarVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(880, 600);
            this.Controls.Add(this.gridListaVentas);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListarVentas";
            this.Text = "ListarVentas";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridListaVentas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox tbxBuscar;
        private System.Windows.Forms.ComboBox cbxBuscarPor;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Label lblVentas;
        private System.Windows.Forms.DataGridView gridListaVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNroVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColVendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMetodoPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecioTotal;
        private System.Windows.Forms.DataGridViewButtonColumn colVerDetalle;
    }
}