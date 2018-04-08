using System;
using System.Collections.Generic;
using System.Linq;

namespace Jagged
{
    /// <summary>
    /// Simple release interface to delegate
    /// </summary>
    public class IntToDel
    {
        #region Public Method

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        /// <param name="comparer"></param>
        public static void Sort<T>(T[] array, IComparer<T> comparer)
        {
            if (array == null)
                throw new ArgumentNullException(nameof(array));

            if (comparer == null)
                throw new ArgumentNullException(nameof(comparer));

            Sorting(array, comparer.Compare);
        }

        #endregion

        #region Private Method

        private static void Sorting<T>(T[] array, Comparison<T> compare)
        {
            for (int i = array.Length - 1; i > 0; i--)
                for (int j = 0; j < i; j++)
                    if (compare(array[j], array[j + 1]) > 0)
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
