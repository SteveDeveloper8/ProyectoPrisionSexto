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

        /// <summary>
        /// CP-05
        /// </summary>
        [TestMethod]
        public void GuardarUsuario_Exitoso()
         {
             var resultadoObtenido = controlUsuario.GuardarUsuario("Jose Andres", "Jimenez Mora", "Jose1997", "1234Jose", "Administrador");
             var resultadoEsperado = true;
             Assert.AreEqual(resultadoEsperado, resultadoObtenido);
         }
        /// <summary>
        /// CP-01
        /// </summary>
        [TestMethod]
        public void ValidarLogin_Exitoso()
         {
             var resultadoObtenido = controlUsuario.validarLogin("daniel08","junio2000");
             var resultadoEsperado = true;
             Assert.AreEqual(resultadoEsperado, resultadoObtenido);
         }
        /// <summary>
        /// CP-06
        /// </summary>
        [TestMethod]
        public void BuscarUsuario_Exitoso()
        {
            var resultadoObtenido = controlUsuario.BuscarUsuario("daniel08");
            Assert.IsNotNull(resultadoObtenido);
        }
        /// <summary>
        /// CP-07
        /// </summary>
        [TestMethod]
        public void ActualizarUsuario_Exitoso()
        {
            var resultadoObtenido = controlUsuario.ActualizarUsuario("Jose Andres", "Jimenez Mora", "Jose1997", "paycoca34", "Administrador");
            var resultadoEsperado = true;
            Assert.AreEqual(resultadoEsperado, resultadoObtenido);
        }
    }
}
