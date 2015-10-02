using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Treinamento_Benner.Tests
{
    [TestClass]
    public class SequenciaFibonacciTest
    {
        [TestMethod]
        public void OPrimeiroElementoDaSequenciaDeveSer0()
        {
            Assert.AreEqual(0, Fibonacci.Elemento(0));
        }
        [TestMethod]
        public void OSegundoElementoDaSequenciaDeveSer1()
        {
            Assert.AreEqual(1, Fibonacci.Elemento(1));
        }
        [TestMethod]
        public void OTerceiroElementoDaSquenciaDeveSer1()
        {
            Assert.AreEqual(1, Fibonacci.Elemento(2));
        }

        [TestMethod]
        public void OQuartoElementoDaSequenciaDeveSer2()
        {
            Assert.AreEqual(2, Fibonacci.Elemento(3));
        }
    }
}
