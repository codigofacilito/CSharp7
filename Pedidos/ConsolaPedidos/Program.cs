using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using libPedidos;

namespace ConsolaPedidos
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            ControlPedidos.rutaAplicacion = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            ControlPedidos.CreaPedido();
            do
            {
                Console.Clear();
                Console.WriteLine("1. Seleccionar cliente");
                Console.WriteLine("2. Agregar producto al pedido");
                Console.WriteLine("3. Eliminar producto del pedido");
                Console.WriteLine("4. Guardar pedido");
                Console.WriteLine("5. Mostrar pedido");
                Console.WriteLine();
                Console.WriteLine("0. Salir");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        ControlPedidos.SeleccionaCliente();
                        break;
                    case 2:
                        ControlPedidos.AgregaProductoAlPedido();
                        break;
                    case 3:
                        ControlPedidos.EliminaProductoDePedido();
                        break;
                    case 4:
                        ControlPedidos.GuardaPedido();
                        break;
                    case 5:
                        Console.WriteLine(ControlPedidos.MuestraPedido());
                        Console.ReadKey();
                        break;
                    default:
                        break;
                }
            } while (opcion != 0);
        }
   }
}
