using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaProductos;

namespace Presentacion8
{
    class Program
    {
        static void Main(string[] args)
        {
            clsProductos Producto, SegundoProducto;
            Producto = new clsProductos();
            Producto.idProducto = 1;
            Producto.Clave = "P0001";
            Producto.Descripcion = "REF NARANJA 600 ML";
            Producto.CodigoBarras = "123456789";
            SegundoProducto = new clsProductos(2, "P0002", "REF TORONJA 600 ML",
                                    "1122334455");
            Console.WriteLine("Los datos del producto son:");
            Console.WriteLine("id : {0}", Producto.idProducto);
            Console.WriteLine("Clave: " + Producto.Clave);
            Console.WriteLine("Descripcion: " + Producto.Descripcion);
            Console.WriteLine("Codigo de Barras: " + Producto.CodigoBarras);
            Console.WriteLine("Los datos del segundo producto son:");
            Console.WriteLine("id : {0}", SegundoProducto.idProducto);
            Console.WriteLine("Clave: " + SegundoProducto.Clave);
            Console.WriteLine("Descripcion: " + SegundoProducto.Descripcion);
            Console.WriteLine("Codigo de Barras: " + SegundoProducto.CodigoBarras);
            Console.ReadKey();
        }
    }
}
