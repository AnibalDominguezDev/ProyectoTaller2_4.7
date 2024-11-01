using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoTaller2.C_Datos;

namespace ProyectoTaller2.C_Logica
{
    internal class Categorias
    {
        public Categorias() { }

        public static bool nuevaCategoria(string nombre)
        {

            string formart = nombre.Trim();
            
            formart.ToUpper();

            try
            {
                using (TALLER2CSEntities3 db = new TALLER2CSEntities3())
                {
                    categoria_productos categoria = new categoria_productos();
                    categoria.nombre = formart;

                    db.categoria_productos.Add(categoria);
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception) {

                MessageBox.Show($"La categoria {nombre} ya existe!");
                return false;
            }
        }
    }
}
