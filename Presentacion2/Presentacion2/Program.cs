using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion2
{
    class Program
    {
        static void Main(string[] args)
        {
            const int NUMERO_FIJO = 12;
            short e = 15;
            int i = 0, l = 1, k = 2;
            float f = 0.0F;
            decimal x = 0.0m;
            string cadena = "Hola mundo";
            bool bandera = false;
            DateTime fecha = DateTime.Now;
            Console.WriteLine("El valor de e es: {0:X}", e);
            Console.WriteLine("Los enteros son i = {0:N}, l = {1:N}, k = {2:N}", i, l, k);
            Console.WriteLine("El valor de f es: {0:E}", f);
            Console.WriteLine("El valor de x es: {0:C}", x);
            Console.WriteLine("El valor de cadena es: " + cadena);
            Console.WriteLine("El valor de bandera es:" + bandera.ToString());
            Console.WriteLine("El valor de fecha es: " + fecha.ToLongDateString());
            Console.WriteLine("El valor de la constante NUMERO_FIJO es: {0}", NUMERO_FIJO);
            Console.ReadKey();
        }
    }
}
