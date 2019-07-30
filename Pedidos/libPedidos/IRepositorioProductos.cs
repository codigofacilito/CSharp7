using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libPedidos
{
    public interface IRepositorioProductos
    {
        void ObtenTodos(Dictionary<string, clsProductosCatalogo> productos);
        void Guarda(clsProductos producto);
        void Modifica(clsProductos producto);
        void Elimina(int id);
    }
}
