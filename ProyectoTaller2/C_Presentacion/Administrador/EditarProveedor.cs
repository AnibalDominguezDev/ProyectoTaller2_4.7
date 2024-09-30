using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTaller2.C_Presentacion.Administrador
{
    public partial class EditarProveedor : Form
    {
        public EditarProveedor()
        {
            InitializeComponent();
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
            if (this.todosLosCamposValidos()) return;
        }

        private void tbxTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }
    }
}
