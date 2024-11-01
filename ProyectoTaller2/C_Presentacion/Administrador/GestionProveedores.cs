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

namespace ProyectoTaller2.C_Presentacion.Administrador
{
    public partial class GestionProveedores : Form
    {
        public GestionProveedores()
        {
            InitializeComponent();
            this.cargarLista();
        }

        private void cargarLista()
        {
            dgbListarProveedores.DataSource = Proveedores.listarProveedores();

            dgbListarProveedores.Columns[0].Visible = false;
            dgbListarProveedores.Columns[0].Name = "idEditar";
            dgbListarProveedores.Columns[1].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill; //nombre
            dgbListarProveedores.Columns[2].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill; //direccion
            dgbListarProveedores.Columns[3].Width = 130;                                                         //telefono
            //dgbListarProveedores.Columns                                                                                         //email
            DataGridViewButtonColumn btnEditar = new DataGridViewButtonColumn();
            {
                btnEditar.Name = "btnEditar";
                btnEditar.HeaderText = "Editar";
                btnEditar.Text = "Editar";
                btnEditar.UseColumnTextForButtonValue = true;
                dgbListarProveedores.Columns.Add(btnEditar);
            }
        }

        private void btnNuevoProveedor_Click(object sender, EventArgs e)
        {
            new AgregarProveedor().ShowDialog();
        }

        private void testEditar_Click(object sender, EventArgs e)
        {
            //new EditarProveedor().ShowDialog();
            dgbListarProveedores.DataSource = "";
            dgbListarProveedores.Columns.Clear();
            this.cargarLista();
     
        }

        private void dgbListarProveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgbListarProveedores.Columns["btnEditar"].Index && e.RowIndex >= 0)
            {
                new EditarProveedor(int.Parse(dgbListarProveedores.Rows[e.RowIndex].Cells["idEditar"].Value.ToString())).ShowDialog();
            }
        }
    }
}
