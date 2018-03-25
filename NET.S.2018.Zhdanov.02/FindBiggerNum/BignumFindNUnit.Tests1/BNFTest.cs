using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BiggerNum;

namespace BiggerNum
{
    [TestFixture]
    public class BNFTest
    {[TestCase(12, ExpectedResult = 21)]
        [TestCase(513, ExpectedResult = 531)]
        [TestCase(2017, ExpectedResult = 2071)]
        [TestCase(414, ExpectedResult = 441)]
        [TestCase(144, ExpectedResult = 414)]      
        [TestCase(1234126, ExpectedResult = 1234162)]      
        [TestCase(10, ExpectedResult = -1)]
        [TestCase(20, ExpectedResult = -1)]
        public int FindNextBiggerNumber(int number)
        {
            return BiggerNum.BigNum.FindNextBiggerNumber(number);
        }

     

    }
}
