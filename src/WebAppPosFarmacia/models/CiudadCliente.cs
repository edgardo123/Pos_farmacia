using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebAppPosFarmacia.models
{
    public class CiudadCliente
    {
        [Key]
        public int CodigoCiudad { get; set; }

        public string NombreCiudad { get; set; }

        public string  DescripcionCiudad { get; set; }

        public List<Clientes> Clientes { get; set; }

    }
}
