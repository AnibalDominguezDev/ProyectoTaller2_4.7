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

        public static bool newSupplier(proveedores new_supplier)
        {
            try
            {
                using (TALLER2CSEntities3 db = new TALLER2CSEntities3())
                {
                    db.proveedores.Add(new_supplier);
                    db.SaveChanges();
                    return true;
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.ToString());

                return false;
            }
        }
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
                        p.estado_proveedor,
                    });

                    return lst.ToList();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static object getEnabledSuppliers()
        {
            try
            {
                using (TALLER2CSEntities3 db = new TALLER2CSEntities3())
                {
                    var lst = db.proveedores.Where(p => p.estado_proveedor.Equals(1)).Select(p => new
                    {
                        p.id_proveedor,
                        p.nombre,
                        p.direccion,
                        p.telefono,
                        p.email,
                        p.estado_proveedor,
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
        public static int getSupplierId(string nombre)
        {
            using (TALLER2CSEntities3 db = new TALLER2CSEntities3())
            {
                var lst = db.proveedores.Where(p => p.nombre.Equals(nombre)).Select(p => p.id_proveedor).First();

                return lst;
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

        public static bool changeSupplierState(int id)
        {
            using (TALLER2CSEntities3 db = new TALLER2CSEntities3())
            {

                var producto = db.proveedores.Find(id);

                if (producto != null)
                {
                    if (producto.estado_proveedor == 1)
                    {
                        producto.estado_proveedor = 0;
                    }
                    else
                    {
                        producto.estado_proveedor = 1;
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

        public static string getSupplierName(int id) 
        { 
            using (TALLER2CSEntities3 db = new TALLER2CSEntities3())
            {
                var lst = db.proveedores.Find(id);

                if (lst != null) return lst.nombre;
                else return "No encontrado";
            }
        
        }
    }
}
