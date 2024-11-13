using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoTaller2.C_Logica;

namespace ProyectoTaller2.C_Presentacion.Vendedor
{
    public partial class EditarCliente : Form
    {
        private int cliienteId;

        public EditarCliente(int idcliente)
        {
            InitializeComponent();
            this.cliienteId = idcliente;

            Clientes cliente = new Clientes();
            txtNomEditarC.Text = cliente.getNombre();
            txtApeEditarC.Text = cliente.getApellido();
            txtDniEditarC.Text = cliente.getDni();
            txtTelEditarC.Text = cliente.getTelefono();
            txtDirEditarC.Text = cliente.getDireccion();
            txtMailEditarC.Text = cliente.getCorreo();
        }

        public void SetClienteId(int id)
        {
            this.cliienteId = id;
        }

        public int GetClienteId()
        {
            return this.cliienteId;
        }

        private void rellenarCampos()
        {
            Clientes cliente = new Clientes().editarCliente(this.cliienteId);
            if (cliente != null)
            {
                MessageBox.Show($"Cliente encontrado: {cliente.getNombre()} {cliente.getApellido()}");
                txtNomEditarC.Text = cliente.getNombre();
                txtApeEditarC.Text = cliente.getApellido();
                txtDniEditarC.Text = cliente.getDni();
                txtTelEditarC.Text = cliente.getTelefono();
                txtDirEditarC.Text = cliente.getDireccion();
                txtMailEditarC.Text = cliente.getCorreo();
            }
            else
            {
                MessageBox.Show("No se encontraron datos para este cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (this.todosLosCamposValidos())
            {
                int idCliente = GetClienteId();  // El id del cliente a editar
                string nombre = txtNomEditarC.Text;
                string apellido = txtApeEditarC.Text;
                string dni = txtDniEditarC.Text;
                string telefono = txtTelEditarC.Text;
                string direccion = txtDirEditarC.Text;
                string correo = txtMailEditarC.Text;

                // Llamar a la capa lógica para actualizar
                Clientes cliente = new Clientes();
                cliente.ActualizarCliente(idCliente, nombre, apellido, dni, telefono, direccion, correo);
                MessageBox.Show("Cliente actualizado con éxito", "Éxito", MessageBoxButtons.OK);
            };
        }

        private bool todosLosCamposValidos()
        {
            Validador validador = new Validador();

            return validador.validarCampo(errorProvider1, txtNomEditarC)
                && validador.validarCampo(errorProvider1, txtApeEditarC)
                && validador.validarCampo(errorProvider1, txtDniEditarC)
                && validador.validarCampo(errorProvider1, txtTelEditarC)
                && validador.validarCampo(errorProvider1, txtDirEditarC)
                && validador.validarCampo(errorProvider1, txtMailEditarC);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Seguro que desea cancelar esta operacion?", "Cancelar agregar Cliente",
                             MessageBoxButtons.YesNo,
                             MessageBoxIcon.Question);

            if (result == DialogResult.Yes) this.Close();
        }

        private void txtDniEditarC_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void txtTelEditarC_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void EditarCliente_Load(object sender, EventArgs e)
        {
            rellenarCampos();
        }
    }
}
