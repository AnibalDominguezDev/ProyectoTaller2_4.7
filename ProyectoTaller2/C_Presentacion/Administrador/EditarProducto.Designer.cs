﻿namespace ProyectoTaller2.C_Presentacion.Administrador
{
    partial class EditarProducto
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
            this.panelFondo = new System.Windows.Forms.Panel();
            this.tbxPrecio = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.cbxMarca = new System.Windows.Forms.ComboBox();
            this.cbxProveedor = new System.Windows.Forms.ComboBox();
            this.tbxCodPrenda = new System.Windows.Forms.TextBox();
            this.lblCodPrenda = new System.Windows.Forms.Label();
            this.tbxStockMinimo = new System.Windows.Forms.TextBox();
            this.tbxStock = new System.Windows.Forms.TextBox();
            this.tbxDescripcion = new System.Windows.Forms.TextBox();
            this.lblStockMinimo = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.tbxNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblAgregarProducto = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelFondo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // panelFondo
            // 
            this.panelFondo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.panelFondo.Controls.Add(this.tbxPrecio);
            this.panelFondo.Controls.Add(this.lblPrecio);
            this.panelFondo.Controls.Add(this.btnCancelar);
            this.panelFondo.Controls.Add(this.btnAgregar);
            this.panelFondo.Controls.Add(this.cbxCategoria);
            this.panelFondo.Controls.Add(this.cbxMarca);
            this.panelFondo.Controls.Add(this.cbxProveedor);
            this.panelFondo.Controls.Add(this.tbxCodPrenda);
            this.panelFondo.Controls.Add(this.lblCodPrenda);
            this.panelFondo.Controls.Add(this.tbxStockMinimo);
            this.panelFondo.Controls.Add(this.tbxStock);
            this.panelFondo.Controls.Add(this.tbxDescripcion);
            this.panelFondo.Controls.Add(this.lblStockMinimo);
            this.panelFondo.Controls.Add(this.lblStock);
            this.panelFondo.Controls.Add(this.lblCategoria);
            this.panelFondo.Controls.Add(this.lblMarca);
            this.panelFondo.Controls.Add(this.lblProveedor);
            this.panelFondo.Controls.Add(this.lblDescripcion);
            this.panelFondo.Controls.Add(this.tbxNombre);
            this.panelFondo.Controls.Add(this.lblNombre);
            this.panelFondo.Controls.Add(this.lblAgregarProducto);
            this.panelFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFondo.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F);
            this.panelFondo.Location = new System.Drawing.Point(0, 0);
            this.panelFondo.Name = "panelFondo";
            this.panelFondo.Size = new System.Drawing.Size(484, 611);
            this.panelFondo.TabIndex = 1;
            // 
            // tbxPrecio
            // 
            this.tbxPrecio.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tbxPrecio.Location = new System.Drawing.Point(158, 231);
            this.tbxPrecio.Name = "tbxPrecio";
            this.tbxPrecio.Size = new System.Drawing.Size(242, 25);
            this.tbxPrecio.TabIndex = 28;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(34, 231);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(66, 24);
            this.lblPrecio.TabIndex = 27;
            this.lblPrecio.Text = "Precio:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnCancelar.Location = new System.Drawing.Point(246, 556);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(110, 43);
            this.btnCancelar.TabIndex = 26;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnAgregar.Location = new System.Drawing.Point(362, 556);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(110, 43);
            this.btnAgregar.TabIndex = 25;
            this.btnAgregar.Text = "Editar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Location = new System.Drawing.Point(158, 369);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(242, 25);
            this.cbxCategoria.TabIndex = 24;
            // 
            // cbxMarca
            // 
            this.cbxMarca.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbxMarca.FormattingEnabled = true;
            this.cbxMarca.Location = new System.Drawing.Point(158, 327);
            this.cbxMarca.Name = "cbxMarca";
            this.cbxMarca.Size = new System.Drawing.Size(242, 25);
            this.cbxMarca.TabIndex = 23;
            // 
            // cbxProveedor
            // 
            this.cbxProveedor.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbxProveedor.FormattingEnabled = true;
            this.cbxProveedor.Location = new System.Drawing.Point(158, 285);
            this.cbxProveedor.Name = "cbxProveedor";
            this.cbxProveedor.Size = new System.Drawing.Size(242, 25);
            this.cbxProveedor.TabIndex = 22;
            // 
            // tbxCodPrenda
            // 
            this.tbxCodPrenda.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tbxCodPrenda.Location = new System.Drawing.Point(158, 51);
            this.tbxCodPrenda.Name = "tbxCodPrenda";
            this.tbxCodPrenda.Size = new System.Drawing.Size(242, 25);
            this.tbxCodPrenda.TabIndex = 21;
            // 
            // lblCodPrenda
            // 
            this.lblCodPrenda.AutoSize = true;
            this.lblCodPrenda.Location = new System.Drawing.Point(34, 51);
            this.lblCodPrenda.Name = "lblCodPrenda";
            this.lblCodPrenda.Size = new System.Drawing.Size(108, 24);
            this.lblCodPrenda.TabIndex = 20;
            this.lblCodPrenda.Text = "Cod Prenda:";
            // 
            // tbxStockMinimo
            // 
            this.tbxStockMinimo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tbxStockMinimo.Location = new System.Drawing.Point(158, 465);
            this.tbxStockMinimo.Name = "tbxStockMinimo";
            this.tbxStockMinimo.Size = new System.Drawing.Size(242, 25);
            this.tbxStockMinimo.TabIndex = 19;
            this.tbxStockMinimo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxStockMinimo_KeyPress);
            // 
            // tbxStock
            // 
            this.tbxStock.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tbxStock.Location = new System.Drawing.Point(158, 413);
            this.tbxStock.Name = "tbxStock";
            this.tbxStock.Size = new System.Drawing.Size(242, 25);
            this.tbxStock.TabIndex = 11;
            this.tbxStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxStock_KeyPress);
            // 
            // tbxDescripcion
            // 
            this.tbxDescripcion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tbxDescripcion.Location = new System.Drawing.Point(158, 141);
            this.tbxDescripcion.Multiline = true;
            this.tbxDescripcion.Name = "tbxDescripcion";
            this.tbxDescripcion.Size = new System.Drawing.Size(242, 69);
            this.tbxDescripcion.TabIndex = 9;
            // 
            // lblStockMinimo
            // 
            this.lblStockMinimo.AutoSize = true;
            this.lblStockMinimo.Location = new System.Drawing.Point(34, 464);
            this.lblStockMinimo.Name = "lblStockMinimo";
            this.lblStockMinimo.Size = new System.Drawing.Size(128, 24);
            this.lblStockMinimo.TabIndex = 8;
            this.lblStockMinimo.Text = "Stock Minimo:";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(34, 414);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(66, 24);
            this.lblStock.TabIndex = 7;
            this.lblStock.Text = "Stock :";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(34, 369);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(93, 24);
            this.lblCategoria.TabIndex = 6;
            this.lblCategoria.Text = "Categoria:";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(34, 326);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(65, 24);
            this.lblMarca.TabIndex = 5;
            this.lblMarca.Text = "Marca:";
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Location = new System.Drawing.Point(34, 284);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(96, 24);
            this.lblProveedor.TabIndex = 4;
            this.lblProveedor.Text = "Proveedor:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(34, 141);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(110, 24);
            this.lblDescripcion.TabIndex = 3;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // tbxNombre
            // 
            this.tbxNombre.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tbxNombre.Location = new System.Drawing.Point(158, 93);
            this.tbxNombre.Name = "tbxNombre";
            this.tbxNombre.Size = new System.Drawing.Size(242, 25);
            this.tbxNombre.TabIndex = 2;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(34, 93);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(80, 24);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblAgregarProducto
            // 
            this.lblAgregarProducto.AutoSize = true;
            this.lblAgregarProducto.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblAgregarProducto.Location = new System.Drawing.Point(32, 9);
            this.lblAgregarProducto.Name = "lblAgregarProducto";
            this.lblAgregarProducto.Size = new System.Drawing.Size(194, 32);
            this.lblAgregarProducto.TabIndex = 0;
            this.lblAgregarProducto.Text = "Editar producto";
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkRate = 300;
            this.errorProvider.ContainerControl = this;
            // 
            // EditarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 611);
            this.Controls.Add(this.panelFondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Producto";
            this.Load += new System.EventHandler(this.EditarProducto_Load);
            this.panelFondo.ResumeLayout(false);
            this.panelFondo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFondo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.ComboBox cbxMarca;
        private System.Windows.Forms.ComboBox cbxProveedor;
        private System.Windows.Forms.TextBox tbxCodPrenda;
        private System.Windows.Forms.Label lblCodPrenda;
        private System.Windows.Forms.TextBox tbxStockMinimo;
        private System.Windows.Forms.TextBox tbxStock;
        private System.Windows.Forms.TextBox tbxDescripcion;
        private System.Windows.Forms.Label lblStockMinimo;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox tbxNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblAgregarProducto;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.TextBox tbxPrecio;
        private System.Windows.Forms.Label lblPrecio;
    }
}