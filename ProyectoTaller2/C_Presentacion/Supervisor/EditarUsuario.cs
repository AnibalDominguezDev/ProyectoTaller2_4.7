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
    public partial class EditarUsuario : Form
    {

        private int userId;
        public EditarUsuario(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void rellenarCampos()
        {
            Usuarios user = new Usuarios().ObtenerUsuarioPorId(this.userId);

            tbxNombre.Text = user.getNombre();
            tbxApellido.Text = user.getApellido();
            tbxDni.Text = user.getDni().ToString();
            tbxTelefono.Text = user.getTelefono();
            tbxDireccion.Text = user.getDireccion();
            tbxUsuario.Text = user.getUsuario();
            tbxContrasena.Text = user.getContrasena();

            cbxRol.SelectedIndex = user.getRol()-1;
            


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
            if (this.todosLosCamposValidos())
            {

                var result = MessageBox.Show("Seguro que desea editar el usuario?", "Confirmar cambios",
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question);

                if (result == DialogResult.Yes && 
                    (Usuarios.editarUsuario
                    (this.userId,
                    tbxNombre.Text,
                    tbxApellido.Text,
                    tbxDni.Text,
                    tbxTelefono.Text,
                    tbxDireccion.Text,
                    tbxUsuario.Text,
                    tbxContrasena.Text,
                    cbxRol.SelectedIndex+1
            
                    )))
                {
                    MessageBox.Show("Usuario editado correctamente!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                } else
                {
                    MessageBox.Show("Error");
                }
                

            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Seguro que desea cancelar esta operacion?", "Cancelar Editar usuario",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);

            if (result == DialogResult.Yes) this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //rellenarCampos();
        }

        private void EditarUsuario_Load(object sender, EventArgs e)
        {
            rellenarCampos();
        }
    }
}
