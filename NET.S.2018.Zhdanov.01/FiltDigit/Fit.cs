using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltDigit
{
    public class Fit
    {
        static int Num(int[] arr, int k)
        {
            int x;

            x = arr[k];

            return x;





        }
        static bool FilterDigit(int NumberFromArray, int Digit)
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
        static void Show(int[] arr, int j)
        {
            Array.Resize<int>(ref arr, j);

            for (int i = 0; i < arr.Length; i++)
            {

                Console.Write($"{arr[i]},");
            }
        }
    }
}
