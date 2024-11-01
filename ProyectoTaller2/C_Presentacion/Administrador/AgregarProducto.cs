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
    public partial class AgregarProducto : Form
    {
        public AgregarProducto()
        {
            InitializeComponent();
        }

        private bool todosLosCamposValidos()
        {
            Validador val = new Validador();

            return val.validarCampo(errorProvider, tbxCodPrenda, 3)
                    && val.validarCampo(errorProvider, tbxNombre, 3)
                    && val.validarCampo(errorProvider, tbxDescripcion, 4)
                    && val.validarCampo(errorProvider, tbxStock)
                    && val.validarCampo(errorProvider, tbxStockMinimo)
                    && val.validarCbx(errorProvider, cbxCategoria)
                    && val.validarCbx(errorProvider, cbxMarca)
                    && val.validarCbx(errorProvider, cbxProveedor);

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Seguro que desea cancelar esta operacion?", "Cancelar agregar producto",
                             MessageBoxButtons.YesNo,
                             MessageBoxIcon.Question);
           
            if (result == DialogResult.Yes) this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

          
            if (todosLosCamposValidos())
            {
             
                if (Productos.nuevoProducto(tbxCodPrenda.Text,tbxNombre.Text,tbxDescripcion.Text,tbxPrecio.Text,tbxStock.Text,tbxStockMinimo.Text,cbxCategoria.Text,cbxMarca.Text,cbxProveedor.SelectedIndex))
                {
                    MessageBox.Show("Exito");
                } else
                {
                    MessageBox.Show($"El producto con codigo: {tbxCodPrenda.Text} ya existe", "Error al insertar el producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
            }
        }

        private void tbxS_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void tbxM_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void tbxStockMinimo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void btnNuevaMarca_Click(object sender, EventArgs e)
        {
            new NuevaMarca().ShowDialog();
        }

        private void btnNuevaCategoria_Click(object sender, EventArgs e)
        {
            new NuevaCategoria().ShowDialog();
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
            cbxProveedor.DataSource = Productos.listarProveedores();
            cbxProveedor.DisplayMember = "nombre";
            cbxProveedor.SelectedIndex = -1;
        }

        private void AgregarProducto_Load(object sender, EventArgs e)
        {
            this.cargarCategorias();
            this.cargarMarcas();
            this.cargarProveedores();
        }


    }
}
