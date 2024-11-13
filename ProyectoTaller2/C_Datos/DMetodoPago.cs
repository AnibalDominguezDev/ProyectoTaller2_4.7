using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoTaller2.C_Logica;

namespace ProyectoTaller2.C_Datos
{
    internal class DMetodoPago
    {
        public DMetodoPago() { }

        public static metodo_pago getMPById(int id)
        {
            using (TALLER2CSEntities3 db = new TALLER2CSEntities3())
            {
                var metodos = db.metodo_pago.Find(id);
                return metodos;
            }
        }

        public static List<string> ObtenerMetodosPagoEnVentas()
        {
            using (TALLER2CSEntities3 db = new TALLER2CSEntities3())
            {
                var lista = db.metodo_pago
                              .Select(m => m.descripcion)
                              .ToList();
                return lista;
            }
        }

        public int BuscarPorNombre(string id)
        {
            try
            {
                using (TALLER2CSEntities3 db = new TALLER2CSEntities3()) // O la conexión que uses
                {
                    var metodo = db.metodo_pago
                                    .FirstOrDefault(mp => mp.descripcion == id);
                    return metodo != null ? metodo.id_metodopago : 0; // Retorna el id del cliente o 0 si no se encuentra
                }
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.Message);
                return 0; // Si ocurre un error, retornamos 0
            }
        }
    }
}
