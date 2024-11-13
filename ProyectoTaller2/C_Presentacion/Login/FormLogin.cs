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
using ProyectoTaller2.C_Presentacion.Administrador;
using ProyectoTaller2.C_Presentacion.Supervisor;
using ProyectoTaller2.C_Presentacion.Vendedor;

namespace ProyectoTaller2.C_Presentacion.Login
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private bool validarCampos()
        {
            Validador validador = new Validador();

            return validador.validarCampo(errorProvider, txtLoginInicio)
                && validador.validarCampo(errorProvider, txtLoginPass);
        }
        private void btnLoginIniciar_Click(object sender, EventArgs e)
        {
            if (validarCampos()){
                string nombre = txtLoginInicio.Text.Trim();
                string contraseña = txtLoginPass.Text;

                LoginL logicaUsuario = new LoginL();
                int rollUsuario = logicaUsuario.IniciarSesion(nombre, contraseña);
                int idUsuario = logicaUsuario.UsuarioID(nombre, contraseña);

                if (idUsuario == -1 )
                {
                    MessageBox.Show("Usuario y / o Contraseña incorrectos!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }

                Sesion.IdUsuarioConectado = idUsuario;

                string nombreCompleto = Usuarios.getNombreCompleto(idUsuario);

                if (rollUsuario == 1)
                {
                    MenuVendedor menu = new MenuVendedor(nombreCompleto);
                    menu.Show();
                    this.Hide();
                }
                else if (rollUsuario == 2)
                {
                    FormPrincipalAdmin formAdmin = new FormPrincipalAdmin(nombreCompleto);
                    formAdmin.Show();
                    this.Hide();
                }
                else if (rollUsuario == 3)
                {
                    FormPrincipalSupervisor formSupervisor = new FormPrincipalSupervisor(nombreCompleto);
                    formSupervisor.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario y / o Contraseña incorrectos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
