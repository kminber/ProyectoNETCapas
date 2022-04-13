using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Infraestructure;

namespace Datos.Repositories
{
    public class PruebaDeConexion
    {
        public Boolean ProbarConexion()
        {
            try
            {   
                //Abro la conexión con la BBDD usando la instrucción "using"
                using (var contexto = new BibliotecaEntities1()) 
                //Se crea una nueva instancia de la conexión y se guarda en contexto
                {
                    List<Libro> librosRetorno = contexto.Libros.ToList();
                }

                return true;
            }
            catch(Exception)
            {
                return false;
                throw;
            }
        }
    }
}
