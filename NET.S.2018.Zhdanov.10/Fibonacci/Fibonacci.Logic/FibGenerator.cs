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
        /// <returns></returns>
        public static IEnumerable<long> Generator()
        {
            long previousElement = 0, currentElement = 1;

            while (true)
            {
                
                var nextElement = previousElement + currentElement;
                yield return nextElement;
                previousElement = currentElement;
                currentElement = nextElement;
            }
        }

                
       
    }
}
