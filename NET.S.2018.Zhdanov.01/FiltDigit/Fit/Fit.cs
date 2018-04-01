using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltDigit
{
    public class Fit
    {
        public static int [] Fitd(int [] arr, int digit)
        {
           
            List<int> resDigit = new List<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                int numFromArr = arr[i];
                if (FilterDigit(numFromArr, digit))
                {
                    resDigit.Add(arr[i]);
                    numFromArr = 0;
                }
            }
            return resDigit.ToArray();
        }
     
        private static bool FilterDigit(int NumberFromArray, int Digit)
        {
            while (NumberFromArray != 0)
            {
                if (NumberFromArray % 10 == Digit || NumberFromArray == Digit)
                {
                    return true;
                }
                else
                    NumberFromArray = NumberFromArray / 10;
            }
            return false;

        }
       
    }
}
