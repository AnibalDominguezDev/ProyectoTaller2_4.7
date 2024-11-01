using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTaller2.C_Datos
{
    internal class DProductos
    {
        public DProductos() { }


        public static bool newProduct(productos new_product)
        {
            try
            {
                using (TALLER2CSEntities3 db = new TALLER2CSEntities3())
                {
                    db.productos.Add(new_product);
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

        public static bool editProduct(int id, productos product)
        {
            try
            {
                using (TALLER2CSEntities3 db = new TALLER2CSEntities3())
                {
                    
                    var editar = db.productos.Find(id);

                    editar.cod_producto = product.cod_producto;
                    editar.nombre = product.nombre;
                    editar.descripcion = product.descripcion;
                    editar.precio = product.precio;
                    editar.stock = product.stock;
                    editar.stock_minimo = product.stock_minimo;
                    editar.id_categoria = product.id_categoria;
                    editar.id_marca = product.id_marca;
                    editar.id_proveedor = product.id_proveedor;
                    

                    db.SaveChanges();
                    return true;
                }
            }
            catch(Exception)
            {
               return false;
            }
        }

        public static object getAllProducts()
        {

            using (TALLER2CSEntities3 db = new TALLER2CSEntities3())
            {
                 var lst = db.productos.Select(p => new {
                          
                               p.id_producto,
                               p.cod_producto,
                               p.nombre,
                               p.descripcion,
                               p.precio,
                               p.stock,
                               p.stock_minimo,
                               catNombre = p.categoria_productos.nombre,
                               p.estado_producto
                           });

                 return lst.ToList(); 

                
            }
        }

        public static object getProductsByCategory(int catId)
        {
            using (TALLER2CSEntities3 db = new TALLER2CSEntities3())
            {
                var lst = db.productos.Where(p => p.id_categoria.Equals(catId)).Select(p => new {

                    p.id_producto,
                    p.cod_producto,
                    p.nombre,
                    p.descripcion,
                    p.precio,
                    p.stock,
                    p.stock_minimo,
                    catNombre = p.categoria_productos.nombre,
                    p.estado_producto
                });

                return lst.ToList();
            }
        }


        public static object getCategories()
        {
                using (TALLER2CSEntities3 db = new TALLER2CSEntities3())
                {
                    var lst = from categoria_productos in db.categoria_productos
                              select categoria_productos;

                    return lst.ToList();
                }
        }

        public static int getCategoryId(string cat)
        {
            using (TALLER2CSEntities3 db = new TALLER2CSEntities3())
            {
                var lst = db.categoria_productos.Where(c => c.nombre.Equals(cat)).Select(c => c.id_categoria).First();

                return lst;
            }
        }

        public static string getCategoryById(int id)
        {
            using (TALLER2CSEntities3 db = new TALLER2CSEntities3())
            {
                var lst = db.categoria_productos.Where(c => c.id_categoria.Equals(id)).Select(c => c.nombre).First();

                return lst;
            }
        }

        public static object getBrands()
        {
            using (TALLER2CSEntities3 db = new TALLER2CSEntities3())
            {

                var lst = from marcas in db.marcas
                          select marcas;

                return lst.ToList();
            }
        }

        public static int getBrandId(string nombre)
        {
            using (TALLER2CSEntities3 db = new TALLER2CSEntities3())
            {
                var lst = db.marcas.Where(m => m.nombre.Equals(nombre)).Select(m => m.id_marca).First();

                return lst;
            }
        }

        public static string getBrandById(int id)
        {
            using (TALLER2CSEntities3 db = new TALLER2CSEntities3())
            {
                var lst = db.marcas.Where(m => m.id_marca.Equals(id)).Select(m => m.nombre).First();

                return lst;
            }
        }

        public static object getSuppliers()
        {
            using (TALLER2CSEntities3 db = new TALLER2CSEntities3())
            {

                var lst = from proveedores in db.proveedores
                          select proveedores;

                return lst.ToList();
            }
        }

        public static productos getProductById(int id)
        {
            using (TALLER2CSEntities3 db = new TALLER2CSEntities3())
            {

                var productos = db.productos.Find(id);

                return productos;
            }
        }

        public static bool changeProductState(int id)
        {
            using (TALLER2CSEntities3 db = new TALLER2CSEntities3())
            {

                var producto = db.productos.Find(id);

                if (producto != null)
                {
                    if (producto.estado_producto == 1)
                    {
                        producto.estado_producto = 0;
                    }
                    else
                    {
                        producto.estado_producto = 1;
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
        
        public static object seachProductByCode(string code)
        {
            using (TALLER2CSEntities3 db = new TALLER2CSEntities3())
            {
                var lst = db.productos.Where(p => p.cod_producto.Equals(code)).Select(p => new {

                    p.id_producto,
                    p.cod_producto,
                    p.nombre,
                    p.descripcion,
                    p.precio,
                    p.stock,
                    p.stock_minimo,
                    catNombre = p.categoria_productos.nombre,
                    p.estado_producto
                });

                return lst.ToList();

            }
        }
    }
}
