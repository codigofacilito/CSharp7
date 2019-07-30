using System;
using System.Collections.Generic;

namespace libreriaPedidos
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
        #endregion

        #region Metodos
        public object Clone()
        {
            clsClientes clienteClonado = new clsClientes();
            clienteClonado.idCliente = idCliente;
            clienteClonado.NombreCompleto = NombreCompleto;
            clienteClonado.Clave = Clave;
            clienteClonado.Rfc = Rfc;
            clienteClonado.Tipo = Tipo;
            return clienteClonado;
        }

        public override string ToString()
        {
            return "idCliente: " + idCliente.ToString() + " Nombre: " + NombreCompleto +
                    " Clave: " + Clave + " Rfc: " + Rfc + " Tipo: " + Tipo.ToString();
        }
        #endregion
    }
}
