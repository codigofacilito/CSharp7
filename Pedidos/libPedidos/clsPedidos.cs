using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libPedidos
{
    public partial class clsPedidos
    {
        public int Folio { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Subtotal { get; set; }
        public decimal MontoIva { get; set; }
        public decimal MontoIeps { get; set; }
        public decimal Total { get; set; }
        public clsClientes Cliente { get; set; }

        public clsPedidos()
        {
            Cliente = new clsClientes();
            Items = new List<clsProductosPedido>();
        }

        public override string ToString()
        {
            string cadena =  "Pedido: " + Folio.ToString() + " Subtotal: " + Subtotal.ToString("C") + " Iva: " + MontoIva.ToString("C") +
                       " MontoIeps: " + MontoIeps.ToString("C") + " Total: " +Total.ToString("C") + "\n\n";
            foreach (clsProductosPedido item in Items)
            {
                cadena += item.ToString();
            }
            return cadena;
        }
    }
}
