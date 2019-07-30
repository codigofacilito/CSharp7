using System;
using System.Collections.Generic;

namespace libreriaPedidos
{
    public class clsRepositorioClientes : IRepositorioClientes
    {
        #region Propiedades
        #endregion

        #region Constructor
        #endregion

        #region Metodos
        public void CreaCliente(clsClientes cliente)
        {
            //throw new NotImplementedException();
        }

        public void EliminaCliente(clsClientes cliente)
        {
            //throw new NotImplementedException();
        }

        public void ModificaCliente(clsClientes cliente)
        {
            //throw new NotImplementedException();
        }

        public void ObtenCliente(clsClientes cliente)
        {
            //throw new NotImplementedException();
        }

        public void ObtenClientes(ref List<clsClientes> clientes)
        {
            clientes.Clear();
            clientes.Add(new clsClientes
            {
                idCliente = 1,
                Clave = "C001",
                NombreCompleto = "Marcos Hernandez",
                Rfc = "HEHM",
                Tipo = TipoCliente.Publico
            });
            clientes.Add(new clsClientes
            {
                idCliente = 2,
                Clave = "C002",
                NombreCompleto = "Pedro Perez",
                Rfc = "PHP",
                Tipo = TipoCliente.Publico
            });
            clientes.Add(new clsClientes
            {
                idCliente = 3,
                Clave = "C003",
                NombreCompleto = "Maria Dominguez",
                Rfc = "DOHM",
                Tipo = TipoCliente.Medio
            });
            clientes.Add(new clsClientes
            {
                idCliente = 4,
                Clave = "C004",
                NombreCompleto = "Julia Salas",
                Rfc = "SAJJ",
                Tipo = (TipoCliente)2
            });
            clientes.Add(new clsClientes
            {
                idCliente = 5,
                Clave = "C005",
                NombreCompleto = "Patricia Fernandez",
                Rfc = "FEHP",
                Tipo = TipoCliente.Mayoreo
            });

            //clientes[0] = new clsClientes
            //{
            //    idCliente = 1,
            //    Clave = "C001",
            //    NombreCompleto = "Marcos Hernandez",
            //    Rfc = "HEHM",
            //    Tipo = TipoCliente.Publico
            //};
            //clientes[1] = new clsClientes
            //{
            //    idCliente = 2,
            //    Clave = "C002",
            //    NombreCompleto = "Pedro Perez",
            //    Rfc = "PHP",
            //    Tipo = TipoCliente.Publico
            //};
            //clientes[2] = new clsClientes
            //{
            //    idCliente = 3,
            //    Clave = "C003",
            //    NombreCompleto = "Maria Dominguez",
            //    Rfc = "DOHM",
            //    Tipo = TipoCliente.Medio
            //};
            //clientes[3] = new clsClientes
            //{
            //    idCliente = 5,
            //    Clave = "C005",
            //    NombreCompleto = "Patricia Fernandez",
            //    Rfc = "FEHP",
            //    Tipo = TipoCliente.Mayoreo
            //};
        }
        #endregion
    }
}
