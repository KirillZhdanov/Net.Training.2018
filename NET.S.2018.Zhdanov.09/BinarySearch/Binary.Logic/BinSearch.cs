using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    public class BinSearch
    {
        /// <summary>
        /// Binary Search Method
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int BinarySearch(int[] arr, int value)
        {
            if (arr.Length == 0 || value < arr[0] || value > arr[arr.Length - 1])
                return -1;
            int first = 0, last = arr.Length;

            while (first < last)
            {
                int middle = first + (last - first) / 2;
                if (value <= arr[middle])
                    last = middle;
                else
                    first = middle + 1;
            }
            if (arr[last] == value)
                return last;
            else
                return -1;

        }
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
    }
}
