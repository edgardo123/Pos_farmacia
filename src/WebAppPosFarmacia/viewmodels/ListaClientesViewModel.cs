using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppPosFarmacia.models;

namespace WebAppPosFarmacia.viewmodels
{
    public class ListaClientesViewModel
    {
        public IEnumerable<Clientes> Clientes { get; set; }

        public string CiudadCliente { get; set; }
    }
}
