namespace ProyectoTaller2.C_Presentacion.Administrador
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
            this.components = new System.ComponentModel.Container();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnNuevoProducto = new System.Windows.Forms.Button();
            this.testEditar = new System.Windows.Forms.Button();
            this.btnAplicar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cbxFiltroCategorias = new System.Windows.Forms.ComboBox();
            this.tbxBuscarCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.lblProductos = new System.Windows.Forms.Label();
            this.dgbDetalleProductos = new System.Windows.Forms.DataGridView();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgbDetalleProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.panelHeader.Controls.Add(this.btnNuevoProducto);
            this.panelHeader.Controls.Add(this.testEditar);
            this.panelHeader.Controls.Add(this.btnAplicar);
            this.panelHeader.Controls.Add(this.btnBuscar);
            this.panelHeader.Controls.Add(this.cbxFiltroCategorias);
            this.panelHeader.Controls.Add(this.tbxBuscarCodigo);
            this.panelHeader.Controls.Add(this.label1);
            this.panelHeader.Controls.Add(this.lblBuscar);
            this.panelHeader.Controls.Add(this.lblProductos);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(880, 100);
            this.panelHeader.TabIndex = 2;
            // 
            // btnNuevoProducto
            // 
            this.btnNuevoProducto.Location = new System.Drawing.Point(18, 55);
            this.btnNuevoProducto.Name = "btnNuevoProducto";
            this.btnNuevoProducto.Size = new System.Drawing.Size(125, 21);
            this.btnNuevoProducto.TabIndex = 11;
            this.btnNuevoProducto.Text = "Nuevo Producto";
            this.btnNuevoProducto.UseVisualStyleBackColor = true;
            this.btnNuevoProducto.Click += new System.EventHandler(this.btnNuevoProducto_Click);
            // 
            // testEditar
            // 
            this.testEditar.Location = new System.Drawing.Point(174, 52);
            this.testEditar.Name = "testEditar";
            this.testEditar.Size = new System.Drawing.Size(75, 23);
            this.testEditar.TabIndex = 10;
            this.testEditar.Text = "testEditar";
            this.testEditar.UseVisualStyleBackColor = true;
            this.testEditar.Click += new System.EventHandler(this.testEditar_Click);
            // 
            // btnAplicar
            // 
            this.btnAplicar.Location = new System.Drawing.Point(784, 53);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(75, 23);
            this.btnAplicar.TabIndex = 9;
            this.btnAplicar.Text = "Aplicar";
            this.btnAplicar.UseVisualStyleBackColor = true;
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(784, 21);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cbxFiltroCategorias
            // 
            this.cbxFiltroCategorias.FormattingEnabled = true;
            this.cbxFiltroCategorias.Location = new System.Drawing.Point(674, 54);
            this.cbxFiltroCategorias.Name = "cbxFiltroCategorias";
            this.cbxFiltroCategorias.Size = new System.Drawing.Size(100, 21);
            this.cbxFiltroCategorias.TabIndex = 6;
            // 
            // tbxBuscarCodigo
            // 
            this.tbxBuscarCodigo.Location = new System.Drawing.Point(674, 22);
            this.tbxBuscarCodigo.Name = "tbxBuscarCodigo";
            this.tbxBuscarCodigo.Size = new System.Drawing.Size(100, 20);
            this.tbxBuscarCodigo.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.label1.Location = new System.Drawing.Point(533, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Filtrar por:";
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.lblBuscar.Location = new System.Drawing.Point(533, 21);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(135, 21);
            this.lblBuscar.TabIndex = 2;
            this.lblBuscar.Text = "Buscar por codigo:";
            // 
            // lblProductos
            // 
            this.lblProductos.AutoSize = true;
            this.lblProductos.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblProductos.Location = new System.Drawing.Point(12, 18);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(248, 32);
            this.lblProductos.TabIndex = 1;
            this.lblProductos.Text = "Gestionar Productos";
            // 
            // dgbDetalleProductos
            // 
            this.dgbDetalleProductos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(247)))));
            this.dgbDetalleProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgbDetalleProductos.ColumnHeadersHeight = 40;
            this.dgbDetalleProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgbDetalleProductos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgbDetalleProductos.Location = new System.Drawing.Point(5, 106);
            this.dgbDetalleProductos.Name = "dgbDetalleProductos";
            this.dgbDetalleProductos.RowHeadersVisible = false;
            this.dgbDetalleProductos.Size = new System.Drawing.Size(868, 462);
            this.dgbDetalleProductos.TabIndex = 11;
            this.dgbDetalleProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgbDetalleProductos_CellClick);
            this.dgbDetalleProductos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgbDetalleProductos_CellFormatting);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // ListarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(880, 600);
            this.Controls.Add(this.dgbDetalleProductos);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListarProductos";
            this.Text = "Listar Productos";
            this.Load += new System.EventHandler(this.ListarProductos_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgbDetalleProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button btnAplicar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cbxFiltroCategorias;
        private System.Windows.Forms.TextBox tbxBuscarCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Label lblProductos;
        private System.Windows.Forms.DataGridView dgbDetalleProductos;
        private System.Windows.Forms.Button testEditar;
        private System.Windows.Forms.Button btnNuevoProducto;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}