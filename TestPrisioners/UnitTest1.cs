using Control;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestPrisioners
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            
                var controlUsuario = new ControladorUsuario();
                //Arrange
                var resultadoObtenido = controlUsuario.GuardarUsuario("Miguel Alejandro", "Jaramillo Vazquez", "miguel23", "strong10", "Administrador");
                var resultadoEsperado = true;
                //Assert
                Assert.AreEqual(resultadoEsperado, resultadoObtenido);
            
        }
    }
}
