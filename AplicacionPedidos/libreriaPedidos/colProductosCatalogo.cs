using System;
using System.Collections.Generic;
using System.Linq;

namespace libreriaPedidos
{
    public class colProductosCatalogo
    {
        #region Propiedades
        public Dictionary<string, clsProductosCatalogo> Items { get; set; }
        #endregion

        #region Constructor
        public colProductosCatalogo()
        {
            Items = new Dictionary<string, clsProductosCatalogo>();
        }

        public colProductosCatalogo(IRepositorioProductos repo)
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

        public List<clsProductosCatalogo> ObtenPorDescripcion(string inicio)
        {
            /*var query = Items.Where(p => p.Value.Descripcion.StartsWith(inicio))
                        .OrderBy(p => p.Value.Descripcion)
                        .Select(p => p.Value);*/
            var query = from p in Items
                        where p.Value.Descripcion.StartsWith(inicio)
                        orderby p.Value.Descripcion
                        select p.Value;
            return query.ToList();
        }
        #endregion
    }
}
