namespace ProyectoTaller2.C_Presentacion.Login
{
    partial class FormLogin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLoginIniciar = new System.Windows.Forms.Button();
            this.lblLoginBienvenido = new System.Windows.Forms.Label();
            this.txtLoginPass = new System.Windows.Forms.TextBox();
            this.txtLoginInicio = new System.Windows.Forms.TextBox();
            this.lblLoginPass = new System.Windows.Forms.Label();
            this.lblLoginUsuario = new System.Windows.Forms.Label();
            this.pbxLoginInicio = new System.Windows.Forms.PictureBox();
            this.pbxFondo = new System.Windows.Forms.PictureBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLoginInicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFondo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.btnLoginIniciar);
            this.panel1.Controls.Add(this.lblLoginBienvenido);
            this.panel1.Controls.Add(this.txtLoginPass);
            this.panel1.Controls.Add(this.txtLoginInicio);
            this.panel1.Controls.Add(this.lblLoginPass);
            this.panel1.Controls.Add(this.lblLoginUsuario);
            this.panel1.Controls.Add(this.pbxLoginInicio);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(267, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 461);
            this.panel1.TabIndex = 1;
            // 
            // btnLoginIniciar
            // 
            this.btnLoginIniciar.BackColor = System.Drawing.Color.AliceBlue;
            this.btnLoginIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLoginIniciar.Location = new System.Drawing.Point(173, 414);
            this.btnLoginIniciar.Name = "btnLoginIniciar";
            this.btnLoginIniciar.Size = new System.Drawing.Size(75, 23);
            this.btnLoginIniciar.TabIndex = 11;
            this.btnLoginIniciar.Text = "Iniciar";
            this.btnLoginIniciar.UseVisualStyleBackColor = false;
            this.btnLoginIniciar.Click += new System.EventHandler(this.btnLoginIniciar_Click);
            // 
            // lblLoginBienvenido
            // 
            this.lblLoginBienvenido.AutoSize = true;
            this.lblLoginBienvenido.BackColor = System.Drawing.Color.Transparent;
            this.lblLoginBienvenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginBienvenido.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblLoginBienvenido.Location = new System.Drawing.Point(59, 21);
            this.lblLoginBienvenido.Name = "lblLoginBienvenido";
            this.lblLoginBienvenido.Size = new System.Drawing.Size(184, 29);
            this.lblLoginBienvenido.TabIndex = 10;
            this.lblLoginBienvenido.Text = "¡BIENVENIDO!";
            // 
            // txtLoginPass
            // 
            this.txtLoginPass.Location = new System.Drawing.Point(64, 357);
            this.txtLoginPass.Name = "txtLoginPass";
            this.txtLoginPass.Size = new System.Drawing.Size(184, 20);
            this.txtLoginPass.TabIndex = 9;
            // 
            // txtLoginInicio
            // 
            this.txtLoginInicio.Location = new System.Drawing.Point(64, 300);
            this.txtLoginInicio.Name = "txtLoginInicio";
            this.txtLoginInicio.Size = new System.Drawing.Size(184, 20);
            this.txtLoginInicio.TabIndex = 8;
            // 
            // lblLoginPass
            // 
            this.lblLoginPass.AutoSize = true;
            this.lblLoginPass.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.lblLoginPass.Location = new System.Drawing.Point(60, 333);
            this.lblLoginPass.Name = "lblLoginPass";
            this.lblLoginPass.Size = new System.Drawing.Size(88, 21);
            this.lblLoginPass.TabIndex = 7;
            this.lblLoginPass.Text = "Contraseña";
            // 
            // lblLoginUsuario
            // 
            this.lblLoginUsuario.AutoSize = true;
            this.lblLoginUsuario.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.lblLoginUsuario.Location = new System.Drawing.Point(60, 276);
            this.lblLoginUsuario.Name = "lblLoginUsuario";
            this.lblLoginUsuario.Size = new System.Drawing.Size(66, 21);
            this.lblLoginUsuario.TabIndex = 6;
            this.lblLoginUsuario.Text = "Usuario:";
            // 
            // pbxLoginInicio
            // 
            this.pbxLoginInicio.Image = global::ProyectoTaller2.Properties.Resources.logo;
            this.pbxLoginInicio.Location = new System.Drawing.Point(64, 71);
            this.pbxLoginInicio.Name = "pbxLoginInicio";
            this.pbxLoginInicio.Size = new System.Drawing.Size(180, 180);
            this.pbxLoginInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxLoginInicio.TabIndex = 5;
            this.pbxLoginInicio.TabStop = false;
            // 
            // pbxFondo
            // 
            this.pbxFondo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbxFondo.Image = global::ProyectoTaller2.Properties.Resources.imgFondo;
            this.pbxFondo.Location = new System.Drawing.Point(0, 0);
            this.pbxFondo.Name = "pbxFondo";
            this.pbxFondo.Size = new System.Drawing.Size(267, 461);
            this.pbxFondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxFondo.TabIndex = 0;
            this.pbxFondo.TabStop = false;
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkRate = 300;
            this.errorProvider.ContainerControl = this;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 461);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbxFondo);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLoginInicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFondo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxFondo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtLoginPass;
        private System.Windows.Forms.TextBox txtLoginInicio;
        private System.Windows.Forms.Label lblLoginPass;
        private System.Windows.Forms.Label lblLoginUsuario;
        private System.Windows.Forms.PictureBox pbxLoginInicio;
        private System.Windows.Forms.Label lblLoginBienvenido;
        private System.Windows.Forms.Button btnLoginIniciar;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}