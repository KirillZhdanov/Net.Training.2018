using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jagged
{
   
    /// <summary>
    /// Compare by Sum
    /// </summary>
    public class ComparatorBySum :  IComparer<int[]>
    {
        /// <summary>
        /// Compare method for checking sum of elements
        /// </summary>
        /// <param name="x">First array</param>
        /// <param name="y">Second array</param>
        /// <returns>Compare integers</returns>
        public int Compare(int[] x, int[] y)
        {
            
                return x.Sum().CompareTo(y.Sum());
           
        }

    }

    /// <summary>
    /// Compare By Min
    /// </summary>
    public class ComparatorByMinElement : IComparer<int[]>
    {
        /// <summary>
        /// Compare method for finding min of elements
        /// </summary>
        /// <param name="x">First array</param>
        /// <param name="y">Second array</param>
        /// <returns>Compare integers</returns>
        public int Compare(int[] x, int[] y)
        {
           
            return x.Min().CompareTo(y.Min());
        }
    }

    /// <summary>
    /// Compare by max
    /// </summary>
    public class ComparatorByMaxElement :  IComparer<int[]>
    {
        /// <summary>
        /// Compare method for finding max of elements
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public int Compare(int[] x, int[] y)
        {
            return x.Max().CompareTo(y.Max());
        }
    }
}
