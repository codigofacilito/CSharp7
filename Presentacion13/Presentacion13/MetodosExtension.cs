using System;
using System.Collections.Generic;

namespace Presentacion13
{
    public static class MetodosExtension
    {
        #region Propiedades
        #endregion

        #region Constructor
        #endregion

        #region Metodos
        public static string SustituyeEspacios(this String str)
        {
            return str.Replace(' ', '-');
        }
        #endregion
    }
}
