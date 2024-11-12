using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoTaller2.C_Datos;

namespace ProyectoTaller2.C_Logica
{
    internal class Proveedores
    {
        private string nombre;
        private string direccion;
        private string email;
        private string telefono;


        public Proveedores() { }

        public Proveedores(string nombre, string direccion, string email, string telefono)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.email = email;
            this.telefono = telefono;
        }

        public string getNombre() {  return this.nombre; }
        public string getDireccion() { return this.direccion; }
        public string getEmail() { return this.email; }
        public string getTelefono() { return this.telefono; }

        public static object listarProveedoresHabilitados()
        {
            return DProveedores.getEnabledSuppliers();
        }
        public static object listarProveedores()
        {
            return DProveedores.getAllSuppliers();
        }

        public static bool nuevoProveedor(string nombre, string direccion, string email, string telefono)
        {
            proveedores nuevo = new proveedores();

            nuevo.nombre = nombre;
            nuevo.email = email;
            nuevo.telefono = telefono;
            nuevo.direccion = direccion;
            nuevo.estado_proveedor = 1;

            return DProveedores.newSupplier(nuevo);

        }

        public static bool editarProveedor(int id,string nombre,string direccion, string telefono, string email)
        {
            proveedores editar = new proveedores();

            editar.nombre = nombre;
            editar.direccion = direccion;
            editar.email = email;
            editar.telefono = telefono;

            return DProveedores.editSupplier(id,editar);
        }

        public Proveedores obtenerProveedoresPorId(int id)
        {

            var editar = DProveedores.getSupplierById(id);

            return new Proveedores(editar.nombre,editar.direccion,editar.email,editar.telefono);

        }

        public static bool cambiarEstadoProveedor(int id)
        {
            return DProveedores.changeSupplierState(id);
        }

        
    }
}
