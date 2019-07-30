using System;
using System.Collections.Generic;

namespace libreriaPedidos
{
    public static class ControlPedidos
    {
        #region Propiedades
        public static clsProductos Producto = new clsProductos();
        public static clsClientes Cliente = new clsClientes();
        public static clsPedidos Pedido = new clsPedidos();
        public static string rutaArchivo = "";
        #endregion

        #region Metodos
        public static void CrearPedido()
        {
            Pedido = new clsPedidos();
        }

        public static void SeleccionaCLiente()
        {
            colClientes Clientes = new colClientes(rutaArchivo);
            Console.WriteLine("Dame el inicio del nombre del cliente:");
            string cadenaInicioNombre = Console.ReadLine();
            clsClientes Cliente = Clientes.ObtenPorNombre(cadenaInicioNombre);
            if (Cliente != null)
            {
                Console.WriteLine("El nombre del cliente encontrado es: " +
                                    Cliente.NombreCompleto + " con clave: " +
                                    Cliente.Clave);
                Pedido.Cliente = (clsClientes)Cliente.Clone();
            }
            else
                Console.WriteLine("No se encontro un  cliente con el inicio del nombre");
            Console.ReadKey();
        }

        public static void AgregaProductoAlPedido()
        {
            clsRepositorioArchivoProductos repo = new clsRepositorioArchivoProductos();
            clsProductosCatalogo producto = new clsProductosCatalogo();
            colProductosCatalogo Productos = new colProductosCatalogo(repo);
            Console.WriteLine("1. Buscar por clave");
            Console.WriteLine("2. Buscar por nombre");
            string opcion = Console.ReadLine();
            int valor = 0;
            if(int.TryParse(opcion, out valor))
            {
                if(valor == 1)
                {
                    Console.WriteLine("Dame la clave del producto:");
                    opcion = Console.ReadLine();
                    if(Productos.BuscaPorClave(opcion, ref producto))
                    {
                        Console.WriteLine("Dame la cantidad:");
                        string opcion2 = Console.ReadLine();
                        decimal cantidad = Convert.ToDecimal(opcion2);
                        clsProductosPedido productoPedido = new clsProductosPedido(producto,
                                                                    Pedido.Cliente.Tipo,
                                                                    cantidad);
                        Pedido.AgregaItem(productoPedido);
                    }
                    else
                    {
                        Console.WriteLine("No se encontró el producto con clave {0}",
                                            opcion);
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.WriteLine("Dame el inicio de la descripcion:");
                    opcion = Console.ReadLine();
                    List<clsProductosCatalogo> resultado = new List<clsProductosCatalogo>();
                    resultado = Productos.ObtenPorDescripcion(opcion);
                    if(resultado.Count > 0)
                    {
                        for (int i = 0; i < resultado.Count; i++)
                        {
                            Console.WriteLine((i + 1).ToString() +
                                            ". " + resultado[i].Descripcion);
                        }
                        Console.WriteLine("Selecciona el producto:");
                        string opcion2 = Console.ReadLine();
                        int indice = Convert.ToInt32(opcion2);
                        Console.WriteLine("Dame la cantidad:");
                        opcion2 = Console.ReadLine();
                        decimal cantidad = Convert.ToDecimal(opcion2);
                        clsProductosPedido productoPedido = new clsProductosPedido(resultado[indice - 1],
                                                                    Pedido.Cliente.Tipo,
                                                                    cantidad);
                        Pedido.AgregaItem(productoPedido);

                    }
                    else
                    {
                        Console.WriteLine("No existen productos con el inicio {0}",
                                            opcion);
                        Console.ReadKey();
                    }
                }
            }
        }

        public static void EliminaProductoDePedido()
        {
            if(Pedido.Items.Count > 0)
            {
                for (int i = 0; i < Pedido.Items.Count; i++)
                {
                    Console.WriteLine((i + 1).ToString() + ". " +
                        Pedido.Items[i].Descripcion);
                }
                Console.WriteLine("Dame el numero del producto a eliminar:");
                string opcion = Console.ReadLine();
                int indice = Convert.ToInt32(opcion) - 1;
                Pedido.EliminaItem(indice);
            }
            else
            {
                Console.WriteLine("No existen productos en el pedido");
                Console.ReadKey();
            }
        }

        public static string MuestraPedido()
        {
            return Pedido.ToString();
        }
        #endregion
    }
}
