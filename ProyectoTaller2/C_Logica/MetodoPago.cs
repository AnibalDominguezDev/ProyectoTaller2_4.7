using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoTaller2.C_Datos;

namespace ProyectoTaller2.C_Logica
{
    internal class MetodoPago
    {
        public static List<string> listarMetodosPagos()
        {
            return DMetodoPago.ObtenerMetodosPagoEnVentas();
        }

        public int BuscarPorNombre(string id)
        {
            var datosMetodoPago = new DMetodoPago();
            return datosMetodoPago.BuscarPorNombre(id);
        }
    }
}
