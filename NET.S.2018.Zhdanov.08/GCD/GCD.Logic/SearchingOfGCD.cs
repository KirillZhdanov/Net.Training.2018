using System;
using static System.Math;

namespace GCD
{
    public class SearchingOfGCD
    {
        #region Euclid
        /// <summary>
        /// Get GCD using Euclidian algorithm
        /// </summary>
        /// <param name="value1">First value</param>
        /// <param name="value2">Second value</param>
        /// <returns>GCD of those values</returns>
        public static int GcdByEuclideanAlgorithm(int value1, int value2)
        {
            if (value1 == value2)
                return value1;

            if (value1 == 0 && value2 == 0)
                throw new ArgumentException();

            if (value1 == 0)
                return value2;

            if (value2 == 0)
                return value1;

            if (value1 < 0)
                value1 = Abs(value1);

            if (value2 < 0)
                value2 = Abs(value2);

            if (value1 > value2)
                return FindGcdUsingEuclideanAlgorithm(value1, value2);
            else
                return FindGcdUsingEuclideanAlgorithm(value2, value1);
        }

       
       
        
        /// <summary>
        /// Gcd for 3 value's
        /// </summary>
        /// <param name="value1"></param>
        /// <param name="value2"></param>
        /// <param name="value3"></param>
        /// <returns></returns>
        public static int GcdByEuclideanAlgorithm(int value1,int value2,int value3)
        {
            
            return GcdByEuclideanAlgorithm(value1, GetGCD(GcdByEuclideanAlgorithm,value2,value3));
        }

        /// <summary>
        /// Get GCD using Euclidian algorithm for more than 3 params
        /// </summary>
        /// <param name="values">Array of values</param>
        /// <returns>GCD of those values</returns>
        public static int GcdByEuclideanAlgorithm(params int[] values)
        {
            var result = values[0];
            for (int i = 1; i < values.Length; i++)
            {
               
                result = GetGCD(GcdByEuclideanAlgorithm, result, values[i]);
            }

            return result;
        }
         
        /// <summary>
        /// Euclidean algorithm for searching GCD
        /// </summary>
        /// <param name="value1">First value</param>
        /// <param name="value2">Second value</param>
        /// <returns>Get GCD of those values</returns>
        private static int FindGcdUsingEuclideanAlgorithm(int value1, int value2)
        {
            var remainder = value1 % value2;
            if (remainder == 0)
                return value2;
                  else
                return FindGcdUsingEuclideanAlgorithm(value2, remainder);
        }
        #endregion

        #region Stain
        /// <summary>
        /// Get GCD using Stain algorithm
        /// </summary>
        /// <param name="value1">First value</param>
        /// <param name="value2">Second value</param>
        /// <returns>GCD of those values</returns>
        public static int GcdByStainAlgorithm(int value1, int value2)
        {
            if (value1 == 0 && value2 == 0)
                throw new ArgumentException();

            if (value1 < 0)
                value1 = Abs(value1);

            if (value2 < 0)
                value2 = Abs(value2);

            return FindGcdUsingStainAlgorithm(value1, value2);
        }
        /// <summary>
        /// GCD for 3 value's
        /// </summary>
        /// <param name="value1"></param>
        /// <param name="value2"></param>
        /// <param name="value3"></param>
        /// <returns></returns>
        public static int GcdByStainAlgorithm(int value1, int value2, int value3)
        {

          
            return GcdByStainAlgorithm(value1, GetGCD(GcdByStainAlgorithm,value2,value3));
        }

        /// <summary>
        /// Get GCD using Stain algorithm for more than 3 params
        /// </summary>
        /// <param name="values">Array of values</param>
        /// <returns>GCD of those values</returns>
        public static int GcdByStainAlgorithm(params int[] values)
        {
            var result = values[0];
            for (int i = 1; i < values.Length; i++)
            {
                
                result = GetGCD(GcdByStainAlgorithm, result, values[i]);
            }

            return result;
        }
              
        /// <summary>
        /// Searching GCD by Stain Method
        /// </summary>
        /// <param name="value1">First value</param>
        /// <param name="value2">Second value</param>
        /// <returns>Get GCD of those values</returns>
        private static int FindGcdUsingStainAlgorithm(int value1, int value2) { 
           
           if (value1 == value2)
            {
            return value1;
            }
            if (value1 == 0)
                return value2;
            if (value2 == 0)
                return value1;
           
            if ((~value1 & 1) == 1) 
            {
                if ((value2 & 1) == 1) 
                    return FindGcdUsingStainAlgorithm(value1 >> 1,value2);

                else
                {
                    return FindGcdUsingStainAlgorithm(value1 >> 1, value2 >> 1) << 1;
                }
            }

            
            if ((~value2 & 1) == 1)
                return FindGcdUsingStainAlgorithm(value1, value2 >> 1);

            
            if (value1 >value2)
                return FindGcdUsingStainAlgorithm((value1 - value2) >> 1, value2);

            return FindGcdUsingStainAlgorithm((value2 - value1) >> 1, value1);
        }
        #endregion
#region Delegate and Private Method
        /// <summary>
        /// Delegate for GCD
        /// </summary>
        /// <param name="value1"></param>
        /// <param name="value2"></param>
        /// <returns></returns>
        delegate int GCDdel(int value1,int value2);
        /// <summary>
        /// GCD method
        /// </summary>
        /// <param name="method"></param>
        /// <param name="value1"></param>
        /// <param name="value2"></param>
        /// <returns></returns>
        private static int GetGCD(GCDdel method, int value1, int value2)
        {
            int resultOfMethod;
            
            resultOfMethod = method(value1, value2);
            
          
            return resultOfMethod;
        }

        #endregion


    }
}
