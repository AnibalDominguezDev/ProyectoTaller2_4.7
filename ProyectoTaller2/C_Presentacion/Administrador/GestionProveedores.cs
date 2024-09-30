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
    public partial class GestionProveedores : Form
    {
        public GestionProveedores()
        {
            InitializeComponent();
        }

        private void btnNuevoProveedor_Click(object sender, EventArgs e)
        {
            new AgregarProveedor().ShowDialog();
        }

        private void testEditar_Click(object sender, EventArgs e)
        {
            new EditarProveedor().ShowDialog();
        }
    }
}
