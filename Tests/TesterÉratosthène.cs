using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Microsoft.VisualStudio.TestTools.UnitTesting.CollectionAssert;

namespace Prog2
{
    [TestClass]
    public class TesterÉratosthène
    {
        [TestMethod]
        public void _01_Ératosthène ()
        {
            AreEqual(new int[0], Crible.Ératosthène(1));
            AreEqual(new int[] { 2 }, Crible.Ératosthène(2));
            AreEqual(new int[] { 2, 3 }, Crible.Ératosthène(4));
            AreEqual(new int[] { 2, 3, 5, 7, 11, 13, 17, 19 }, Crible.Ératosthène(20));
            AreEqual(new int[] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 },
                Crible.Ératosthène());
            Assert.AreEqual(997, Crible.Ératosthène(1000).Last());
            Assert.AreEqual(9973, Crible.Ératosthène(10000).Last());
            Assert.AreEqual(99991, Crible.Ératosthène(100000).Last());
        }
    }
}
