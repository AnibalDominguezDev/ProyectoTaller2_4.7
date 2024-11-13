using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Drawing.Design;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoTaller2.C_Datos;
using ProyectoTaller2.C_Presentacion.Supervisor;

namespace ProyectoTaller2.C_Logica
{
    internal class Usuarios
    {
        private string nombre;
        private string apellido;
        private int dni;
        private string telefono;
        private string direccion;
        private string usuario;
        private string contrasena;
        private int rol;
        private int estado;

        public Usuarios() { }

        public Usuarios(string nombre, string apellido, int dni, string telefono, string direccion, string usuario,string contrasena, int rol, int estado)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;
            this.dni = dni;
            this.direccion = direccion;
            this.usuario = usuario;
            this.contrasena = contrasena;
            this.rol = rol;
            this.estado = estado;
        }
        public string getNombre() { return this.nombre; }
        public string getApellido() { return this.apellido; }
        public int getRol() { return this.rol; }
        public int getDni() { return this.dni; }
        public string getUsuario() { return this.usuario; }
        public string getContrasena() { return this.contrasena; }
        public string getDireccion() { return this.direccion; }
        public string getTelefono() {  return this.telefono; }
        public int getEstado() { return this.estado; }
        public bool guardarUsuario(string nombre, string apellido, string dni, string telefono, string direccion, string usuario, string contrasena,int rol_id)
        {
            try
            {
                int idni = Int32.Parse(dni);

        
                
                    usuarios nuevo = new usuarios();
                    nuevo.nombre = nombre;
                    nuevo.apellido = apellido;
                    nuevo.dni = idni;
                    nuevo.telefono = telefono;
                    nuevo.direccion = direccion;
                    nuevo.usuario = usuario;
                    nuevo.contrasena = contrasena;
                    nuevo.rol_id = rol_id;
                    nuevo.fecha_alta = DateTime.Now;
                    nuevo.estadoUsuario = 1;


                return DUsuarios.AddUsuario(nuevo);
                

            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);
                return false;
            }
        }

        public static bool editarUsuario(int id, string nombre, string apellido, string dni, string telefono, string direccion, string usuario, string contrasena, int rol_id)
        {
             try
             {
                  usuarios user = new usuarios();

                  int idni = Int32.Parse(dni); 
                  user.nombre = nombre;
                  user.apellido = apellido;
                  user.dni = idni;
                  user.telefono = telefono;
                  user.direccion = direccion;
                  user.usuario = usuario;
                  user.contrasena = contrasena;
                  user.rol_id = rol_id;
                user.estadoUsuario = 1;

                  return DUsuarios.editUsuario(id, user);

             } catch (Exception e)
             {
                  Console.Error.WriteLine(e.Message);
                  return false;
             } 
        }

        public static object listarUsuarios()
        {
            return DUsuarios.getUsers();
        }

        public static object listarUsuariosPorRol(int idRol = 1)
        {
            return DUsuarios.getUserByRol(idRol);
        }

        public static object listarUsuariosPorDni(int dni)
        {
            return DUsuarios.listUsersByDni(dni);
        }

        public Usuarios ObtenerUsuarioPorId(int id)
        {

            var user = DUsuarios.getUserById(id);

            if (user != null)
            {
                return new Usuarios(user.nombre,
                                    user.apellido,
                                    user.dni,
                                    user.telefono,
                                    user.direccion,
                                    user.usuario,
                                    user.contrasena,
                                    user.rol_id,
                                    user.estadoUsuario
                                    );
            }
            return null;
            
        }

        public static object listarRoles()
        {
            return DUsuarios.getUserRoles();
        }

        public static bool cambiarEstadoUsuario(int id)
        {
            return DUsuarios.changeUserState(id);
        }

        public static object buscarUsuarioPorApellido(string apellido)
        {
            return DUsuarios.SearchUsersByLastName(apellido);
        }

        public static string getNombreCompleto(int id)
        {
            return DUsuarios.getFullName(id);            
        }

        public static List<VendedoresConMasVentas> getVendedoresConMasVentas()
        {
            return DUsuarios.getMostValuableSeller();
        }

        public static List<VendedoresEstadisticas> getGananciasMensualesVendedor(int id)
        {
            return DUsuarios.getSellerStats(id);
        }

        public static int getVendedorIdPorDni(int dni)
        {
            return DUsuarios.getSellerIdByDni(dni);
        }

        public static int contarVendedoresActivos()
        {
            return DUsuarios.getActiveSellersCount();
        }
        public static object ListarVendedores()
        {
            return DUsuarios.getSellers();
        }
    }
}
