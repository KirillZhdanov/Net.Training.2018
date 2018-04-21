using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
   public class IfChanged:EventArgs
    {
        public int Rows { get; private set; }
        public int Cols { get; private set; }


        public IfChanged(int i, int j)
        {
            Rows = i;
            Cols = j;
        }

    }
}
