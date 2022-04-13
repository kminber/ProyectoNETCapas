using Negocio.EntitiesDTO;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;


namespace Presentacion.Views
{
    public partial class AltaLibro : Form
    {
        public AltaLibro()
        {
            InitializeComponent();
        }


        public LibrosDTO libroModificado;

        public AltaLibro(LibrosDTO libro)
        {
            libroModificado = libro;
            InitializeComponent();
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (libroModificado is null != true)
            {
                libroModificado.nombre = txtNombre.Text;
                libroModificado.autor = txtAutor.Text;
                libroModificado.idCategoria = new Negocio.Management.LibroManagement().ObtenerCategorias().Where(b => b.nombre == cmdCategoria.Text).First().idCategoria;
                libroModificado.fechaPublicacion = DateTime.Now;

                new Negocio.Management.LibroManagement().ModificarLibro(libroModificado);
            }
            else
            {
                LibrosDTO libro = new LibrosDTO();
                libro.nombre = txtNombre.Text;
                libro.autor = txtAutor.Text;
                libro.idCategoria = new Negocio.Management.LibroManagement().ObtenerCategorias().Where(b => b.nombre == cmdCategoria.Text).First().idCategoria;
                libro.fechaPublicacion = DateTime.Now;

                new Negocio.Management.LibroManagement().AltaLibro(libro);
            }
            
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AltaLibro_Load(object sender, EventArgs e)
        {
            cmdCategoria.DataSource = new Negocio.Management.LibroManagement().ObtenerCategorias().Select(b => b.nombre).ToList();

            if (libroModificado is null != true)
            {
                txtNombre.Text = libroModificado.nombre;
                txtAutor.Text = libroModificado.autor;
                cmdCategoria.Text = new Negocio.Management.LibroManagement().ObtenerCategorias().Where(b => b.idCategoria == libroModificado.idCategoria).First().nombre;
            }

        }
    }
}
