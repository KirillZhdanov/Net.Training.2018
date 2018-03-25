using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalNotation
{
    public static class DecNot
    {
        /// <summary>
        /// Converting to decimal method
        /// </summary>
        /// <param name="value"></param>
        /// <param name="Base"></param>
        /// <returns></returns>

        public static int ToDecimal(string value, int Base)
        {
            const string sym = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int rank = 1, result = 0;
            
            for (var i = value.Length - 1; i >= 0; i--)
            {
                var index = sym.IndexOf(value[i]);
                if (index < 0 || index >= Base)
                    throw new ArgumentException();
                result += rank * index;
                rank *= Base;
            }
            if (result <0)
                throw new OverflowException();
            return result;
        }
    }
}
