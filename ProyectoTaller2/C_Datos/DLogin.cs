using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTaller2.C_Datos
{
    internal class DLogin
    {
        public int VerificarUsuario(string nombreUsuario, string contraseña)
        {
            try
            {
                using (TALLER2CSEntities3 db = new TALLER2CSEntities3())
                {
                    var usuario = db.usuarios
                                    .FirstOrDefault(u => u.usuario == nombreUsuario && u.contrasena == contraseña);

                    return usuario != null ? usuario.rol_id : -1; // Retorna el perfil si es correcto, -1 si no existe
                }
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.Message);
                return -1;
            }
        }

        public int ObtenerID(string nombreUsuario, string contraseña)
        {
            try
            {
                using (TALLER2CSEntities3 db = new TALLER2CSEntities3())
                {
                    var usuario = db.usuarios
                                    .FirstOrDefault(u => u.usuario == nombreUsuario && u.contrasena == contraseña);

                    return usuario != null ? usuario.id_usuario : -1; // Retorna el perfil si es correcto, -1 si no existe
                }
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.Message);
                return -1;
            }
        }

        public static bool isActive(int id)
        {
            using (TALLER2CSEntities3 db = new TALLER2CSEntities3())
            {
                var user = db.usuarios.Find(id);
                Console.WriteLine(user.estadoUsuario);

                return (user != null && !user.estadoUsuario.Equals(1));
                
            }
        }
    }
}
