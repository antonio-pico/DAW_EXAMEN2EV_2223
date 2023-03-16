using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LotoClassNS;

namespace LotoTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestMethod]
        public void ValidarLotoMenor()
        {
            bool esperado = false;

            int[] misNums = new int[6];
            misNums[0] = 0;
            misNums[1] = 2;
            misNums[2] = 3;
            misNums[3] = 4;
            misNums[4] = 5;
            misNums[5] = 6;

            loto loteria = new loto(misNums);

            Assert.AreEqual(esperado, loteria.CombinacionValida, "Número menor de 1");

        }

        [TestMethod]
        public void ValidarLotoMayor()
        {
            bool esperado = false;

            int[] misNums = new int[6];
            misNums[0] = 50;
            misNums[1] = 2;
            misNums[2] = 3;
            misNums[3] = 4;
            misNums[4] = 5;
            misNums[5] = 6;

            loto loteria = new loto(misNums);

            Assert.AreEqual(esperado, loteria.CombinacionValida, "Número mayor de 49");

        }

        [TestMethod]
        public void ValidarLotoCorrecto()
        {
            bool esperado = true;

            int[] misNums = new int[6];
            misNums[0] = 1;
            misNums[1] = 2;
            misNums[2] = 3;
            misNums[3] = 4;
            misNums[4] = 5;
            misNums[5] = 6;

            loto loteria = new loto(misNums);

            Assert.AreEqual(esperado, loteria.CombinacionValida, "Número incorrecto");

        }

        [TestMethod]
        public void ValidarLotoNumRepetido()
        {
            bool esperado = false;

            int[] misNums = new int[6];
            misNums[0] = 1;
            misNums[1] = 1;
            misNums[2] = 3;
            misNums[3] = 4;
            misNums[4] = 5;
            misNums[5] = 6;

            loto loteria = new loto(misNums);

            Assert.AreEqual(esperado, loteria.CombinacionValida, "Número repetido");

        }

    }
}
