namespace ProyectoTaller2.C_Presentacion.Vendedor
{
    partial class MenuVendedor
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
            this.panelMenuVendedor = new System.Windows.Forms.Panel();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnAltaCliente = new System.Windows.Forms.Button();
            this.btnRealizarVenta = new System.Windows.Forms.Button();
            this.btnMisVentas = new System.Windows.Forms.Button();
            this.btnListaProductos = new System.Windows.Forms.Button();
            this.pbxLogoV = new System.Windows.Forms.PictureBox();
            this.lblNomUsuario = new System.Windows.Forms.Label();
            this.lblTituloVendedor = new System.Windows.Forms.Label();
            this.panelMuestra = new System.Windows.Forms.Panel();
            this.panelMenuVendedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogoV)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenuVendedor
            // 
            this.panelMenuVendedor.BackColor = System.Drawing.Color.White;
            this.panelMenuVendedor.Controls.Add(this.btnCerrarSesion);
            this.panelMenuVendedor.Controls.Add(this.btnAltaCliente);
            this.panelMenuVendedor.Controls.Add(this.btnRealizarVenta);
            this.panelMenuVendedor.Controls.Add(this.btnMisVentas);
            this.panelMenuVendedor.Controls.Add(this.btnListaProductos);
            this.panelMenuVendedor.Controls.Add(this.pbxLogoV);
            this.panelMenuVendedor.Controls.Add(this.lblNomUsuario);
            this.panelMenuVendedor.Controls.Add(this.lblTituloVendedor);
            this.panelMenuVendedor.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuVendedor.Location = new System.Drawing.Point(0, 0);
            this.panelMenuVendedor.Name = "panelMenuVendedor";
            this.panelMenuVendedor.Size = new System.Drawing.Size(300, 611);
            this.panelMenuVendedor.TabIndex = 1;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.Salmon;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCerrarSesion.Image = global::ProyectoTaller2.Properties.Resources.salida__1_;
            this.btnCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSesion.Location = new System.Drawing.Point(34, 556);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnCerrarSesion.Size = new System.Drawing.Size(232, 34);
            this.btnCerrarSesion.TabIndex = 5;
            this.btnCerrarSesion.Text = "Cerrar sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnAltaCliente
            // 
            this.btnAltaCliente.Image = global::ProyectoTaller2.Properties.Resources.agregar_usuario_small;
            this.btnAltaCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAltaCliente.Location = new System.Drawing.Point(34, 477);
            this.btnAltaCliente.Name = "btnAltaCliente";
            this.btnAltaCliente.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnAltaCliente.Size = new System.Drawing.Size(232, 47);
            this.btnAltaCliente.TabIndex = 4;
            this.btnAltaCliente.Text = "Alta Cliente";
            this.btnAltaCliente.UseVisualStyleBackColor = true;
            this.btnAltaCliente.Click += new System.EventHandler(this.btnAltaCliente_Click);
            // 
            // btnRealizarVenta
            // 
            this.btnRealizarVenta.Image = global::ProyectoTaller2.Properties.Resources.carro_de_compras_rapido;
            this.btnRealizarVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRealizarVenta.Location = new System.Drawing.Point(34, 289);
            this.btnRealizarVenta.Name = "btnRealizarVenta";
            this.btnRealizarVenta.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnRealizarVenta.Size = new System.Drawing.Size(232, 47);
            this.btnRealizarVenta.TabIndex = 1;
            this.btnRealizarVenta.Text = "Realizar Venta";
            this.btnRealizarVenta.UseVisualStyleBackColor = true;
            this.btnRealizarVenta.Click += new System.EventHandler(this.btnRealizarVenta_Click);
            // 
            // btnMisVentas
            // 
            this.btnMisVentas.Image = global::ProyectoTaller2.Properties.Resources.lista_venta;
            this.btnMisVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMisVentas.Location = new System.Drawing.Point(34, 351);
            this.btnMisVentas.Name = "btnMisVentas";
            this.btnMisVentas.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnMisVentas.Size = new System.Drawing.Size(232, 47);
            this.btnMisVentas.TabIndex = 2;
            this.btnMisVentas.Text = "Mis ventas";
            this.btnMisVentas.UseVisualStyleBackColor = true;
            this.btnMisVentas.Click += new System.EventHandler(this.btnMisVentas_Click);
            // 
            // btnListaProductos
            // 
            this.btnListaProductos.Image = global::ProyectoTaller2.Properties.Resources.comprobacion_de_lista;
            this.btnListaProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListaProductos.Location = new System.Drawing.Point(34, 416);
            this.btnListaProductos.Name = "btnListaProductos";
            this.btnListaProductos.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnListaProductos.Size = new System.Drawing.Size(232, 47);
            this.btnListaProductos.TabIndex = 3;
            this.btnListaProductos.Text = "Listar Productos";
            this.btnListaProductos.UseVisualStyleBackColor = true;
            this.btnListaProductos.Click += new System.EventHandler(this.btnListaProductos_Click);
            // 
            // pbxLogoV
            // 
            this.pbxLogoV.Image = global::ProyectoTaller2.Properties.Resources.logo;
            this.pbxLogoV.Location = new System.Drawing.Point(57, 28);
            this.pbxLogoV.Name = "pbxLogoV";
            this.pbxLogoV.Size = new System.Drawing.Size(180, 180);
            this.pbxLogoV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxLogoV.TabIndex = 11;
            this.pbxLogoV.TabStop = false;
            // 
            // lblNomUsuario
            // 
            this.lblNomUsuario.AutoSize = true;
            this.lblNomUsuario.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNomUsuario.Location = new System.Drawing.Point(59, 248);
            this.lblNomUsuario.Name = "lblNomUsuario";
            this.lblNomUsuario.Size = new System.Drawing.Size(162, 19);
            this.lblNomUsuario.TabIndex = 10;
            this.lblNomUsuario.Text = "Conectado como: (name)";
            // 
            // lblTituloVendedor
            // 
            this.lblTituloVendedor.AutoSize = true;
            this.lblTituloVendedor.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTituloVendedor.Location = new System.Drawing.Point(86, 211);
            this.lblTituloVendedor.Name = "lblTituloVendedor";
            this.lblTituloVendedor.Size = new System.Drawing.Size(124, 32);
            this.lblTituloVendedor.TabIndex = 9;
            this.lblTituloVendedor.Text = "Vendedor";
            // 
            // panelMuestra
            // 
            this.panelMuestra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMuestra.Location = new System.Drawing.Point(300, 0);
            this.panelMuestra.Name = "panelMuestra";
            this.panelMuestra.Size = new System.Drawing.Size(884, 611);
            this.panelMuestra.TabIndex = 3;
            // 
            // MenuVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 611);
            this.Controls.Add(this.panelMuestra);
            this.Controls.Add(this.panelMenuVendedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "MenuVendedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clothing store: Vendedor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuVendedor_FormClosing);
            this.panelMenuVendedor.ResumeLayout(false);
            this.panelMenuVendedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogoV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenuVendedor;
        private System.Windows.Forms.PictureBox pbxLogoV;
        private System.Windows.Forms.Label lblNomUsuario;
        private System.Windows.Forms.Label lblTituloVendedor;
        private System.Windows.Forms.Button btnListaProductos;
        private System.Windows.Forms.Button btnAltaCliente;
        private System.Windows.Forms.Button btnRealizarVenta;
        private System.Windows.Forms.Button btnMisVentas;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Panel panelMuestra;
    }
}