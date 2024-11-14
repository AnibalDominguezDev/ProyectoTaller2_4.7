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
    public partial class EditarProducto : Form
    {

        private int productId;
        public EditarProducto(int id)
        {
            this.productId = id;
            InitializeComponent();
            this.cargarCategorias();
            this.cargarMarcas();
            this.cargarProveedores();
            this.rellenarCampos();
        }

        private void rellenarCampos()
        {

            Productos editar = new Productos().ObtenerUsuarioPorId(productId);

            tbxCodPrenda.Text = editar.getCodProducto();
            tbxNombre.Text = editar.getNombre();
            tbxPrecio.Text = editar.getPrecio().ToString();
            tbxDescripcion.Text = editar.getDescripcion();
            cbxCategoria.Text = editar.getCategoriaNombre();
            cbxMarca.Text = editar.getMarcaNombre();
            cbxProveedor.Text = editar.getNombreProveedor();
            tbxStock.Text = editar.getStock().ToString();
            tbxStockMinimo.Text = editar.getStockMin().ToString();

        }

        private bool todosLosCamposValidos()
        {
            Validador val = new Validador();

            return val.validarCampo(errorProvider, tbxCodPrenda, 3)
                    && val.validarCampo(errorProvider, tbxNombre, 3)
                    && val.validarCampo(errorProvider, tbxDescripcion, 4)
                    && val.validarCampo(errorProvider, tbxStock)
                    && val.validarCampo(errorProvider, tbxStockMinimo);
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Seguro que desea cancelar la edicion del prodcuto?", "Cancelar editar producto",
                             MessageBoxButtons.YesNo,
                             MessageBoxIcon.Question);

            if (result == DialogResult.Yes) this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (this.todosLosCamposValidos())
            {
                if (Productos.editarProducto(this.productId,tbxCodPrenda.Text,tbxNombre.Text,tbxDescripcion.Text,tbxPrecio.Text,tbxStock.Text,tbxStockMinimo.Text,cbxCategoria.Text,cbxMarca.Text,cbxProveedor.Text))
                {
                    MessageBox.Show("Producto editado correctamente!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                } else
                {
                    MessageBox.Show("No se pudo editar el producto, verifique que los campos son correctos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tbxStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void tbxStockMinimo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void EditarProducto_Load(object sender, EventArgs e)
        {

        }

        private void cargarCategorias()
        {
            cbxCategoria.Items.Clear();
            cbxCategoria.DataSource = Productos.listarCategorias();
            cbxCategoria.DisplayMember = "nombre";
            cbxCategoria.SelectedIndex = -1;
        }

        private void cargarMarcas()
        {
            cbxMarca.Items.Clear();
            cbxMarca.DataSource = Productos.listarMarcas();
            cbxMarca.DisplayMember = "nombre";
            cbxMarca.SelectedIndex = -1;
        }

        private void cargarProveedores()
        {
            cbxProveedor.Items.Clear();
            cbxProveedor.DataSource = Proveedores.listarProveedores();
            cbxProveedor.DisplayMember = "nombre";
            cbxProveedor.SelectedIndex = -1;
        }

    }
}
