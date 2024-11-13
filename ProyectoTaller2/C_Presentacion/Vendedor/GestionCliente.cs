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
    public partial class GestionCliente : Form
    {
        public GestionCliente()
        {
            InitializeComponent();
        }

        private void btnAltaCliente_Click(object sender, EventArgs e)
        {
            AltaCliente cliente = new AltaCliente();
            cliente.Show();
        }

        private void GestionCliente_Load(object sender, EventArgs e)
        {
            ConfigurarColumnasDataGridView();
            listarClientes();
        }

        private void ConfigurarColumnasDataGridView()
        {
            dgbClientes.AutoGenerateColumns = false;

            dgbClientes.Columns["ColFecha"].DataPropertyName = "create_at";
            dgbClientes.Columns["ColDNI"].DataPropertyName = "dni";
            dgbClientes.Columns["ColNom"].DataPropertyName = "nombre";
            dgbClientes.Columns["ColApe"].DataPropertyName = "apellido";
            dgbClientes.Columns["ColDir"].DataPropertyName = "direccion";
            dgbClientes.Columns["ColTel"].DataPropertyName = "telefono";
            dgbClientes.Columns["ColCorreo"].DataPropertyName = "correo";

            dgbClientes.Columns["col_idCliente"].DataPropertyName = "id_cliente";
        }

        private void listarClientes()
        {
            var clientes = Clientes.ListarClientes();
            dgbClientes.DataSource = clientes;
        }

        private void dgbClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgbClientes.Columns["ColEditar"].Index && e.RowIndex >= 0)
            {
                // Obtener el idCliente desde la fila seleccionada
                int idCliente = Convert.ToInt32(dgbClientes.Rows[e.RowIndex].Cells["col_idCliente"].Value);

                // Llamar a la capa lógica para obtener el objeto Clientes
                Clientes cliente = new Clientes().editarCliente(idCliente);

                if (cliente != null)
                {
                    // Pasar el objeto cliente al constructor de EditarCliente
                    EditarCliente editarForm = new EditarCliente(idCliente);
                    editarForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("No se encontró el cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Evita que se ingrese cualquier carácter que no sea número
            }
        }

        private void SoloLetras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // Evita que se ingrese cualquier carácter que no sea letra
            }
        }

        private void cbxBuscarGestionC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxBuscarGestionC.SelectedItem != null)
            {
                if (cbxBuscarGestionC.SelectedItem.ToString() == "DNI")
                {
                    txtBuscarGestionC.KeyPress += new KeyPressEventHandler(SoloNumeros_KeyPress);
                    txtBuscarGestionC.KeyPress -= new KeyPressEventHandler(SoloLetras_KeyPress);
                }
                else if (cbxBuscarGestionC.SelectedItem.ToString() == "Nombre")
                {
                    txtBuscarGestionC.KeyPress += new KeyPressEventHandler(SoloLetras_KeyPress);
                    txtBuscarGestionC.KeyPress -= new KeyPressEventHandler(SoloNumeros_KeyPress);
                }
            }
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            string criterioBusqueda = txtBuscarGestionC.Text.Trim();

            if (string.IsNullOrWhiteSpace(criterioBusqueda))
            {
                MessageBox.Show("Por favor, ingrese un valor para buscar.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verificar que se haya seleccionado una opción en el ComboBox de búsqueda
            if (cbxBuscarGestionC.SelectedItem != null)
            {
                if (cbxBuscarGestionC.SelectedItem.ToString() == "DNI")
                {
                    BuscarClientePorDNI(criterioBusqueda);
                }
                else if (cbxBuscarGestionC.SelectedItem.ToString() == "Nombre")
                {
                    BuscarClientePorNombre(criterioBusqueda);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un criterio de búsqueda.", "Selección requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BuscarClientePorDNI(string dni)
        {
            var clientes = Clientes.listarClentesPorDni(dni);
            dgbClientes.DataSource = clientes;
        }

        private void BuscarClientePorNombre(string nombre)
        {
            var clientes = Clientes.listarClientesPorNombre(nombre);
            dgbClientes.DataSource = clientes;
        }

    }
}
