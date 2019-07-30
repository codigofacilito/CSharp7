using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libreriaPedidos
{
    public interface IRepositorioProductos
    {
        void ObtenTodos(Dictionary<string, clsProductosCatalogo> productos);
        void Guarda(clsProductosCatalogo producto);
        void Modifica(clsProductosCatalogo producto);
        void Elimina(int id);
    }
}
