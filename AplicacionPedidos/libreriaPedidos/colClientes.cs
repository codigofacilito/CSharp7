using System;
using System.Collections.Generic;

namespace libreriaPedidos
{
    public class colClientes
    {
        #region Propiedades
        public List<clsClientes> Items { get; set; }
        #endregion

        #region Constructor
        public colClientes()
        {
            clsRepositorioClientes repo = new clsRepositorioClientes();
            List<clsClientes> intermedio = new List<clsClientes>();
            repo.ObtenClientes(ref intermedio);
            Items = intermedio;
        }
        public colClientes(string ruta)
        {
            clsRepositorioArchivoClientes repo = new clsRepositorioArchivoClientes(ruta);
            List<clsClientes> intermedio = new List<clsClientes>();
            repo.ObtenClientes(ref intermedio);
            Items = intermedio;
        }
        #endregion

        #region Metodos
        public clsClientes ObtenPorNombre(string inicioNombre)
        {
            clsClientes clienteRegresa = null;
            clienteRegresa = Items.Find(x => x.NombreCompleto.StartsWith(inicioNombre));
            return clienteRegresa;
        }
        #endregion
    }
}
