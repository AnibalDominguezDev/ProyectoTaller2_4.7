namespace ProyectoTaller2.C_Presentacion.Supervisor
{
    partial class FormPrincipalSupervisor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipalSupervisor));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnListarUsuarios = new System.Windows.Forms.Button();
            this.btnAgregarUsuario = new System.Windows.Forms.Button();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.lblNombreSupervisor = new System.Windows.Forms.Label();
            this.lblTituloSupervisor = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnCerrarSesion);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnListarUsuarios);
            this.panel1.Controls.Add(this.btnAgregarUsuario);
            this.panel1.Controls.Add(this.pbxLogo);
            this.panel1.Controls.Add(this.lblNombreSupervisor);
            this.panel1.Controls.Add(this.lblTituloSupervisor);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 611);
            this.panel1.TabIndex = 2;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.Salmon;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarSesion.Image")));
            this.btnCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSesion.Location = new System.Drawing.Point(34, 546);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnCerrarSesion.Size = new System.Drawing.Size(232, 32);
            this.btnCerrarSesion.TabIndex = 4;
            this.btnCerrarSesion.Text = "Cerrar sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // button2
            // 
            this.button2.Image = global::ProyectoTaller2.Properties.Resources.respaldo;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(34, 433);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(232, 47);
            this.button2.TabIndex = 3;
            this.button2.Text = "BD Backup";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnListarUsuarios
            // 
            this.btnListarUsuarios.Image = global::ProyectoTaller2.Properties.Resources.lista_de_miembros;
            this.btnListarUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListarUsuarios.Location = new System.Drawing.Point(34, 365);
            this.btnListarUsuarios.Name = "btnListarUsuarios";
            this.btnListarUsuarios.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnListarUsuarios.Size = new System.Drawing.Size(232, 47);
            this.btnListarUsuarios.TabIndex = 2;
            this.btnListarUsuarios.Text = "Listar usuarios";
            this.btnListarUsuarios.UseVisualStyleBackColor = true;
            this.btnListarUsuarios.Click += new System.EventHandler(this.btnListarUsuarios_Click);
            // 
            // btnAgregarUsuario
            // 
            this.btnAgregarUsuario.Image = global::ProyectoTaller2.Properties.Resources.agregar_usuario_small;
            this.btnAgregarUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarUsuario.Location = new System.Drawing.Point(34, 295);
            this.btnAgregarUsuario.Name = "btnAgregarUsuario";
            this.btnAgregarUsuario.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnAgregarUsuario.Size = new System.Drawing.Size(232, 47);
            this.btnAgregarUsuario.TabIndex = 1;
            this.btnAgregarUsuario.Text = "Agregar Usuario";
            this.btnAgregarUsuario.UseVisualStyleBackColor = true;
            this.btnAgregarUsuario.Click += new System.EventHandler(this.btnAgregarUsuario_Click);
            // 
            // pbxLogo
            // 
            this.pbxLogo.Image = global::ProyectoTaller2.Properties.Resources.logo;
            this.pbxLogo.Location = new System.Drawing.Point(60, 12);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(180, 180);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxLogo.TabIndex = 11;
            this.pbxLogo.TabStop = false;
            // 
            // lblNombreSupervisor
            // 
            this.lblNombreSupervisor.AutoSize = true;
            this.lblNombreSupervisor.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNombreSupervisor.Location = new System.Drawing.Point(69, 228);
            this.lblNombreSupervisor.Name = "lblNombreSupervisor";
            this.lblNombreSupervisor.Size = new System.Drawing.Size(162, 19);
            this.lblNombreSupervisor.TabIndex = 10;
            this.lblNombreSupervisor.Text = "Conectado como: (name)";
            // 
            // lblTituloSupervisor
            // 
            this.lblTituloSupervisor.AutoSize = true;
            this.lblTituloSupervisor.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTituloSupervisor.Location = new System.Drawing.Point(87, 195);
            this.lblTituloSupervisor.Name = "lblTituloSupervisor";
            this.lblTituloSupervisor.Size = new System.Drawing.Size(137, 32);
            this.lblTituloSupervisor.TabIndex = 9;
            this.lblTituloSupervisor.Text = "Supervisor";
            // 
            // FormPrincipalSupervisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 611);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "FormPrincipalSupervisor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clothing Store: Supervisor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrincipalSupervisor_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Label lblNombreSupervisor;
        private System.Windows.Forms.Label lblTituloSupervisor;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnListarUsuarios;
        private System.Windows.Forms.Button btnAgregarUsuario;
        private System.Windows.Forms.Button btnCerrarSesion;
    }
}