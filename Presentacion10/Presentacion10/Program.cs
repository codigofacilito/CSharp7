using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion10
{
    class Program
    {
        static int[] arreglo = { 1, 2, 3, 4, 5, 6, -1 };
        static void Main(string[] args)
        {
            Console.WriteLine("Dame un valor a buscar en el arreglo:");
            int valorBuscar = Convert.ToInt32(Console.ReadLine());
            ref int valor = ref BuscaValores(valorBuscar);
            if (valor != -1)
                Console.WriteLine("El valor encontrado es {0}", valor);
            else
                Console.WriteLine("No se encontro el valor");
            Console.ReadKey();
        }

        public static ref int BuscaValores(int valor)
        {
            for (int i = 0; i < 6; i++)
            {
                if (arreglo[i] == valor)
                    return ref arreglo[i];
            }
            return ref arreglo[6]; ;
        }
    }
}
