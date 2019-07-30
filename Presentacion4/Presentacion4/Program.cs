using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion4
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena1 = String.Empty;
            string cadena2 = @"Valor con escape \directorio";
            int bandera = 0;
            bool bandera2 = false;
            Console.WriteLine("La cadena 1 de inicio es: " + cadena1);
            Console.WriteLine("La cadena 2 de inicio es: " + cadena2);
            Console.WriteLine("La longitud de la cadena 1 es {0:N}", cadena1.Length);
            Console.WriteLine("La longitud de la cadena 2 es {0:N}", cadena2.Length);
            cadena1 = cadena2.Substring(0, 5);
            Console.WriteLine("La cadena 2 ahora tiene una subcadena: " + cadena1);
            bandera = cadena1.CompareTo(cadena2);
            Console.WriteLine("El valor de bandera en la comparación es {0:N}", bandera);
            bandera2 = cadena1.Contains('a');
            Console.WriteLine("El valor de bandera 2 al buscar el caracter a en la cadena 1 " +
                                bandera2.ToString());
            Console.WriteLine("Las cadenas concatenadas son:" + String.Concat(cadena1, cadena2));
            bandera2 = cadena1.Equals(cadena2);
            Console.WriteLine("El valor de bandera 2 para saber si son iguales es " +
                                bandera2.ToString());
            Console.WriteLine("El valor de cadena 2 sin los caracteres dos y tres es: " +
                                cadena2.Remove(1, 2));
            Console.WriteLine("El valor de cadena 2 con la letra a reempleazada por e es :" +
                                cadena2.Replace('a', 'e'));
            Console.WriteLine("El valor de cadena 2 en mayúsculas es: " +
                                cadena2.ToUpper());
            Console.WriteLine("El valor de cadena 2 en minúsuclas es: " +
                                cadena2.ToLower());
            Console.WriteLine("El valor del primer caracter de la cadena 1 es: " + cadena1[0]);

            Console.ReadKey();
        }
    }
}
