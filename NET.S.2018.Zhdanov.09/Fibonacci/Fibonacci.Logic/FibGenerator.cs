using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    public  class FibGen
    {    
        /// <summary>
        /// Generator of Fibonacci num's
        /// </summary>
        /// <param name="maxValue"></param>
        /// <returns></returns>
        public static int[] Generator(int maxValue)
        {
            int[] fibNumsArray=new int [2];
            fibNumsArray[0] = 0;
            fibNumsArray[1] = 1;
            int i = 1;
            while (true)
            {
                Array.Resize<int>(ref fibNumsArray, i+2);
              fibNumsArray[i+1] = fibNumsArray[i - 1] + fibNumsArray[i];
              i++;
                if (fibNumsArray[i]>=maxValue)
                    break;
               
            }
            Array.Resize<int>(ref fibNumsArray, i);
            return fibNumsArray;
        }

                
       
    }
}
