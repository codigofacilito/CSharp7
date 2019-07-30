using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion6
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena = "";
            int valor = 0;
            Console.WriteLine("Dame un valor:");
            cadena = Console.ReadLine();
            valor = Convert.ToInt32(cadena);
            switch (valor)
            {
                case 1:
                    Console.WriteLine("El valor de la variable valor es 1");
                    break;
                case 11:
                case 12:
                case 13:
                    Console.WriteLine("El valor de la variable valor esta entre 11 y 13");
                    break;
                default:
                    Console.WriteLine("El valor es diferente de 1, 11, 12 o 13");
                    break;
            }
            Console.ReadKey();
        }
    }
}
