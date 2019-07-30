using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion7
{
    class Program
    {
        static void Main(string[] args)
        {
            int? x = 12;
            int y;
            string cadena = x.HasValue ? "El valor de x es: " + x.ToString() :
                            "El valor de x es nulo";
            y = x ?? -1;
            Console.WriteLine(cadena);
            Console.WriteLine("El valor de y es: {0}", y);
            Console.ReadKey();
        }
    }
}
