using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoTaller2.C_Datos;

namespace ProyectoTaller2.C_Logica
{
    internal class Marcas
    {
        public Marcas() { }

        public static bool nuevaMarca(string nombre)
        {
            try
            {
                using (TALLER2CSEntities3 db = new TALLER2CSEntities3())
                {
                    marcas nuevo = new marcas();
                    nuevo.nombre = nombre;
                    db.marcas.Add(nuevo);
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception e) { 
               
                MessageBox.Show($"La marca {nombre} ya existe!");
                return false;
            }
        }
    }
}
