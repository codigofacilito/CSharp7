using System;
using System.Collections.Generic;

namespace LibreriaProductos
{
    public class clsProductos
    {
        #region Propiedades
        public int idProducto { get; set; }
        public string Clave { get; set; }
        public string Descripcion { get; set; }
        public string CodigoBarras { get; set; }
        #endregion

        #region Constructor
        public clsProductos()
        {
        }

        public clsProductos(int id, string clave, string descripcion,
                            string codigo)
        {
            idProducto = id;
            Clave = clave;
            Descripcion = descripcion;
            CodigoBarras = codigo;
        }
        #endregion

        #region Metodos
        #endregion
    }
}
