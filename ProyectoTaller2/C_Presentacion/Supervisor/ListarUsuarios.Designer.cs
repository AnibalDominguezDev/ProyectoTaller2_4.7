namespace ProyectoTaller2.C_Presentacion.Supervisor
{
    partial class ListarUsuarios
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
            this.btnRecargarLista = new System.Windows.Forms.Button();
            this.btnAplicar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cbxFiltroRol = new System.Windows.Forms.ComboBox();
            this.tbxBuscar = new System.Windows.Forms.TextBox();
            this.cbxFiltroBuscar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.lblUsuarios = new System.Windows.Forms.Label();
            this.dgbUsuarios = new System.Windows.Forms.DataGridView();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgbUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.panelHeader.Controls.Add(this.btnRecargarLista);
            this.panelHeader.Controls.Add(this.btnAplicar);
            this.panelHeader.Controls.Add(this.btnBuscar);
            this.panelHeader.Controls.Add(this.cbxFiltroRol);
            this.panelHeader.Controls.Add(this.tbxBuscar);
            this.panelHeader.Controls.Add(this.cbxFiltroBuscar);
            this.panelHeader.Controls.Add(this.label1);
            this.panelHeader.Controls.Add(this.lblBuscar);
            this.panelHeader.Controls.Add(this.lblUsuarios);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(880, 100);
            this.panelHeader.TabIndex = 2;
            this.panelHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.panelHeader_Paint);
            // 
            // btnRecargarLista
            // 
            this.btnRecargarLista.Location = new System.Drawing.Point(18, 52);
            this.btnRecargarLista.Name = "btnRecargarLista";
            this.btnRecargarLista.Size = new System.Drawing.Size(93, 31);
            this.btnRecargarLista.TabIndex = 10;
            this.btnRecargarLista.Text = "Recargar";
            this.btnRecargarLista.UseVisualStyleBackColor = true;
            this.btnRecargarLista.Click += new System.EventHandler(this.button1_Click);
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
            // cbxFiltroRol
            // 
            this.cbxFiltroRol.FormattingEnabled = true;
            this.cbxFiltroRol.Location = new System.Drawing.Point(677, 52);
            this.cbxFiltroRol.Name = "cbxFiltroRol";
            this.cbxFiltroRol.Size = new System.Drawing.Size(100, 21);
            this.cbxFiltroRol.TabIndex = 6;
            // 
            // tbxBuscar
            // 
            this.tbxBuscar.Location = new System.Drawing.Point(677, 21);
            this.tbxBuscar.Name = "tbxBuscar";
            this.tbxBuscar.Size = new System.Drawing.Size(100, 20);
            this.tbxBuscar.TabIndex = 5;
            this.tbxBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxBuscar_KeyPress);
            // 
            // cbxFiltroBuscar
            // 
            this.cbxFiltroBuscar.FormattingEnabled = true;
            this.cbxFiltroBuscar.Items.AddRange(new object[] {
            "DNI",
            "Apellido"});
            this.cbxFiltroBuscar.Location = new System.Drawing.Point(574, 20);
            this.cbxFiltroBuscar.Name = "cbxFiltroBuscar";
            this.cbxFiltroBuscar.Size = new System.Drawing.Size(97, 21);
            this.cbxFiltroBuscar.TabIndex = 4;
            this.cbxFiltroBuscar.SelectedIndexChanged += new System.EventHandler(this.cbxFiltroBuscar_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.label1.Location = new System.Drawing.Point(591, 53);
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
            // lblUsuarios
            // 
            this.lblUsuarios.AutoSize = true;
            this.lblUsuarios.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblUsuarios.Location = new System.Drawing.Point(12, 18);
            this.lblUsuarios.Name = "lblUsuarios";
            this.lblUsuarios.Size = new System.Drawing.Size(113, 32);
            this.lblUsuarios.TabIndex = 1;
            this.lblUsuarios.Text = "Usuarios";
            // 
            // dgbUsuarios
            // 
            this.dgbUsuarios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(247)))));
            this.dgbUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgbUsuarios.ColumnHeadersHeight = 40;
            this.dgbUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgbUsuarios.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgbUsuarios.Location = new System.Drawing.Point(3, 116);
            this.dgbUsuarios.Name = "dgbUsuarios";
            this.dgbUsuarios.RowHeadersVisible = false;
            this.dgbUsuarios.Size = new System.Drawing.Size(865, 462);
            this.dgbUsuarios.TabIndex = 11;
            this.dgbUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgbDetalleProductos_CellClick);
            this.dgbUsuarios.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgbUsuarios_CellFormatting);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // ListarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(880, 600);
            this.Controls.Add(this.dgbUsuarios);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListarUsuarios";
            this.Text = "ListarUsuarios";
            this.Load += new System.EventHandler(this.ListarUsuarios_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgbUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button btnAplicar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cbxFiltroRol;
        private System.Windows.Forms.TextBox tbxBuscar;
        private System.Windows.Forms.ComboBox cbxFiltroBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Label lblUsuarios;
        private System.Windows.Forms.DataGridView dgbUsuarios;
        private System.Windows.Forms.Button btnRecargarLista;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}