using Control;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data.SqlClient;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ControladorUsuario controlUsuario = new ControladorUsuario();
            //Arrange
            Console.WriteLine("entra");
            var resultadoObtenido = controlUsuario.prueba();/*controlUsuario.GuardarUsuario("Miguel Alejandro", "Jaramillo Vazquez", "miguel23", "strong10", "Administrador");*/
      
            var resultadoEsperado = true;
            //Assert
            Assert.AreEqual(resultadoEsperado, resultadoObtenido);
        }
    }
}
