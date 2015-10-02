using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Treinamento_Benner.Tests
{
    [TestClass]
   public class StringHelperTest
    {
        [TestMethod]
        public void RegraPadrao()
        {
            Assert.AreEqual("Bolas", "Bola".ToPlural());
        }
        [TestMethod]
        public void RegraQuantoTemTrocarParaTemComAcento()
        {
            Assert.AreEqual("têm", "tem".ToPlural());
        }
        [TestMethod]
        public void RegraQuantoFinalElTrocarPorEis()
        {
            Assert.AreEqual("cartéis", "cartel".ToPlural());
        }

        [TestMethod]
        public void RegraQuantoDoisTresSeisOuDezNaoFazNada()
        {
            Assert.AreEqual("três", "três".ToPlural());
            Assert.AreEqual("dois", "dois".ToPlural());
        }

        [TestMethod]
        public void RegraQuantoTerminadoEmEsTrocarPorEses()
        {
            Assert.AreEqual("meses", "mês".ToPlural());
        }

        [TestMethod]
        public void RegraQuantoPalavraForExisteAdicionarM()
        {
            Assert.AreEqual("existem", "existe".ToPlural());
        }

        [TestMethod]
        public void RegraQuandoTerminadoEmAOTrocarPorOES()
        {
            Assert.AreEqual("piões", "pião".ToPlural());
        }
    }
}
