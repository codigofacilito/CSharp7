using System;
using System.Collections.Generic;
using System.Threading;

namespace Presentacion11
{
    public delegate void MuestraAvance(string valor);
    public class RepositorioProductos
    {
        #region Eventos
        public event MuestraAvance avance;
        #endregion
        #region Propiedades
        #endregion

        #region Constructor
        #endregion

        #region Metodos
        public void ObtenTodos()
        {
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(250);
                avance(i.ToString());
            }
        }
        #endregion
    }
}
