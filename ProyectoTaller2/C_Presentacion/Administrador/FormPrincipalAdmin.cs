using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoTaller2.C_Presentacion.Login;
using ProyectoTaller2.C_Presentacion.Supervisor;

namespace ProyectoTaller2.C_Presentacion.Administrador
{
    public partial class FormPrincipalAdmin : Form
    {
        private string nombreUsuario;
        public FormPrincipalAdmin(string nombreCompleto)
        {
            InitializeComponent();
            this.nombreUsuario = nombreCompleto;
            lblNombreAdmin.Text = $"Conectado como: {this.nombreUsuario}";
        }

        private void cargarFormulario(Form formulario)
        {
            if (this.Contains(this.ActiveMdiChild)) ActiveMdiChild?.Close();

            Form form = formulario;
            form.MdiParent = this;
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        private void btnListarVentas_Click(object sender, EventArgs e)
        {
            this.cargarFormulario(new ListarVentas());
        }

        private void btnGestionarProductos_Click(object sender, EventArgs e)
        {
            this.cargarFormulario(new ListarProductos());
        }

        private void btnGestionarClientes_Click(object sender, EventArgs e)
        {
            this.cargarFormulario(new GestionClientes());
        }

        private void btnGestionProveedores_Click(object sender, EventArgs e)
        {
            this.cargarFormulario(new GestionProveedores());
        }

        private void btnInformesVentas_Click(object sender, EventArgs e)
        {
            this.cargarFormulario(new EstadisticasVentas());
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {

            FormLogin loginForm = new FormLogin();

            var result = MessageBox.Show("Seguro que desea cerrar la sesion actual?", "Cerrar sesion",
                              MessageBoxButtons.YesNo,
                              MessageBoxIcon.Question);

            if (result == DialogResult.Yes) this.Close();

            loginForm.Show();
        }
    }
}
