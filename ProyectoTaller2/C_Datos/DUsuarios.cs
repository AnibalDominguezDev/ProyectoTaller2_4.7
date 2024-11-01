using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Contexts;
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

        public static bool editUsuario(int id,usuarios user)
        {
            try
            {

            
                using (TALLER2CSEntities3 db = new TALLER2CSEntities3())
                {
                    var editarUsuario = db.usuarios.Find(id);

                    editarUsuario.nombre = user.nombre;
                    editarUsuario.apellido = user.apellido;
                    editarUsuario.telefono = user.telefono;
                    editarUsuario.dni = user.dni;
                    editarUsuario.direccion = user.direccion;
                    editarUsuario.rol_id = user.rol_id;
                    editarUsuario.usuario = user.usuario;
                    editarUsuario.contrasena = user.contrasena;
                    editarUsuario.estadoUsuario = user.estadoUsuario;

                    db.SaveChanges();

                    return true;
                }
            } catch (Exception e ) {
                
                Console.Error.WriteLine(e.Message);
                return false; }

        }

        public static object getUsers()
        {
            using (TALLER2CSEntities3 db = new TALLER2CSEntities3())
            {
                var lst = from usuarios in db.usuarios
                          select new
                          {
                              usuarios.fecha_alta,
                              usuarios.apellido,
                              usuarios.nombre,
                              usuarios.dni,
                              usuarios.telefono,
                              usuarios.usuario,
                              rol = usuarios.rol_usuario.nombre,
                              usuarios.estadoUsuario,
                              usuarios.id_usuario

                          };

                return lst.ToList();
            }
        }



        public static usuarios getUserById(int id)
        {
            using (TALLER2CSEntities3 db = new TALLER2CSEntities3())
            {
                var user = db.usuarios.Find(id);

                return user;
      
            }
        }

        public static object SearchUsersByLastName(string lastName)
        {
            using (TALLER2CSEntities3 db = new TALLER2CSEntities3())
            {
                var lst = db.usuarios.Where(p => p.apellido.Equals(lastName)).Select(p => new
                {

                    p.fecha_alta,
                    p.apellido,
                    p.nombre,
                    p.dni,
                    p.telefono,
                    p.usuario,
                    Rol = p.rol_usuario.nombre,
                    p.estadoUsuario,
                    p.id_usuario
                });

                return lst.ToList();
            }
        }
    }
}
