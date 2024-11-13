namespace ProyectoTaller2.C_Presentacion.Vendedor
{
    partial class ListarProductos
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
            this.dgbDetalleProductos = new System.Windows.Forms.DataGridView();
            this.colCodPrenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecioUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxProductos = new System.Windows.Forms.GroupBox();
            this.btxFiltrar = new System.Windows.Forms.Button();
            this.cbxFiltrarCategoria = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxBuscarPor = new System.Windows.Forms.ComboBox();
            this.tbxBuscarProducto = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.lblProductos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgbDetalleProductos)).BeginInit();
            this.gbxProductos.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgbDetalleProductos
            // 
            this.dgbDetalleProductos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(247)))));
            this.dgbDetalleProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgbDetalleProductos.ColumnHeadersHeight = 40;
            this.dgbDetalleProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgbDetalleProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodPrenda,
            this.colNombreProducto,
            this.colDescripcion,
            this.ColStock,
            this.colPrecioUnit,
            this.colCategoria});
            this.dgbDetalleProductos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgbDetalleProductos.Location = new System.Drawing.Point(6, 134);
            this.dgbDetalleProductos.Name = "dgbDetalleProductos";
            this.dgbDetalleProductos.RowHeadersVisible = false;
            this.dgbDetalleProductos.Size = new System.Drawing.Size(868, 444);
            this.dgbDetalleProductos.TabIndex = 12;
            // 
            // colCodPrenda
            // 
            this.colCodPrenda.HeaderText = "Cod Prenda";
            this.colCodPrenda.Name = "colCodPrenda";
            this.colCodPrenda.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colNombreProducto
            // 
            this.colNombreProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNombreProducto.HeaderText = "Nombre";
            this.colNombreProducto.Name = "colNombreProducto";
            // 
            // colDescripcion
            // 
            this.colDescripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDescripcion.HeaderText = "Descripcion";
            this.colDescripcion.Name = "colDescripcion";
            // 
            // ColStock
            // 
            this.ColStock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColStock.HeaderText = "Stock";
            this.ColStock.Name = "ColStock";
            this.ColStock.Width = 60;
            // 
            // colPrecioUnit
            // 
            this.colPrecioUnit.HeaderText = "Precio Unitario";
            this.colPrecioUnit.Name = "colPrecioUnit";
            // 
            // colCategoria
            // 
            this.colCategoria.HeaderText = "Categoria";
            this.colCategoria.Name = "colCategoria";
            // 
            // gbxProductos
            // 
            this.gbxProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gbxProductos.Controls.Add(this.btxFiltrar);
            this.gbxProductos.Controls.Add(this.cbxFiltrarCategoria);
            this.gbxProductos.Controls.Add(this.label1);
            this.gbxProductos.Controls.Add(this.cbxBuscarPor);
            this.gbxProductos.Controls.Add(this.tbxBuscarProducto);
            this.gbxProductos.Controls.Add(this.btnBuscar);
            this.gbxProductos.Controls.Add(this.lblBuscar);
            this.gbxProductos.Controls.Add(this.lblProductos);
            this.gbxProductos.Location = new System.Drawing.Point(6, 12);
            this.gbxProductos.Name = "gbxProductos";
            this.gbxProductos.Size = new System.Drawing.Size(868, 116);
            this.gbxProductos.TabIndex = 13;
            this.gbxProductos.TabStop = false;
            // 
            // btxFiltrar
            // 
            this.btxFiltrar.Location = new System.Drawing.Point(780, 49);
            this.btxFiltrar.Name = "btxFiltrar";
            this.btxFiltrar.Size = new System.Drawing.Size(71, 22);
            this.btxFiltrar.TabIndex = 12;
            this.btxFiltrar.Text = "Filtrar";
            this.btxFiltrar.UseVisualStyleBackColor = true;
            // 
            // cbxFiltrarCategoria
            // 
            this.cbxFiltrarCategoria.FormattingEnabled = true;
            this.cbxFiltrarCategoria.Items.AddRange(new object[] {
            "Cod Prenda",
            "Nombre"});
            this.cbxFiltrarCategoria.Location = new System.Drawing.Point(640, 49);
            this.cbxFiltrarCategoria.Name = "cbxFiltrarCategoria";
            this.cbxFiltrarCategoria.Size = new System.Drawing.Size(134, 21);
            this.cbxFiltrarCategoria.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.label1.Location = new System.Drawing.Point(456, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "Filtrar por categoria:";
            // 
            // cbxBuscarPor
            // 
            this.cbxBuscarPor.FormattingEnabled = true;
            this.cbxBuscarPor.Items.AddRange(new object[] {
            "Cod Prenda",
            "Nombre"});
            this.cbxBuscarPor.Location = new System.Drawing.Point(549, 82);
            this.cbxBuscarPor.Name = "cbxBuscarPor";
            this.cbxBuscarPor.Size = new System.Drawing.Size(85, 21);
            this.cbxBuscarPor.TabIndex = 9;
            // 
            // tbxBuscarProducto
            // 
            this.tbxBuscarProducto.Location = new System.Drawing.Point(640, 82);
            this.tbxBuscarProducto.Name = "tbxBuscarProducto";
            this.tbxBuscarProducto.Size = new System.Drawing.Size(134, 20);
            this.tbxBuscarProducto.TabIndex = 8;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(780, 81);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(71, 22);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.lblBuscar.Location = new System.Drawing.Point(456, 81);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(87, 21);
            this.lblBuscar.TabIndex = 4;
            this.lblBuscar.Text = "Buscar por:";
            // 
            // lblProductos
            // 
            this.lblProductos.AutoSize = true;
            this.lblProductos.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblProductos.Location = new System.Drawing.Point(16, 16);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(200, 32);
            this.lblProductos.TabIndex = 2;
            this.lblProductos.Text = "Listar productos";
            // 
            // ListarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(880, 600);
            this.Controls.Add(this.gbxProductos);
            this.Controls.Add(this.dgbDetalleProductos);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListarProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListarProductos";
            this.Load += new System.EventHandler(this.ListarProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgbDetalleProductos)).EndInit();
            this.gbxProductos.ResumeLayout(false);
            this.gbxProductos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgbDetalleProductos;
        private System.Windows.Forms.GroupBox gbxProductos;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Label lblProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodPrenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecioUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoria;
        private System.Windows.Forms.Button btxFiltrar;
        private System.Windows.Forms.ComboBox cbxFiltrarCategoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxBuscarPor;
        private System.Windows.Forms.TextBox tbxBuscarProducto;
    }
}