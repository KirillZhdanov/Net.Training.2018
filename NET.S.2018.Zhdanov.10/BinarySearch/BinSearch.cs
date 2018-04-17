using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    public static class BinSearch
    {
        /// <summary>
        /// BinarySearch Method
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arr"></param>
        /// <param name="value"></param>
        /// <param name="compar"></param>
        /// <returns></returns>
        public static int BinarySearch<T>(T[] arr, T value,Comparison<T> compar) 
        {
            if (arr.Length == 0 || arr == null || compar == null)
                throw new ArgumentNullException("Please check params");
            int first = 0, last = arr.Length;


            while (first <= last)
            {
                int mid = first + (last - first) / 2;

                if (arr[mid].Equals(value))
                    return mid;

                if (compar(value, arr[mid]) == 1)
                    first = mid + 1;
                else last = mid - 1;
            }
            return -1;

        }


        #region Sort
        /// <summary>
        /// Recursive method
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static T[] SortbyMergeMethod<T>(T[] arr)
            where T : IComparable
        {
            if (arr.Length == 1)
                return arr;
            var middle = arr.Length / 2;
            return Merge(SortbyMergeMethod(arr.Take(middle).ToArray()), SortbyMergeMethod(arr.Skip(middle).ToArray()));
        }
        /// <summary>
        /// Merging algorithm
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arr"></param>
        /// <param name="arr1"></param>
        /// <returns></returns>
        private static T[] Merge<T>(T[] arr, T[] arr1)
            where T : IComparable
        {
            int a = 0, b = 0;

            T[] res_arr = new T[arr.Length + arr1.Length];
            for (var i = 0; i < arr.Length + arr1.Length; i++)
            {
                if (b.CompareTo(arr1.Length) < 0 && a.CompareTo(arr.Length) < 0)
                {
                    if (arr[a].CompareTo(arr1[b]) > 0)
                    {
                        res_arr[i] = arr1[b++];
                    }
                    else
                        res_arr[i] = arr[a++];
                }
                else
                    if (b < arr1.Length)
                {
                    res_arr[i] = arr1[b++];
                }
                else
                {

                    res_arr[i] = arr[a++];
                }
            }
            return res_arr;
        }
        #endregion
    }
}
