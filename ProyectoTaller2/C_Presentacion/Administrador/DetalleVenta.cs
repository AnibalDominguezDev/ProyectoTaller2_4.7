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

namespace ProyectoTaller2.C_Presentacion.Administrador
{
    public partial class DetalleVenta : Form
    {
        private int idVenta;
        public DetalleVenta(int id_venta)
        {
            this.idVenta = id_venta;
            InitializeComponent();
            cargarDetalle();        
        }

        public int getIdVenta()
        {
            return this.idVenta;
        }

        private void cargarDetalle()
        {
            Ventas venta = new Ventas().obtenerVentaPorId(this.idVenta);
            lblFecha.Text = $"Fecha: {venta.getFecha()}";
            lblVendedor.Text = $"Vendedor: {Usuarios.getNombreCompleto(venta.getIdUsuario())}";
            lblCliente.Text = $"Cliente: {Clientes.getNombreCliente(venta.getIdCliente())}";

            lblPrecioTotal.Text = $"Total: ${venta.getTotalVenta()}";

            lblDetalleDeVenta.Text = $"Detalle de la venta Nro: # {this.idVenta}";

            formatoDataGrid();
            dgbDetalleProductos.DataSource = Ventas.obtenerDatosVenta(getIdVenta());
        }

        private void formatoDataGrid()
        {
            dgbDetalleProductos.AutoGenerateColumns = false;

            dgbDetalleProductos.Columns["productoId"].DataPropertyName = "codProducto";
            dgbDetalleProductos.Columns["colNombre"].DataPropertyName = "producto";
            dgbDetalleProductos.Columns["colDescripcion"].DataPropertyName = "productoDesc";
            dgbDetalleProductos.Columns["colCantidad"].DataPropertyName = "cantidad";
            dgbDetalleProductos.Columns["colPrecioUnitario"].DataPropertyName = "precio";
            dgbDetalleProductos.Columns["colSubTotal"].DataPropertyName = "subTotal";
        }
    }
}
