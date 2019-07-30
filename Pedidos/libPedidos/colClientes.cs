using System;
using System.Collections.Generic;

namespace libPedidos
{
    public class colClientes
    {
        #region Propiedades
        public List<clsClientes> Items;
        #endregion

        #region Constructor
        public colClientes()
        {
            Items = new List<clsClientes>();
            clsRepositorioClientes repo = new clsRepositorioClientes();
            repo.ObtenClientes(Items);
        }
        public colClientes(string ruta)
        {
            Items = new List<clsClientes>();
            clsRepositorioArchivoClientes repo = new clsRepositorioArchivoClientes(ruta);
            repo.ObtenClientes(Items);
        }
        #endregion

        #region Metodos
        public clsClientes ObtenPorNombre(string inicioNombre)
        {
            clsClientes clienteRegresa = null;
            clienteRegresa = Items.Find(delegate (clsClientes x) { return x.NombreCompleto.Contains(inicioNombre); });
            return clienteRegresa;
        }
        #endregion
    }
}
