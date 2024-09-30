namespace ProyectoTaller2.C_Presentacion.Administrador
{
    partial class EditarProveedor
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
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.tbxTelefono = new System.Windows.Forms.TextBox();
            this.tbxDireccion = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.tbxNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblEditarProveedor = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelFondo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // panelFondo
            // 
            this.panelFondo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.panelFondo.Controls.Add(this.tbxEmail);
            this.panelFondo.Controls.Add(this.btnCancelar);
            this.panelFondo.Controls.Add(this.btnAgregar);
            this.panelFondo.Controls.Add(this.tbxTelefono);
            this.panelFondo.Controls.Add(this.tbxDireccion);
            this.panelFondo.Controls.Add(this.lblMarca);
            this.panelFondo.Controls.Add(this.lblProveedor);
            this.panelFondo.Controls.Add(this.lblDescripcion);
            this.panelFondo.Controls.Add(this.tbxNombre);
            this.panelFondo.Controls.Add(this.lblNombre);
            this.panelFondo.Controls.Add(this.lblEditarProveedor);
            this.panelFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFondo.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F);
            this.panelFondo.Location = new System.Drawing.Point(0, 0);
            this.panelFondo.Name = "panelFondo";
            this.panelFondo.Size = new System.Drawing.Size(484, 423);
            this.panelFondo.TabIndex = 2;
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(158, 265);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(242, 29);
            this.tbxEmail.TabIndex = 27;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnCancelar.Location = new System.Drawing.Point(239, 358);
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
            this.btnAgregar.Location = new System.Drawing.Point(362, 357);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(110, 43);
            this.btnAgregar.TabIndex = 25;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // tbxTelefono
            // 
            this.tbxTelefono.Location = new System.Drawing.Point(158, 223);
            this.tbxTelefono.Name = "tbxTelefono";
            this.tbxTelefono.Size = new System.Drawing.Size(242, 29);
            this.tbxTelefono.TabIndex = 19;
            this.tbxTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxTelefono_KeyPress);
            // 
            // tbxDireccion
            // 
            this.tbxDireccion.Location = new System.Drawing.Point(158, 141);
            this.tbxDireccion.Multiline = true;
            this.tbxDireccion.Name = "tbxDireccion";
            this.tbxDireccion.Size = new System.Drawing.Size(242, 69);
            this.tbxDireccion.TabIndex = 9;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(34, 265);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(62, 24);
            this.lblMarca.TabIndex = 5;
            this.lblMarca.Text = "Email:";
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Location = new System.Drawing.Point(34, 223);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(85, 24);
            this.lblProveedor.TabIndex = 4;
            this.lblProveedor.Text = "Telefono:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(34, 141);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(91, 24);
            this.lblDescripcion.TabIndex = 3;
            this.lblDescripcion.Text = "Dirección:";
            // 
            // tbxNombre
            // 
            this.tbxNombre.Location = new System.Drawing.Point(158, 93);
            this.tbxNombre.Name = "tbxNombre";
            this.tbxNombre.Size = new System.Drawing.Size(242, 29);
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
            // lblEditarProveedor
            // 
            this.lblEditarProveedor.AutoSize = true;
            this.lblEditarProveedor.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblEditarProveedor.Location = new System.Drawing.Point(32, 20);
            this.lblEditarProveedor.Name = "lblEditarProveedor";
            this.lblEditarProveedor.Size = new System.Drawing.Size(207, 32);
            this.lblEditarProveedor.TabIndex = 0;
            this.lblEditarProveedor.Text = "Editar Proveedor";
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkRate = 300;
            this.errorProvider.ContainerControl = this;
            // 
            // EditarProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 423);
            this.Controls.Add(this.panelFondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditarProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditarProveedor";
            this.panelFondo.ResumeLayout(false);
            this.panelFondo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFondo;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox tbxTelefono;
        private System.Windows.Forms.TextBox tbxDireccion;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox tbxNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblEditarProveedor;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}