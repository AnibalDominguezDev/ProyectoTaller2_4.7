using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTaller2.C_Datos
{
    internal class DVenta_Detalle
    {
        public DVenta_Detalle() { }

        public static bool AddDetalle(venta_detalle nuevaVenta)
        {
            try
            {
                using (TALLER2CSEntities3 dbv = new TALLER2CSEntities3())
                {
                    dbv.venta_detalle.Add(nuevaVenta);

                    if (nuevaVenta.id_producto != 0)
                    {
                        using (TALLER2CSEntities3 db = new TALLER2CSEntities3())
                        {
                            var producto = db.productos.Find(nuevaVenta.id_producto);

                            // Validación de stock
                            if (producto != null)
                            {
                                if (producto.stock >= nuevaVenta.cantidad)
                                {
                                    // Si hay suficiente stock, actualizamos
                                    producto.stock -= nuevaVenta.cantidad;
                                    db.SaveChanges();
                                }
                                else
                                {
                                    // Stock insuficiente, operación fallida
                                    Console.WriteLine("Stock insuficiente para completar la venta.");
                                    return false;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Producto no encontrado.");
                                return false;
                            }
                        }
                    }

                    dbv.SaveChanges();
                }

                return true;
            }
            catch (Exception error)
            {
                Console.Error.WriteLine(error.Message);
                return false;
            }
        }
    }
}
