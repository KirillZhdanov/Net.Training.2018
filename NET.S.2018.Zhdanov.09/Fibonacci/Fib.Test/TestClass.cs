using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fibonacci;

namespace Fib.NUnit.Tests
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void TestMethod()
        {
           int [] actual= Fibonacci.FibGen.Generator(18000);
            int[] expected = { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597, 2584, 4181, 6765, 10946, 17711 };





            // TODO: Add your test code here
            CollectionAssert.AreEqual(actual,expected );
        }
    }
}
