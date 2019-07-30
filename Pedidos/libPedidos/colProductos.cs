using System;
using System.Collections.Generic;
using System.Linq;

namespace libPedidos
{
    public class colProductos
    {
        #region Propiedades
        public Dictionary<string, clsProductosCatalogo> Items { get; set; }
        #endregion

        #region Constructor
        public colProductos()
        {
            Items = new Dictionary<string, clsProductosCatalogo>();
        }

        public colProductos(IRepositorioProductos repo)
        {
            Items = new Dictionary<string, clsProductosCatalogo>();
            repo.ObtenTodos(Items);
        }
        #endregion

        #region Metodos
        public bool BuscaPorClave(string clave, ref clsProductosCatalogo producto)
        {
            producto = new clsProductosCatalogo();
            return Items.TryGetValue(clave, out producto);
        }
        public List<clsProductosCatalogo> ObtenPorNombre(string inicioNombre)
        {
            List<clsProductosCatalogo> producto = null;
            producto = (List<clsProductosCatalogo>)(from p in Items where p.Value.Descripcion.StartsWith(inicioNombre) select p.Value);
            return producto;
        }

        public Dictionary<string, clsProductosCatalogo> ObtenDiccionarioPorNombre(string inicioNombre)
        {
            var query = from p in Items where p.Value.Descripcion.StartsWith(inicioNombre) orderby p.Value.Descripcion  select p;
            return query.ToDictionary(p => p.Key, p => p.Value);
        }
        #endregion
    }
}
