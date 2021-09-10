using Control;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestsPrision
{
    [TestClass]
    public class ActividadPracticaTest
    {
        ControlActividadPractica controlPractica = new ControlActividadPractica();
        /// <summary>
        /// CP-11
        /// </summary>
        [TestMethod]
        public void GuardarActividadCurricular_Exitoso()
        {
            var resultadoObtenido = controlPractica.GuardarActividadPractica(50, "Romper piedras", 1, "Taller");
            Assert.IsNotNull(resultadoObtenido);
        }
        /// <summary>
        /// CP-12
        /// </summary>
        [TestMethod]
        public void ConsultarActividadCurricular_Exitoso()
        {
            var resultadoObtenido = controlPractica.FiltrarDescripcionModalidad("Romper piedras", "Taller");
            Assert.IsNotNull(resultadoObtenido);
        }
        /// <summary>
        /// CP-13
        /// </summary>
        [TestMethod]
        public void EliminarActividadCurricular_Exitoso()
        {
            var resultadoObtenido = controlPractica.EliminarActividad("Romper piedras", "Taller");
            var resultadoEsperado = true;
            Assert.AreEqual(resultadoEsperado, resultadoObtenido);
        }
    }
}
