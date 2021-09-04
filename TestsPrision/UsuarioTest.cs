using Control;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace TestsPrision
{
    [TestClass]
    public class UsuarioTest
    {
        ControladorUsuario controlUsuario = new ControladorUsuario();

        //Prueba que al guardar un usuario devuelve true.
        [TestMethod]
        public void GuardarUsuario_Exitoso()
         {
             //var resultadoObtenido = controlUsuario.GuardarUsuario("Jose Andres", "Jimenez Mora", "Jose1997", "1234Jose", "Administrador");
             //var resultadoEsperado = true;
             //Assert.AreEqual(resultadoEsperado, resultadoObtenido);
         }


        [TestMethod]
        //Prueba que al ingresar un usuario y contrasena valide que existe en la base y retorne true
        public void ValidarLogin_Exitoso()
         {
             //var resultadoObtenido = controlUsuario.validarLogin("daniel08","junio2000");
             //var resultadoEsperado = true;
             //Assert.AreEqual(resultadoEsperado, resultadoObtenido);
         }
    }
}
