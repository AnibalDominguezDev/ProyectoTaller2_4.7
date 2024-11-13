namespace ProyectoTaller2.C_Presentacion.Vendedor
{
    partial class GestionCliente
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnAltaCliente = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscarGestionC = new System.Windows.Forms.TextBox();
            this.cbxBuscarGestionC = new System.Windows.Forms.ComboBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.lblAgregarProducto = new System.Windows.Forms.Label();
            this.dgbClientes = new System.Windows.Forms.DataGridView();
            this.col_idCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColApe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCorreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgbClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.panelHeader.Controls.Add(this.btnAltaCliente);
            this.panelHeader.Controls.Add(this.btnBuscar);
            this.panelHeader.Controls.Add(this.txtBuscarGestionC);
            this.panelHeader.Controls.Add(this.cbxBuscarGestionC);
            this.panelHeader.Controls.Add(this.lblBuscar);
            this.panelHeader.Controls.Add(this.lblAgregarProducto);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(864, 100);
            this.panelHeader.TabIndex = 1;
            // 
            // btnAltaCliente
            // 
            this.btnAltaCliente.Location = new System.Drawing.Point(657, 61);
            this.btnAltaCliente.Name = "btnAltaCliente";
            this.btnAltaCliente.Size = new System.Drawing.Size(181, 23);
            this.btnAltaCliente.TabIndex = 10;
            this.btnAltaCliente.Text = "Alta Cliente";
            this.btnAltaCliente.UseVisualStyleBackColor = true;
            this.btnAltaCliente.Click += new System.EventHandler(this.btnAltaCliente_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(763, 20);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 21);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // txtBuscarGestionC
            // 
            this.txtBuscarGestionC.Location = new System.Drawing.Point(657, 20);
            this.txtBuscarGestionC.Name = "txtBuscarGestionC";
            this.txtBuscarGestionC.Size = new System.Drawing.Size(100, 20);
            this.txtBuscarGestionC.TabIndex = 5;
            // 
            // cbxBuscarGestionC
            // 
            this.cbxBuscarGestionC.FormattingEnabled = true;
            this.cbxBuscarGestionC.Items.AddRange(new object[] {
            "Nombre",
            "DNI"});
            this.cbxBuscarGestionC.Location = new System.Drawing.Point(554, 20);
            this.cbxBuscarGestionC.Name = "cbxBuscarGestionC";
            this.cbxBuscarGestionC.Size = new System.Drawing.Size(97, 21);
            this.cbxBuscarGestionC.TabIndex = 4;
            this.cbxBuscarGestionC.SelectedIndexChanged += new System.EventHandler(this.cbxBuscarGestionC_SelectedIndexChanged);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.lblBuscar.Location = new System.Drawing.Point(461, 21);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(87, 21);
            this.lblBuscar.TabIndex = 2;
            this.lblBuscar.Text = "Buscar por:";
            // 
            // lblAgregarProducto
            // 
            this.lblAgregarProducto.AutoSize = true;
            this.lblAgregarProducto.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregarProducto.Location = new System.Drawing.Point(12, 21);
            this.lblAgregarProducto.Name = "lblAgregarProducto";
            this.lblAgregarProducto.Size = new System.Drawing.Size(221, 32);
            this.lblAgregarProducto.TabIndex = 1;
            this.lblAgregarProducto.Text = "Gestionar Clientes";
            // 
            // dgbClientes
            // 
            this.dgbClientes.AllowUserToAddRows = false;
            this.dgbClientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(247)))));
            this.dgbClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgbClientes.ColumnHeadersHeight = 40;
            this.dgbClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgbClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_idCliente,
            this.ColFecha,
            this.ColDNI,
            this.ColNom,
            this.ColApe,
            this.ColDir,
            this.ColTel,
            this.ColCorreo,
            this.ColEditar});
            this.dgbClientes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgbClientes.Location = new System.Drawing.Point(0, 106);
            this.dgbClientes.Name = "dgbClientes";
            this.dgbClientes.RowHeadersVisible = false;
            this.dgbClientes.Size = new System.Drawing.Size(856, 462);
            this.dgbClientes.TabIndex = 4;
            this.dgbClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgbClientes_CellClick);
            // 
            // col_idCliente
            // 
            this.col_idCliente.HeaderText = "ID";
            this.col_idCliente.Name = "col_idCliente";
            this.col_idCliente.Visible = false;
            // 
            // ColFecha
            // 
            this.ColFecha.HeaderText = "Fecha de Alta";
            this.ColFecha.Name = "ColFecha";
            this.ColFecha.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColDNI
            // 
            this.ColDNI.HeaderText = "DNI";
            this.ColDNI.Name = "ColDNI";
            // 
            // ColNom
            // 
            this.ColNom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColNom.HeaderText = "Nombre";
            this.ColNom.Name = "ColNom";
            // 
            // ColApe
            // 
            this.ColApe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColApe.HeaderText = "Apellido";
            this.ColApe.Name = "ColApe";
            // 
            // ColDir
            // 
            this.ColDir.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColDir.HeaderText = "Dirección";
            this.ColDir.Name = "ColDir";
            // 
            // ColTel
            // 
            this.ColTel.HeaderText = "Telefono";
            this.ColTel.Name = "ColTel";
            // 
            // ColCorreo
            // 
            this.ColCorreo.HeaderText = "Correo electrónico";
            this.ColCorreo.Name = "ColCorreo";
            this.ColCorreo.Width = 120;
            // 
            // ColEditar
            // 
            this.ColEditar.HeaderText = "Editar";
            this.ColEditar.Name = "ColEditar";
            this.ColEditar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColEditar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColEditar.Text = "Editar";
            this.ColEditar.UseColumnTextForButtonValue = true;
            // 
            // GestionCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(864, 573);
            this.Controls.Add(this.dgbClientes);
            this.Controls.Add(this.panelHeader);
            this.Name = "GestionCliente";
            this.Text = "GestionCliente";
            this.Load += new System.EventHandler(this.GestionCliente_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgbClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscarGestionC;
        private System.Windows.Forms.ComboBox cbxBuscarGestionC;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Label lblAgregarProducto;
        private System.Windows.Forms.DataGridView dgbClientes;
        private System.Windows.Forms.Button btnAltaCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_idCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColApe;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDir;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCorreo;
        private System.Windows.Forms.DataGridViewButtonColumn ColEditar;
    }
}