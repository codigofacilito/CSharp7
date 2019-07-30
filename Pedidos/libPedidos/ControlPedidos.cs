using System;
using System.Collections.Generic;

namespace libPedidos
{
    public static class ControlPedidos
    {
        #region Propiedades
        public static clsProductos Producto = new clsProductos();
        public static clsClientes Cliente = new clsClientes();
        public static clsPedidos Pedido = new clsPedidos();
        public static string rutaAplicacion = "";
        #endregion

         #region Metodos
        public static void CreaPedido()
        {
            Pedido = new clsPedidos();
        }

        public static void SeleccionaCliente()
        {
            colClientes Clientes = new colClientes(rutaAplicacion);
            Console.WriteLine("Dame el inicio del nombre del cliente:");
            string cadenaInicioNombre = Console.ReadLine();
            clsClientes Cliente = Clientes.ObtenPorNombre(cadenaInicioNombre);
            if (Cliente != null)
            {
                Console.WriteLine("El nombre del cliente encontrado es: " +
                                    Cliente.NombreCompleto + " con clave: " +
                                    Cliente.Clave);
                Pedido.Cliente = Cliente.Clone() as clsClientes;
            }
            else
                Console.WriteLine("No se encontro un cliente con el inicio del nombre");
            Console.ReadKey();
        }

        public static void AgregaProductoAlPedido()
        {
            clsRepositorioProductos repo = new clsRepositorioProductos();
            clsProductosCatalogo producto = new clsProductosCatalogo();
            colProductos Productos = new colProductos(repo);
            Console.WriteLine("1. Buscar por clave");
            Console.WriteLine("2. Buscar por nombre");
            string opcion = Console.ReadLine();
            int valor = 0;
            if(int.TryParse(opcion, out valor))
                if(valor == 1)
                {
                    Console.WriteLine("Dame una clave:");
                    opcion = Console.ReadLine();
                    if (Productos.BuscaPorClave(opcion, ref producto))
                    {
                        Console.WriteLine("Dame la cantidad:");
                        string opcion2 = Console.ReadLine();
                        clsProductosPedido productoPedido = new clsProductosPedido();
                        productoPedido.idProducto = producto.idProducto;
                        productoPedido.Cantidad = Convert.ToInt32(opcion2);
                        productoPedido.Clave = producto.Clave;
                        productoPedido.Descripcion = producto.Descripcion;
                        productoPedido.EsMontoIeps = producto.EsMontoIeps;
                        productoPedido.Ieps = producto.Ieps;
                        productoPedido.PorcentajeIva = producto.PorcentajeIva;
                        productoPedido.Precio = producto.Precio;
                        decimal precioSinIvaSinIeps = 0;
                        productoPedido.MontoIeps = producto.DesglosaIeps(ref precioSinIvaSinIeps);
                        productoPedido.MontoIva = producto.DesglosaIva();
                        productoPedido.PrecioSinIvaSinIeps = precioSinIvaSinIeps;
                        productoPedido.Subtotal = productoPedido.PrecioSinIvaSinIeps * productoPedido.Cantidad;
                        productoPedido.Total = (productoPedido.PrecioSinIvaSinIeps + productoPedido.MontoIeps + productoPedido.MontoIva) *
                                                productoPedido.Cantidad;
                        Pedido.Items.Add(productoPedido);
                        Pedido.Subtotal += productoPedido.PrecioSinIvaSinIeps * productoPedido.Cantidad;
                        Pedido.MontoIva += productoPedido.MontoIva;
                        Pedido.MontoIeps += productoPedido.MontoIeps;
                        Pedido.Total += (productoPedido.PrecioSinIvaSinIeps + productoPedido.MontoIeps + productoPedido.MontoIva) *
                                                productoPedido.Cantidad;
                        Console.WriteLine("Se agrego el producto con id: {0}, clave: {1} descripcion: {2}, cantidad: {3} y precio: {4}",
                                            productoPedido.idProducto, productoPedido.Clave, productoPedido.Descripcion, productoPedido.Cantidad,
                                            productoPedido.Precio);
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("No se encontro el producto con clave: {0}", opcion);
                        Console.ReadKey();
                    }
                }
        }

        public static void EliminaProductoDePedido()
        {
        }

        public static void GuardaPedido()
        {
        }

        public static string MuestraPedido()
        {
           return Pedido.ToString();
        }
        #endregion
    }
}
