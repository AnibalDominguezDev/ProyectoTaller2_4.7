using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTaller2.C_Presentacion.Login
{
    public partial class Login : Form
    {
        public Login()
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
            if (validarCampos()) return;
        }
    }
}
