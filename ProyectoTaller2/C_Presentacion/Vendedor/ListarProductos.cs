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
    public partial class ListarProductos : Form
    {
        public ListarProductos()
        {
            InitializeComponent();
        }

        private void ListarProductos_Load(object sender, EventArgs e)
        {
            ConfigurarColumnasDataGridView();
            lstProductos();
            lstCategorias();
            
        }

        private void lstCategorias()
        {
            cbxFiltrarCategoria.DataSource = Productos.listarCategorias();
            cbxFiltrarCategoria.DisplayMember = "nombre";
            cbxFiltrarCategoria.SelectedIndex = -1;
        }

        private void ConfigurarColumnasDataGridView()
        {
            dgbDetalleProductos.AutoGenerateColumns = false;

            dgbDetalleProductos.Columns["colCodPrenda"].DataPropertyName = "cod_producto";
            dgbDetalleProductos.Columns["colNombreProducto"].DataPropertyName = "nombre";
            dgbDetalleProductos.Columns["colDescripcion"].DataPropertyName = "descripcion";
            dgbDetalleProductos.Columns["ColStock"].DataPropertyName = "stock";
            dgbDetalleProductos.Columns["colPrecioUnit"].DataPropertyName = "precio";
            dgbDetalleProductos.Columns["colCategoria"].DataPropertyName = "categoriaNombre";
        }

        private void lstProductos()
        {
            var productos = Productos.listarProductosVendedor();
            dgbDetalleProductos.DataSource = productos;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombreProducto = tbxBuscarProducto.Text.Trim();
                List<object> productos = Productos.listarProductosPorNombre(nombreProducto);

                dgbDetalleProductos.DataSource = productos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al buscar los productos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btxFiltrar_Click(object sender, EventArgs e)
        {
            dgbDetalleProductos.DataSource = Productos.listarProductosPorCategoria(cbxFiltrarCategoria.Text);
        }
    }
}
