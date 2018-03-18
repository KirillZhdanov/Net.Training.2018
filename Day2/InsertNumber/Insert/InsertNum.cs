using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insert
{
    public class InsertNum
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="number"></param>
        /// <param name="numberToInsert"></param>
        /// <param name="i"></param>
        /// <param name="j"></param>
        /// <returns></returns>
        public static int Insert(int number, int InsertNumber, int i, int j)
        {
           
            int mask1 = ((number >> j) << (i + j)) | ((int.MaxValue >> 30 - i) & number);
            int mask2 = (InsertNumber << i + 1) & (int.MaxValue >> 30 - j);
            return mask1 | mask2;
        }
    }
}
