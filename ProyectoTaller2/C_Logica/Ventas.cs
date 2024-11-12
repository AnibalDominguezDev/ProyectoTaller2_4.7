using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoTaller2.C_Datos;

namespace ProyectoTaller2.C_Logica
{
    internal class Ventas
    {

        public Ventas() { }

        public static double getGananciasTotales()
        {
            return DVentas.getEarnings();
        }

        public static int getCantidadVentas()
        {
            return DVentas.getSellCounts();
        }
    }
}
