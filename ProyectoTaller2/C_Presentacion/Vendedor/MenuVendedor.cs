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

namespace ProyectoTaller2.C_Presentacion.Vendedor
{
    public partial class MenuVendedor : Form
    {
        private string nombreUsuario;
        public MenuVendedor(string nombreCompleto)
        {
            InitializeComponent();
            this.nombreUsuario = nombreCompleto;
            lblNomUsuario.Text = $"Conectado como: {this.nombreUsuario}";
        }

        private void CargarFormularioEnPanel(Form formulario, Panel panelDestino)
        {
            // Limpiar cualquier control anterior en el panel destino
            panelDestino.Controls.Clear();

            // Configurar el formulario como hijo de este contenedor (MDI)
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;

            // Agregar el formulario al panel destino y mostrarlo
            panelDestino.Controls.Add(formulario);
            formulario.Show();
        }

        private void btnAltaCliente_Click(object sender, EventArgs e)
        {
            //CargarFormularioEnPanel(new AltaCliente(), panelMuestra);
            CargarFormularioEnPanel(new GestionCliente(), panelMuestra);
        }

        private void btnListaProductos_Click(object sender, EventArgs e)
        {
            CargarFormularioEnPanel(new ListarProductos(), panelMuestra);
        }

        private void btnMisVentas_Click(object sender, EventArgs e)
        {
            CargarFormularioEnPanel(new ListarVentasRealizadas(), panelMuestra);
        }

        private void btnRealizarVenta_Click(object sender, EventArgs e)
        {
            CargarFormularioEnPanel(new RealizarVenta(this.nombreUsuario), panelMuestra);
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            
            FormLogin loginForm = new FormLogin();

            var result = MessageBox.Show("Seguro que desea cerrar la sesion actual?", "Cerrar sesion",
                              MessageBoxButtons.YesNo,
                              MessageBoxIcon.Question);

            if (result == DialogResult.Yes) this.Close();

            loginForm.ShowDialog();
        }

        private void MenuVendedor_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
