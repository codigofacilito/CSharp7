using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libPedidos
{
    public class clsRepositorioClientes : intRepositorioClientes
    {
        public void AgregaCliente(clsClientes cliente)
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

        public void ObtenClientes(List<clsClientes> clientes)
        {
            clientes.Clear();
            clientes.Add(
                new clsClientes { idCliente = 1, Clave = "C001", NombreCompleto = "Marcos Hernandez",
                    Rfc = "HEHM", Tipo = TipoCliente.Publico });
            clientes.Add(
                new clsClientes
                {
                    idCliente = 2,
                    Clave = "C002",
                    NombreCompleto = "Pedro Perez",
                    Rfc = "PHP",
                    Tipo = TipoCliente.Publico
                });
            clientes.Add(
                new clsClientes { idCliente = 3, Clave = "C003", NombreCompleto = "Maria Dominguez",
                    Rfc = "DOHM", Tipo = TipoCliente.Medio });
            clientes.Add(
                new clsClientes { idCliente = 4, Clave = "C004", NombreCompleto = "Julia Salas",
                    Rfc = "SAJJ", Tipo = (TipoCliente)2 });
            clientes.Add(
                new clsClientes
                {
                    idCliente = 5,
                    Clave = "C005",
                    NombreCompleto = "Patricia Fernandez",
                    Rfc = "FEHP",
                    Tipo = TipoCliente.Mayoreo
                });
        }
    }
}
