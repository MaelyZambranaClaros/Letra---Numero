using Microsoft.VisualStudio.TestTools.UnitTesting;
using Numero_Letra.Controllers;

namespace UnitTestNumero_Letra
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestNumeroALetras()
        {
            //Arrange
            LiteralController literalController = new LiteralController();
            int a = 5;
            string esperado = "CINCO";

            //Act
            string resultado = literalController.LiteralGet(a);

            //Assert
            Assert.AreEqual(esperado, resultado);
        }
    }
}
