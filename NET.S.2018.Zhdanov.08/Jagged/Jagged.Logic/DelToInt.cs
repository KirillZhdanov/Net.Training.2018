using System;
using System.Collections.Generic;

namespace Jagged
{
    /// <summary>
    /// Simple release delegate to interface
    /// </summary>
    public class DelToInt
    {
        #region Public Method

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        /// <param name="comparer"></param>
        public static void Sort<T>(T[] array, Comparison<T> comparer)
        {
            if (array == null)
                throw new ArgumentNullException(nameof(array));

            if (comparer == null)
                throw new ArgumentNullException(nameof(comparer));

            Sorting(array, Comparer<T>.Create(comparer));
        }

        #endregion

        #region Private Method
        
        private static void Sorting<T>(T[] array, IComparer<T> comparator)
        {
            for (int i = array.Length - 1; i > 0; i--)
                for (int j = 0; j < i; j++)
                    if (comparator.Compare(array[j], array[j + 1]) > 0)
                       Swap(ref array[j], ref array[j + 1]);
        }

        private static void Swap<T>(ref T array1, ref T array2)
        {
            var temp = array1;
            array1 = array2;
            array2 = temp;
        }
        #endregion
    }
}
