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
            
        }

        private void cargarLista()
        {
            dgbListarProveedores.DataSource = "";
            dgbListarProveedores.Columns.Clear();
            dgbListarProveedores.DataSource = Proveedores.listarProveedores();

            dgbListarProveedores.Columns[0].Visible = false;
            dgbListarProveedores.Columns[0].Name = "idEditar";
            dgbListarProveedores.Columns[1].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill; //nombre
            dgbListarProveedores.Columns[2].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill; //direccion
            dgbListarProveedores.Columns[3].Width = 130;                                                         //telefono
            dgbListarProveedores.Columns[5].Visible = false;     
            
            DataGridViewButtonColumn btnEditar = new DataGridViewButtonColumn();
            {
                btnEditar.Name = "btnEditar";
                btnEditar.HeaderText = "Editar";
                btnEditar.Text = "Editar";
                btnEditar.UseColumnTextForButtonValue = true;
                dgbListarProveedores.Columns.Add(btnEditar);
            }

            DataGridViewButtonColumn btnEliminar = new DataGridViewButtonColumn();
            {
                btnEliminar.Name = "btnEliminar";
                btnEliminar.HeaderText = "Accion";
                btnEliminar.Text = "Eliminar";
                btnEliminar.UseColumnTextForButtonValue = false;
                dgbListarProveedores.Columns.Add(btnEliminar);
            }

            foreach (DataGridViewRow row in dgbListarProveedores.Rows)
            {

                if ((int)row.Cells["estado_proveedor"].Value == 1)
                {
                    row.Cells["btnEliminar"].Value = "Eliminar";
                }
                else
                {
                    row.Cells["btnEliminar"].Value = "Activar";
                }
            }
        }

        private void btnNuevoProveedor_Click(object sender, EventArgs e)
        {
            new AgregarProveedor().ShowDialog();
        }

        private void testEditar_Click(object sender, EventArgs e)
        {
            //new EditarProveedor().ShowDialog();
           
            this.cargarLista();

        }

        private void dgbListarProveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgbListarProveedores.Columns["btnEditar"].Index && e.RowIndex >= 0)
            {
                new EditarProveedor(int.Parse(dgbListarProveedores.Rows[e.RowIndex].Cells["idEditar"].Value.ToString())).ShowDialog();
            }

            if (e.ColumnIndex == dgbListarProveedores.Columns["btnEliminar"].Index && e.RowIndex >= 0)
            {
                if (Proveedores.cambiarEstadoProveedor(int.Parse(dgbListarProveedores.Rows[e.RowIndex].Cells["idEditar"].Value.ToString())))
                {
                    MessageBox.Show("Producto actualizado correctamente!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarLista();
                }
            }
        }

        private void GestionProveedores_Load(object sender, EventArgs e)
        {
            this.cargarLista();
        }
    }
}
