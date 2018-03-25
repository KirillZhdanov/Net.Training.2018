using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NewtonLogic;




namespace NewtonLogic
{
    /// <summary>
    /// Ms unit testing of Newton's Method
    /// </summary>
    [TestClass]
    public class MSNewtonTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            double test;
           test = Newtons.FindNthRoot(8.0, 3.0,0.0001);
           Assert.AreEqual(test,2.0,1);
          
        }
        [TestMethod]
        public void TestMethod()
        {
        
            double test;
            test = Newtons.FindNthRoot(1.0, 5.0, 0.0001);
            
            Assert.AreEqual(test, 1.0,1);
            
        }
        [TestMethod]
        public void Test()
        {
            double test,t;
            test = Newtons.FindNthRoot(1.0, 5.0, 0.0001);
            t = Math.Pow(1, 1 / 5);

            test = Newtons.FindNthRoot(0.001, 3.0, 0.0001);
            Assert.AreEqual(t, test,1);

           
        }
        [TestMethod]
        public void Test1()
        {
            double test;
            test = Newtons.FindNthRoot(0.04100625, 4, 0.0001);
          Assert.AreEqual(test, 0.45,1);
        }
        [TestMethod]
        public void Test2()
        {
            double test;
            
            test = Newtons.FindNthRoot(8, 3, 0.0001);
            Assert.AreEqual(test, 2.0,1);
            
        }
        [TestMethod]
        public void Test3()
        {
            double test;
            test = Newtons.FindNthRoot(0.0279936, 7, 0.0001);
            Assert.AreEqual(test, 0.6,1);
           
        }
        [TestMethod]
        public void Test4()
        {
            double test;
            test = Newtons.FindNthRoot(0.0081, 4, 0.1);
            Assert.AreEqual(test, 0.3,1);
        }
    }
}
