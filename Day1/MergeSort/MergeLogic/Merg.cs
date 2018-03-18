using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeLogic
{
    public class Merg
    { /// <summary>
      /// Init string
      /// </summary>
      /// <returns></returns>
        //private static string[] GetStrtest() => new string[] { "qcba", "aaa", "mtp", "tcp", "habra", "tost", "test", "zee", "zaq" };
        /// <summary>
        /// Show items
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arr"></param>
        private static void Show<T>(T[] arr)
             where T : IComparable

        {
            foreach (T item in arr)
                System.Console.Write(item + " ");
            Console.WriteLine();

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
