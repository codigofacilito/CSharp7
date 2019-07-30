using System;
using System.Collections.Generic;

namespace libPedidos
{
    public class clsClientes : clsAbstractaPersonas, ICloneable
    {
        #region Propiedades
        public int idCliente { get; set; }
        public string Clave { get; set; }
        public string Rfc { get; set; }
        public TipoCliente Tipo { get; set; }
        #endregion

        #region Constructor
        public clsClientes() { }
        public clsClientes(string nombre, string clave, string rfc)
        {
            NombreCompleto = nombre;
            Clave = clave;
            Rfc = rfc;
        }

        public object Clone()
        {
            clsClientes clienteClonado = new clsClientes();
            clienteClonado.Clave = Clave;
            clienteClonado.NombreCompleto = NombreCompleto;
            clienteClonado.idCliente = idCliente;
            clienteClonado.Rfc = Rfc;
            clienteClonado.Tipo = Tipo;
            return clienteClonado;
        }
        #endregion

        #region Metodos
        #endregion
    }
}
