using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppPosFarmacia.models
{
    public class ICiudadRepositorio
    {
        IEnumerable<CiudadCliente> CiudadCliente { get; }
    }
}
