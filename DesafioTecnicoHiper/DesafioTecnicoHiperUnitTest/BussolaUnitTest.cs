using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesafioTecnicoHiperClassLibrary;

namespace DesafioTecnicoHiperUnitTest
{
    [TestClass]
    public class BussolaUnitTest
    {
        /// <summary>
        /// Teste da sequencia DDDDEEE
        /// Resultado deve ser LSONOSL
        /// </summary>
        [TestMethod]
        public void Sequencia01Test()
        {
            Bussola bussola = new Bussola();

            Assert.AreEqual("LSONOSL", bussola.DefineOrientacao("DDDDEEE"));
        }

        /// <summary>
        /// Teste da sequencia DDEEDED
        /// Resultado deve ser LSLNLNL 
        /// </summary>
        [TestMethod]
        public void Sequencia02Test()
        {
            Bussola bussola = new Bussola();

            Assert.AreEqual("LSLNLNL", bussola.DefineOrientacao("DDEEDED"));
        }

        /// <summary>
        /// Teste da sequencia EDDDDDE
        /// Resultado deve ser ONLSONO
        /// </summary>
        [TestMethod]
        public void Sequencia03Test()
        {
            Bussola bussola = new Bussola();

            Assert.AreEqual("ONLSONO", bussola.DefineOrientacao("EDDDDDE"));
        }

        /// <summary>
        /// Teste da sequencia EEDEED
        /// Resultado deve ser OSOSLS
        /// </summary>
        [TestMethod]
        public void Sequencia04Test()
        {
            Bussola bussola = new Bussola();

            Assert.AreEqual("OSOSLS", bussola.DefineOrientacao("EEDEED"));
        }
    }
}
