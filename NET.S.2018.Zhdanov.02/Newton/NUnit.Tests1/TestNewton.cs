using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit.Tests1
{
    /// <summary>
    /// NUnit test for Newton's Method
    /// </summary>
    [TestFixture]
    public class TestNewton
    {/// <summary>
     /// 
     /// </summary>
     /// <param name="num">Original number</param>
     /// <param name="degree">Degree</param>
     /// <param name="eps">It's your delta for approximation</param>
     /// <param name="exp">Expected Result</param>
        [TestCase(1, 5, 0.0001, 1)]
        [TestCase(8, 3, 0.0001,  2)]
        [TestCase(0.001, 3, 0.0001, 0.1)]
        [TestCase(0.04100625, 4, 0.0001, 0.45)]
        [TestCase(8, 3, 0.0001,  2)]
        [TestCase(0.0279936, 7, 0.0001, 0.6)]
        [TestCase(0.0081, 4, 0.1,  0.3)]
        [TestCase(-0.008, 3, 0.1, -0.2)]
        [TestCase(0.004241979, 9, 0.00000001,  0.545)]
       
        public void Sqrt(double num, double degree, double eps,double exp)
        {
            double actual;
            actual=NewtonLogic.Newtons.FindNthRoot(num, degree, eps);

            Assert.AreEqual(exp, actual, 1);

              
        }

    }
}
