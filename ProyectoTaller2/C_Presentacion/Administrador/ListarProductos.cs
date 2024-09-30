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
    public partial class ListarProductos : Form
    {
        public ListarProductos()
        {
            InitializeComponent();
        }

        private void testEditar_Click(object sender, EventArgs e)
        {
            new EditarProducto().ShowDialog();
        }

        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            new AgregarProducto().ShowDialog();
        }
    }
}
