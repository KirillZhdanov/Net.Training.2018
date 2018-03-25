using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MergeLogic;

namespace MergeLogic
{
    [TestClass]
    public class MergTest
    {
        [TestMethod]
        public void TestMerge()
        {

            // исходные данные

            int[] expected = new int[5] { 1, 5, 6, 7, 8 };

            int[] array = new int[5] { 5, 8, 7, 6, 1 };
            int[] y = new int[5] { 1, 5, 6, 7, 8 };



            // получение значения с помощью тестируемого метода
            int []  actual=Merg.SortbyMergeMethod(array);

            // сравнение ожидаемого результата с полученным
            CollectionAssert.AreEqual(expected, actual);
          




        }
    }
}
