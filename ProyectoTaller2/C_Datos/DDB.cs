using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using ProyectoTaller2.C_Logica;
using ProyectoTaller2.C_Presentacion.Supervisor;

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
                    string name = $"taller2cs-backup-{DateTime.Now.ToString("dd-MM-yyy")}";  
                    string query = $"BACKUP DATABASE [taller2cs] TO DISK = '{path}/{name}.bak' WITH FORMAT, INIT";

                    db.Database.Connection.Open();
                    db.Database.ExecuteSqlCommand(System.Data.Entity.TransactionalBehavior.DoNotEnsureTransaction,query);
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

        public static bool restoreBackup(string path) 
        {

            try
            {
                string connectionString = "Server=DESKTOP-C6OKO8R\\SQLEXPRESS; Database=master; Integrated Security=True;";


                using (TALLER2CSEntities3 taller2cs = new TALLER2CSEntities3())
                {
                    taller2cs.Dispose();
                }

                using (SqlConnection db = new SqlConnection(connectionString))
                {


                    string dbName = "taller2cs";
                    string query = $"RESTORE DATABASE {dbName} FROM DISK = '{path}' WITH REPLACE, RECOVERY;";

                    db.Open();

                    using (SqlCommand command = new SqlCommand(query, db))
                    {
                        command.ExecuteNonQuery();
                    }

                    db.Close();
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
