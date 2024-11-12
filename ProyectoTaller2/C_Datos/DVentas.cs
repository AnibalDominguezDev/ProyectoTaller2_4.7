using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTaller2.C_Datos
{
    internal class DVentas
    {

        public DVentas() { }

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
    }
}
