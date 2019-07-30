using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using libreriaPedidos;
using System.IO;

namespace AplicacionPedidos
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int opcion = 0;
                ControlPedidos.CrearPedido();
                ControlPedidos.rutaArchivo = Path.GetDirectoryName(System.Reflection
                                                .Assembly.GetExecutingAssembly().Location);
                do
                {
                    Console.Clear();
                    Console.WriteLine("1. Seleccionar el cliente");
                    Console.WriteLine("2. Agregar producto al pedido");
                    Console.WriteLine("3. Eliminar producto del pedido");
                    Console.WriteLine("4. Mostrar pedido");
                    Console.WriteLine("0. Salir");
                    opcion = Convert.ToInt32(Console.ReadLine());
                    switch (opcion)
                    {
                        case 1:
                            ControlPedidos.SeleccionaCLiente();
                            break;
                        case 2:
                            ControlPedidos.AgregaProductoAlPedido();
                            break;
                        case 3:
                            ControlPedidos.EliminaProductoDePedido();
                            break;
                        case 4:
                            Console.WriteLine(ControlPedidos.MuestraPedido());
                            Console.ReadKey();
                            break;
                        default:
                            break;
                    }
                } while (opcion != 0);
            }
            catch(Exception e)
            {
                Console.WriteLine("Excepcion: " + e.Message);
                Console.ReadKey();
            }
        }
    }
}
