using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace WebAppPosFarmacia.models
{
    public class AppDBContext: DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options): base (options)
        {

        }//fin del constructor
        public DbSet<CiudadCliente> CiudadCliente { get; set; }
        public DbSet<Clientes> Clientes { get; set; }
    }
}
