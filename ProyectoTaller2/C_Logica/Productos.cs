using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ProyectoTaller2.C_Datos;

namespace ProyectoTaller2.C_Logica
{
    internal class Productos
    {

        private string codProducto {  get; set; }
        private string nombre {  get; set; }
        private string descripcion { get; set; }
        private float precio { get; set; }
        private int stock { get; set; }
        private int stock_min { get; set; }
        private int id_categoria { get; set; }
        private string catNombre; 
        private int id_marca { get; set; }
        private string marcaNombre;
        private int id_proveedor { get; set; }



        public Productos() { }

        public Productos(string codProducto, string nombre, string desc, string precio, string stock, string stock_min, int id_categoria, int id_marca, int id_proveedor)
        {

            this.codProducto = codProducto;
            this.nombre = nombre;
            this.descripcion = desc;
            this.precio = float.Parse(precio);
            this.stock = int.Parse(stock);
            this.stock_min = int.Parse(stock_min);
            this.id_categoria = id_categoria;
            this.id_marca = id_marca;
            this.id_proveedor = id_proveedor;
            this.catNombre = DProductos.getCategoryById(id_categoria);
            this.marcaNombre = DProductos.getBrandById(id_marca);

        }

        public string getCodProducto(){ return this.codProducto;}
        public string getNombre(){ return this.nombre;}
        public string getDescripcion(){ return this.descripcion;}
        public float getPrecio() {  return this.precio;}
        public int getStock() { return this.stock;}
        public int getStockMin() { return this.stock_min;}
        public int getIdCategoria() {  return this.id_categoria;}
        public int getIdMarca() {  return this.id_marca;}
        public int getIdProveedor() { return this.id_proveedor;}
        public string getCategoriaNombre() { return this.catNombre; }



        public static bool nuevoProducto(string codProducto, string nombre, string desc, string precio, string stock, string stock_min, string categoria, string marca, string proveedor)
        {
            try
            {
                float fPrecio = float.Parse(precio);
                int istock = int.Parse(stock);
                int istockMin = int.Parse(stock_min);


                productos nuevo = new productos();

                nuevo.cod_producto = codProducto;
                nuevo.nombre = nombre;
                nuevo.descripcion = desc;
                nuevo.precio = fPrecio;
                nuevo.stock = istock;
                nuevo.stock_minimo = istockMin;
                nuevo.id_categoria = DProductos.getCategoryId(categoria);
                nuevo.id_marca = DProductos.getBrandId(marca);
                nuevo.id_proveedor = DProveedores.getSupplierId(proveedor);
                nuevo.estado_producto = 1;
                nuevo.create_at = DateTime.Now;

                return DProductos.newProduct(nuevo);

            }
            catch (Exception e)
            {
                return false;
            }
        }


        public static bool editarProducto(int id,string codProducto, string nombre, string desc, string precio, string stock, string stock_min, string categoria, string marca, string proveedor)
        {
            productos editar = new productos();

            editar.cod_producto = codProducto;
            editar.nombre = nombre;
            editar.descripcion = desc;
            editar.precio = float.Parse(precio); 
            editar.stock = Int32.Parse(stock);
            editar.stock_minimo = Int32.Parse(stock_min);
            editar.id_categoria = DProductos.getCategoryId(categoria);
            editar.id_marca = DProductos.getBrandId(marca);
            editar.id_proveedor = DProveedores.getSupplierId(proveedor);

            return DProductos.editProduct(id,editar);
        }

        public static object listarProductos()
        {
            return DProductos.getAllProducts();
        }

        public static object listarProductosPorCategoria(string categoria)
        {

            int categoriaID = DProductos.getCategoryId(categoria);

            return DProductos.getProductsByCategory(categoriaID);

        }

        public static object buscarProductoPorCodigo(string codigo)
        {
            return DProductos.seachProductByCode(codigo);
        }

        public static object listarCategorias() //separar
        {
           return DProductos.getCategories();
        }

        public static object listarMarcas()//separar
        {
            return DProductos.getBrands();
        }

        public static object listarProveedores()//separar
        {
            return DProductos.getSuppliers();
        }

        public Productos ObtenerUsuarioPorId(int id)
        {
            
            var producto = DProductos.getProductById(id);

            return new Productos(
                    producto.cod_producto,
                    producto.nombre,
                    producto.descripcion,
                    producto.precio.ToString(),
                    producto.stock.ToString(),
                    producto.stock_minimo.ToString(),
                    producto.id_categoria,
                    producto.id_marca,
                    producto.id_proveedor
                ); 
        }

        public static string getNombreCategoria(int id)
        {
            return DProductos.getCategoryName(id);
        }

        public static List<ProductosMasVendidos> getProductosMasVendidos(DateTime inicio, DateTime fin)
        {
            return DProductos.getMostSellingProduct(inicio, fin);
        }

        public static bool cambiarEstadoProducto(int id)
        {
            return DProductos.changeProductState(id);
        }

        public static List<VentasResumen> getResumenMensual(DateTime inicio, DateTime fin)
        {
            return DProductos.getOrdersSummary(inicio,fin);
        }

        public static List<CategoriaMasVendida> getCategoriasMasVendidas(DateTime inicio, DateTime fin)
        {
            return DProductos.getMostSellingCategories(inicio,fin);
        }
    }
}
