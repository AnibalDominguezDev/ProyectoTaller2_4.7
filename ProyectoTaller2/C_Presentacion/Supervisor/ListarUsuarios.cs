﻿using System;
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
            dgbUsuarios.Update();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Usuarios().ObtenerUsuarioPorId(3);

            //dgbDetalleProductos.Rows.Add(Usuarios.listarUsuarios());
        }

        private void dgbDetalleProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgbUsuarios.Columns["btnEditar"].Index)
            {
                Console.WriteLine("FUNCIONA" + int.Parse(dgbUsuarios.Rows[e.RowIndex].Cells["idEditar"].Value.ToString()));
                new EditarUsuario(int.Parse(dgbUsuarios.Rows[e.RowIndex].Cells["idEditar"].Value.ToString())).ShowDialog();
            }
        }

        private void ListarUsuarios_Load(object sender, EventArgs e)
        {
            cargarLista();

            cbxFiltroRol.DataSource = Usuarios.listarRoles();
            cbxFiltroRol.DisplayMember = "nombre";
            cbxFiltroRol.SelectedIndex = -1;

        }

        private void cargarLista()
        {
         
            dgbUsuarios.DataSource = Usuarios.listarUsuarios();

            dgbUsuarios.Columns[0].HeaderText = "Fecha de Alta";



            dgbUsuarios.Columns[1].HeaderText = "Apellido";
            dgbUsuarios.Columns[1].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;

            dgbUsuarios.Columns[2].HeaderText = "Nombre";
            dgbUsuarios.Columns[2].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;

            dgbUsuarios.Columns[3].HeaderText = "DNI";
            dgbUsuarios.Columns[4].HeaderText = "Telefono";
            dgbUsuarios.Columns[5].HeaderText = "Usuario";


            dgbUsuarios.Columns[6].HeaderText = "Rol";
            dgbUsuarios.Columns[6].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;


            dgbUsuarios.Columns[7].HeaderText = "Activo";
            dgbUsuarios.Columns[7].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;


            dgbUsuarios.Columns[8].Visible = false;
            dgbUsuarios.Columns[8].Name = "idEditar";
            
       



            DataGridViewButtonColumn btnEditar = new DataGridViewButtonColumn();
            {
                btnEditar.Name = "btnEditar";
                btnEditar.HeaderText = "Editar";
                btnEditar.Text = "Editar";
                btnEditar.UseColumnTextForButtonValue = true;
                dgbUsuarios.Columns.Add(btnEditar);
            }

        }
        private void btnAplicar_Click(object sender, EventArgs e)
        {
            dgbUsuarios.DataSource = Usuarios.listarUsuariosPorRol(cbxFiltroRol.SelectedIndex+1);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
             Validador val = new Validador();
            if (cbxFiltroBuscar.SelectedIndex == 0 && val.validarCbx(errorProvider,cbxFiltroBuscar) && val.validarCampo(errorProvider,tbxBuscar))
            {
                try
                {
                    dgbUsuarios.DataSource = Usuarios.listarUsuariosPorDni(int.Parse(tbxBuscar.Text));
                } catch (Exception) {
                    MessageBox.Show("La opcion de buscar por Dni solo admite campos numericos", "Error al Buscar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                 
            } else if((cbxFiltroBuscar.SelectedIndex == 1) && val.validarCbx(errorProvider, cbxFiltroBuscar) && val.validarCampo(errorProvider,tbxBuscar))
            {
                dgbUsuarios.DataSource = Usuarios.buscarUsuarioPorApellido(tbxBuscar.Text.Trim());
            }
        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {
           // cargarLista();
        }

        private void cbxFiltroBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbxBuscar.Clear();
        }

        private void tbxBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbxFiltroBuscar.SelectedIndex == 0) e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
            else if (cbxFiltroBuscar.SelectedIndex == 1) e.Handled = char.IsDigit(e.KeyChar);
        }
    }
}
