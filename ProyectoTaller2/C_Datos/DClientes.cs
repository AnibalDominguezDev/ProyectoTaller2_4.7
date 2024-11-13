using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTaller2.C_Datos
{
    internal class DClientes
    {
        public DClientes() { }

        public static bool AddCliente(clientes nuevoCliente)
        {
            try
            {
                using (TALLER2CSEntities3 db = new TALLER2CSEntities3())
                {
                    db.clientes.Add(nuevoCliente);
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

        public static clientes getUserById(int id)
        {
            using (TALLER2CSEntities3 db = new TALLER2CSEntities3())
            {
                var client = db.clientes.Find(id);
                return client;
            }

        }

        public static List<object> ObtenerTodosLosClientes()
        {
            using (TALLER2CSEntities3 db = new TALLER2CSEntities3())
            {
                var lista = from cliente in db.clientes
                            where cliente.estado_cliente == 1
                            select new
                            {
                                cliente.id_cliente,
                                cliente.create_at,
                                cliente.nombre,
                                cliente.apellido,
                                cliente.dni,
                                cliente.telefono,
                                cliente.direccion,
                                cliente.correo
                            };
                return lista.ToList<object>();
            }
        }

        public static List<string> ListarClientesEnVentas()
        {
            using (TALLER2CSEntities3 db = new TALLER2CSEntities3())
            {
                var nombresClientes = db.clientes
                                        .Where(c => c.estado_cliente == 1)
                                        .Select(c => c.nombre + " " + c.apellido)
                                        .ToList();
                return nombresClientes;
            }
        }

        public static object ListarPorDNI(string dni)
        {
            using (TALLER2CSEntities3 db = new TALLER2CSEntities3())
            {
                var lista = from clientes in db.clientes
                            where clientes.dni.Contains(dni)
                            select new
                            {
                                clientes.nombre,
                                clientes.apellido,
                                clientes.dni,
                                clientes.telefono,
                                clientes.direccion,
                                clientes.correo,
                                clientes.estado_cliente
                            };
                return lista.ToList();

            }
        }

        public static object ListarPorNombre(string nombre)
        {
            using (TALLER2CSEntities3 db = new TALLER2CSEntities3())
            {
                var lista = from clientes in db.clientes
                            where clientes.nombre.Contains(nombre) || clientes.apellido.Contains(nombre)
                            select new
                            {
                                clientes.create_at,
                                clientes.nombre,
                                clientes.apellido,
                                clientes.dni,
                                clientes.telefono,
                                clientes.direccion,
                                clientes.correo,
                                clientes.estado_cliente
                            };
                return lista.ToList();
            }
        }

        public int ObtenerPorNombre(string nombre, string apellido)
        {
            try
            {
                using (var db = new TALLER2CSEntities3()) // O la conexión que uses
                {
                    var cliente = db.clientes
                                    .FirstOrDefault(c => c.nombre == nombre && c.apellido == apellido);
                    return cliente != null ? cliente.id_cliente : 0; // Retorna el id del cliente o 0 si no se encuentra
                }
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.Message);
                return 0; // Si ocurre un error, retornamos 0
            }
        }

        public static bool ActualizarCliente(int id, string nom, string ape, string dni, string tel, string dir, string mail)
        {
            try
            {
                using (TALLER2CSEntities3 db = new TALLER2CSEntities3())
                {
                    // Buscar el cliente en la base de datos

                    var clientToUpdate = db.clientes.Find(id);
                    if (clientToUpdate != null)
                    {
                        // Actualizar los datos del cliente
                        clientToUpdate.nombre = nom;
                        clientToUpdate.apellido = ape;
                        clientToUpdate.dni = dni;
                        clientToUpdate.telefono = tel;
                        clientToUpdate.direccion = dir;
                        clientToUpdate.correo = mail;

                        // Guardar los cambios en la base de datos
                        db.SaveChanges();
                        return true; // Éxito en la actualización
                    }
                    return false; // Cliente no encontrado
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores
                Console.WriteLine($"Error al actualizar el cliente: {ex.Message}");
                return false;
            }
        }

        public static string getClientFullName(int id)
        {
            using (TALLER2CSEntities3 db = new TALLER2CSEntities3())
            {
                var cliente = db.clientes.Find(id);

                if (cliente != null)
                {
                    return $"{cliente.nombre} {cliente.apellido}";
                } else
                {
                    return "Cliente no encontrado";
                }
            }
        }

        public static object getAllClients()
        {
           
                try
                {
                    using (TALLER2CSEntities3 db = new TALLER2CSEntities3())
                    {
                        var lst = db.clientes.Select(p => new
                        {
                            p.create_at,
                            estado = p.estado_cliente == 1 ? "Activo" : "Inactivo",
                            p.id_cliente,
                            p.nombre,
                            p.direccion,
                            p.telefono,
                            p.dni,
                            p.apellido,
                        });

                        return lst.ToList();
                    }
                }
                catch (Exception)
                {
                    return null;
                }
            
        }

        public static bool changeClientState(int id)
        {
            using (TALLER2CSEntities3 db = new TALLER2CSEntities3())
            {

                var usuario = db.clientes.Find(id);

                if (usuario != null)
                {
                    if (usuario.estado_cliente == 1)
                    {
                        usuario.estado_cliente = 0;
                    }
                    else
                    {
                        usuario.estado_cliente = 1;
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
    }
}
