using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoTaller2.C_Datos;

namespace ProyectoTaller2.C_Logica
{
    internal class Venta_Detalle
    {
        private int id_venta;
        private int id_producto;
        private int cantidad;
        private float total;
        private int metodoPago;

        public Venta_Detalle() { }

        public Venta_Detalle(int id_venta, int id_producto, int cantidad, float total, int metodoPago)
        {
            this.id_venta = id_venta;
            this.id_producto = id_producto;
            this.cantidad = cantidad;
            this.total = total;
            this.metodoPago = metodoPago;
        }

        public int getId_venta() { return id_venta; }
        public int getId_producto() { return id_producto; }
        public int getCantidad() { return cantidad; }
        public float getTotal() { return total; }
        public int getMetodoPago() { return metodoPago; }

        public bool guardarDetalle(int idventa, int idprodducto, decimal precio, int cantidad)
        {
            try
            {
                venta_detalle nuevo = new venta_detalle();
                nuevo.id_venta = idventa;
                nuevo.id_producto = idprodducto;
                nuevo.cantidad = cantidad;
                nuevo.precio = precio;

                return DVenta_Detalle.AddDetalle(nuevo);
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);
                return false;
            }
        }
    }
}
