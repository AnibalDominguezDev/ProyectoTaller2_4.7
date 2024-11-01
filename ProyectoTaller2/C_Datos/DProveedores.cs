using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTaller2.C_Datos
{
    internal class DProveedores
    {
        public DProveedores() { }

        public static object getAllSuppliers()
        {
            try
            {
                using (TALLER2CSEntities3 db = new TALLER2CSEntities3())
                {
                    var lst = db.proveedores.Select(p => new
                    {
                        p.id_proveedor,
                        p.nombre,
                        p.direccion,
                        p.telefono,
                        p.email,
                    });

                    return lst.ToList();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static bool editSupplier(int id, proveedores proveedor)
        {
            try
            {
                using (TALLER2CSEntities3 db = new TALLER2CSEntities3())
                {
                    var editar = db.proveedores.Find(id);

                    editar.nombre = proveedor.nombre;
                    editar.direccion = proveedor.direccion;
                    editar.email = proveedor.email;
                    editar.telefono = proveedor.telefono;

                    db.SaveChanges();

                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static proveedores getSupplierById(int id) 
        { 
            using (TALLER2CSEntities3 db = new TALLER2CSEntities3())
            {
                var lst = db.proveedores.Find(id);
                return lst;
            }
        }
    }
}
