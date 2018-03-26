using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JagArr;



namespace Jagged
{
    
    [TestFixture]
    public class TestJagg
    {
        [Test]
        public void TestSumIncrease()
        {
            int row = 3;
            int[][] actualJaggedArray = new int[row][];
            actualJaggedArray[0] = new int[] { 6, 3, 2 };
            actualJaggedArray[1] = new int[] { 3, 7, 2, 0, 6, 1 };
            actualJaggedArray[2] = new int[] { 6, 3, 4 };

            int[][] expectations = new int[row][];
            expectations[0] = new int[] { 3, 7, 2, 0, 6, 1 };
            expectations[1] = new int[] { 6, 3, 4 };
            expectations[2] = new int[] { 6, 3, 2 };
            JaggedArr.SortSumIncrease(actualJaggedArray);
            CollectionAssert.AreEqual(actualJaggedArray[0], expectations[0]);
            CollectionAssert.AreEqual(actualJaggedArray[1], expectations[1]);
            CollectionAssert.AreEqual(actualJaggedArray[2], expectations[2]);


        }
        [Test]
        public void TestSumDecrease()
        {
            int row = 3;
            int[][] actualJaggedArray = new int[row][];
            actualJaggedArray[0] = new int[] { 6, 3, 2 };
            actualJaggedArray[1] = new int[] { 3, 7, 2, 0, 6, 1 };
            actualJaggedArray[2] = new int[] { 6, 3, 4 };

            int[][] expectations = new int[row][];
            expectations[0] = new int[] { 6, 3, 2 };
            expectations[1] = new int[] { 6, 3, 4 };
            expectations[2] = new int[] { 3, 7, 2, 0, 6, 1 };
            JaggedArr.SortSumDecrease(actualJaggedArray);
            CollectionAssert.AreEqual(actualJaggedArray[0], expectations[0]);
            CollectionAssert.AreEqual(actualJaggedArray[1], expectations[1]);
            CollectionAssert.AreEqual(actualJaggedArray[2], expectations[2]);


        }
        [Test]
        public void TestMaxInc()
        {
            int row = 3;
            int[][] actualJagggedArray = new int[row][];
            actualJagggedArray[0] = new int[] { 4, 3, 2 };
            actualJagggedArray[1] = new int[] { 3, 5, 2, 0, 6, 1 };
            actualJagggedArray[2] = new int[] { 5, 7, 4 };
           

            int[][] expectations = new int[row][];
            expectations[0] = new int[] { 5, 7, 4 };
            expectations[1] = new int[] { 3, 5, 2, 0, 6, 1 };
            expectations[2] = new int[] { 4, 3, 2 };
            JaggedArr.SortMaxInc(actualJagggedArray);
            CollectionAssert.AreEqual(actualJagggedArray[0], expectations[0]);
            CollectionAssert.AreEqual(actualJagggedArray[1], expectations[1]);
            CollectionAssert.AreEqual(actualJagggedArray[2], expectations[2]);


        }
        [Test]
        public void TestMaxDec()
        {
            int row = 3;
            int[][] actualJagggedArray = new int[row][];
            actualJagggedArray[0] = new int[] { 4, 3, 2 };
            actualJagggedArray[1] = new int[] { 3, 5, 2, 0, 6, 1 };
            actualJagggedArray[2] = new int[] { 5, 7, 4 };


            int[][] expectations = new int[row][];
            expectations[0] = new int[] { 4, 3, 2 };
            expectations[1] = new int[] { 3, 5, 2, 0, 6, 1 };
            expectations[2] = new int[] { 5, 7, 4 };
            JaggedArr.SortMaxDec(actualJagggedArray);
            CollectionAssert.AreEqual(actualJagggedArray[0], expectations[0]);
            CollectionAssert.AreEqual(actualJagggedArray[1], expectations[1]);
            CollectionAssert.AreEqual(actualJagggedArray[2], expectations[2]);


        }
        [Test]
        public void TestMinInc()
        {
            int row = 3;
            int[][] actualJagggedArray = new int[row][];
            actualJagggedArray[0] = new int[] { 2, 2, 2 ,0};
            actualJagggedArray[1] = new int[] { 3, 3, 3,3, 3, 3 };
            actualJagggedArray[2] = new int[] { 1,1, 1 };

            int[][] expectations = new int[row][];
            expectations[0] = new int[] { 3, 3, 3, 3, 3, 3 };
            expectations[1] = new int[]{ 1, 1, 1 };
            expectations[2] = new int[]  { 2, 2, 2,0};
            JaggedArr.SortMinInc(actualJagggedArray);
            CollectionAssert.AreEqual(actualJagggedArray[0], expectations[0]);
            CollectionAssert.AreEqual(actualJagggedArray[1], expectations[1]);
            CollectionAssert.AreEqual(actualJagggedArray[2], expectations[2]);


        }
        [Test]
        public void TestMinDec()
        {
            int row = 3;
            int[][] actualJagggedArray = new int[row][];
            actualJagggedArray[0] = new int[] { 2, 2, 2, 0 };
            actualJagggedArray[1] = new int[] { 3, 3, 3, 3, 3, 3 };
            actualJagggedArray[2] = new int[] { 1, 1, 1 };

            int[][] expectations = new int[row][];
            expectations[0] = new int[] { 2, 2, 2, 0 };
            expectations[1] = new int[] { 1, 1, 1 };
            expectations[2] = new int[] { 3, 3, 3, 3, 3, 3 };
            JaggedArr.SortMinDec(actualJagggedArray);
            CollectionAssert.AreEqual(actualJagggedArray[0], expectations[0]);
            CollectionAssert.AreEqual(actualJagggedArray[1], expectations[1]);
            CollectionAssert.AreEqual(actualJagggedArray[2], expectations[2]);


        }
    }
}
