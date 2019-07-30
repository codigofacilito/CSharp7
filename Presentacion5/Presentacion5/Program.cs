using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion5
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena = "";
            int valor1, valor2;
            Console.WriteLine("Dame el valor 1:");
            cadena = Console.ReadLine();
            valor1 = Convert.ToInt32(cadena);
            Console.WriteLine("Dame el valor 2:");
            cadena = Console.ReadLine();
            valor2 = Convert.ToInt32(cadena);
            int resultado = (valor1 + valor2) * (valor1 / valor2);
            Console.WriteLine("El resultado es: {0}", resultado);
            /*if (valor1 < valor2)
            {
                Console.WriteLine("El valor 1: {0} es menor al valor 2: {1}",
                        valor1, valor2);
            }
            else if (valor1 == valor2)
                Console.WriteLine("El valor 1: {0} es igual al valor 2: {1}",
                    valor1, valor2);
            else
                Console.WriteLine("El valor 1: {0} es mayor al valor 2: {1}",
                    valor1, valor2);*/
            Console.ReadKey();
        }
    }
}
