using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion12
{
    class Program
    {
        static void Main(string[] args)
        {
            clsProceso proceso = new clsProceso();
            (bool regresa, string mensajeError) error = proceso.EjecutaProceso(true);
            if (error.regresa)
                Console.WriteLine("El proceso se ejecuto de manera correcta");
            else
                Console.WriteLine("El proceso termino con el siguiente error: {0}",
                                    error.mensajeError);
            Console.ReadKey();
        }
    }
}
