using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion3
{
    class Program
    {
        static void Main(string[] args)
        {
            byte e = 0;
            int k = 0;
            float x = 0.0f;
            decimal suma = 0.0m;
            string cadena = "";
            Console.WriteLine("Dame un valor para e:");
            cadena = Console.ReadLine();
            e = Convert.ToByte(cadena);
            Console.WriteLine("Dame un valor para k:");
            cadena = Console.ReadLine();
            k = Convert.ToInt32(cadena);
            Console.WriteLine("Dame un valor para x:");
            cadena = Console.ReadLine();
            x = Convert.ToSingle(cadena);
            Console.WriteLine("Dame un valor para suma:");
            cadena = Console.ReadLine();
            suma = Convert.ToDecimal(cadena);
            Console.WriteLine("El valor de e es {0:N}", e);
            Console.WriteLine("El valor de k es {0:N}", k);
            Console.WriteLine("El valor de x es {0:N2}", x);
            Console.WriteLine("El valor de suma es {0:C}", suma);
            Console.ReadKey();
        }
    }
}
