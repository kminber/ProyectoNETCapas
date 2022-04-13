using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Negocio;

namespace PruebasUnitarias
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            try
            {
                Negocio.EntitiesDTO.LibrosDTO librosEjemplo = new Negocio.EntitiesDTO.LibrosDTO();
                librosEjemplo.nombre = "Prueba";
                librosEjemplo.autor = "Ejemplo";
                librosEjemplo.fechaPublicacion = DateTime.Now;
                librosEjemplo.idCategoria = 2;

                new Negocio.Management.LibroManagement().AltaLibro(librosEjemplo);

                //Para notificar que el test ha funcionado, se utiliza:
                Assert.IsTrue(true, "El alta ha sido correcta");
            }
            catch(Exception)
            {
                //Para notificar que el test ha dado un error, se utiliza:
                Assert.IsTrue(false, "El alta ha sido incorrecta");

                throw;
            }
        
        }
    }
}
