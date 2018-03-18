using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSortLogic

{
    /// <summary>
    /// Quick SortClass
    /// </summary>
    public class Quicksort
    {
        /// <summary>
        /// Dividing of array
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        /// <param name="head"></param>
        /// <param name="tail"></param>
        /// <returns></returns>
         public int Divide(int[] array, int head, int tail)
           
        {
            int marker = head;
            for (int i = head; i <= tail; i++)
                marker = Swap(array, tail, marker, i);
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
        private static int Swap(int[] array, int tail, int marker, int i) 
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
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        /// <param name="head"></param>
        /// <param name="tail"></param>
       public int[] Quicksrt(int[] array, int head, int tail)
           
        {
            

            if (head < tail) { 
           array= Quicksrt(array, head, Divide(array, head, tail) - 1);
            array= Quicksrt(array, Divide(array, head, tail) + 1, tail);}

            return array;
        }
       
    }
}
