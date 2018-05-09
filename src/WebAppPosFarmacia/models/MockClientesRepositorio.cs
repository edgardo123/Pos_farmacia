using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppPosFarmacia.models
{
    public class MockClientesRepositorio: IClientesRepositorio
    {
        private readonly ICiudadRepositorio _ciudadRepositorio = new MockCiudadClienteRepositorio();

        public IEnumerable<Clientes> Clientes
        {
            get
            {
                return new List<Clientes>
                {
                    new Clientes {IdCliente = 1, NombreCliente = "Carlos Antonio", ApellidoCliente = "Lopez Acosta", TelefonoCliente =23456789 , EmailCliente = "@carlos", GeneroCliente = "M", CodigoCiudad  = 1 },
                    new Clientes {IdCliente = 2, NombreCliente = "Eduardo Antonio", ApellidoCliente = "Barias Ramirez", TelefonoCliente =23556788 , EmailCliente = "@ramirez", GeneroCliente = "M", CodigoCiudad  = 12 },
                    new Clientes {IdCliente = 3, NombreCliente = "José Angel", ApellidoCliente = "Franco Hernandez", TelefonoCliente =23058779 , EmailCliente = "@franco", GeneroCliente = "M", CodigoCiudad  = 13 },
                    new Clientes {IdCliente = 4, NombreCliente = "Carlos Edenilson", ApellidoCliente = "Paredes Machado", TelefonoCliente =23006744 , EmailCliente = "@paredes", GeneroCliente = "M", CodigoCiudad  = 14 },
                    new Clientes {IdCliente = 5, NombreCliente = "Reyna Maria", ApellidoCliente = "Henrriquez Lopez", TelefonoCliente =23116789 , EmailCliente = "@lopez", GeneroCliente = "F", CodigoCiudad  = 11 },
                    new Clientes {IdCliente = 6, NombreCliente = "Manuel de Jesus", ApellidoCliente = "Martines de la O", TelefonoCliente =22256709 , EmailCliente = "@martinez", GeneroCliente = "M", CodigoCiudad  = 10 },
                    new Clientes {IdCliente = 7, NombreCliente = "Edwin Alexis", ApellidoCliente = "Menjivar Leiva", TelefonoCliente =23156723 , EmailCliente = "@leiva", GeneroCliente = "M", CodigoCiudad  = 6 },
                    new Clientes {IdCliente = 8, NombreCliente = "Jose Antonio", ApellidoCliente = "Hernandez Hernandez", TelefonoCliente =23456714 , EmailCliente = "@hernandez", GeneroCliente = "M", CodigoCiudad  = 4 },
                    new Clientes {IdCliente = 9, NombreCliente = "Kevin Aparicio", ApellidoCliente = "Angel Ramiurez", TelefonoCliente =23756759 , EmailCliente = "@carlosangel", GeneroCliente = "M", CodigoCiudad  = 3 },
                    new Clientes {IdCliente = 10, NombreCliente = "Andino Jose", ApellidoCliente = "Mejia Leiva", TelefonoCliente =23556924 , EmailCliente = "@andino", GeneroCliente = "M", CodigoCiudad  = 2}
    };
            }//fin de get
        }//fin de  IEnumerable productos
        public IEnumerable<Clientes>ClientesFrecuentes { get; }
        public Clientes GetClientesPorId(int IdCliente)
        {
            throw new System.NotImplementedException();
        }
    }//fin public class
}

        
 
   
     
 
 
