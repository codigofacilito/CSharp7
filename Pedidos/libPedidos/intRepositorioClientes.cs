using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libPedidos
{
    interface intRepositorioClientes
    {
        void ObtenClientes(List<clsClientes> clientes);
        void AgregaCliente(clsClientes cliente);
        void ModificaCliente(clsClientes cliente);
        void EliminaCliente(clsClientes cliente);
    }
}
