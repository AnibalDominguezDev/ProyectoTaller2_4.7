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
                    && val.validarCampo(errorProvider, tbxStockMinimo);
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
            if (todosLosCamposValidos()) return;
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
    }
}
