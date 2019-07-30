using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion11
{
    class Program
    {
        static void Main(string[] args)
        {
            RepositorioProductos repo = new RepositorioProductos();
            repo.avance += DespliegaAvance;
            repo.ObtenTodos();
            Console.ReadKey();
        }

        private static void DespliegaAvance(string valor)
        {
            Console.Write(valor);
        }
    }
}
