using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiggerNum
{
    public class BigNum
    {
       

        /// <summary>
        /// Searching of the next bigger number.
        /// </summary>
        /// <returns>The find.</returns>
        /// <param name="number">Input number.</param>
        public static int FindNextBiggerNumber(int number)
        {

            int[] arr = GetArr(number);

            for (int i = arr.Length - 1; i >=1; i--)
            {
                if (arr[i] > arr[i - 1])
                {
                    Quicksrt(arr, i, arr.Length - 1);
                    for (int j = i; j <= arr.Length - 1; j++)
                    {
                        if (arr[j] > arr[i - 1])
                        {
                            Swap(ref arr[j], ref arr[i - 1]);
                            return GetNum(arr);
                        }
                    }
                }
            }
            return -1;
        }
        /// <summary>
        /// Taking number and boxing it's digits to array
        /// </summary>
        /// <returns>The array.</returns>
        /// <param name="number">Input number.</param>
        private static int[] GetArr(int number)
        {
            int length = 0;
            int tmp = number;
            while (tmp != 0)
            {
                tmp /= 10;
                length++;
            }
            int[] a = new int[length];
            for (int i = length - 1; i >= 0; i--)
            {
                a[i] = number % 10;
                number /= 10;
            }
            return a;
        }
        /// <summary>
        /// Making number from array elements
        /// </summary>
        /// <returns>The number.</returns>
        /// <param name="arr">Input array.</param>
        private static int GetNum(int[] arr)
        {
            int number = 0;
            int degree = arr.Length - 1;
            for (int i = 0; i < arr.Length; i++)
            {
                number += Convert.ToInt32(arr[i] * Math.Pow(10, degree));
                degree--;
            }
            return number;
        }

        /// <summary>
        /// Swap
        /// </summary>
        /// <returns>The swap.</returns>
        /// <param name="num">The alpha component.</param>
        /// <param name="num1">The blue component.</param>
        private static void Swap(ref int num, ref int num1)
        {
            int tmp = num;
            num = num1;
            num1 = tmp;
        }


        /// <summary>
        /// Dividing of array
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        /// <param name="head"></param>
        /// <param name="tail"></param>
        /// <returns></returns>
        public static int Divide(int[] array, int head, int tail)

        {
            int marker = head;
            for (int i = head; i <= tail; i++)
                marker = QuickSwap(array, tail, marker, i);
            return marker - 1;
        }

        /// <summary>
        /// Swap
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        /// <param name="tail"></param>
        /// <param name="marker"></param>
        /// <param name="i"></param>
        /// <returns></returns>
        private static int QuickSwap(int[] array, int tail, int marker, int i)
        {
            {
                if (array[i].CompareTo(array[tail]) <= 0)
                {
                    int temp = array[marker];
                    array[marker] = array[i];
                    array[i] = temp;
                    marker += 1;
                }
            }

            return marker;
        }

        /// <summary>
        /// QuickSort algorithm
        /// </summary>        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        /// <param name="head"></param>
        /// <param name="tail"></param>
        public static void Quicksrt(int[] array, int head, int tail)

        {


            if (head < tail)
            {
                Quicksrt(array, head, Divide(array, head, tail) - 1);
                Quicksrt(array, Divide(array, head, tail) + 1, tail);
            }


        }
    }
}
