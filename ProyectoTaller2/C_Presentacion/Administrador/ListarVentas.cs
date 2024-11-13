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

namespace ProyectoTaller2.C_Presentacion.Administrador
{
    public partial class ListarVentas : Form
    {
        public ListarVentas()
        {
            InitializeComponent();
            ConfigurarColumnasDataGridView();
            cargarVentas();
        }

        private void testDetalle_Click(object sender, EventArgs e)
        {
           
        }

        private void cargarVentas()
        {
            DateTime desde = new DateTime(2024, 1, 1);
            DateTime hasta = new DateTime(2024, 12, 30);
            gridListaVentas.DataSource = Ventas.obtenerTodasLasVentas();
        }

        private void ConfigurarColumnasDataGridView()
        {
            gridListaVentas.AutoGenerateColumns = false;

            gridListaVentas.Columns["ColNroVenta"].DataPropertyName = "id_venta";
            gridListaVentas.Columns["ColFecha"].DataPropertyName = "fecha";
            gridListaVentas.Columns["colCliente"].DataPropertyName = "cliente";
            gridListaVentas.Columns["ColVendedor"].DataPropertyName = "vendedor"; 
            gridListaVentas.Columns["colMetodoPago"].DataPropertyName = "metodoPago";
            gridListaVentas.Columns["colPrecioTotal"].DataPropertyName = "precio_total";
        }

        private void gridListaVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == gridListaVentas.Columns["colVerDetalle"].Index && e.RowIndex >= 0)
            {

                new DetalleVenta((int)gridListaVentas.Rows[e.RowIndex].Cells["ColNroVenta"].Value).ShowDialog();
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cbxBuscarPor.SelectedIndex == 0)// Nro venta
            {
                gridListaVentas.DataSource = Ventas.obtenerListaVentasPorID(int.Parse(tbxBuscar.Text));
            }
            else if (cbxBuscarPor.SelectedIndex == 1) //Dni Vendedor
            {
                gridListaVentas.DataSource = Ventas.obtenerListaVentasPorDni("vendedor", int.Parse(tbxBuscar.Text.Trim()));
            }
            else if (cbxBuscarPor.SelectedIndex == 2) // Dni Cliente
            {
                gridListaVentas.DataSource = Ventas.obtenerListaVentasPorDni("cliente", int.Parse(tbxBuscar.Text.Trim()));
            }
        }

        private void tbxBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
