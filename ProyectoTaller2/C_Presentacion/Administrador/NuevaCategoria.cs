using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTaller2.C_Presentacion.Administrador
{
    public partial class NuevaCategoria : Form
    {
        public NuevaCategoria()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Validador validador = new Validador();
            if (validador.validarCampo(errorProvider, tbxNombre)) return;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Seguro que desea cancelar esta operacion?", "Cancelar agregar marca",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);

            if (result == DialogResult.Yes) this.Close();
        }
    }
}
