using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoTaller2.C_Datos;

namespace ProyectoTaller2.C_Logica
{
    internal class DB
    {
        public DB() { }

        public static bool GuardarBackcup(string path)
        {
            return DDB.createBackup(path);
        }
    }
}
