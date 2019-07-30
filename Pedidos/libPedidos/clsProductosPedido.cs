using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libPedidos
{
    public class clsProductosPedido : clsProductos
    {
        public decimal Cantidad { get; set; }
        public decimal Subtotal { get; set; }
        public decimal MontoIva { get; set; }
        public decimal MontoIeps { get; set; }
        public decimal Total { get; set; }
        public decimal PrecioSinIvaSinIeps { get; set; }

        public override string ToString()
        {
            return "Producto: " + Clave + " Descripcion: " + Descripcion + " Cantidad: " + Cantidad.ToString() +
                            " Precio Unitario: " + PrecioSinIvaSinIeps.ToString("C") + " MontoIva: " + MontoIva.ToString() +
                            " MontoIeps: " + MontoIeps.ToString("C") + " Total: " + Total.ToString("C") + "\n";
        }
    }
}
