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
            if (this.todosLosCamposValidos())
            {
                if (new Clientes().guardarCliente(txtNomAltaC.Text, txtApeAltaC.Text, txtDniAltaC.Text, txtTelC.Text, txtDirAltaC.Text, txtMailAltaC.Text))
                {
                    MessageBox.Show("Cliente agregado ocn exito", "Exito", MessageBoxButtons.OK);

                    txtNomAltaC.Clear();
                    txtApeAltaC.Clear();
                    txtDniAltaC.Clear();
                    txtTelC.Clear();
                    txtDirAltaC.Clear();
                    txtMailAltaC.Clear();
                }
                else
                {
                    MessageBox.Show("Ocurrio un error al agregar el cliente", "Error", MessageBoxButtons.OK);
                }
            };
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
