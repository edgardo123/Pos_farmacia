using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace WebAppPosFarmacia.models
{
    public class Clientes
    {
        [Key]
        public int IdCliente { get; set; }

        public string NombreCliente { get; set; }

        public string ApellidoCliente { get; set; }

        public int  TelefonoCliente { get; set; }

        public string EmailCliente{ get; set; }

        public string GeneroCliente { get; set; }

        public int CodigoCiudad { get; set; }

        

        public virtual CiudadCliente CiudadCliente  { get; set; }
    }
}
