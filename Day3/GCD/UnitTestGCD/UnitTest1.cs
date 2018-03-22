using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GCD;

namespace GCD
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void EqualityOfMethods()
        {
            int stainsresult,euclideanresult;
            euclideanresult = SearchingOfGCD.GetGcdByEuclideanAlgorithm(144, 20,40,36);
            stainsresult = SearchingOfGCD.GetGcdByStainAlgorithm(144, 20,40,36);
            Assert.AreEqual(stainsresult, euclideanresult);

        }
    }
}
