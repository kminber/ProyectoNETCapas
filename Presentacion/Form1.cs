using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Presentacion.Views;

namespace Presentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPrueba_Click(object sender, EventArgs e)
        {

            if (new Negocio.Management.PruebaDeConexion().PruebaDeConexionNegocio())
            {
                lblResultado.Text = "La conexión es correcta";
            }
            else
            {
                lblResultado.Text = "La conexión es fallida";
            }

            lblResultado.Visible = true;

        }

        private void btnModificacionLibros_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                Negocio.EntitiesDTO.LibrosDTO LibroSeleccionado = dataGridView1.CurrentRow.DataBoundItem as Negocio.EntitiesDTO.LibrosDTO;
                AltaLibro pantallaAlta = new AltaLibro(LibroSeleccionado); //Con el parámetro se llama al otro constructor
                pantallaAlta.ShowDialog();
                dataGridView1.DataSource = new Negocio.Management.LibroManagement().ObtenerLibros();
            }             
        }

        private void btnAltaLibros_Click(object sender, EventArgs e)
        {
            AltaLibro pantallaAlta = new AltaLibro(); //Crear instancia de la nueva ventana
            pantallaAlta.ShowDialog(); //Abre la ventana del formulario de alta de libros y bloquea lo que haya por detrás
            dataGridView1.DataSource = new Negocio.Management.LibroManagement().ObtenerLibros();
        }

        private void btnEliminacionLibros_Click(object sender, EventArgs e)
        {
            if(dataGridView1.Rows.Count > 0)
            {
                Negocio.EntitiesDTO.LibrosDTO LibroSeleccionado = dataGridView1.CurrentRow.DataBoundItem as Negocio.EntitiesDTO.LibrosDTO;

                if(new Negocio.Management.LibroManagement().VerificarUnidades(LibroSeleccionado.idLibro))
                {
                    DialogResult Respuesta = MessageBox.Show("Este libro contiene unidades" + System.Environment.NewLine + "¿Estás seguro de querer eliminarlo?", "Validación", MessageBoxButtons.YesNo);

                    if(Respuesta == DialogResult.Yes)
                    {
                        new Negocio.Management.LibroManagement().EliminarLibro(LibroSeleccionado);
                    }
                }
                else
                {
                    new Negocio.Management.LibroManagement().EliminarLibro(LibroSeleccionado);
                }             
                dataGridView1.DataSource = new Negocio.Management.LibroManagement().ObtenerLibros();
            }         
        }

        private void btnConsultaDeLibros_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new Negocio.Management.LibroManagement().ObtenerLibros();
        }

        private void btnConsultaDeLibrosUnidades_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new Negocio.Management.LibroManagement().ObtenerLibrosConUnidades();
        }
    }
}
