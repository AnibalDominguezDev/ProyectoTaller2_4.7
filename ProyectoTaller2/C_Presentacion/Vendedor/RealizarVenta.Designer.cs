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
            this.lblNuevaVenta = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFechaVenta = new System.Windows.Forms.DateTimePicker();
            this.gridVentaProducto = new System.Windows.Forms.DataGridView();
            this.Col_idPro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNomP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDescrip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAgregar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblNomVendedor = new System.Windows.Forms.Label();
            this.cbxCliente = new System.Windows.Forms.ComboBox();
            this.lblClienteV = new System.Windows.Forms.Label();
            this.lblSelecPro = new System.Windows.Forms.Label();
            this.cbxBuscarPor = new System.Windows.Forms.ComboBox();
            this.tbxBuscarProducto = new System.Windows.Forms.TextBox();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.lblDetalleVenta = new System.Windows.Forms.Label();
            this.lblTotalPagar = new System.Windows.Forms.Label();
            this.btnCancelarVenta = new System.Windows.Forms.Button();
            this.btnCobrar = new System.Windows.Forms.Button();
            this.lblPrecioTotal = new System.Windows.Forms.Label();
            this.lblMetodoPago = new System.Windows.Forms.Label();
            this.cbxMetodoPago = new System.Windows.Forms.ComboBox();
            this.txtBuscarCliente = new System.Windows.Forms.TextBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.gbListaClientes = new System.Windows.Forms.GroupBox();
            this.dgvClientesVentas = new System.Windows.Forms.DataGridView();
            this.Col_idCli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNomC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColApeC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDniC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSelecC = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblListaClientes = new System.Windows.Forms.Label();
            this.btnBuscarCPor = new System.Windows.Forms.Button();
            this.lblClienteSelec = new System.Windows.Forms.TextBox();
            this.gridRealizarVenta = new System.Windows.Forms.DataGridView();
            this.Col_proId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_NomProductoVR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_precioUnitarioVR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_cantidadVR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_precioTotalVR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_EliminarProRV = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridVentaProducto)).BeginInit();
            this.gbListaClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientesVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridRealizarVenta)).BeginInit();
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
            this.Col_idPro,
            this.ColNomP,
            this.ColDescrip,
            this.ColPrecio,
            this.ColStock,
            this.ColAgregar});
            this.gridVentaProducto.Location = new System.Drawing.Point(27, 159);
            this.gridVentaProducto.Name = "gridVentaProducto";
            this.gridVentaProducto.Size = new System.Drawing.Size(807, 110);
            this.gridVentaProducto.TabIndex = 7;
            this.gridVentaProducto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridVentaProducto_CellContentClick);
            // 
            // Col_idPro
            // 
            this.Col_idPro.HeaderText = "ID";
            this.Col_idPro.Name = "Col_idPro";
            this.Col_idPro.Visible = false;
            // 
            // ColNomP
            // 
            this.ColNomP.HeaderText = "Nombre Producto";
            this.ColNomP.Name = "ColNomP";
            // 
            // ColDescrip
            // 
            this.ColDescrip.HeaderText = "Descripción";
            this.ColDescrip.Name = "ColDescrip";
            // 
            // ColPrecio
            // 
            this.ColPrecio.HeaderText = "Precio";
            this.ColPrecio.Name = "ColPrecio";
            // 
            // ColStock
            // 
            this.ColStock.HeaderText = "Stock";
            this.ColStock.Name = "ColStock";
            // 
            // ColAgregar
            // 
            this.ColAgregar.HeaderText = "Agregar";
            this.ColAgregar.Name = "ColAgregar";
            this.ColAgregar.Text = "Agregar Producto";
            this.ColAgregar.UseColumnTextForButtonValue = true;
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
            this.cbxCliente.Items.AddRange(new object[] {
            "DNI",
            "Nombre"});
            this.cbxCliente.Location = new System.Drawing.Point(216, 21);
            this.cbxCliente.Name = "cbxCliente";
            this.cbxCliente.Size = new System.Drawing.Size(102, 21);
            this.cbxCliente.TabIndex = 11;
            this.cbxCliente.SelectedIndexChanged += new System.EventHandler(this.cbxCliente_SelectedIndexChanged);
            // 
            // lblClienteV
            // 
            this.lblClienteV.AutoSize = true;
            this.lblClienteV.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.lblClienteV.Location = new System.Drawing.Point(578, 78);
            this.lblClienteV.Name = "lblClienteV";
            this.lblClienteV.Size = new System.Drawing.Size(61, 21);
            this.lblClienteV.TabIndex = 10;
            this.lblClienteV.Text = "Cliente:";
            // 
            // lblSelecPro
            // 
            this.lblSelecPro.AutoSize = true;
            this.lblSelecPro.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.lblSelecPro.Location = new System.Drawing.Point(23, 127);
            this.lblSelecPro.Name = "lblSelecPro";
            this.lblSelecPro.Size = new System.Drawing.Size(163, 21);
            this.lblSelecPro.TabIndex = 17;
            this.lblSelecPro.Text = "Seleccionar productos:";
            // 
            // cbxBuscarPor
            // 
            this.cbxBuscarPor.FormattingEnabled = true;
            this.cbxBuscarPor.Items.AddRange(new object[] {
            "Cod. Prenda",
            "Nombre"});
            this.cbxBuscarPor.Location = new System.Drawing.Point(462, 129);
            this.cbxBuscarPor.Name = "cbxBuscarPor";
            this.cbxBuscarPor.Size = new System.Drawing.Size(156, 21);
            this.cbxBuscarPor.TabIndex = 20;
            this.cbxBuscarPor.SelectedIndexChanged += new System.EventHandler(this.cbxBuscarPor_SelectedIndexChanged);
            // 
            // tbxBuscarProducto
            // 
            this.tbxBuscarProducto.Location = new System.Drawing.Point(624, 129);
            this.tbxBuscarProducto.Name = "tbxBuscarProducto";
            this.tbxBuscarProducto.Size = new System.Drawing.Size(134, 20);
            this.tbxBuscarProducto.TabIndex = 19;
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.Location = new System.Drawing.Point(764, 127);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(71, 22);
            this.btnBuscarProducto.TabIndex = 18;
            this.btnBuscarProducto.Text = "Buscar";
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // lblDetalleVenta
            // 
            this.lblDetalleVenta.AutoSize = true;
            this.lblDetalleVenta.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.lblDetalleVenta.Location = new System.Drawing.Point(23, 304);
            this.lblDetalleVenta.Name = "lblDetalleVenta";
            this.lblDetalleVenta.Size = new System.Drawing.Size(116, 21);
            this.lblDetalleVenta.TabIndex = 21;
            this.lblDetalleVenta.Text = "Detalle de veta:";
            // 
            // lblTotalPagar
            // 
            this.lblTotalPagar.AutoSize = true;
            this.lblTotalPagar.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F);
            this.lblTotalPagar.Location = new System.Drawing.Point(48, 562);
            this.lblTotalPagar.Name = "lblTotalPagar";
            this.lblTotalPagar.Size = new System.Drawing.Size(130, 25);
            this.lblTotalPagar.TabIndex = 22;
            this.lblTotalPagar.Text = "Total a pagar:";
            // 
            // btnCancelarVenta
            // 
            this.btnCancelarVenta.BackColor = System.Drawing.Color.Salmon;
            this.btnCancelarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelarVenta.Location = new System.Drawing.Point(764, 556);
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
            this.btnCobrar.Location = new System.Drawing.Point(678, 556);
            this.btnCobrar.Name = "btnCobrar";
            this.btnCobrar.Size = new System.Drawing.Size(70, 31);
            this.btnCobrar.TabIndex = 23;
            this.btnCobrar.Text = "Cobrar";
            this.btnCobrar.UseVisualStyleBackColor = false;
            this.btnCobrar.Click += new System.EventHandler(this.btnCobrar_Click);
            // 
            // lblPrecioTotal
            // 
            this.lblPrecioTotal.AutoSize = true;
            this.lblPrecioTotal.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F);
            this.lblPrecioTotal.Location = new System.Drawing.Point(530, 562);
            this.lblPrecioTotal.Name = "lblPrecioTotal";
            this.lblPrecioTotal.Size = new System.Drawing.Size(65, 25);
            this.lblPrecioTotal.TabIndex = 25;
            this.lblPrecioTotal.Text = "$0,00";
            // 
            // lblMetodoPago
            // 
            this.lblMetodoPago.AutoSize = true;
            this.lblMetodoPago.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.lblMetodoPago.Location = new System.Drawing.Point(548, 304);
            this.lblMetodoPago.Name = "lblMetodoPago";
            this.lblMetodoPago.Size = new System.Drawing.Size(124, 21);
            this.lblMetodoPago.TabIndex = 26;
            this.lblMetodoPago.Text = "Metodo de pago:";
            // 
            // cbxMetodoPago
            // 
            this.cbxMetodoPago.FormattingEnabled = true;
            this.cbxMetodoPago.Items.AddRange(new object[] {
            "Cod Prenda",
            "Nombre"});
            this.cbxMetodoPago.Location = new System.Drawing.Point(678, 304);
            this.cbxMetodoPago.Name = "cbxMetodoPago";
            this.cbxMetodoPago.Size = new System.Drawing.Size(156, 21);
            this.cbxMetodoPago.TabIndex = 27;
            // 
            // txtBuscarCliente
            // 
            this.txtBuscarCliente.Location = new System.Drawing.Point(324, 22);
            this.txtBuscarCliente.Name = "txtBuscarCliente";
            this.txtBuscarCliente.Size = new System.Drawing.Size(134, 20);
            this.txtBuscarCliente.TabIndex = 28;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Location = new System.Drawing.Point(460, 20);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(71, 22);
            this.btnBuscarCliente.TabIndex = 29;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // gbListaClientes
            // 
            this.gbListaClientes.Controls.Add(this.dgvClientesVentas);
            this.gbListaClientes.Controls.Add(this.lblListaClientes);
            this.gbListaClientes.Controls.Add(this.btnBuscarCliente);
            this.gbListaClientes.Controls.Add(this.cbxCliente);
            this.gbListaClientes.Controls.Add(this.txtBuscarCliente);
            this.gbListaClientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbListaClientes.Location = new System.Drawing.Point(175, 188);
            this.gbListaClientes.Name = "gbListaClientes";
            this.gbListaClientes.Size = new System.Drawing.Size(547, 225);
            this.gbListaClientes.TabIndex = 31;
            this.gbListaClientes.TabStop = false;
            // 
            // dgvClientesVentas
            // 
            this.dgvClientesVentas.AllowUserToAddRows = false;
            this.dgvClientesVentas.AllowUserToOrderColumns = true;
            this.dgvClientesVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClientesVentas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvClientesVentas.BackgroundColor = System.Drawing.Color.Lavender;
            this.dgvClientesVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientesVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_idCli,
            this.ColNomC,
            this.ColApeC,
            this.ColDniC,
            this.ColSelecC});
            this.dgvClientesVentas.Location = new System.Drawing.Point(16, 51);
            this.dgvClientesVentas.Name = "dgvClientesVentas";
            this.dgvClientesVentas.Size = new System.Drawing.Size(515, 157);
            this.dgvClientesVentas.TabIndex = 1;
            this.dgvClientesVentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientesVentas_CellContentClick);
            // 
            // Col_idCli
            // 
            this.Col_idCli.HeaderText = "ID";
            this.Col_idCli.Name = "Col_idCli";
            this.Col_idCli.Visible = false;
            // 
            // ColNomC
            // 
            this.ColNomC.HeaderText = "Nombre";
            this.ColNomC.Name = "ColNomC";
            // 
            // ColApeC
            // 
            this.ColApeC.HeaderText = "Apellido";
            this.ColApeC.Name = "ColApeC";
            // 
            // ColDniC
            // 
            this.ColDniC.HeaderText = "DNI";
            this.ColDniC.Name = "ColDniC";
            // 
            // ColSelecC
            // 
            this.ColSelecC.HeaderText = "Seleccionar";
            this.ColSelecC.Name = "ColSelecC";
            this.ColSelecC.Text = "Seleccionar";
            this.ColSelecC.UseColumnTextForButtonValue = true;
            // 
            // lblListaClientes
            // 
            this.lblListaClientes.AutoSize = true;
            this.lblListaClientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblListaClientes.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaClientes.Location = new System.Drawing.Point(13, 22);
            this.lblListaClientes.Name = "lblListaClientes";
            this.lblListaClientes.Size = new System.Drawing.Size(131, 15);
            this.lblListaClientes.TabIndex = 0;
            this.lblListaClientes.Text = "LISTA DE CLIENTES";
            // 
            // btnBuscarCPor
            // 
            //this.btnBuscarCPor.BackgroundImage = global::ProyectoTaller2.Properties.Resources.buscar3;
            this.btnBuscarCPor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBuscarCPor.Location = new System.Drawing.Point(805, 73);
            this.btnBuscarCPor.Name = "btnBuscarCPor";
            this.btnBuscarCPor.Size = new System.Drawing.Size(29, 30);
            this.btnBuscarCPor.TabIndex = 32;
            this.btnBuscarCPor.UseVisualStyleBackColor = true;
            this.btnBuscarCPor.Click += new System.EventHandler(this.btnBuscarCPor_Click);
            // 
            // lblClienteSelec
            // 
            this.lblClienteSelec.Location = new System.Drawing.Point(645, 79);
            this.lblClienteSelec.Name = "lblClienteSelec";
            this.lblClienteSelec.Size = new System.Drawing.Size(154, 20);
            this.lblClienteSelec.TabIndex = 33;
            // 
            // gridRealizarVenta
            // 
            this.gridRealizarVenta.AllowUserToAddRows = false;
            this.gridRealizarVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridRealizarVenta.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridRealizarVenta.BackgroundColor = System.Drawing.Color.Lavender;
            this.gridRealizarVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridRealizarVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_proId,
            this.col_NomProductoVR,
            this.col_precioUnitarioVR,
            this.col_cantidadVR,
            this.col_precioTotalVR,
            this.col_EliminarProRV});
            this.gridRealizarVenta.Location = new System.Drawing.Point(27, 331);
            this.gridRealizarVenta.Name = "gridRealizarVenta";
            this.gridRealizarVenta.Size = new System.Drawing.Size(807, 204);
            this.gridRealizarVenta.TabIndex = 8;
            this.gridRealizarVenta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridRealizarVenta_CellContentClick);
            this.gridRealizarVenta.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridRealizarVenta_CellEndEdit);
            this.gridRealizarVenta.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridRealizarVenta_CellValueChanged);
            // 
            // Col_proId
            // 
            this.Col_proId.HeaderText = "ID";
            this.Col_proId.Name = "Col_proId";
            this.Col_proId.Visible = false;
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
            this.col_precioTotalVR.HeaderText = "Subtotal";
            this.col_precioTotalVR.Name = "col_precioTotalVR";
            // 
            // col_EliminarProRV
            // 
            this.col_EliminarProRV.HeaderText = "Eliminar";
            this.col_EliminarProRV.Name = "col_EliminarProRV";
            this.col_EliminarProRV.Text = "Eliminar";
            this.col_EliminarProRV.UseColumnTextForButtonValue = true;
            // 
            // RealizarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(864, 650);
            this.Controls.Add(this.lblClienteSelec);
            this.Controls.Add(this.btnBuscarCPor);
            this.Controls.Add(this.gbListaClientes);
            this.Controls.Add(this.cbxMetodoPago);
            this.Controls.Add(this.lblMetodoPago);
            this.Controls.Add(this.lblPrecioTotal);
            this.Controls.Add(this.btnCancelarVenta);
            this.Controls.Add(this.btnCobrar);
            this.Controls.Add(this.lblTotalPagar);
            this.Controls.Add(this.lblDetalleVenta);
            this.Controls.Add(this.cbxBuscarPor);
            this.Controls.Add(this.tbxBuscarProducto);
            this.Controls.Add(this.btnBuscarProducto);
            this.Controls.Add(this.lblSelecPro);
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
            this.Load += new System.EventHandler(this.RealizarVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridVentaProducto)).EndInit();
            this.gbListaClientes.ResumeLayout(false);
            this.gbListaClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientesVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridRealizarVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNuevaVenta;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFechaVenta;
        private System.Windows.Forms.DataGridView gridVentaProducto;
        private System.Windows.Forms.Label lblNomVendedor;
        private System.Windows.Forms.ComboBox cbxCliente;
        private System.Windows.Forms.Label lblClienteV;
        private System.Windows.Forms.Label lblSelecPro;
        private System.Windows.Forms.ComboBox cbxBuscarPor;
        private System.Windows.Forms.TextBox tbxBuscarProducto;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.Label lblDetalleVenta;
        private System.Windows.Forms.Label lblTotalPagar;
        private System.Windows.Forms.Button btnCancelarVenta;
        private System.Windows.Forms.Button btnCobrar;
        private System.Windows.Forms.Label lblPrecioTotal;
        private System.Windows.Forms.Label lblMetodoPago;
        private System.Windows.Forms.ComboBox cbxMetodoPago;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.TextBox txtBuscarCliente;
        private System.Windows.Forms.GroupBox gbListaClientes;
        private System.Windows.Forms.Label lblListaClientes;
        private System.Windows.Forms.DataGridView dgvClientesVentas;
        private System.Windows.Forms.Button btnBuscarCPor;
        private System.Windows.Forms.TextBox lblClienteSelec;
        private System.Windows.Forms.DataGridView gridRealizarVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_idCli;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNomC;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColApeC;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDniC;
        private System.Windows.Forms.DataGridViewButtonColumn ColSelecC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_idPro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNomP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDescrip;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColStock;
        private System.Windows.Forms.DataGridViewButtonColumn ColAgregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_proId;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_NomProductoVR;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_precioUnitarioVR;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cantidadVR;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_precioTotalVR;
        private System.Windows.Forms.DataGridViewButtonColumn col_EliminarProRV;
    }
}