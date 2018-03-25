using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecimalNotation;

namespace DecimalNotation
{
    [TestFixture]
    public class TestDecNot
    {
        [TestCase("0110111101100001100001010111111",2, ExpectedResult = 934331071)]
        [TestCase("01101111011001100001010111111", 2, ExpectedResult = 233620159)]
        [TestCase("11101101111011001100001010111111", 2, ExpectedResult = 3991716543)]
        [TestCase("1AEF101", 2, ExpectedResult = 934331071)]
        [TestCase("1AEF101", 16, ExpectedResult = 28242177)]
        [TestCase("11111111111111111111111111111111000011", 2, ExpectedResult = 5)]
        public int TestMethod(string value,int Base)
        {
            int DecRes;
           DecRes= DecimalNotation.DecNot.ToDecimal(value, Base);
            return DecRes;
        }
    }
}
