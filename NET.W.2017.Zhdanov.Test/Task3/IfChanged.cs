using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
   public class IfChanged:EventArgs
    {
        public int USD { get;  set; }
        public int Euro { get;  set; }


        public IfChanged(int a, int b)
        {
            USD = a;
            Euro = b;
        }
        public IfChanged() { }

    }
}
