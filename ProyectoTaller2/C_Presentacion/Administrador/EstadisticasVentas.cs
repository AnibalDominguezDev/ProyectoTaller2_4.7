using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using ProyectoTaller2.C_Datos;
using ProyectoTaller2.C_Logica;

namespace ProyectoTaller2.C_Presentacion.Administrador
{
    public partial class EstadisticasVentas : Form
    {
        public EstadisticasVentas()
        {
            InitializeComponent();
            cargarVendedores();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cargarVendedores()
        {
            cbxVendedores.Items.Clear();
            cbxVendedores.DataSource = Usuarios.ListarVendedores();
            cbxVendedores.DisplayMember = "NomYApeDNI";
            cbxVendedores.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            cargarProductosMasVendidos(dtpPDesde.Value, dtpPHasta.Value);
            cargarCategoriaMasVendida(dtpPDesde.Value, dtpPHasta.Value);

        }

        private void btnFiltrarG_Click(object sender, EventArgs e)
        {

         

           cargarGananciasMensuales(dtpGDesde.Value, dtpGHasta.Value);

        }

        private void btnBuscarV_Click(object sender, EventArgs e)
        {

            if (!String.IsNullOrEmpty(cbxVendedores.Text))
            {
                try
                {
                    int dni = int.Parse(cbxVendedores.Text.Split(' ', (char)StringSplitOptions.RemoveEmptyEntries).LastOrDefault());

                    chartGnanaciasVendedor.Series.Clear();
                    //chartVentasGenerales.ChartAreas.Clear();

                    Series series = new Series
                    {
                        Name = "Ventas",
                        ChartType = SeriesChartType.Line,
                    };

                    var lst = Usuarios.getGananciasMensualesVendedor(3);



                    foreach (var venta in lst)
                    {
                        series.Points.AddXY(venta.Mes, venta.TotalPrecio);
                    }


                    chartGnanaciasVendedor.Series.Add(series);
                }
                catch (Exception) { }

            }

        }

        private void testEstats_Click(object sender, EventArgs e)
        {
            
            
        }

        private void cargarGananciasMensuales(DateTime desde, DateTime hasta)
        {
            chartVentasGenerales.Series.Clear();
            //chartVentasGenerales.ChartAreas.Clear();

            Series series = new Series
            {
                Name = "Ventas",
                ChartType = SeriesChartType.Line,
                IsValueShownAsLabel = true
            };

            var ventas = Productos.getResumenMensual(desde,hasta);


            foreach (var venta in ventas)
            {
                series.Points.AddXY(venta.Mes.ToString(), venta.TotalVentas);
            }

            chartVentasGenerales.Series.Add(series);


            chartVentasGenerales.ChartAreas[0].AxisX.Title = "Fecha";
            chartVentasGenerales.ChartAreas[0].AxisY.Title = "Monto Total";
        }

        private void cargarVendedorConMasVentas()
        {
            chartVentasVendedores.Series.Clear();
            //chartVentasGenerales.ChartAreas.Clear();

            Series series = new Series
            {
                Name = "Ventas",
                ChartType = SeriesChartType.Bar,

            };

            var lst = Usuarios.getVendedoresConMasVentas();

            foreach (var venta in lst)
            {
                series.Points.AddXY(Usuarios.getNombreCompleto(venta.IdUsuario), venta.Ventas);
            }

            chartVentasVendedores.Series.Add(series);
        }

        private void cargarProductosMasVendidos(DateTime inicio, DateTime fin)
        {
            chartProductoMasVendido.Series.Clear();

            Series series = new Series
            {
                Name = "Ventas",
                ChartType = SeriesChartType.Column,
                IsValueShownAsLabel = true
            };

            var lst = Productos.getProductosMasVendidos(inicio, fin);

            foreach (var venta in lst)
            {
                series.Points.AddXY(venta.Producto, venta.TotalCantidadProductos);
            }

            chartProductoMasVendido.Series.Add(series);

        }

        private void cargarCategoriaMasVendida(DateTime inicio, DateTime fin)
        {

            chartCategoriaMasVendida.Series.Clear();

            Series series = new Series
            {
                Name = "Ventas",
                ChartType = SeriesChartType.Pie,
                IsValueShownAsLabel = true

            };

            var lst = Productos.getCategoriasMasVendidas(inicio,fin);

            foreach (var venta in lst)
            {
                series.Points.AddXY(Productos.getNombreCategoria(venta.IdCategoria), venta.VecesVendido);
            }

            chartCategoriaMasVendida.Series.Add(series);
        }

        private void cargarGraficos()
        {
            lblVentasTotales.Text = $"Ventas Totales: {Ventas.getCantidadVentas()}";
            lblGanancias.Text = $"Ganancias Totales: ${Ventas.getGananciasTotales()}";
            lvlVendedoresActivos.Text = $"Vendedores activos {Usuarios.contarVendedoresActivos()}";


            DateTime desde = new DateTime(2024, 1, 1);
            DateTime hasta = new DateTime(2024, 12, 30);


            cargarGananciasMensuales(desde,hasta);
            cargarProductosMasVendidos(desde, hasta);
            cargarCategoriaMasVendida(desde, hasta);
            cargarVendedorConMasVentas();
        }

        private void EstadisticasVentas_Load(object sender, EventArgs e)
        {
            cargarGraficos();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           

            
        }
    }
}
