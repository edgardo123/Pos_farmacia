using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppPosFarmacia.models
{
    public interface IClientesRepositorio
    {
        IEnumerable<Clientes> Clientes { get; }

        Clientes GetClientesPorId(int IdCliente);


    }  
}
