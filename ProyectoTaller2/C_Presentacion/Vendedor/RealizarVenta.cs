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
    public partial class RealizarVenta : Form
    {
        public RealizarVenta()
        {
            InitializeComponent();
        }

        private bool todosLosCamposValidos()
        {
            Validador validador = new Validador();

            return validador.validarCbx(errorProvider, cbxCliente);
        }
        private void btnCobrar_Click(object sender, EventArgs e)
        {
            if (todosLosCamposValidos()) return;
        }

        private void btnCancelarVenta_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Seguro que desea cancelar esta operacion?", "Cancelar Venta",
                             MessageBoxButtons.YesNo,
                             MessageBoxIcon.Question);

            if (result == DialogResult.Yes) this.Close();
        }
    }
}
