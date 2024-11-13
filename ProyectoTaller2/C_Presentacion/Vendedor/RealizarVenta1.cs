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
    public partial class RealizarVenta1 : Form
    {
        private int idCliente;
        public RealizarVenta1()
        {
            InitializeComponent();
        }

        private void setIdCliente(int id)
        {
            this.idCliente = id;
        }

        private int getIdCliente()
        {
            return this.idCliente;
        }

        /*
        private void lstMetodosPago()
        {
            var metodos = MetodoPago.listarMetodosPagos();
            cbxMetodoPago.DataSource = metodos;
        }

        private void ConfigurarColumnasDataGridView()
        {
            gridVentaProducto.AutoGenerateColumns = false;

            gridVentaProducto.Columns["ColNomP"].DataPropertyName = "nombre";
            gridVentaProducto.Columns["ColDescrip"].DataPropertyName = "descripcion";
            gridVentaProducto.Columns["ColStock"].DataPropertyName = "stock";
            gridVentaProducto.Columns["ColPrecio"].DataPropertyName = "precio";

            gridVentaProducto.Columns["Col_idPro"].DataPropertyName = "id_producto";
        }

        private void lstProductos()
        {
            var productos = Productos.listaProductosParaVentas();
            gridVentaProducto.DataSource = productos;
        }

        private void gridVentaProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == gridVentaProducto.Columns["ColAgregar"].Index && e.RowIndex >= 0)
            {
                int idPro = Convert.ToInt32(gridVentaProducto.Rows[e.RowIndex].Cells["Col_idPro"].Value);
                string nombreProducto = gridVentaProducto.Rows[e.RowIndex].Cells["ColNomP"].Value.ToString();
                decimal precioUnitario = Convert.ToDecimal(gridVentaProducto.Rows[e.RowIndex].Cells["ColPrecio"].Value);
                int stockDisponible = Convert.ToInt32(gridVentaProducto.Rows[e.RowIndex].Cells["ColStock"].Value);

                // Verificar si el producto ya existe en gridRealizarVenta
                bool productoExistente = false;
                foreach (DataGridViewRow row in gridRealizarVenta.Rows)
                {
                    if (row.Cells["col_NomProductoVR"].Value != null && row.Cells["col_NomProductoVR"].Value.ToString() == nombreProducto)
                    {
                        productoExistente = true;
                        break;
                    }
                }

                // Si el producto no existe en el gridRealizarVenta, agregarlo con cantidad inicial de 1
                if (!productoExistente)
                {
                    int nuevaFila = gridRealizarVenta.Rows.Add();
                    gridRealizarVenta.Rows[nuevaFila].Cells["Col_proId"].Value = idPro;
                    gridRealizarVenta.Rows[nuevaFila].Cells["col_NomProductoVR"].Value = nombreProducto;
                    gridRealizarVenta.Rows[nuevaFila].Cells["col_cantidadVR"].Value = 1; // Cantidad inicial de 1
                    gridRealizarVenta.Rows[nuevaFila].Cells["col_precioUnitarioVR"].Value = precioUnitario;
                    gridRealizarVenta.Rows[nuevaFila].Cells["col_precioTotalVR"].Value = precioUnitario; // Precio total inicial
                    ActualizarTotalCompra();
                    // Guarda el stock disponible en el Tag para validarlo luego
                    gridRealizarVenta.Rows[nuevaFila].Tag = stockDisponible;
                }

            }
        }

        private void ConfigurarGridRealizarVenta()
        {
            gridRealizarVenta.AutoGenerateColumns = false;

            // Configuración de columnas para gridRealizarVenta
            if (gridRealizarVenta.Columns["Col_proId"] == null)
            {
                gridRealizarVenta.Columns.Add("Col_proId", "ID Producto");
                gridRealizarVenta.Columns["Col_proId"].Visible = false; // Hacer la columna oculta
            }

            if (gridRealizarVenta.Columns["col_NomProductoVR"] == null)
            {
                gridRealizarVenta.Columns.Add("col_NomProductoVR", "Producto");
                gridRealizarVenta.Columns["col_NomProductoVR"].DataPropertyName = "nombre";
            }

            if (gridRealizarVenta.Columns["col_cantidadVR"] == null)
            {
                gridRealizarVenta.Columns.Add("col_cantidadVR", "Cantidad");
                gridRealizarVenta.Columns["col_cantidadVR"].DataPropertyName = "cantidad";
            }

            if (gridRealizarVenta.Columns["col_precioUnitarioVR"] == null)
            {
                gridRealizarVenta.Columns.Add("col_precioUnitarioVR", "Precio");
                gridRealizarVenta.Columns["col_precioUnitarioVR"].DataPropertyName = "precio";
            }

            if (gridRealizarVenta.Columns["col_precioTotalVR"] == null)
            {
                gridRealizarVenta.Columns.Add("col_precioTotalVR", "Precio Total");
            }

        }

        private void gridRealizarVenta_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == gridRealizarVenta.Columns["col_cantidadVR"].Index)
            {
                DataGridViewRow row = gridRealizarVenta.Rows[e.RowIndex];
                int cantidad = Convert.ToInt32(row.Cells["col_cantidadVR"].Value);
                decimal precioUnitario = Convert.ToDecimal(row.Cells["col_precioUnitarioVR"].Value);
                int stockDisponible = Convert.ToInt32(gridVentaProducto.Rows[e.RowIndex].Cells["ColStock"].Value);

                if (cantidad > stockDisponible)
                {
                    MessageBox.Show("No hay stock suficiente", "Stock insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    // Restaurar la cantidad anterior a la cantidad máxima permitida
                    row.Cells["col_cantidadVR"].Value = stockDisponible;
                    row.Cells["col_precioTotalVR"].Value = stockDisponible * precioUnitario;
                }
                else
                {
                    // Actualizar el precio total basado en la cantidad válida
                    row.Cells["col_precioTotalVR"].Value = cantidad * precioUnitario;
                }

                ActualizarTotalCompra();
            }
        }

        private void gridRealizarVenta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            gridRealizarVenta.Rows.RemoveAt(e.RowIndex);
            ActualizarTotalCompra();
        }

        private void gridRealizarVenta_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == gridRealizarVenta.Columns["col_cantidadVR"].Index)
            {
                ActualizarTotalCompra();
            }
        }

        private void ActualizarTotalCompra()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in gridRealizarVenta.Rows)
            {
                if (row.Cells["col_precioTotalVR"].Value != null)
                {
                    total += Convert.ToDecimal(row.Cells["col_precioTotalVR"].Value);
                }
            }

            lblPrecioTotal.Text = $"${total:0.00}";
        }

        private void cbxBuscarPor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxBuscarPor.SelectedItem.ToString() == "Cod. Prenda")
            {
                tbxBuscarProducto.KeyPress += new KeyPressEventHandler(SoloNumeros_KeyPress);
                tbxBuscarProducto.KeyPress -= new KeyPressEventHandler(SoloLetras_KeyPress);
            }
            else if (cbxBuscarPor.SelectedItem.ToString() == "Nombre")
            {
                tbxBuscarProducto.KeyPress += new KeyPressEventHandler(SoloLetras_KeyPress);
                tbxBuscarProducto.KeyPress -= new KeyPressEventHandler(SoloNumeros_KeyPress);
            }
        }

        private void SoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Evita que se ingrese cualquier carácter que no sea número
            }
        }

        private void SoloLetras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // Evita que se ingrese cualquier carácter que no sea letra
            }
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            string criterioBusqueda = tbxBuscarProducto.Text.Trim();

            if (string.IsNullOrWhiteSpace(criterioBusqueda))
            {
                MessageBox.Show("Por favor, ingrese un valor para buscar.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbxBuscarPor.SelectedItem.ToString() == "Cod. Prenda")
            {
                // Convertimos el texto a número y hacemos la búsqueda por código
                if (int.TryParse(criterioBusqueda, out int codigoPrenda))
                {
                    BuscarProductoPorCodigo(codigoPrenda);
                }
                else
                {
                    MessageBox.Show("Ingrese un código válido.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (cbxBuscarPor.SelectedItem.ToString() == "Nombre")
            {
                BuscarProductoPorNombre(criterioBusqueda);
            }
        }

        private void BuscarProductoPorCodigo(int codigo)
        {
            var productos = Productos.ListarPorductorPorCodigo(codigo);
            gridVentaProducto.DataSource = productos;
        }

        private void BuscarProductoPorNombre(string nombre)
        {
            var productos = Productos.listarProductosPorNombre(nombre);
            gridVentaProducto.DataSource = productos;
        }

        private void ConfigurarColumnasDGVClientes()
        {
            dgvClientesVentas.AutoGenerateColumns = false;

            dgvClientesVentas.Columns["ColNomC"].DataPropertyName = "nombre";
            dgvClientesVentas.Columns["ColApeC"].DataPropertyName = "apellido";
            dgvClientesVentas.Columns["ColDniC"].DataPropertyName = "dni";

            dgvClientesVentas.Columns["Col_idCli"].DataPropertyName = "id_cliente";
        }

        public void CargarClientes()
        {
            var clientes = Clientes.ListarClientes();
            dgvClientesVentas.DataSource = clientes;
        }

        private void dgvClientesVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvClientesVentas.Columns["ColSelecC"].Index && e.RowIndex >= 0)
            {
                idCliente = (int)dgvClientesVentas.Rows[e.RowIndex].Cells["Col_idCli"].Value;
                string nombreCliente = dgvClientesVentas.Rows[e.RowIndex].Cells["ColNomC"].Value.ToString();
                string apellidoCliente = dgvClientesVentas.Rows[e.RowIndex].Cells["ColApeC"].Value.ToString();

                lblClienteSelec.Text = $"{nombreCliente} {apellidoCliente}";

                gbListaClientes.Visible = false;
            }
        }

        private void cbxCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxCliente.SelectedItem != null)
            {
                if (cbxCliente.SelectedItem.ToString() == "DNI")
                {
                    txtBuscarCliente.KeyPress += new KeyPressEventHandler(SoloNumeros_KeyPress);
                    txtBuscarCliente.KeyPress -= new KeyPressEventHandler(SoloLetras_KeyPress);
                }
                else if (cbxCliente.SelectedItem.ToString() == "Nombre")
                {
                    txtBuscarCliente.KeyPress += new KeyPressEventHandler(SoloLetras_KeyPress);
                    txtBuscarCliente.KeyPress -= new KeyPressEventHandler(SoloNumeros_KeyPress);
                }
            }
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            string criterioBusqueda = txtBuscarCliente.Text.Trim();

            if (string.IsNullOrWhiteSpace(criterioBusqueda))
            {
                MessageBox.Show("Por favor, ingrese un valor para buscar.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verificar que se haya seleccionado una opción en el ComboBox de búsqueda
            if (cbxCliente.SelectedItem != null)
            {
                if (cbxCliente.SelectedItem.ToString() == "DNI")
                {
                    BuscarClientePorDNI(criterioBusqueda);
                }
                else if (cbxCliente.SelectedItem.ToString() == "Nombre")
                {
                    BuscarClientePorNombre(criterioBusqueda);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un criterio de búsqueda.", "Selección requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void BuscarClientePorDNI(string dni)
        {
            var clientes = Clientes.listarClentesPorDni(dni);
            dgvClientesVentas.DataSource = clientes;
        }

        private void BuscarClientePorNombre(string nombre)
        {
            var clientes = Clientes.listarClientesPorNombre(nombre);
            dgvClientesVentas.DataSource = clientes;
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
        } */
    }
}
