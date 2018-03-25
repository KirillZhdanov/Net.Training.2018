using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JagArr
{
    public static class JaggedArr
    {
        #region Sort by sum
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
        #endregion

        #region Sort by max 
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
        #endregion

        #region Sort by Min
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

        private static void Swap(ref int[] a, ref int[] b)
        {
            int[] temp = a;
            a = b;
            b = temp;
        }
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
       
        private static int GetSum(int[] array)
        {
            int sum = 0;
            foreach (int element in array)
            {
                sum += element;
            }
            return sum;
        }
    }
}
