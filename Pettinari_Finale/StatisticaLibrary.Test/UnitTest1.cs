using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StatisticaLibrary.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int num = 7;
            bool risposta = true;

            bool positivo = Statistica.IsPositivo(num);
            Assert.AreEqual(risposta, positivo);

        }

        [TestMethod]
        public void TestMethod2()
        {
            int num = -7;
            bool risposta = false;

            bool positivo = Statistica.IsPositivo(num);
            Assert.AreEqual(risposta, positivo);

        }

        [TestMethod]
        public void TestMethod3()
        {
            int[] array = new int[] { 6, 5, -12, -33, 77 };
            int numero = 3;

            int pos = Statistica.ContaPositivi(array);
            Assert.AreEqual(numero, pos);

        }

        [TestMethod]
        public void TestMethod4()
        {
            int[] array = new int[] { 4, -3, -12, -33, -77 };
            int numero = 1;

            int pos = Statistica.ContaPositivi(array);
            Assert.AreEqual(numero, pos);

        }

        [TestMethod]
        public void TestMethod5()
        {
            int[] array = new int[] { 6, 5, -12, -33, 77 };
            int[] positivo = new int[] { 6, 5, 77 };

            int[] pos = Statistica.Positivi(positivo);
            CollectionAssert.AreEqual(positivo, pos);

        }

        [TestMethod]
        public void TestMethod6()
        {
            int[] array = new int[] { -6, -5, -12, -33, 77 };
            int[] positivo = { 77 };

            int[] pos = Statistica.Positivi(positivo);
            CollectionAssert.AreEqual(positivo, pos);

        }
    }
}
