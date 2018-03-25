using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickSortLogic;

namespace QuickSortLogic
{
    [TestClass]
    public class SortTest
    {
        [TestMethod]
        public void Testquick()
        {
            // исходные данные
           
            int[] expected =new int[5] {1,5,6,7,8 };
           
            int[] array = new int[5] { 5,8,7,6,1};

            

            
            // получение значения с помощью тестируемого метода
            Quicksort q = new Quicksort();
            int []actual = q.Quicksrt(array, 0, array.Length - 1);
            // сравнение ожидаемого результата с полученным
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
