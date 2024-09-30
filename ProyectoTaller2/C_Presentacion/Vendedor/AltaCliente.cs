using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTaller2.C_Presentacion.Vendedor
{
    public partial class AltaCliente : Form
    {
        public AltaCliente()
        {
            InitializeComponent();
        }

        private bool todosLosCamposValidos()
        {
            Validador validador = new Validador();

            return validador.validarCampo(errorProvider, txtNomAltaC)
                && validador.validarCampo(errorProvider, txtApeAltaC)
                && validador.validarCampo(errorProvider, txtDniAltaC)
                && validador.validarCampo(errorProvider, txtTelC)
                && validador.validarCampo(errorProvider, txtDirAltaC)
                && validador.validarCampo(errorProvider, txtMailAltaC);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (this.todosLosCamposValidos()) return;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Seguro que desea cancelar esta operacion?", "Cancelar agregar Cliente",
                             MessageBoxButtons.YesNo,
                             MessageBoxIcon.Question);

            if (result == DialogResult.Yes) this.Close();
        }

        private void txtDniAltaC_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void txtTelC_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }
    }
}
