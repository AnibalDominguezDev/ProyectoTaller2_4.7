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
            openFileDialog.Filter = "Archivo BAK (*.bak)|*.bak |All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK) tbxRestaurarDesde.Text = openFileDialog.FileName;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (DB.GuardarBackcup(tbxGuardarEn.Text))
            {
                MessageBox.Show("Copia de seguridad guardada correctamente.","Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                MessageBox.Show("Ocurrio un error al guardar la copia", "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            if (DB.RecuperarBackup(tbxRestaurarDesde.Text))
            {
                MessageBox.Show("Copia de seguridad restaurada correctamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                MessageBox.Show("Ocurrio un error al restaurar la copia", "Error al restaurar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
