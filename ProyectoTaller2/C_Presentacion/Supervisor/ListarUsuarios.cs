using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoTaller2.C_Datos;
using ProyectoTaller2.C_Logica;

namespace ProyectoTaller2.C_Presentacion.Supervisor
{
    public partial class ListarUsuarios : Form
    {
        public ListarUsuarios()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //new EditarUsuario().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Usuarios().ObtenerUsuarioPorId(3);

            //dgbDetalleProductos.Rows.Add(Usuarios.listarUsuarios());
        }

        private void dgbDetalleProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgbDetalleProductos.Columns["btnEditar"].Index)
            {
                Console.WriteLine("FUNCIONA" + int.Parse(dgbDetalleProductos.Rows[e.RowIndex].Cells["idEditar"].Value.ToString()));
                new EditarUsuario(int.Parse(dgbDetalleProductos.Rows[e.RowIndex].Cells["idEditar"].Value.ToString())).ShowDialog();
            }
        }

        private void ListarUsuarios_Load(object sender, EventArgs e)
        {
            cargarLista();

            cbxFiltroRol.DataSource = Usuarios.listarRoles();
            cbxFiltroRol.DisplayMember = "nombre";

        }

        private void cargarLista()
        {
            dgbDetalleProductos.DataSource = Usuarios.listarUsuarios();

            dgbDetalleProductos.Columns[0].HeaderText = "Fecha de Alta";
            dgbDetalleProductos.Columns[1].HeaderText = "Apellido";
            dgbDetalleProductos.Columns[2].HeaderText = "Nombre";
            dgbDetalleProductos.Columns[3].HeaderText = "DNI";
            dgbDetalleProductos.Columns[4].HeaderText = "Telefono";
            dgbDetalleProductos.Columns[5].HeaderText = "Usuario";
            dgbDetalleProductos.Columns[6].HeaderText = "Rol";
            dgbDetalleProductos.Columns[7].HeaderText = "Activo";
            //dgbDetalleProductos.Columns[8].Visible = false;
            dgbDetalleProductos.Columns[8].Name = "idEditar";
            
       



            DataGridViewButtonColumn btnEditar = new DataGridViewButtonColumn();
            {
                btnEditar.Name = "btnEditar";
                btnEditar.HeaderText = "Editar";
                btnEditar.Text = "Editar";
                btnEditar.UseColumnTextForButtonValue = true;
                dgbDetalleProductos.Columns.Add(btnEditar);
        }

            }
        private void btnAplicar_Click(object sender, EventArgs e)
        {
            dgbDetalleProductos.DataSource = Usuarios.listarUsuariosPorRol(cbxFiltroRol.SelectedIndex+1);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cbxFiltroBuscar.SelectedIndex == 0)
            {
                dgbDetalleProductos.DataSource = Usuarios.listarUsuariosPorDni(int.Parse(tbxBuscar.Text)); 
            }
        }
    }
}
