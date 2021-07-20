using Control;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;

namespace TestPrision
{
    [TestClass]
    public class UsuarioTest
    {
        
        [TestMethod]
        public void GuardarUsuario_DeberiaRetornarTrue()
        {
            
            var controlUsuario = new ControladorUsuario();
            //Arrange
            //var resultadoObtenido = controlUsuario.prueba();
            var resultadoObtenido =controlUsuario.GuardarUsuario("Miguel Alejandro", "Jaramillo Vazquez", "miguel23", "strong10", "Administrador");
            Console.WriteLine(resultadoObtenido);
            var resultadoEsperado = true;
            //Assert
            Assert.AreEqual(resultadoEsperado, resultadoObtenido);
        }
        [TestMethod]
        public void ValidarLogin_DeberiaRetornaTrue()
        {
            var controlUsuario = new ControladorUsuario();
            var actual = controlUsuario.validarLogin("daniel08", "junio2000");
     
            Assert.IsTrue(actual);
        }
    }
}
 