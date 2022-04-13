using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Infraestructure;

namespace Datos.Repositories
{
    public class LibroRepository
    {
        public List<Libro> ObtenerLibros()
        {
            List<Libro> listaRetorno = new List<Libro>();

            try
            {
                using (var contexto = new BibliotecaEntities1())
                {
                    listaRetorno = contexto.Libros.ToList();
                }

                return listaRetorno;
            }
            catch
            {
                return listaRetorno;
            }
        }

        public List<ObtenerLibrosConUnidades_Result> ObtenerLibrosConUnidades()
        {
            List<ObtenerLibrosConUnidades_Result> listaRetorno = new List<ObtenerLibrosConUnidades_Result>();

            try
            {
                using (var contexto = new BibliotecaEntities1())
                {
                    listaRetorno = contexto.ObtenerLibrosConUnidades().ToList();
                }

                return listaRetorno;
            }
            catch
            {
                return listaRetorno;
            }
        }

        public List<Categoria> ObtenerCategorias()
        {
            List<Categoria> listaRetorno = new List<Categoria>();

            try
            {
                using (var contexto = new BibliotecaEntities1())
                {
                    listaRetorno = contexto.Categorias.ToList();
                }

                return listaRetorno;
            }
            catch
            {
                return listaRetorno;
            }
        }

        public void AltaLibro(Libro altaLibro)
        {
            //Abrir la BBDD a través de la conexión
            using (var contexto = new BibliotecaEntities1())
            {
                contexto.Libros.Add(altaLibro);
                contexto.SaveChanges(); //Commit de los cambios, es una confirmación
            }
        }

        public void ModificarLibro(Libro nuevoLibro)
        {
            try
            {
                //Abrir la BBDD a través de la conexión
                using (var contexto = new BibliotecaEntities1())
                {
                    Libro libroOriginal = contexto.Libros.Where(b => b.idLibro == nuevoLibro.idLibro).First();
                    libroOriginal.nombre = nuevoLibro.nombre;
                    libroOriginal.autor = nuevoLibro.autor;
                    libroOriginal.idCategoria = nuevoLibro.idCategoria;

                    //Para indicar a EntityFramework que la entidad que se ha capturado de la BBDD ha sido modificada:
                    contexto.Entry(libroOriginal).State = System.Data.Entity.EntityState.Modified;
                    contexto.SaveChanges();
                }
            }
            catch
            {
                throw;
            }
        }

        public void EliminarLibro(Int32 idLibro)
        {
            //Abrir la BBDD a través de la conexión
            using (var contexto = new BibliotecaEntities1())
            {
                //Creo una lista con los libros con unidades que han sido seleccionados
                List<LibrosUnidade> libroConUnidades = contexto.LibrosUnidades.Where(b => b.idLibro == idLibro).ToList();

                Libro libroEliminar = contexto.Libros.Where(b => b.idLibro == idLibro).First();

                if(libroConUnidades.Count > 0)
                {
                    contexto.LibrosUnidades.RemoveRange(libroConUnidades); //Elimina un listado de registros
                    contexto.Entry(libroEliminar).State = System.Data.Entity.EntityState.Deleted;
                    contexto.SaveChanges();
                }
                else
                {
                    //Para indicar a EntityFramework que la entidad que se ha capturado de la BBDD ha sido modificada:
                    contexto.Entry(libroEliminar).State = System.Data.Entity.EntityState.Deleted;
                    contexto.SaveChanges();
                }            
            }
        }

        public Boolean VerificarUnidades(Int32 idLibro)
        {
            List<LibrosUnidade> libroConUnidades = new List<LibrosUnidade>();

            using (var contexto = new BibliotecaEntities1())
            {
                libroConUnidades = contexto.LibrosUnidades.Where(b => b.idLibro == idLibro).ToList();
            }

            if(libroConUnidades.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}

