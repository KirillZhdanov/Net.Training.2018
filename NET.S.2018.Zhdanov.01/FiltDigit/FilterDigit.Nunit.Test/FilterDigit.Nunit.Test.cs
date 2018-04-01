using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FDGT;

namespace FDGT
{
    [TestFixture]
    public class TestClass
    {
        
        [Test]
        public void TestMethod()
        {
            int[] arr = {2,10,3,11,17,81,471,692,537,825,491 };
            int[] expected = { 10,11,17,81,471,491};
           int digit = 1;
           int[] actual= FiltDigit.Fit.Fitd(arr,digit);
           
            Assert.AreEqual(expected,actual);
        }

        [Test]
        public void TestMethod1()
        {
            int[] arr = { 2, 10, 3, 11, 17, 81, 471, 692, 537, 825, 491 };
            int[] expected = {2,692,825 };
            int digit = 2;
            int[] actual = FiltDigit.Fit.Fitd(arr, digit);
            
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestMethod2()
        {
            int[] arr = { 2, 10, 3, 11, 17, 81, 471, 692, 537, 825, 491 };
            int[] expected = { 3,537 };
            int digit = 3;
            int[] actual = FiltDigit.Fit.Fitd(arr, digit);
           
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestMethod3()
        {
            int[] arr = { 2, 10, 3, 11, 17, 81, 471, 692, 537, 825, 491 };
            int[] expected = { 471,491 };
            int digit = 4;
            int[] actual = FiltDigit.Fit.Fitd(arr, digit);
           
            Assert.AreEqual(expected, actual);
        }
    }
}
