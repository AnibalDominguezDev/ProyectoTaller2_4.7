using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTaller2.C_Presentacion.Supervisor
{
    public partial class EditarUsuario : Form
    {
        public EditarUsuario()
        {
            InitializeComponent();
        }
        private bool todosLosCamposValidos()
        {
            Validador validador = new Validador();

            return validador.validarCampo(errorProvider, tbxNombre, 3)
                && validador.validarCampo(errorProvider, tbxApellido, 3)
                && validador.validarCampo(errorProvider, tbxDni, 8)
                && validador.validarCampo(errorProvider, tbxTelefono, 9)
                && validador.validarCampo(errorProvider, tbxDireccion, 6)
                && validador.validarCampo(errorProvider, tbxUsuario)
                && validador.validarCampo(errorProvider, tbxContrasena, 4)
                && validador.validarCbx(errorProvider,cbxRol);
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (this.todosLosCamposValidos()) return;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Seguro que desea cancelar esta operacion?", "Cancelar Editar usuario",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);

            if (result == DialogResult.Yes) this.Close();
        }
    }
}
