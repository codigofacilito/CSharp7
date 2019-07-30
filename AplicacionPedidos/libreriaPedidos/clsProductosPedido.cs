using System;
using System.Collections.Generic;

namespace libreriaPedidos
{
    public class clsProductosPedido : clsProductos
    {
        #region Propiedades
        public decimal Cantidad { get; set; }
        public decimal Subtotal { get; set; }
        public decimal MontoIva { get; set; }
        public decimal MontoIeps { get; set; }
        public decimal Total { get; set; }
        public decimal PrecioSinIvaSinIeps { get; set; }
        #endregion

        #region Constructor
        public clsProductosPedido()
        {

        }

        public clsProductosPedido(clsProductosCatalogo productoDeCatalogo,
                                    TipoCliente tipo, decimal cantidad)
        {
            idProducto = productoDeCatalogo.idProducto;
            Clave = productoDeCatalogo.Clave;
            CodigoBarras = productoDeCatalogo.CodigoBarras;
            Descripcion = productoDeCatalogo.Descripcion;
            PorcentajeIva = productoDeCatalogo.PorcentajeIva;
            Ieps = productoDeCatalogo.Ieps;
            EsMontoIeps = productoDeCatalogo.EsMontoIeps;
            Cantidad = cantidad;
            switch (tipo)
            {
                case TipoCliente.Publico:
                    Precio = productoDeCatalogo.Precio;
                    break;
                case TipoCliente.Medio:
                    Precio = productoDeCatalogo.Precio2;
                    break;
                case TipoCliente.Mayoreo:
                    Precio = productoDeCatalogo.Precio3;
                    break;
                default:
                    Precio = productoDeCatalogo.Precio;
                    break;
            }
            MontoIva = DesglosaIva();
            decimal precioSinIvaSinIepsCalculado = 0m;
            MontoIeps = DesglosaIeps(out precioSinIvaSinIepsCalculado);
            PrecioSinIvaSinIeps = precioSinIvaSinIepsCalculado;
            Subtotal = PrecioSinIvaSinIeps * Cantidad;
            Total = Subtotal + MontoIva + MontoIeps;
        }
        #endregion

        #region Metodos
        public override string ToString()
        {
            return "Producto: " + Clave + " Descripcion: " + Descripcion + " Cantidad: " +
                    Cantidad.ToString() + " Precio unitario: " + PrecioSinIvaSinIeps.ToString("C") +
                    " MontoIva: " + MontoIva.ToString("C") + " MontoIeps: " + MontoIeps.ToString("C") +
                    " Total: " + Total.ToString("C") + "\n";
     
        }
        #endregion
    }
}
