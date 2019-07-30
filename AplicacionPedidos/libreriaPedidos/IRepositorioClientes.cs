using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libreriaPedidos
{
    interface IRepositorioClientes
    {
        void ObtenClientes(ref List<clsClientes> clientes);
        void ObtenCliente(clsClientes cliente);
        void CreaCliente(clsClientes cliente);
        void ModificaCliente(clsClientes cliente);
        void EliminaCliente(clsClientes cliente);
    }
}
