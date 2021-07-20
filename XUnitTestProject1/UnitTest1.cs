using Control;
using System;
using Xunit;


using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var controlUsuario = new ControladorUsuario();
            //Arrange
            //var resultadoObtenido = controlUsuario.prueba();
            var resultadoObtenido = controlUsuario.GuardarUsuario("Miguel Alejandro", "Jaramillo Vazquez", "miguel23", "strong10", "Administrador");
            Console.WriteLine(resultadoObtenido);

            //Assert
            Assert.True(resultadoObtenido);

        }
    }
}
