using System;
using System.Collections.Generic;

namespace libreriaPedidos
{
    public partial class clsPedidos
    {
        #region Propiedades
        public int Folio { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Subtotal { get; set; }
        public decimal MontoIva { get; set; }
        public decimal MontoIeps { get; set; }
        public decimal Total { get; set; }
        public clsClientes Cliente { get; set; }
        #endregion

        #region Constructor
        public  clsPedidos()
        {
            Cliente = new clsClientes();
            Items = new List<clsProductosPedido>();
        }
        #endregion

        #region Metodos
        public override string ToString()
        {
            string cadena = "";
            cadena += Cliente.ToString() + "\n";
            cadena += "Pedido: " + Folio.ToString() + " Subtotal: " + Subtotal.ToString("C") +
                        " Iva: " + MontoIva.ToString("C") + " MontoIeps: " + MontoIeps.ToString("C") +
                        " Total: " + Total.ToString("C") + "\n\n";
            foreach (clsProductosPedido item in Items)
            {
                cadena += item.ToString();
            }
            return cadena;
        }
        #endregion
    }
}
