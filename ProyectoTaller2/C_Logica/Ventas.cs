using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using ProyectoTaller2.C_Datos;

namespace ProyectoTaller2.C_Logica
{
    internal class Ventas
    {

        private int idCliente;
        private int idUsuario;
        private DateTime fechaV;
        private double totalVenta;
        private int cantidadP;
        private int metodo_pago;


        public Ventas() { }

        public Ventas(int p_idcliente, int p_idusuario, DateTime p_fechaV, double p_total, int cantidad, int metodopago)
        {
            this.idCliente = p_idcliente;
            this.idUsuario = p_idusuario;
            this.fechaV = p_fechaV;
            this.totalVenta = p_total;
            this.cantidadP = cantidad;
            this.metodo_pago = metodopago;
        }

        public int getIdCliente() { return this.idCliente; }
        public int getIdUsuario() { return this.idUsuario; }
        public DateTime getFecha() { return this.fechaV; }
        public double getTotalVenta() { return this.totalVenta; }
        private int getMetodoPago() { return this.metodo_pago; }

        public bool guardarVenta(int p_idcliente, int p_idusuario, DateTime p_fechaV, float p_total, int metodoPago)
        {
            try
            {
                ventas nueva = new ventas();
                nueva.id_cliente = p_idcliente;
                nueva.id_usuario = p_idusuario;
                nueva.fecha = p_fechaV;
                nueva.precio_total = p_total;
                nueva.id_metodoPago= metodoPago;
                
                return DVentas.AddVenta(nueva);
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);
                return false;
            }
        }

        public static object obtenerDatosVenta(int id)
        {
            return DVentas.obtenerDatosVenta(id);
        }

        public int ObtenerUltimaVentaID()
        {
            DVentas venta = new DVentas();
            return venta.ObtenerUltimaVentaID();
        }

        public static double getGananciasTotales()
        {
            return DVentas.getEarnings();
        }

        public static int getCantidadVentas()
        {
            return DVentas.getSellCounts();
        }

        public static object obtenerVentasPorVendedor(int id, DateTime fechaInicio, DateTime fechaFin)
        {
            return DVentas.obtenerVentasPorVendedor(id,fechaInicio,fechaFin);
        }

        public static object obtenerTodasLasVentas()
        {
            return DVentas.getAllSales();
        }


        public Ventas obtenerVentaPorId(int id)
        {

            ventas v = DVentas.getVentaById(id);

            return new Ventas(v.id_cliente, v.id_usuario, v.fecha, v.precio_total, 0, v.id_metodoPago);
        }

        public static object obtenerListaVentasPorID(int id)
        {
            return DVentas.getSalesById(id);
        }

        public static object obtenerListaVentasPorDni(string rol,int dni)
        {
            if (rol == "vendedor")
            {
                return DVentas.getSalesBySellerDni(dni);
            } else if (rol == "cliente")
            {
                return DVentas.getSalesByClientDni(dni);
            }
            return null;
        }
    }
}
