using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libPedidos
{
    public class clsProductos
    {
        public int idProducto { get; set; }
        public string Descripcion { get; set; }
        public string Clave { get; set; }
        public string CodigoBarras { get; set; }
        public decimal Precio { get; set; }
        public decimal PorcentajeIva { get; set; }
        public decimal Ieps { get; set; }
        public bool EsMontoIeps { get; set; }

        public decimal DesglosaIva()
        {
            return Math.Round((Precio / (1 + PorcentajeIva / 100)) * PorcentajeIva / 100, 2);
        }

        public decimal PrecioSinIva()
        {
            return Math.Round(Precio / (1 + PorcentajeIva / 100), 2);
        }

        public decimal DesglosaIeps(ref decimal PrecioSinIvaSinIeps)
        {
            decimal PrecioSinIva = Precio / (1 + PorcentajeIva / 100);
            PrecioSinIvaSinIeps = 0;
            decimal MontoIeps = 0;
            if (EsMontoIeps)
            {
                MontoIeps = Math.Round(Ieps, 2);
                PrecioSinIvaSinIeps = Math.Round(PrecioSinIva - MontoIeps, 2);
            }
            else
            {
                PrecioSinIvaSinIeps = Math.Round(PrecioSinIva / (1 + Ieps / 100), 2);
                MontoIeps = Math.Round(PrecioSinIvaSinIeps * Ieps / 100, 2);
            }
            return MontoIeps;
        }
    }
}
