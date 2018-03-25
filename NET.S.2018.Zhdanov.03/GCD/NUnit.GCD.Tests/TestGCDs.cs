using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GCD;

namespace GCD
{
    [TestFixture]
    public class TestGCDsbyEuclid
    {
        [TestCase(1440, 264,188,16, ExpectedResult = 4)]
        [TestCase(1440, 12, ExpectedResult = 12)]
        public int GCDbyEuclidean(params int[] values)
        {
            return GCD.SearchingOfGCD.GetGcdByEuclideanAlgorithm(values);
        }

    }
    [TestFixture]
    public class TestGCDsbyStain
    {
        [TestCase(1440, 264, 188, 16, ExpectedResult = 4)]
        [TestCase(1440, 12, ExpectedResult = 12)]
        public int GCDbyEuclidean(params int[] values)
        {
            return GCD.SearchingOfGCD.GetGcdByStainAlgorithm(values);
        }

    }
}
