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

namespace ProyectoTaller2.C_Presentacion.Supervisor
{
    public partial class AgregarUsuario : Form
    {
        public AgregarUsuario()
        {
            InitializeComponent();
        }

        private bool todosLosCamposValidos()
        {
            Validador validador = new Validador();

            return validador.validarCampo(errorProvider, tbxNombre, 3)
                && validador.validarCampo(errorProvider, tbxApellido, 5)
                && validador.validarCampo(errorProvider, tbxDni, 8)
                && validador.validarCampo(errorProvider, tbxTelefono, 9)
                && validador.validarCampo(errorProvider, tbxDireccion, 6)
                && validador.validarCampo(errorProvider, tbxUsuario)
                && validador.validarCampo(errorProvider, tbxContrasena, 4)
                && validador.validarCbx(errorProvider,cbxRol);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Seguro que desea cancelar esta operacion?", "Cancelar agregar usuario",
                             MessageBoxButtons.YesNo,
                             MessageBoxIcon.Question);

            if (result == DialogResult.Yes) this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (this.todosLosCamposValidos())
            {
                if (new Usuarios().guardarUsuario(tbxNombre.Text, tbxApellido.Text, tbxDni.Text, tbxTelefono.Text, tbxDireccion.Text, tbxUsuario.Text, tbxContrasena.Text,cbxRol.SelectedIndex+1)){
                MessageBox.Show("Se agrego al usuario correctamnete", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                    tbxNombre.Clear();
                    tbxApellido.Clear();
                    tbxDni.Clear();
                    tbxTelefono.Clear();
                    tbxDireccion.Clear();
                    tbxUsuario.Clear();
                    tbxContrasena.Clear();
                    cbxRol.SelectedIndex = -1;
                
;               } else
                {
                    MessageBox.Show("Ocurrio un error al insertar el usuario", "Error al insertar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                };
            };
        }

        private void tbxDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void tbxTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }
    }
}
