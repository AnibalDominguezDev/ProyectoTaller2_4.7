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
    public partial class ListarProductos : Form
    {
        public ListarProductos()
        {
            InitializeComponent();
            rellenarCbx();
        }

        private void testEditar_Click(object sender, EventArgs e)
        {
            this.cargarListaProductos();
        }

        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            new AgregarProducto().ShowDialog();
        }

        private void dgvFormart()
        {
            dgbDetalleProductos.Columns[0].Visible = false;
            dgbDetalleProductos.Columns[0].Name = "idEditar";
            dgbDetalleProductos.Columns[1].HeaderText = "Cod Producto";
            dgbDetalleProductos.Columns[2].HeaderText = "Nombre";
            dgbDetalleProductos.Columns[3].HeaderText = "Descripcion";
            dgbDetalleProductos.Columns[4].HeaderText = "Precio";
            dgbDetalleProductos.Columns[5].HeaderText = "Stock";
            dgbDetalleProductos.Columns[5].Name = "stock";
            dgbDetalleProductos.Columns[6].HeaderText = "Stock minimo";
            dgbDetalleProductos.Columns[6].Name = "stockMin";
            dgbDetalleProductos.Columns[7].HeaderText = "Categoria";
            dgbDetalleProductos.Columns[8].Name = "estado";
            dgbDetalleProductos.Columns[8].Visible = false;


            DataGridViewButtonColumn btnEditar = new DataGridViewButtonColumn();
            {
                btnEditar.Name = "btnEditar";
                btnEditar.HeaderText = "Editar";
                btnEditar.Text = "Editar";
                btnEditar.UseColumnTextForButtonValue = true;
                dgbDetalleProductos.Columns.Add(btnEditar);
            }

            DataGridViewButtonColumn btnEliminar = new DataGridViewButtonColumn();
            {
                btnEliminar.Name = "btnEliminar";
                btnEliminar.HeaderText = "Accion";
                btnEliminar.Text = "Eliminar";
                btnEliminar.UseColumnTextForButtonValue = false;
                dgbDetalleProductos.Columns.Add(btnEliminar);
            }

        }

        private void cargarListaProductos()
        {
            dgbDetalleProductos.DataSource = "";
            dgbDetalleProductos.Columns.Clear();
            dgbDetalleProductos.DataSource = Productos.listarProductos();


            this.dgvFormart();

            foreach (DataGridViewRow row in dgbDetalleProductos.Rows)
            {

                if ((int)row.Cells["estado"].Value == 1)
                {
                    row.Cells["btnEliminar"].Value = "Eliminar";
                }
                else
                {
                    row.Cells["btnEliminar"].Value = "Activar";
                }
            }
        }

        private void rellenarCbx()
        {
            cbxFiltroCategorias.Items.Clear();
            cbxFiltroCategorias.DataSource = Productos.listarCategorias();
            cbxFiltroCategorias.DisplayMember = "nombre";
            cbxFiltroCategorias.SelectedIndex = -1;
        }
        private void ListarProductos_Load(object sender, EventArgs e)
        {
            this.cargarListaProductos();
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            Validador validador = new Validador();

            if (validador.validarCbx(errorProvider,cbxFiltroCategorias)) dgbDetalleProductos.DataSource = Productos.listarProductosPorCategoria(cbxFiltroCategorias.Text);

            foreach (DataGridViewRow row in dgbDetalleProductos.Rows)
            {

                if ((int)row.Cells["estado"].Value == 1)
                {
                    row.Cells["btnEliminar"].Value = "Eliminar";
                }
                else
                {
                    row.Cells["btnEliminar"].Value = "Activar";
                }
            }
        }

        private void dgbDetalleProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgbDetalleProductos.Columns["btnEditar"].Index && e.RowIndex >= 0)
            {

                new EditarProducto(int.Parse(dgbDetalleProductos.Rows[e.RowIndex].Cells["idEditar"].Value.ToString())).ShowDialog();
                cargarListaProductos();
            }

            if (e.ColumnIndex == dgbDetalleProductos.Columns["btnEliminar"].Index && e.RowIndex >= 0)
            {
                if (Productos.cambiarEstadoProducto(int.Parse(dgbDetalleProductos.Rows[e.RowIndex].Cells["idEditar"].Value.ToString())))
                {
                    MessageBox.Show("Producto actualizado correctamente!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarListaProductos();
                }
            }
        }

        private void dgbDetalleProductos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {


            if (dgbDetalleProductos.Columns[e.ColumnIndex].Name == "estado")
            {
                int estado = (int)dgbDetalleProductos.Rows[e.RowIndex].Cells["estado"].Value;

                Console.WriteLine("HOLAAA" + estado);

                if (estado == 0) dgbDetalleProductos.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Salmon;
            }


            if (dgbDetalleProductos.Columns[e.ColumnIndex].Name == "stock")
            {

                var stockValue = (int)dgbDetalleProductos.Rows[e.RowIndex].Cells["stock"].Value;
                int stockMin = (int)dgbDetalleProductos.Rows[e.RowIndex].Cells["stockMin"].Value;

                if (stockValue <= stockMin)
                {
                    dgbDetalleProductos.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Khaki;
                }

            }



        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Validador val = new Validador();

            if (val.validarCampo(errorProvider, tbxBuscarCodigo))
            {
                dgbDetalleProductos.DataSource = Productos.buscarProductoPorCodigo(tbxBuscarCodigo.Text.Trim());
            }
        }
    }
}
