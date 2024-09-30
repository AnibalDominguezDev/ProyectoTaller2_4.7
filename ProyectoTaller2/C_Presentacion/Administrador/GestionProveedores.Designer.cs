namespace ProyectoTaller2.C_Presentacion.Administrador
{
    partial class GestionProveedores
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
            this.btnNuevoProveedor = new System.Windows.Forms.Button();
            this.btnAplicar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.lblAgregarProducto = new System.Windows.Forms.Label();
            this.dgbDetalleProductos = new System.Windows.Forms.DataGridView();
            this.ColFechaAlta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.testEditar = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgbDetalleProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.panelHeader.Controls.Add(this.testEditar);
            this.panelHeader.Controls.Add(this.btnNuevoProveedor);
            this.panelHeader.Controls.Add(this.btnAplicar);
            this.panelHeader.Controls.Add(this.btnBuscar);
            this.panelHeader.Controls.Add(this.textBox2);
            this.panelHeader.Controls.Add(this.comboBox2);
            this.panelHeader.Controls.Add(this.textBox1);
            this.panelHeader.Controls.Add(this.comboBox1);
            this.panelHeader.Controls.Add(this.label1);
            this.panelHeader.Controls.Add(this.lblBuscar);
            this.panelHeader.Controls.Add(this.lblAgregarProducto);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(880, 100);
            this.panelHeader.TabIndex = 1;
            // 
            // btnNuevoProveedor
            // 
            this.btnNuevoProveedor.Location = new System.Drawing.Point(18, 54);
            this.btnNuevoProveedor.Name = "btnNuevoProveedor";
            this.btnNuevoProveedor.Size = new System.Drawing.Size(107, 24);
            this.btnNuevoProveedor.TabIndex = 10;
            this.btnNuevoProveedor.Text = "Nuevo proveedor";
            this.btnNuevoProveedor.UseVisualStyleBackColor = true;
            this.btnNuevoProveedor.Click += new System.EventHandler(this.btnNuevoProveedor_Click);
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
            // lblAgregarProducto
            // 
            this.lblAgregarProducto.AutoSize = true;
            this.lblAgregarProducto.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblAgregarProducto.Location = new System.Drawing.Point(12, 11);
            this.lblAgregarProducto.Name = "lblAgregarProducto";
            this.lblAgregarProducto.Size = new System.Drawing.Size(274, 32);
            this.lblAgregarProducto.TabIndex = 1;
            this.lblAgregarProducto.Text = "Gestionar proveedores";
            // 
            // dgbDetalleProductos
            // 
            this.dgbDetalleProductos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(247)))));
            this.dgbDetalleProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgbDetalleProductos.ColumnHeadersHeight = 40;
            this.dgbDetalleProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgbDetalleProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColFechaAlta,
            this.colNombre,
            this.ColDireccion,
            this.ColTelefono,
            this.colEmail,
            this.ColEditar});
            this.dgbDetalleProductos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgbDetalleProductos.Location = new System.Drawing.Point(3, 106);
            this.dgbDetalleProductos.Name = "dgbDetalleProductos";
            this.dgbDetalleProductos.RowHeadersVisible = false;
            this.dgbDetalleProductos.Size = new System.Drawing.Size(865, 462);
            this.dgbDetalleProductos.TabIndex = 4;
            // 
            // ColFechaAlta
            // 
            this.ColFechaAlta.HeaderText = "Fecha de Alta";
            this.ColFechaAlta.Name = "ColFechaAlta";
            this.ColFechaAlta.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colNombre
            // 
            this.colNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            // 
            // ColDireccion
            // 
            this.ColDireccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColDireccion.HeaderText = "Dirección";
            this.ColDireccion.Name = "ColDireccion";
            // 
            // ColTelefono
            // 
            this.ColTelefono.HeaderText = "Telefono";
            this.ColTelefono.Name = "ColTelefono";
            this.ColTelefono.Width = 120;
            // 
            // colEmail
            // 
            this.colEmail.HeaderText = "Email";
            this.colEmail.Name = "colEmail";
            // 
            // ColEditar
            // 
            this.ColEditar.HeaderText = "Editar";
            this.ColEditar.Name = "ColEditar";
            this.ColEditar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColEditar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // testEditar
            // 
            this.testEditar.Location = new System.Drawing.Point(143, 55);
            this.testEditar.Name = "testEditar";
            this.testEditar.Size = new System.Drawing.Size(107, 24);
            this.testEditar.TabIndex = 11;
            this.testEditar.Text = "test Editar";
            this.testEditar.UseVisualStyleBackColor = true;
            this.testEditar.Click += new System.EventHandler(this.testEditar_Click);
            // 
            // GestionProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(880, 600);
            this.Controls.Add(this.dgbDetalleProductos);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GestionProveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GestionProveedores";
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
        private System.Windows.Forms.Label lblAgregarProducto;
        private System.Windows.Forms.Button btnNuevoProveedor;
        private System.Windows.Forms.DataGridView dgbDetalleProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFechaAlta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewButtonColumn ColEditar;
        private System.Windows.Forms.Button testEditar;
    }
}