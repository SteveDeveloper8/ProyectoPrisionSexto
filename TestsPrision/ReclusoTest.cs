﻿using Control;
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
        /// <summary>
        /// CP-02
        /// </summary>
        [TestMethod]
        public void GuardarRecluso_Exitoso()
        {
            var resultadoObtenido = controlRecluso.GuardarRecluso("HFHD-7582", "Alejandro Manuel", "Maldonado Perez", "Masculino", Convert.ToDateTime("08/07/1987"), 8, "0910126713");
            var resultadoEsperado = true;
            Assert.AreEqual(resultadoEsperado, resultadoObtenido);
        }

        /// <summary>
        /// CP-03
        /// </summary>
        [TestMethod]
        public void ListarCargos_Exitoso()
        {
            var resultadoObtenido = controlRecluso.ListarCargos("8965-58");
            Assert.IsNotNull(resultadoObtenido);
        }
        /// <summary>
        /// CP-04
        /// </summary>
        [TestMethod]
        public void BuscarRecluso_Exitoso()
        {
            var resultadoObtenido = controlRecluso.BuscarRecluso("0953238789");
            Assert.IsNotNull(resultadoObtenido);
        }
    }
}
