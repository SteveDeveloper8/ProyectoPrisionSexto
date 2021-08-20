using Control;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestsPrision
{
    [TestClass]
    public class ReclusoTest
    {
        ControlRecluso controlRecluso = new ControlRecluso();
        [TestMethod]
        //Prueba que al guardar un recluso devuelve true.
        public void GuardarRecluso_Exitoso()
        {
            var resultadoObtenido = controlRecluso.GuardarRecluso("HFHD-7582", "Alejandro Manuel", "Maldonado Perez", "Masculino", Convert.ToDateTime("08/07/1987"), 8, "0910126713");
            var resultadoEsperado = true;
            Assert.AreEqual(resultadoEsperado, resultadoObtenido);
        }


        [TestMethod]
        //Prueba que al buscar  una lista de cargos existente a partir del codigo del recluso devuelva una lista de objetos
        public void ListarCargos_Exitoso()
        {
            var resultadoObtenido = controlRecluso.ListarCargos("8965-58");
            Assert.IsNotNull(resultadoObtenido);
        }



        //Prueba que al buscar un recluso existente devuelva un objeto.
        [TestMethod]
        public void BuscarRecluso_Exitoso()
        {
            var resultadoObtenido = controlRecluso.BuscarRecluso("0953238789");
            Assert.IsNotNull(resultadoObtenido);
        }
    }
}
