namespace ProyectoTaller2.C_Presentacion.Vendedor
{
    partial class RealizarVenta
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
            this.components = new System.ComponentModel.Container();
            this.lblNuevaVenta = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFechaVenta = new System.Windows.Forms.DateTimePicker();
            this.gridVentaProducto = new System.Windows.Forms.DataGridView();
            this.col_NomProductoRV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_PrecioRV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_stockRV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_AgregarProRV = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gridRealizarVenta = new System.Windows.Forms.DataGridView();
            this.lblNomVendedor = new System.Windows.Forms.Label();
            this.cbxCliente = new System.Windows.Forms.ComboBox();
            this.lblClienteV = new System.Windows.Forms.Label();
            this.lblSelecPro = new System.Windows.Forms.Label();
            this.cbxBuscarPor = new System.Windows.Forms.ComboBox();
            this.tbxBuscarProducto = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblDetalleVenta = new System.Windows.Forms.Label();
            this.lblPrecioTotal = new System.Windows.Forms.Label();
            this.col_NomProductoVR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_precioUnitarioVR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_cantidadVR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_precioTotalVR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_EliminarProRV = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnCancelarVenta = new System.Windows.Forms.Button();
            this.btnCobrar = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridVentaProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridRealizarVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNuevaVenta
            // 
            this.lblNuevaVenta.AutoSize = true;
            this.lblNuevaVenta.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblNuevaVenta.Location = new System.Drawing.Point(21, 21);
            this.lblNuevaVenta.Name = "lblNuevaVenta";
            this.lblNuevaVenta.Size = new System.Drawing.Size(157, 32);
            this.lblNuevaVenta.TabIndex = 3;
            this.lblNuevaVenta.Text = "Nueva venta";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.lblFecha.Location = new System.Drawing.Point(23, 77);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(55, 21);
            this.lblFecha.TabIndex = 5;
            this.lblFecha.Text = "Fecha:";
            // 
            // dtpFechaVenta
            // 
            this.dtpFechaVenta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaVenta.Location = new System.Drawing.Point(84, 78);
            this.dtpFechaVenta.Name = "dtpFechaVenta";
            this.dtpFechaVenta.Size = new System.Drawing.Size(136, 20);
            this.dtpFechaVenta.TabIndex = 6;
            // 
            // gridVentaProducto
            // 
            this.gridVentaProducto.AllowUserToAddRows = false;
            this.gridVentaProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridVentaProducto.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridVentaProducto.BackgroundColor = System.Drawing.Color.Lavender;
            this.gridVentaProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridVentaProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_NomProductoRV,
            this.col_PrecioRV,
            this.col_stockRV,
            this.col_AgregarProRV});
            this.gridVentaProducto.Location = new System.Drawing.Point(27, 162);
            this.gridVentaProducto.Name = "gridVentaProducto";
            this.gridVentaProducto.Size = new System.Drawing.Size(807, 110);
            this.gridVentaProducto.TabIndex = 7;
            // 
            // col_NomProductoRV
            // 
            this.col_NomProductoRV.HeaderText = "Nombre Producto";
            this.col_NomProductoRV.Name = "col_NomProductoRV";
            // 
            // col_PrecioRV
            // 
            this.col_PrecioRV.HeaderText = "Precio";
            this.col_PrecioRV.Name = "col_PrecioRV";
            // 
            // col_stockRV
            // 
            this.col_stockRV.HeaderText = "Stock";
            this.col_stockRV.Name = "col_stockRV";
            // 
            // col_AgregarProRV
            // 
            this.col_AgregarProRV.HeaderText = "Agregar";
            this.col_AgregarProRV.Name = "col_AgregarProRV";
            // 
            // gridRealizarVenta
            // 
            this.gridRealizarVenta.AllowUserToAddRows = false;
            this.gridRealizarVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridRealizarVenta.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridRealizarVenta.BackgroundColor = System.Drawing.Color.Lavender;
            this.gridRealizarVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridRealizarVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_NomProductoVR,
            this.col_precioUnitarioVR,
            this.col_cantidadVR,
            this.col_precioTotalVR,
            this.col_EliminarProRV});
            this.gridRealizarVenta.Location = new System.Drawing.Point(27, 310);
            this.gridRealizarVenta.Name = "gridRealizarVenta";
            this.gridRealizarVenta.Size = new System.Drawing.Size(807, 204);
            this.gridRealizarVenta.TabIndex = 8;
            // 
            // lblNomVendedor
            // 
            this.lblNomVendedor.AutoSize = true;
            this.lblNomVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomVendedor.Location = new System.Drawing.Point(690, 31);
            this.lblNomVendedor.Name = "lblNomVendedor";
            this.lblNomVendedor.Size = new System.Drawing.Size(144, 20);
            this.lblNomVendedor.TabIndex = 9;
            this.lblNomVendedor.Text = "Nombre Vendedor";
            // 
            // cbxCliente
            // 
            this.cbxCliente.FormattingEnabled = true;
            this.cbxCliente.Location = new System.Drawing.Point(620, 79);
            this.cbxCliente.Name = "cbxCliente";
            this.cbxCliente.Size = new System.Drawing.Size(214, 21);
            this.cbxCliente.TabIndex = 11;
            // 
            // lblClienteV
            // 
            this.lblClienteV.AutoSize = true;
            this.lblClienteV.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.lblClienteV.Location = new System.Drawing.Point(553, 77);
            this.lblClienteV.Name = "lblClienteV";
            this.lblClienteV.Size = new System.Drawing.Size(61, 21);
            this.lblClienteV.TabIndex = 10;
            this.lblClienteV.Text = "Cliente:";
            // 
            // lblSelecPro
            // 
            this.lblSelecPro.AutoSize = true;
            this.lblSelecPro.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.lblSelecPro.Location = new System.Drawing.Point(23, 134);
            this.lblSelecPro.Name = "lblSelecPro";
            this.lblSelecPro.Size = new System.Drawing.Size(163, 21);
            this.lblSelecPro.TabIndex = 17;
            this.lblSelecPro.Text = "Seleccionar productos:";
            // 
            // cbxBuscarPor
            // 
            this.cbxBuscarPor.FormattingEnabled = true;
            this.cbxBuscarPor.Items.AddRange(new object[] {
            "Cod Prenda",
            "Nombre"});
            this.cbxBuscarPor.Location = new System.Drawing.Point(532, 135);
            this.cbxBuscarPor.Name = "cbxBuscarPor";
            this.cbxBuscarPor.Size = new System.Drawing.Size(85, 21);
            this.cbxBuscarPor.TabIndex = 20;
            // 
            // tbxBuscarProducto
            // 
            this.tbxBuscarProducto.Location = new System.Drawing.Point(623, 135);
            this.tbxBuscarProducto.Name = "tbxBuscarProducto";
            this.tbxBuscarProducto.Size = new System.Drawing.Size(134, 20);
            this.tbxBuscarProducto.TabIndex = 19;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(763, 134);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(71, 22);
            this.btnBuscar.TabIndex = 18;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // lblDetalleVenta
            // 
            this.lblDetalleVenta.AutoSize = true;
            this.lblDetalleVenta.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.lblDetalleVenta.Location = new System.Drawing.Point(23, 286);
            this.lblDetalleVenta.Name = "lblDetalleVenta";
            this.lblDetalleVenta.Size = new System.Drawing.Size(116, 21);
            this.lblDetalleVenta.TabIndex = 21;
            this.lblDetalleVenta.Text = "Detalle de veta:";
            // 
            // lblPrecioTotal
            // 
            this.lblPrecioTotal.AutoSize = true;
            this.lblPrecioTotal.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F);
            this.lblPrecioTotal.Location = new System.Drawing.Point(618, 527);
            this.lblPrecioTotal.Name = "lblPrecioTotal";
            this.lblPrecioTotal.Size = new System.Drawing.Size(59, 25);
            this.lblPrecioTotal.TabIndex = 22;
            this.lblPrecioTotal.Text = "Total:";
            // 
            // col_NomProductoVR
            // 
            this.col_NomProductoVR.HeaderText = "Nombre Producto";
            this.col_NomProductoVR.Name = "col_NomProductoVR";
            // 
            // col_precioUnitarioVR
            // 
            this.col_precioUnitarioVR.HeaderText = "Precio Unitario";
            this.col_precioUnitarioVR.Name = "col_precioUnitarioVR";
            // 
            // col_cantidadVR
            // 
            this.col_cantidadVR.HeaderText = "Cantidad";
            this.col_cantidadVR.Name = "col_cantidadVR";
            // 
            // col_precioTotalVR
            // 
            this.col_precioTotalVR.HeaderText = "Sub Total";
            this.col_precioTotalVR.Name = "col_precioTotalVR";
            // 
            // col_EliminarProRV
            // 
            this.col_EliminarProRV.HeaderText = "Eliminar";
            this.col_EliminarProRV.Name = "col_EliminarProRV";
            // 
            // btnCancelarVenta
            // 
            this.btnCancelarVenta.BackColor = System.Drawing.Color.Salmon;
            this.btnCancelarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelarVenta.Location = new System.Drawing.Point(428, 526);
            this.btnCancelarVenta.Name = "btnCancelarVenta";
            this.btnCancelarVenta.Size = new System.Drawing.Size(70, 31);
            this.btnCancelarVenta.TabIndex = 24;
            this.btnCancelarVenta.Text = "Cancelar";
            this.btnCancelarVenta.UseVisualStyleBackColor = false;
            this.btnCancelarVenta.Click += new System.EventHandler(this.btnCancelarVenta_Click);
            // 
            // btnCobrar
            // 
            this.btnCobrar.BackColor = System.Drawing.Color.SpringGreen;
            this.btnCobrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCobrar.Location = new System.Drawing.Point(318, 526);
            this.btnCobrar.Name = "btnCobrar";
            this.btnCobrar.Size = new System.Drawing.Size(70, 31);
            this.btnCobrar.TabIndex = 23;
            this.btnCobrar.Text = "Cobrar";
            this.btnCobrar.UseVisualStyleBackColor = false;
            this.btnCobrar.Click += new System.EventHandler(this.btnCobrar_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkRate = 300;
            this.errorProvider.ContainerControl = this;
            // 
            // RealizarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(864, 561);
            this.Controls.Add(this.btnCancelarVenta);
            this.Controls.Add(this.btnCobrar);
            this.Controls.Add(this.lblPrecioTotal);
            this.Controls.Add(this.lblDetalleVenta);
            this.Controls.Add(this.cbxBuscarPor);
            this.Controls.Add(this.tbxBuscarProducto);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblSelecPro);
            this.Controls.Add(this.cbxCliente);
            this.Controls.Add(this.lblClienteV);
            this.Controls.Add(this.lblNomVendedor);
            this.Controls.Add(this.gridRealizarVenta);
            this.Controls.Add(this.gridVentaProducto);
            this.Controls.Add(this.dtpFechaVenta);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblNuevaVenta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RealizarVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RealizarVenta";
            ((System.ComponentModel.ISupportInitialize)(this.gridVentaProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridRealizarVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNuevaVenta;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFechaVenta;
        private System.Windows.Forms.DataGridView gridVentaProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_NomProductoRV;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_PrecioRV;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_stockRV;
        private System.Windows.Forms.DataGridViewButtonColumn col_AgregarProRV;
        private System.Windows.Forms.DataGridView gridRealizarVenta;
        private System.Windows.Forms.Label lblNomVendedor;
        private System.Windows.Forms.ComboBox cbxCliente;
        private System.Windows.Forms.Label lblClienteV;
        private System.Windows.Forms.Label lblSelecPro;
        private System.Windows.Forms.ComboBox cbxBuscarPor;
        private System.Windows.Forms.TextBox tbxBuscarProducto;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblDetalleVenta;
        private System.Windows.Forms.Label lblPrecioTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_NomProductoVR;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_precioUnitarioVR;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cantidadVR;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_precioTotalVR;
        private System.Windows.Forms.DataGridViewButtonColumn col_EliminarProRV;
        private System.Windows.Forms.Button btnCancelarVenta;
        private System.Windows.Forms.Button btnCobrar;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}