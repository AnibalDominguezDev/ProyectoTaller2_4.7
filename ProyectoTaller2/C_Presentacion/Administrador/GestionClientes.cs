using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoTaller2.C_Datos;
using ProyectoTaller2.C_Logica;
using ProyectoTaller2.C_Presentacion.Vendedor;

namespace ProyectoTaller2.C_Presentacion.Administrador
{
    public partial class GestionClientes : Form
    {
        public GestionClientes()
        {
            InitializeComponent();
            FormatearDataGrid();
            cargarLista();
        }

        private void FormatearDataGrid()
        {
            dgbClientes.AutoGenerateColumns = false;
            dgbClientes.Columns["Colid"].DataPropertyName = "id_cliente";
            dgbClientes.Columns["ColFechaAlta"].DataPropertyName = "create_at";
            dgbClientes.Columns["ColDNI"].DataPropertyName = "dni";
            dgbClientes.Columns["colNombre"].DataPropertyName = "nombre";
            dgbClientes.Columns["ColApellido"].DataPropertyName = "apellido";
            dgbClientes.Columns["ColDireccion"].DataPropertyName = "direccion";
            dgbClientes.Columns["ColTelefono"].DataPropertyName = "telefono";
            dgbClientes.Columns["ColEstado"].DataPropertyName = "estado";
        }

        private void cargarLista()
        {
            dgbClientes.DataSource = "";
            dgbClientes.DataSource = DClientes.getAllClients();
        }

        private void dgbClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgbClientes.Columns["ColEditar"].Index && e.RowIndex >= 0)
            {
                new EditarCliente((int)dgbClientes.Rows[e.RowIndex].Cells["Colid"].Value).ShowDialog();
            }

            if (e.ColumnIndex == dgbClientes.Columns["colEliminar"].Index && e.RowIndex >= 0)
            {
                 if (Clientes.cambiarEstadoCliente((int)dgbClientes.Rows[e.RowIndex].Cells["Colid"].Value))
                {
                    MessageBox.Show("Cliente actualizado correctamente!","Exito",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    cargarLista();
                };
                
                // new DetalleVenta((int)dgbClientes.Rows[e.RowIndex].Cells["ColNroVenta"].Value).ShowDialog();
            }
        }
    }
}
