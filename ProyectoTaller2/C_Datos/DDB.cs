using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTaller2.C_Datos
{
    internal class DDB
    {
        public DDB() { }

        public static bool createBackup(string path)
        {
            try
            {
                using (TALLER2CSEntities3 db = new TALLER2CSEntities3())
                {
                   
                    string query = $"BACKUP DATABASE [tallercs2] TO DISK = '{path}'";

                    db.Database.Connection.Open();
                    db.Database.ExecuteSqlCommand(query);
                    db.Database.Connection.Close();


                    return true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
    }
}
