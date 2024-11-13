using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ProyectoTaller2.C_Datos
{

    public class VentasResumen
    {
        public int Mes { get; set; }
        public double TotalVentas { get; set; }
    }

    public class CategoriaMasVendida
    {
        public int IdCategoria { get; set; }
        public int VecesVendido { get; set; }
    }

    public class ProductosMasVendidos
    {
        public string Producto { get; set; }
        public int TotalCantidadProductos { get; set; }
    }
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
            catch (Exception)
            {
                return false;
            }
        }

        public static List<object> ObtenerListaProductos()
        {
            using (TALLER2CSEntities3 db = new TALLER2CSEntities3())
            {
                var lista = from productos in db.productos
                            where productos.estado_producto == 1
                            join categoria_productos in db.categoria_productos on productos.id_categoria equals categoria_productos.id_categoria
                            select new
                            {
                                productos.id_producto,
                                productos.nombre,
                                productos.descripcion,
                                productos.stock,
                                productos.precio,
                                categoriaNombre = categoria_productos.nombre,
                                productos.cod_producto
                            };
                return lista.ToList<object>();
            }
        }

        public static List<object> ObtenerListaProductosPorCategoria(int id)
        {
            using (TALLER2CSEntities3 db = new TALLER2CSEntities3())
            {
                var lista = from productos in db.productos
                            where productos.estado_producto == 1 && productos.id_categoria == id
                            join categoria_productos in db.categoria_productos on productos.id_categoria equals categoria_productos.id_categoria
                            select new
                            {
                                productos.id_producto,
                                productos.nombre,
                                productos.descripcion,
                                productos.stock,
                                productos.precio,
                                categoriaNombre = categoria_productos.nombre,
                                productos.cod_producto
                            };
                return lista.ToList<object>();
            }
        }

        public static List<object> ObtenerProductosDisponibles()
        {
            using (TALLER2CSEntities3 db = new TALLER2CSEntities3())
            {
                var lista = from productos in db.productos
                            where productos.estado_producto == 1
                            select new
                            {
                                productos.id_producto,
                                productos.nombre,
                                productos.descripcion,
                                productos.stock,
                                productos.precio
                            };
                return lista.ToList<object>();
            }
        }

        public static List<Object> BuscarProductoPorCod(string cod)
        {
            using (TALLER2CSEntities3 db = new TALLER2CSEntities3())
            {

                var lst = db.productos.Where(p => p.cod_producto.Equals(cod));
                return lst.ToList<object>();
            }
        }

        public static List<object> ProductosPorNombre(string nombreFiltro)
        {
            using (TALLER2CSEntities3 db = new TALLER2CSEntities3())
            {
                var lista = from producto in db.productos
                            where producto.estado_producto == 1 &&
                                  (string.IsNullOrEmpty(nombreFiltro) || producto.nombre.Contains(nombreFiltro))
                            join categoria_productos in db.categoria_productos on producto.id_categoria equals categoria_productos.id_categoria
                            select new
                            {
                                IdProducto = producto.id_producto,
                                Nombre = producto.nombre,
                                Descripcion = producto.descripcion,
                                Stock = producto.stock,
                                Precio = producto.precio,
                                CategoriaNombre = categoria_productos.nombre
                            };

                return lista.ToList<object>();
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
                    categoriaNombre = p.categoria_productos.nombre,
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

        public static string getCategoryName(int id)
        {
            using (TALLER2CSEntities3 db = new TALLER2CSEntities3())
            {

                var cat = db.categoria_productos.Find(id);
                return $"{cat.nombre}";
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


        public static List<VentasResumen> getOrdersSummary(DateTime fechaInicio, DateTime fechaFin)
        {
            using (TALLER2CSEntities3 db = new TALLER2CSEntities3())
            {
               // DateTime fechaInicio = inicio;
                //DateTime fechaFin = fin;

                var lst = db.ventas.Where(v => v.fecha >= fechaInicio && v.fecha <= fechaFin)
                    .GroupBy(v => v.fecha.Month)
                    .Select(g => new VentasResumen
                    {
                    Mes = g.Key,
                    TotalVentas = g.Sum(v => v.precio_total)
                     }).ToList();


                return lst;
             }
        }

        public static List<ProductosMasVendidos> getMostSellingProduct(DateTime fechaInicio, DateTime fechaFin)
        {
            using (TALLER2CSEntities3 db = new TALLER2CSEntities3())
            {
                Series series = new Series
                {
                    Name = "Ventas",
                    ChartType = SeriesChartType.Column,
                    IsValueShownAsLabel = true
                };

                var lst = db.venta_detalle
                            .Where(vd => vd.ventas.fecha >= fechaInicio && vd.ventas.fecha <= fechaFin)
                            .GroupBy(vd => vd.productos.nombre)
                            .Select(g => new ProductosMasVendidos
                            {
                                Producto = g.Key,
                                TotalCantidadProductos = g.Sum(vd => vd.cantidad)
                            })
                            .ToList();
                return lst;
            }
        }

        public static List<CategoriaMasVendida> getMostSellingCategories(DateTime fechaInicio, DateTime fechaFin)
        {
            using (TALLER2CSEntities3 db = new TALLER2CSEntities3())
            {
                var lst = db.productos
                    .Join(db.venta_detalle,
                          p => p.id_producto,
                          vd => vd.id_producto,
                          (p, vd) => new { p.id_categoria, vd })  // Primer JOIN: Productos con VentaDetalles
                    .Join(db.ventas,
                          pvd => pvd.vd.id_detalle_venta,
                          v => v.id_venta,
                          (pvd, v) => new { pvd.id_categoria, pvd.vd, v })  // Segundo JOIN: VentaDetalles con Ventas
                    .Where(pvd => pvd.v.fecha >= fechaInicio && pvd.v.fecha <= fechaFin)  
                    .GroupBy(pvd => pvd.id_categoria)  
                    .Select(g => new CategoriaMasVendida
                    {
                        IdCategoria = g.Key,  // La categoría de los productos
                        VecesVendido = g.Count()  // Contamos cuántas veces fue vendido un producto de esa categoría
                    })
                    .ToList();  

                return lst;
            }
        }
    }
}
