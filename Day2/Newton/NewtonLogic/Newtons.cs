using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewtonLogic
{
    public class Newtons
    {
       public static double FindNthRoot(double num,double degree, double eps)
        {
            double x = num / degree;
             if (num < 0)
                throw new ArithmeticException("Number should be greater than 0!");
            if (Math.Abs(eps) > 1)
            throw new ArithmeticException("Epsilon should be less than 1");
           double x1 = (1.0 / degree) * ((degree - 1.0) * x + num / Math.Pow((int)x, degree - 1));

            while (Math.Abs(x1 - x) > eps)
            {
                x = x1;
                x1 = (1.0 / degree) * ((degree - 1) * x + num / Math.Pow((int)x, degree - 1));
            }
            return x1;
        }

    }
}
