using System;
using System.Collections.Generic;

namespace Presentacion12
{
    public class clsProceso
    {
        #region Propiedades
        #endregion

        #region Constructor
        #endregion

        #region Metodos
        public (bool regresa, string mensajeError) EjecutaProceso(bool valor)
        {
            (bool regresa, string mensajeError) tupla;
            if (valor)
            {
                tupla.regresa = valor;
                tupla.mensajeError = "";
            }
            else
            {
                tupla.regresa = valor;
                tupla.mensajeError = "Error de datos";
            }
            return tupla;
        }
        #endregion
    }
}
