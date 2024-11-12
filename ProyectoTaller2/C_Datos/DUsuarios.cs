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
using System.Windows.Forms;
using ProyectoTaller2.C_Logica;
using ProyectoTaller2.C_Presentacion.Supervisor;

namespace ProyectoTaller2.C_Datos
{
    public class VendedoresConMasVentas
    {
        public int IdUsuario { get; set; }
        public int Ventas { get; set; }
    }

    public class VendedoresEstadisticas
    {
        public int IdUsuario { set; get; }
        public double TotalPrecio { set; get; }
        public int Mes { set; get; }
    }
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

        public static object getUserByRol(int idRol)
        {
            using (TALLER2CSEntities3 db = new TALLER2CSEntities3())
            {
                var lst = from usuarios in db.usuarios
                          where usuarios.rol_id == idRol
                          select new
                          {
                              usuarios.fecha_alta,
                              usuarios.apellido,
                              usuarios.nombre,
                              usuarios.dni,
                              usuarios.telefono,
                              usuarios.usuario,
                              rol = usuarios.rol_usuario.nombre,
                              usuarios.estadoUsuario

                          };

                return lst.ToList();
            }
        }

        public static object getUserRoles()
        {
            using (TALLER2CSEntities3 db = new TALLER2CSEntities3())
            {
                var lst = from rol_usuario in db.rol_usuario
                          select rol_usuario;

                return lst.ToList();
            }
        }

        public static object listUsersByDni(int dni)
        {
            using (TALLER2CSEntities3 db = new TALLER2CSEntities3())
            {
                var lst = from usuarios in db.usuarios
                          where usuarios.dni == dni
                          select new
                          {
                              usuarios.fecha_alta,
                              usuarios.apellido,
                              usuarios.nombre,
                              usuarios.dni,
                              usuarios.telefono,
                              usuarios.usuario,
                              rol = usuarios.rol_usuario.nombre,
                              usuarios.estadoUsuario

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
                    activo = (p.estadoUsuario == 1) ? "Si" : "No" ,
                    p.id_usuario
                });

                return lst.ToList();
            }
        }

        public static bool changeUserState(int id)
        {
            using (TALLER2CSEntities3 db = new TALLER2CSEntities3())
            {

                var usuario = db.usuarios.Find(id);

                if (usuario != null)
                {
                    if (usuario.estadoUsuario == 1)
                    {
                        usuario.estadoUsuario = 0;
                    }
                    else
                    {
                        usuario.estadoUsuario = 1;
                    }
                    db.SaveChanges();
                    return true;

                }
                else
                {
                    return false;
                }


            }
        }

        public static List<VendedoresConMasVentas> getMostValuableSeller()
        {
            using (TALLER2CSEntities3 db = new TALLER2CSEntities3())
            {
                var lst = db.ventas
                    .GroupBy(v => v.id_usuario)
                    .Select(g => new VendedoresConMasVentas
                    {
                        IdUsuario = g.Key,
                        Ventas = g.Count()
                    }).OrderByDescending(x => x.IdUsuario)
                    .ToList();

                return lst;
            }
        }

        public static List<VendedoresEstadisticas> getSellerStats(int id)
        {
            using (TALLER2CSEntities3 db = new TALLER2CSEntities3())
            {
                var lst = db.ventas
                     .Where(v => v.id_usuario == id)
                     .GroupBy(v => new { v.id_usuario, Mes = v.fecha.Month }) // Agrupar por id_usuario y mes
                     .Select(g => new VendedoresEstadisticas
                     {
                         TotalPrecio = g.Sum(v => v.precio_total), // Sumar el precio_total
                         IdUsuario = g.Key.id_usuario,             // id_usuario
                         Mes = g.Key.Mes                          // Mes
                     })
                     .ToList();
                return lst;
            }
        }

        public static string getFullName(int id)
        {
            using (TALLER2CSEntities3 db = new TALLER2CSEntities3())
                {
                var user = db.usuarios.Find(id);

                return $"{user.nombre} {user.apellido}"; 
                    
                }

                
        }

        public static int getSellerIdByDni(int dni)
        {
            using (TALLER2CSEntities3 db = new TALLER2CSEntities3())
            {

                var lst = db.usuarios.Where(u => u.dni.Equals(dni)).Select(u => u.id_usuario).First();
                

                return lst;
            }
        }
        
        public static object getSellers()
        {
            using (TALLER2CSEntities3 db = new TALLER2CSEntities3())
            {

                var lst = db.usuarios.Where(u => u.rol_id.Equals(1)).Select(u => new 
                                                                          { u.id_usuario,
                                                                            NomYApeDNI = u.nombre + " " + u.apellido + " " + u.dni});

                return lst.ToList();
            }
        }

    }
}
