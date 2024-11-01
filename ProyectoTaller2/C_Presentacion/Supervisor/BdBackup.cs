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
    public partial class BdBackup : Form
    {
        public BdBackup()
        {
            InitializeComponent();
        }

        private void btnGuardarUbicacion_Click(object sender, EventArgs e)
        {

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK) tbxGuardarEn.Text = folderBrowserDialog.SelectedPath;
        }

        private void btnRestaurarUbicacion_Click_1(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK) tbxRestaurarDesde.Text = openFileDialog.FileName;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (DB.GuardarBackcup(tbxGuardarEn.Text))
            {
                MessageBox.Show("Exito");
            }
        }
    }
}
