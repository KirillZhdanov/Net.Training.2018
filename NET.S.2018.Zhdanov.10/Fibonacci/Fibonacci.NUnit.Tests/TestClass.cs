﻿using NUnit.Framework;
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

        #region Init of first 2 element for Fibonacci
        /// <summary>
        /// In
        /// </summary>
        private long[] actual = { 0, 1 };
        #endregion
        #region Tests
        /// <summary>
        /// Test Fibonacci for 23 element's
        /// </summary>
        [Test]
        public void Test23Elements()
        {
            
            long[] expected = { 0,1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597, 2584, 4181, 6765, 10946, 17711 };
           
            int i =2;
            foreach (var item in FibGen.Generator().Take(21))
            {
                Array.Resize<long>(ref actual, i+1);
            
                actual[i] = item;
                i++;
               
            }
             Array.Resize<long>(ref actual, i);

            // TODO: Add your test code here
            CollectionAssert.AreEqual(expected,actual );
        }
        /// <summary>
        ///  Test Fibonacci for 10 element's
        /// </summary>
        [Test]
        public void Test10Elements()
        {

            long[] expected = { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34 };

            int i = 2;
            foreach (var item in FibGen.Generator().Take(8))
            {
                Array.Resize<long>(ref actual, i + 1);

                actual[i] = item;
                i++;

            }
            Array.Resize<long>(ref actual, i);

            // TODO: Add your test code here
            CollectionAssert.AreEqual(expected, actual);
        }
        /// <summary>
        ///  Test Fibonacci for 25 element's
        /// </summary>

        [Test]
        public void Test25Elements()
        {

            long[] expected = { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597, 2584, 4181, 6765, 10946, 17711,28657,46368 };

            int i = 2;
            foreach (var item in FibGen.Generator().Take(23))
            {
                Array.Resize<long>(ref actual, i + 1);

                actual[i] = item;
                i++;

            }
            Array.Resize<long>(ref actual, i);

            // TODO: Add your test code here
            CollectionAssert.AreEqual(expected, actual);
        }
        /// <summary>
        ///  Test Fibonacci for 86 element's
        /// </summary>
        [Test]
        public void Test86Elements()
        {

            long[] expected = { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597, 2584, 4181, 6765, 10946, 17711, 28657, 46368, 75025, 121393, 196418, 317811, 514229, 832040, 1346269, 2178309, 3524578, 5702887, 9227465, 14930352, 24157817, 39088169, 63245986, 102334155, 165580141, 267914296, 433494437, 701408733, 1134903170, 1836311903, 2971215073, 4807526976, 7778742049, 12586269025, 20365011074, 32951280099, 53316291173, 86267571272, 139583862445, 225851433717, 365435296162, 591286729879, 956722026041, 1548008755920, 2504730781961, 4052739537881, 6557470319842, 10610209857723, 17167680177565, 27777890035288, 44945570212853, 72723460248141, 117669030460994, 190392490709135, 308061521170129, 498454011879264, 806515533049393, 1304969544928657, 2111485077978050, 3416454622906707, 5527939700884757, 8944394323791464, 14472334024676221, 23416728348467685, 37889062373143906, 61305790721611591, 99194853094755497, 160500643816367088, 259695496911122585};

            int i = 2;
            foreach (var item in FibGen.Generator().Take(84))
            {
                Array.Resize<long>(ref actual, i + 1);

                actual[i] = item;
                i++;

            }
            Array.Resize<long>(ref actual, i);

            // TODO: Add your test code here
            CollectionAssert.AreEqual(expected, actual);
        }
        #endregion
    }
}
