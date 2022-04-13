using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Management
{
    public class PruebaDeConexion
    {
        public Boolean PruebaDeConexionNegocio()
        {
            return new Datos.Repositories.PruebaDeConexion().ProbarConexion();
        }
    }
}
