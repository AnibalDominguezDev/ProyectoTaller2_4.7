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
    public partial class EditarProveedor : Form
    {
        private int proveedorId;
        public EditarProveedor(int id)
        {   
            this.proveedorId = id;
            InitializeComponent();
            this.rellenarCampos();
        }

        private void rellenarCampos()
        {
           Proveedores proveedor = new Proveedores().obtenerProveedoresPorId(this.proveedorId);

            tbxNombre.Text = proveedor.getNombre();
            tbxDireccion.Text = proveedor.getDireccion();
            tbxTelefono.Text = proveedor.getTelefono();
            tbxEmail.Text = proveedor.getEmail();

            
        }
         private bool todosLosCamposValidos()
        {
            Validador val = new Validador();

            return val.validarCampo(errorProvider, tbxNombre, 4)
                && val.validarCampo(errorProvider, tbxDireccion)
                && val.validarCampo(errorProvider, tbxTelefono, 6)
                && val.validarCampo(errorProvider, tbxEmail, 7);
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Seguro que desea cancelar la edicion del proveedor?", "Cancelar editar proveedor",
                             MessageBoxButtons.YesNo,
                             MessageBoxIcon.Question);

            if (result == DialogResult.Yes) this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (this.todosLosCamposValidos())
            {
                if (Proveedores.editarProveedor(this.proveedorId,tbxNombre.Text,tbxDireccion.Text,tbxTelefono.Text,tbxEmail.Text))
                {
                    MessageBox.Show("Proveedor actualizado correctamente!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else
                {
                    MessageBox.Show("Ocurrio un error al editar el proveedor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };
        }

        private void tbxTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void EditarProveedor_Load(object sender, EventArgs e)
        {

        }
    }
}
