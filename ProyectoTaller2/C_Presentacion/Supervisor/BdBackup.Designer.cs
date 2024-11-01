namespace ProyectoTaller2.C_Presentacion.Supervisor
{
    partial class BdBackup
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
            this.panelFondo = new System.Windows.Forms.Panel();
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnRestaurarUbicacion = new System.Windows.Forms.Button();
            this.btnGuardarUbicacion = new System.Windows.Forms.Button();
            this.tbxRestaurarDesde = new System.Windows.Forms.TextBox();
            this.tbxGuardarEn = new System.Windows.Forms.TextBox();
            this.lblRestaurar = new System.Windows.Forms.Label();
            this.lblRealizarCopia = new System.Windows.Forms.Label();
            this.lblBaseDeDatos = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.panelFondo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFondo
            // 
            this.panelFondo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.panelFondo.Controls.Add(this.btnRestaurar);
            this.panelFondo.Controls.Add(this.btnGuardar);
            this.panelFondo.Controls.Add(this.btnRestaurarUbicacion);
            this.panelFondo.Controls.Add(this.btnGuardarUbicacion);
            this.panelFondo.Controls.Add(this.tbxRestaurarDesde);
            this.panelFondo.Controls.Add(this.tbxGuardarEn);
            this.panelFondo.Controls.Add(this.lblRestaurar);
            this.panelFondo.Controls.Add(this.lblRealizarCopia);
            this.panelFondo.Controls.Add(this.lblBaseDeDatos);
            this.panelFondo.Location = new System.Drawing.Point(190, 59);
            this.panelFondo.Name = "panelFondo";
            this.panelFondo.Size = new System.Drawing.Size(500, 465);
            this.panelFondo.TabIndex = 0;
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Location = new System.Drawing.Point(428, 286);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(69, 20);
            this.btnRestaurar.TabIndex = 10;
            this.btnRestaurar.Text = "Restaurar";
            this.btnRestaurar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(428, 156);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(69, 20);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnRestaurarUbicacion
            // 
            this.btnRestaurarUbicacion.Location = new System.Drawing.Point(307, 287);
            this.btnRestaurarUbicacion.Name = "btnRestaurarUbicacion";
            this.btnRestaurarUbicacion.Size = new System.Drawing.Size(115, 20);
            this.btnRestaurarUbicacion.TabIndex = 8;
            this.btnRestaurarUbicacion.Text = "Buscar archivo";
            this.btnRestaurarUbicacion.UseVisualStyleBackColor = true;
            this.btnRestaurarUbicacion.Click += new System.EventHandler(this.btnRestaurarUbicacion_Click_1);
            // 
            // btnGuardarUbicacion
            // 
            this.btnGuardarUbicacion.Location = new System.Drawing.Point(307, 157);
            this.btnGuardarUbicacion.Name = "btnGuardarUbicacion";
            this.btnGuardarUbicacion.Size = new System.Drawing.Size(115, 20);
            this.btnGuardarUbicacion.TabIndex = 7;
            this.btnGuardarUbicacion.Text = "Selecionar carpeta";
            this.btnGuardarUbicacion.UseVisualStyleBackColor = true;
            this.btnGuardarUbicacion.Click += new System.EventHandler(this.btnGuardarUbicacion_Click);
            // 
            // tbxRestaurarDesde
            // 
            this.tbxRestaurarDesde.Location = new System.Drawing.Point(48, 287);
            this.tbxRestaurarDesde.Name = "tbxRestaurarDesde";
            this.tbxRestaurarDesde.Size = new System.Drawing.Size(253, 20);
            this.tbxRestaurarDesde.TabIndex = 6;
            // 
            // tbxGuardarEn
            // 
            this.tbxGuardarEn.Location = new System.Drawing.Point(48, 157);
            this.tbxGuardarEn.Name = "tbxGuardarEn";
            this.tbxGuardarEn.Size = new System.Drawing.Size(253, 20);
            this.tbxGuardarEn.TabIndex = 5;
            // 
            // lblRestaurar
            // 
            this.lblRestaurar.AutoSize = true;
            this.lblRestaurar.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.lblRestaurar.Location = new System.Drawing.Point(44, 236);
            this.lblRestaurar.Name = "lblRestaurar";
            this.lblRestaurar.Size = new System.Drawing.Size(126, 21);
            this.lblRestaurar.TabIndex = 4;
            this.lblRestaurar.Text = "Restaurar desde:";
            // 
            // lblRealizarCopia
            // 
            this.lblRealizarCopia.AutoSize = true;
            this.lblRealizarCopia.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.lblRealizarCopia.Location = new System.Drawing.Point(44, 124);
            this.lblRealizarCopia.Name = "lblRealizarCopia";
            this.lblRealizarCopia.Size = new System.Drawing.Size(111, 21);
            this.lblRealizarCopia.TabIndex = 3;
            this.lblRealizarCopia.Text = "Realizar copia:";
            // 
            // lblBaseDeDatos
            // 
            this.lblBaseDeDatos.AutoSize = true;
            this.lblBaseDeDatos.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblBaseDeDatos.Location = new System.Drawing.Point(42, 37);
            this.lblBaseDeDatos.Name = "lblBaseDeDatos";
            this.lblBaseDeDatos.Size = new System.Drawing.Size(171, 32);
            this.lblBaseDeDatos.TabIndex = 2;
            this.lblBaseDeDatos.Text = "Base de datos";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "Archivo";
            // 
            // BdBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(880, 600);
            this.Controls.Add(this.panelFondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BdBackup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BdBackup";
            this.panelFondo.ResumeLayout(false);
            this.panelFondo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFondo;
        private System.Windows.Forms.Label lblBaseDeDatos;
        private System.Windows.Forms.Label lblRestaurar;
        private System.Windows.Forms.Label lblRealizarCopia;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnRestaurarUbicacion;
        private System.Windows.Forms.Button btnGuardarUbicacion;
        private System.Windows.Forms.TextBox tbxRestaurarDesde;
        private System.Windows.Forms.TextBox tbxGuardarEn;
        private System.Windows.Forms.Button btnRestaurar;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
    }
}