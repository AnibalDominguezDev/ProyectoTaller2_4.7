using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoTaller2.C_Datos;

namespace ProyectoTaller2.C_Logica
{
    internal class Clientes
    {
        private string nombre;
        private string apellido;
        private string dni;
        private string telefono;
        private string direccion;
        private string correo;

        public Clientes() { }

        public Clientes(string pnombre, string papellido, string pdni, string ptelefono, string pdireccion, string pcorreo)
        {
            this.nombre = pnombre;
            this.apellido = papellido;
            this.dni = pdni;
            this.telefono = ptelefono;
            this.direccion = pdireccion;
            this.correo = pcorreo;
        }

        public string getNombre() { return this.nombre; }
        public string getApellido() { return this.apellido; }
        public string getDni() { return this.dni; }
        public string getDireccion() { return this.direccion; }
        public string getTelefono() { return this.telefono; }
        public string getCorreo() { return this.correo; }

        public bool guardarCliente(string pnombre, string papellido, string pdni, string ptelefono, string pdireccion, string pcorreo)
        {
            try
            {
                clientes nuevo = new clientes();
                nuevo.nombre = pnombre;
                nuevo.apellido = papellido;
                nuevo.dni = pdni;
                nuevo.telefono = ptelefono;
                nuevo.direccion = pdireccion;
                nuevo.correo = pcorreo;
                nuevo.estado_cliente = 1;
                nuevo.create_at = DateTime.Now;

                return DClientes.AddCliente(nuevo);
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);
                return false;
            }
        }

        public static List<object> ListarClientes()
        {
            return DClientes.ObtenerTodosLosClientes();
        }

        public static List<string> ListaDeClientesParaVentas()
        {
            return DClientes.ListarClientesEnVentas();
        }

        public Clientes editarCliente(int id)
        {
            var cliente = DClientes.getUserById(id);

            if (cliente != null)
            {
                return new Clientes(cliente.nombre, cliente.apellido, cliente.dni, cliente.telefono, cliente.direccion, cliente.correo);
            }
            else
            {
                return null;
            }

        }

        public bool ActualizarCliente(int id, string nom, string ape, string dni, string tel, string dir, string mail)
        {
            return DClientes.ActualizarCliente(id, nom, ape, dni, tel, dir, mail);
        }

        public static object listarClentesPorDni(string dni)
        {
            return DClientes.ListarPorDNI(dni);
        }

        public static object listarClientesPorNombre(string nombre)
        {
            return DClientes.ListarPorNombre(nombre);
        }

        public static string getNombreCliente(int id)
        {
            return DClientes.getClientFullName(id);
        }

        public static bool cambiarEstadoCliente(int id)
        {
            return DClientes.changeClientState(id);
        }

        /*public int ObtenerClientePorNombre(string nombre, string apellido)
        {
            return DClientes.ObtenerPorNombre(nombre, apellido);
        }*/
    }
}
