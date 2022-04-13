using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Repositories;    //Para hacer la llamada a los métodos del repositorio
using Datos.Infraestructure; //Para acceder a la infraestructura de los tipos de datos
using Negocio.EntitiesDTO;   //Para devolver el tipo de dato de las entidades

namespace Negocio.Management
{
    public class LibroManagement
    {
        public List<LibrosDTO> ObtenerLibros()
        {
            List<Libro> LibrosDatos = new Datos.Repositories.LibroRepository().ObtenerLibros();
            List<LibrosDTO> ListadoRetorno = new List<LibrosDTO>();

            //Proceso de mapeo
            foreach (var item in LibrosDatos)
            {
                var dto = new LibrosDTO();

                //dto.idLibro = item.idLibro;
                //dto.nombre = item.nombre;
                //dto.autor = item.autor;
                //dto.fechaPublicacion = item.fechaPublicacion;
                //dto.idCategoria = item.idCategoria;

                Negocio.Utils.parse(item, ref dto);
                ListadoRetorno.Add(dto);
            }
            return ListadoRetorno;
        }

        public List<LibroConUnidadesDTO> ObtenerLibrosConUnidades()
        {
            List<ObtenerLibrosConUnidades_Result> LibrosDatos = new Datos.Repositories.LibroRepository().ObtenerLibrosConUnidades();
            List<LibroConUnidadesDTO> ListadoRetorno = new List<LibroConUnidadesDTO>();

            //Proceso de mapeo
            foreach (var item in LibrosDatos)
            {
                var dto = new LibroConUnidadesDTO();
                Negocio.Utils.parse(item, ref dto);
                ListadoRetorno.Add(dto);
            }
            return ListadoRetorno;
        }

        public List<CategoriasDTO> ObtenerCategorias()
        {
            List<Categoria> CategoriasDatos = new Datos.Repositories.LibroRepository().ObtenerCategorias();
            List<CategoriasDTO> ListadoRetorno = new List<CategoriasDTO>();

            //Proceso de mapeo
            foreach (var item in CategoriasDatos)
            {
                var dto = new CategoriasDTO();
                Negocio.Utils.parse(item, ref dto);
                ListadoRetorno.Add(dto);
            }
            return ListadoRetorno;
        }

        public void AltaLibro(LibrosDTO altaLibro)
        {
            Libro LibroBBDD = new Libro();

            Negocio.Utils.parse(altaLibro, ref LibroBBDD);

            new Datos.Repositories.LibroRepository().AltaLibro(LibroBBDD);
        }

        public void ModificarLibro(LibrosDTO libroModificado)
        {
            Libro LibroBBDD = new Libro();

            Negocio.Utils.parse(libroModificado, ref LibroBBDD);

            new Datos.Repositories.LibroRepository().ModificarLibro(LibroBBDD);
        }

        public void EliminarLibro(LibrosDTO eliminarLibro)
        {
            new Datos.Repositories.LibroRepository().EliminarLibro(eliminarLibro.idLibro);
        }

        public Boolean VerificarUnidades(Int32 idLibro)
        {
            return new Datos.Repositories.LibroRepository().VerificarUnidades(idLibro);
        }

    }
}

