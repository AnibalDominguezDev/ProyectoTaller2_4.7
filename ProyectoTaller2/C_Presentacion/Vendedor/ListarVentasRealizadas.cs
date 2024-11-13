using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoTaller2.C_Logica;
using ProyectoTaller2.C_Presentacion.Administrador;
using ProyectoTaller2.C_Presentacion.Login;

namespace ProyectoTaller2.C_Presentacion.Vendedor
{
    public partial class ListarVentasRealizadas : Form
    {
        public ListarVentasRealizadas()
        {
            InitializeComponent();
            ConfigurarColumnasDataGridView();
            cargarVentas();
            
        }

        private void cargarVentas()
        {
            int idVendedor = Sesion.IdUsuarioConectado;
            DateTime desde = new DateTime(2024, 1, 1);
            DateTime hasta = new DateTime(2024, 12, 30);
            gridListaVentas.DataSource = Ventas.obtenerVentasPorVendedor(idVendedor,desde,hasta);
        }

        private void ConfigurarColumnasDataGridView()
        {
            gridListaVentas.AutoGenerateColumns = false;
            
            gridListaVentas.Columns["ColNroVenta"].DataPropertyName = "id_venta";
            gridListaVentas.Columns["ColFecha"].DataPropertyName = "fecha";
            gridListaVentas.Columns["colCliente"].DataPropertyName = "cliente";
            gridListaVentas.Columns["colCantProductos"].DataPropertyName = "metodoPago";
            gridListaVentas.Columns["colPrecioTotal"].DataPropertyName = "precio_total";
        }

        private void gridListaVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == gridListaVentas.Columns["colVerDetalle"].Index && e.RowIndex >= 0)
            {

                new DetalleVenta((int)gridListaVentas.Rows[e.RowIndex].Cells["ColNroVenta"].Value).ShowDialog();
            }
        }

        private void btnFiltroVen_Click(object sender, EventArgs e)
        {
            gridListaVentas.DataSource = Ventas.obtenerVentasPorVendedor(3, dtpDesde.Value, dtpHasta.Value);
        }
    }
}
