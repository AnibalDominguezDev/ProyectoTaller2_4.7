using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTaller2.C_Datos
{
    internal class DVentas
    {

        public DVentas() { }

        
        public static bool AddVenta(ventas nuevaVenta)
        {
            try
            {
                using (TALLER2CSEntities3 db = new TALLER2CSEntities3())
                {
                    db.ventas.Add(nuevaVenta);
                    db.SaveChanges();
                }

                return true;
            }
            catch (Exception error)
            {
                Console.Error.WriteLine(error.Message);
                return false;
            }
        }
        public static double getEarnings()
        {
            using (TALLER2CSEntities3 db = new TALLER2CSEntities3())
            {
                var lst = db.ventas.Sum(v => v.precio_total);

                return lst;
            }
        }

        public static int getSellCounts()
        {
            using (TALLER2CSEntities3 db = new TALLER2CSEntities3())
            {
                var lst = db.ventas.Count();

                return lst;
            }
        }

        public int ObtenerUltimaVentaID()
        {
            using (TALLER2CSEntities3 db = new TALLER2CSEntities3())
            {
                var ultimaVenta = db.ventas.OrderByDescending(v => v.id_venta).FirstOrDefault();
                return ultimaVenta != null ? ultimaVenta.id_venta : 0;
            }
        }

        public static object obtenerVentasPorVendedor(int id,DateTime fechaInicio, DateTime fechaFin)
        {
            using (TALLER2CSEntities3 db = new TALLER2CSEntities3())
            {
               var lst = db.ventas.Where(v => v.id_usuario.Equals(id) && v.fecha >= fechaInicio && v.fecha <= fechaFin)
                    .Select(v => new
                    {
                        v.id_venta,
                        v.fecha,
                        cliente = v.clientes.nombre + " " + v.clientes.apellido + " " + v.clientes.dni,
                        metodoPago = v.metodo_pago.descripcion,
                        v.precio_total
                    } ).ToList();

                return lst;
            }
        }

        public static object getAllSales()
        {
            using (TALLER2CSEntities3 db = new TALLER2CSEntities3())
            {
                var lst = db.ventas
                     .Select(v => new
                     {
                         v.id_venta,
                         v.fecha,
                         cliente = v.clientes.nombre + " " + v.clientes.apellido + " " + v.clientes.dni,
                         vendedor = v.usuarios.nombre + " " + v.usuarios.apellido + " " + v.usuarios.dni,
                         metodoPago = v.metodo_pago.descripcion,
                         v.precio_total
                     }).ToList();

                return lst;
            }
        }

        public static object getSalesById(int id)
        {
            using (TALLER2CSEntities3 db = new TALLER2CSEntities3())
            {
                var lst = db.ventas.Where(v => v.id_venta.Equals(id))
                     .Select(v => new
                     {
                         v.id_venta,
                         v.fecha,
                         cliente = v.clientes.nombre + " " + v.clientes.apellido + " " + v.clientes.dni,
                         vendedor = v.usuarios.nombre + " " + v.usuarios.apellido + " " + v.usuarios.dni,
                         metodoPago = v.metodo_pago.descripcion,
                         v.precio_total
                     }).ToList();

                return lst;
            }
        }

        public static object getSalesBySellerDni(int dni)
        {
            using (TALLER2CSEntities3 db = new TALLER2CSEntities3())
            {
                var lst = db.ventas.Join(db.usuarios,
                             v => v.id_usuario,
                             u => u.id_usuario,
                             (v, u) => new { v, u }).Where(u => u.u.dni.Equals(dni))
                     .Select(v => new
                     {
                         v.v.id_venta,
                         v.v.fecha,
                         cliente = v.v.clientes.nombre + " " + v.v.clientes.apellido + " " + v.v.clientes.dni,
                         vendedor = v.v.usuarios.nombre + " " + v.v.usuarios.apellido + " " + v.v.usuarios.dni,
                         metodoPago = v.v.metodo_pago.descripcion,
                         v.v.precio_total
                     }).ToList();

                return lst;
            }
        }

        public static object getSalesByClientDni(int dni)
        {
            
            using (TALLER2CSEntities3 db = new TALLER2CSEntities3())
            {
                string idni = dni.ToString();

                var lst = from v in db.ventas
                                join c in db.clientes on v.id_cliente equals c.id_cliente
                                where c.dni == (idni)
                                select new
                                {
                                    v.id_venta,
                                    v.fecha,
                                    cliente = v.clientes.nombre + " " + v.clientes.apellido + " " + v.clientes.dni,
                                    vendedor = v.usuarios.nombre + " " + v.usuarios.apellido + " " + v.usuarios.dni,
                                    metodoPago = v.metodo_pago.descripcion,
                                    v.precio_total
                                };
                return lst.ToList();
            }
        }

        public static object obtenerDatosVenta(int idVenta)
        {
            using (TALLER2CSEntities3 db = new TALLER2CSEntities3())
            {
                var lst = db.venta_detalle.Where(vd => vd.id_venta.Equals(idVenta)).Select(vd => new
                {
                    codProducto = vd.productos.cod_producto,
                    producto = vd.productos.nombre,
                    productoDesc = vd.productos.descripcion,
                    vd.cantidad,
                    vd.precio,
                    subTotal = vd.precio * vd.cantidad,
                }).ToList();
                return lst;
            }
        }

        public static ventas getVentaById(int id)
        {
            using (TALLER2CSEntities3 db = new TALLER2CSEntities3())
            {
                var lst = db.ventas.Find(id);

                return lst;
            }
        }
    }
}
