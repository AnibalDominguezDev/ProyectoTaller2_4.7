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
    public partial class ListarVentas : Form
    {
        public ListarVentas()
        {
            InitializeComponent();
        }

        private void testDetalle_Click(object sender, EventArgs e)
        {
            new DetalleVenta().ShowDialog();
        }
    }
}
