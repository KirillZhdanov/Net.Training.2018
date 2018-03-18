using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insert
{/// <summary>
/// InsertNumber class
/// </summary>
    public class InsertNum
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="number"></param>
        /// <param name="InsertNumber"></param>
        /// <param name="i"></param>
        /// <param name="j"></param>
        /// <returns></returns>
        public static int Insert(int number, int InsertNumber, int i, int j)
        {
           
            int num1 = ((number >> j) << (i + j)) | ((int.MaxValue >> 30 - i) & number);
            int num2 = (InsertNumber << i + 1) & (int.MaxValue >> 30 - j);
            int num3= num1 | num2;
            return num3;
        }
    }
}
