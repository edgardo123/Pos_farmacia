using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppPosFarmacia.models
{
    public class MockCiudadClienteRepositorio: ICiudadRepositorio
    {
         
         

            public IEnumerable<CiudadCliente> CiudadCliente
        {
                get
                {
                    return new List<CiudadCliente>
{
            new CiudadCliente {CodigoCiudad=1,NombreCiudad="San Salvador",DescripcionCiudad="Capital de El salvador" },
            new CiudadCliente {CodigoCiudad=2,NombreCiudad="Santa Ana",DescripcionCiudad="Seunda Capital de El salvador" },
            new CiudadCliente {CodigoCiudad=3,NombreCiudad="La Libertad",DescripcionCiudad="Poblacion: 842 624  " },
            new CiudadCliente {CodigoCiudad=4,NombreCiudad="Chalatenango",DescripcionCiudad="Poblacion: 274 878" },
            new CiudadCliente {CodigoCiudad=5,NombreCiudad="Cabañas",DescripcionCiudad="Poblacion: 214 150" },
            new CiudadCliente {CodigoCiudad=6,NombreCiudad="San Miguel",DescripcionCiudad="Poblacion: 546 022" },
            new CiudadCliente {CodigoCiudad=7,NombreCiudad="San Vicente",DescripcionCiudad="Poblacion: 546 022" },
            new CiudadCliente {CodigoCiudad=8,NombreCiudad="La Paz",DescripcionCiudad="Poblacion: 288 022" },
            new CiudadCliente {CodigoCiudad=9,NombreCiudad="Usulutan",DescripcionCiudad="Poblacion: 464 883 " },
            new CiudadCliente {CodigoCiudad=10,NombreCiudad="Cuscatlan",DescripcionCiudad="Poblacion: 216 446" },
            new CiudadCliente {CodigoCiudad=11,NombreCiudad="La Union",DescripcionCiudad="Poblacion: 372 271" },
            new CiudadCliente {CodigoCiudad=12,NombreCiudad="Ahuachapan",DescripcionCiudad="Poblacion: 319 503" },
             new CiudadCliente {CodigoCiudad=13,NombreCiudad="Sonsonate",DescripcionCiudad="Poblacion: 518 522" },
              new CiudadCliente {CodigoCiudad=14,NombreCiudad="Morazan",DescripcionCiudad="Poblacion: 181 285" }

};
                }// fin del get
            }//fin del ienumerable
        }//fin de public class
    }
 
