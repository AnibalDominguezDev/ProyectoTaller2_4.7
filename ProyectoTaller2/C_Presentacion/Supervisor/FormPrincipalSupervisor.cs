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

namespace ProyectoTaller2.C_Presentacion.Supervisor
{
    public partial class FormPrincipalSupervisor : Form
    {
        private string nombreUsuario;
        public FormPrincipalSupervisor(string nombreCompleto)
        {
            InitializeComponent();
            this.nombreUsuario = nombreCompleto;
            lblNombreSupervisor.Text = $"Conectado como: {this.nombreUsuario}"; 
        }

        private void cargarFormulario(Form formulario)
        {
            if (this.Contains(this.ActiveMdiChild)) ActiveMdiChild?.Close();

            Form form = formulario;
            form.MdiParent = this;
            form.Dock = DockStyle.Fill;
            form.Show();
        }
        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            this.cargarFormulario(new AgregarUsuario());
        }

        private void btnListarUsuarios_Click(object sender, EventArgs e)
        {
            this.cargarFormulario(new ListarUsuarios());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.cargarFormulario(new BdBackup());
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

        private void FormPrincipalSupervisor_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
