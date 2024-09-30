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
            this.lblBaseDeDatos = new System.Windows.Forms.Label();
            this.lblRealizarCopia = new System.Windows.Forms.Label();
            this.lblRestaurar = new System.Windows.Forms.Label();
            this.panelFondo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFondo
            // 
            this.panelFondo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.panelFondo.Controls.Add(this.lblRestaurar);
            this.panelFondo.Controls.Add(this.lblRealizarCopia);
            this.panelFondo.Controls.Add(this.lblBaseDeDatos);
            this.panelFondo.Location = new System.Drawing.Point(190, 59);
            this.panelFondo.Name = "panelFondo";
            this.panelFondo.Size = new System.Drawing.Size(500, 465);
            this.panelFondo.TabIndex = 0;
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
    }
}