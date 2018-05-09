using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;//operaciones con las conexiones

namespace WebAppPosFarmacia.models
{
    public class CiudadClientesRepositorio: ICiudadClientesRepositorio
    {
        private readonly AppDBContext _appDBContext;

        //metodo constructor
        public CiudadClientesRepositorio(AppDBContext appDBContext)
        {
            _appDBContext = appDBContext;
        }//fin metodo constructor

        //extensiones de los metodos disponibles en la clase interface
        public IEnumerable<CiudadCliente> CiudadCliente => _appDBContext.CiudadCliente;

    }
}
