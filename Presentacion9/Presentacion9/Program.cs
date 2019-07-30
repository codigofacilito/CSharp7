using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion9
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int[] arreglo = new int[5];
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("Dame el valor {0}: ", i);
                arreglo[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("El valor del elemento {0} es: {1}", i, arreglo[i]);
            }
            Console.ReadKey();
        }
    }
}
