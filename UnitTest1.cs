using Microsoft.VisualStudio.TestTools.UnitTesting;
using SistemaGestionEstudiantil;
using System;
using System.Collections.Generic;

namespace SistemaGestionEstudiantil.Tests
{
    [TestClass()]
    public class UnitTest1
    {

        string id = "23423";
        string sexo = "Mascilino";
        string nombre = "Juanito";
        string gradoAcursar = "Noveno";
        string promedio = "4.5";
        string direccion = "Calle siempre viva";
        Acudiente abuela = new Acudiente("123", "Femenino", "Mariela", "4214911", "Abuela");

        Estudiante pepeprueba = new Estudiante();

        List<Estudiante> ListEstudiantes = new List<Estudiante>();
        


        [TestMethod()]
        public void matricularUnEstudianteTest()  // Funciona 

        {
            pepeprueba.matricularUnEstudiante(id, sexo, nombre, gradoAcursar, promedio, direccion, abuela);

            Assert.IsNotNull(pepeprueba);
        }

        [TestMethod()]
        public void modificarDatosEstudianteTest()   // Esta se queda cargando 
        {
            List<Estudiante> ListEstudiantes = new List<Estudiante>();
            pepeprueba.matricularUnEstudiante(id, sexo, nombre, gradoAcursar, promedio, direccion, abuela);
            ListEstudiantes.Add(pepeprueba);

            // Modifica el id de pepeprueba que es 23423 a 1032 

            pepeprueba.modificarDatosEstudiante(ListEstudiantes);


            Assert.AreEqual(pepeprueba.Id,1032);

        }
    }
}

