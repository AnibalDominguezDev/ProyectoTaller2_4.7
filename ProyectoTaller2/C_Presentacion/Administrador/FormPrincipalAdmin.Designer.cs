namespace ProyectoTaller2.C_Presentacion.Administrador
{
    partial class FormPrincipalAdmin
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
            this.PanelMenuAdmin = new System.Windows.Forms.Panel();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnInformesVentas = new System.Windows.Forms.Button();
            this.btnGestionProveedores = new System.Windows.Forms.Button();
            this.btnGestionarClientes = new System.Windows.Forms.Button();
            this.btnGestionarProductos = new System.Windows.Forms.Button();
            this.btnListarVentas = new System.Windows.Forms.Button();
            this.lblNombreAdmin = new System.Windows.Forms.Label();
            this.lblTituloAdmin = new System.Windows.Forms.Label();
            this.PanelMenuAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelMenuAdmin
            // 
            this.PanelMenuAdmin.BackColor = System.Drawing.Color.White;
            this.PanelMenuAdmin.Controls.Add(this.pbxLogo);
            this.PanelMenuAdmin.Controls.Add(this.btnCerrarSesion);
            this.PanelMenuAdmin.Controls.Add(this.btnInformesVentas);
            this.PanelMenuAdmin.Controls.Add(this.btnGestionProveedores);
            this.PanelMenuAdmin.Controls.Add(this.btnGestionarClientes);
            this.PanelMenuAdmin.Controls.Add(this.btnGestionarProductos);
            this.PanelMenuAdmin.Controls.Add(this.btnListarVentas);
            this.PanelMenuAdmin.Controls.Add(this.lblNombreAdmin);
            this.PanelMenuAdmin.Controls.Add(this.lblTituloAdmin);
            this.PanelMenuAdmin.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenuAdmin.Location = new System.Drawing.Point(0, 0);
            this.PanelMenuAdmin.Name = "PanelMenuAdmin";
            this.PanelMenuAdmin.Size = new System.Drawing.Size(300, 611);
            this.PanelMenuAdmin.TabIndex = 1;
            // 
            // pbxLogo
            // 
            this.pbxLogo.Image = global::ProyectoTaller2.Properties.Resources.logo;
            this.pbxLogo.Location = new System.Drawing.Point(53, 3);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(180, 180);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxLogo.TabIndex = 8;
            this.pbxLogo.TabStop = false;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.Salmon;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCerrarSesion.Image = global::ProyectoTaller2.Properties.Resources.salida__1_;
            this.btnCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSesion.Location = new System.Drawing.Point(28, 565);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnCerrarSesion.Size = new System.Drawing.Size(232, 34);
            this.btnCerrarSesion.TabIndex = 6;
            this.btnCerrarSesion.Text = "Cerrar sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnInformesVentas
            // 
            this.btnInformesVentas.Image = global::ProyectoTaller2.Properties.Resources.histograma_de_grafico;
            this.btnInformesVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInformesVentas.Location = new System.Drawing.Point(28, 473);
            this.btnInformesVentas.Name = "btnInformesVentas";
            this.btnInformesVentas.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnInformesVentas.Size = new System.Drawing.Size(232, 47);
            this.btnInformesVentas.TabIndex = 5;
            this.btnInformesVentas.Text = "Informes Venta";
            this.btnInformesVentas.UseVisualStyleBackColor = true;
            this.btnInformesVentas.Click += new System.EventHandler(this.btnInformesVentas_Click);
            // 
            // btnGestionProveedores
            // 
            this.btnGestionProveedores.Image = global::ProyectoTaller2.Properties.Resources.proveedor__1_;
            this.btnGestionProveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionProveedores.Location = new System.Drawing.Point(28, 420);
            this.btnGestionProveedores.Name = "btnGestionProveedores";
            this.btnGestionProveedores.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnGestionProveedores.Size = new System.Drawing.Size(232, 47);
            this.btnGestionProveedores.TabIndex = 4;
            this.btnGestionProveedores.Text = "Gestionar Proovedores";
            this.btnGestionProveedores.UseVisualStyleBackColor = true;
            this.btnGestionProveedores.Click += new System.EventHandler(this.btnGestionProveedores_Click);
            // 
            // btnGestionarClientes
            // 
            this.btnGestionarClientes.Image = global::ProyectoTaller2.Properties.Resources.usuarios;
            this.btnGestionarClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionarClientes.Location = new System.Drawing.Point(28, 367);
            this.btnGestionarClientes.Name = "btnGestionarClientes";
            this.btnGestionarClientes.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnGestionarClientes.Size = new System.Drawing.Size(232, 47);
            this.btnGestionarClientes.TabIndex = 3;
            this.btnGestionarClientes.Text = "Gestionar clientes";
            this.btnGestionarClientes.UseVisualStyleBackColor = true;
            this.btnGestionarClientes.Click += new System.EventHandler(this.btnGestionarClientes_Click);
            // 
            // btnGestionarProductos
            // 
            this.btnGestionarProductos.Image = global::ProyectoTaller2.Properties.Resources.caja_abierta;
            this.btnGestionarProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionarProductos.Location = new System.Drawing.Point(28, 314);
            this.btnGestionarProductos.Name = "btnGestionarProductos";
            this.btnGestionarProductos.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnGestionarProductos.Size = new System.Drawing.Size(232, 47);
            this.btnGestionarProductos.TabIndex = 2;
            this.btnGestionarProductos.Text = "Gestionar productos";
            this.btnGestionarProductos.UseVisualStyleBackColor = true;
            this.btnGestionarProductos.Click += new System.EventHandler(this.btnGestionarProductos_Click);
            // 
            // btnListarVentas
            // 
            this.btnListarVentas.Image = global::ProyectoTaller2.Properties.Resources.comprobacion_de_lista;
            this.btnListarVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListarVentas.Location = new System.Drawing.Point(28, 261);
            this.btnListarVentas.Name = "btnListarVentas";
            this.btnListarVentas.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnListarVentas.Size = new System.Drawing.Size(232, 47);
            this.btnListarVentas.TabIndex = 1;
            this.btnListarVentas.Text = "Listar todas las ventas";
            this.btnListarVentas.UseVisualStyleBackColor = true;
            this.btnListarVentas.Click += new System.EventHandler(this.btnListarVentas_Click);
            // 
            // lblNombreAdmin
            // 
            this.lblNombreAdmin.AutoSize = true;
            this.lblNombreAdmin.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNombreAdmin.Location = new System.Drawing.Point(71, 212);
            this.lblNombreAdmin.Name = "lblNombreAdmin";
            this.lblNombreAdmin.Size = new System.Drawing.Size(162, 19);
            this.lblNombreAdmin.TabIndex = 1;
            this.lblNombreAdmin.Text = "Conectado como: (name)";
            // 
            // lblTituloAdmin
            // 
            this.lblTituloAdmin.AutoSize = true;
            this.lblTituloAdmin.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTituloAdmin.Location = new System.Drawing.Point(53, 180);
            this.lblTituloAdmin.Name = "lblTituloAdmin";
            this.lblTituloAdmin.Size = new System.Drawing.Size(180, 32);
            this.lblTituloAdmin.TabIndex = 0;
            this.lblTituloAdmin.Text = "Administrador";
            // 
            // FormPrincipalAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 611);
            this.Controls.Add(this.PanelMenuAdmin);
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "FormPrincipalAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clothing Store: Administrador";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrincipalAdmin_FormClosing);
            this.PanelMenuAdmin.ResumeLayout(false);
            this.PanelMenuAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelMenuAdmin;
        private System.Windows.Forms.Label lblNombreAdmin;
        private System.Windows.Forms.Label lblTituloAdmin;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button btnInformesVentas;
        private System.Windows.Forms.Button btnGestionProveedores;
        private System.Windows.Forms.Button btnGestionarClientes;
        private System.Windows.Forms.Button btnGestionarProductos;
        private System.Windows.Forms.Button btnListarVentas;
        private System.Windows.Forms.PictureBox pbxLogo;
    }
}