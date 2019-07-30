using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace libPedidos
{
    public class clsRepositorioProductos : IRepositorioProductos
    {
        #region Propiedades
        #endregion

        #region Constructor
        #endregion

        #region Metodos
        public void Elimina(int id)
        {
            //throw new NotImplementedException();
        }

        public void Guarda(clsProductos producto)
        {
            //throw new NotImplementedException();
        }

        public void Modifica(clsProductos producto)
        {
            //throw new NotImplementedException();
        }

        public void ObtenTodos(Dictionary<string, clsProductosCatalogo> productos)
        {
            productos.Clear();
            productos.Add("P0001", new clsProductosCatalogo
            {
                idProducto = 1,
                Clave = "P0001",
                CodigoBarras = "11111",
                Descripcion = "REF BIG COLA 600ML",
                EsMontoIeps = false,
                Ieps = 2,
                PorcentajeIva = 16,
                Precio = 12.5m,
                Precio2 = 12m,
                Precio3 = 11.5m
            });
            productos.Add("P0002", new clsProductosCatalogo
            {
                idProducto = 2,
                Clave = "P0002",
                CodigoBarras = "222222",
                Descripcion = "REF FANTA 600ML",
                EsMontoIeps = false,
                Ieps = 2,
                PorcentajeIva = 16,
                Precio = 10m,
                Precio2 = 9.5m,
                Precio3 = 9m
            });
            productos.Add("P0003", new clsProductosCatalogo
            {
                idProducto = 3,
                Clave = "P0003",
                CodigoBarras = "333333",
                Descripcion = "ACEITE 123 1 L",
                EsMontoIeps = false,
                Ieps = 0,
                PorcentajeIva = 16,
                Precio = 28.5m,
                Precio2 = 28m,
                Precio3 = 27.5m
            });
            productos.Add("P0004", new clsProductosCatalogo
            {
                idProducto = 4,
                Clave = "P0004",
                CodigoBarras = "444444",
                Descripcion = "GTA EMP 250 G",
                EsMontoIeps = false,
                Ieps = 0,
                PorcentajeIva = 16,
                Precio = 14m,
                Precio2 = 13.5m,
                Precio3 = 13m
            });
            productos.Add("P0005", new clsProductosCatalogo
            {
                idProducto = 5,
                Clave = "P0005",
                CodigoBarras = "555555",
                Descripcion = "PASTA DIENTES WAS 250 G",
                EsMontoIeps = false,
                Ieps = 0,
                PorcentajeIva = 16,
                Precio = 26m,
                Precio2 = 25m,
                Precio3 = 24.5m
            });
        }
        #endregion
    }
}
