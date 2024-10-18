using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoTaller2.C_Logica;
using ProyectoTaller2.C_Presentacion.Supervisor;

namespace ProyectoTaller2.C_Datos
{
    internal class DUsuarios
    {
        public DUsuarios() { }

        public static bool AddUsuario(usuarios nuevoUsuario)
        {

            try
            {

                using (TALLER2CSEntities3 db = new TALLER2CSEntities3())
                {
                    db.usuarios.Add(nuevoUsuario);
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



        public static usuarios getUserById(int id)
        {
            using (TALLER2CSEntities3 db = new TALLER2CSEntities3())
            {
                var user = db.usuarios.Find(id);

                return user;
      
            }

            return null;
        }
    }
}
