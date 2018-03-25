using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JagArr
{
    public static class JaggedArr
    {
        #region Sortings
        /// <summary>
        /// Sorting according to sum of elements
        /// </summary>
        /// <param name="arr"></param>

        public static void SortSum(int[][] arr)
        {
            
            for (int i = 0; i < arr.Length; i++)
                for (int j = i + 1; j < arr.Length; j++)
                {
                     if (GetSum(arr[i])<GetSum(arr[j]))
                     {
                         Swap(ref arr[i], ref arr[j]);
                     }

                }
        }
       
        /// <summary>
        /// Sorting according to MAX
        /// </summary>
        /// <param name="arr"></param>
       
        public static void SortMax(int[][] arr)
        {           
            for (int i = 0; i < arr.Length; i++)
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (GetMax(arr[i]) < GetMax(arr[j]))
                    {
                        Swap(ref arr[i], ref arr[j]);
                    }
                }

           
        }
        
        /// <summary>
        /// Sorting according to MIN
        /// </summary>
        /// <param name="arr"></param>
       
        public static void SortMin(int[][] arr)
        {       for (int i = 0; i < arr.Length; i++)
                for (int j = i + 1; j < arr.Length; j++)
                {                   
                    if (GetMin(arr[i]) < GetMin(arr[j]))
                    {
                        Swap(ref arr[i], ref arr[j]);
                    }
                }
        }

        #endregion

        #region Static Methods
        /// <summary>
        /// Swap Method
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        private static void Swap(ref int[] a, ref int[] b)
        {
            int[] temp = a;
            a = b;
            b = temp;
        }
        /// <summary>
        /// Searching MIN helper Method
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        private static int GetMin(int[] array)
        {
            int min =999999 ;
            foreach (int item in array)
            {
                if (item < min)
                {
                    min = item;
                }
            }
            return min;
        }
        /// <summary>
        /// Searching MAX helper Method
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        private static int GetMax(int[] array)
        {
            int max = -9999999;
            foreach (int item in array)
            {
                if (item > max)
                {
                    max = item;
                }
            }
            return max;
        }
       /// <summary>
       /// Taking sum of elements method
       /// </summary>
       /// <param name="array"></param>
       /// <returns></returns>
        private static int GetSum(int[] array)
        {
            int sum = 0;
            foreach (int element in array)
            {
                sum += element;
            }
            return sum;
        }
        #endregion
    }
}
