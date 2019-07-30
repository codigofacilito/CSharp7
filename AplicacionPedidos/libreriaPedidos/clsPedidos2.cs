using System;
using System.Collections.Generic;

namespace libreriaPedidos
{
    public partial class clsPedidos
    {
        #region Propiedades
        public List<clsProductosPedido> Items { get; set; }
        #endregion

        #region Constructor
        #endregion

        #region Metodos
        public void AgregaItem(clsProductosPedido producto)
        {
            Items.Add(producto);
            Subtotal += producto.Subtotal;
            MontoIeps += producto.MontoIeps;
            MontoIva += producto.MontoIva;
            Total += producto.Total;
        }

        public void EliminaItem(int indice)
        {
            Subtotal -= Items[indice].Subtotal;
            MontoIeps -= Items[indice].MontoIeps;
            MontoIva -= Items[indice].MontoIva;
            Total -= Items[indice].Total;
            Items.RemoveAt(indice);
        }
        #endregion
    }
}
