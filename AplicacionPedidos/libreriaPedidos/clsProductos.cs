using System;
using System.Collections.Generic;

namespace libreriaPedidos
{
    public class clsProductos : clsAbstractaProductos
    {
        #region Propiedades
        public string CodigoBarras { get; set; }
        public decimal Precio { get; set; }
        public decimal PorcentajeIva { get; set; }
        public decimal Ieps { get; set; }
        public bool EsMontoIeps { get; set; }
        #endregion

        #region Constructor
        public clsProductos()
        {

        }

        public clsProductos(int id, string clave, string descripcion,
                            string codigoBarras, decimal precio, 
                            decimal porcentajeIva)
        {
            idProducto = id;
            Clave = clave;
            Descripcion = descripcion;
            CodigoBarras = codigoBarras;
            Precio = precio;
            PorcentajeIva = porcentajeIva;
        }
        #endregion

        #region Metodos
        public decimal DesglosaIva()
        {
            return Math.Round((Precio / (1 + PorcentajeIva / 100)) *
                                PorcentajeIva / 100, 2);
        }

        public decimal PrecioSinIva()
        {
            return Math.Round(Precio / (1 + PorcentajeIva / 100), 2);
        }

        public decimal DesglosaIeps(out decimal PrecioSinIvaSinIeps)
        {
            decimal PrecioSinIva = Precio / (1 + PorcentajeIva / 100);
            decimal MontoIeps = 0m;
            PrecioSinIvaSinIeps = 0m;
            if(EsMontoIeps)
            {
                MontoIeps = Ieps;
                PrecioSinIvaSinIeps = Math.Round(PrecioSinIva - MontoIeps, 2);
            }
            else
            {
                PrecioSinIvaSinIeps = Math.Round(PrecioSinIva / (1 + Ieps / 100),2);
                MontoIeps = Math.Round(PrecioSinIvaSinIeps * Ieps / 100, 2);
            }
            return MontoIeps;
        }
        #endregion
    }
}
