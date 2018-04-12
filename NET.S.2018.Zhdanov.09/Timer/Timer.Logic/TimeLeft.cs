using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timer
{

    public class TimeLeft:EventArgs
    {

        public int Seconds { get; private set; }

        public TimeLeft(int seconds)
        {
            Seconds = seconds;
        }
    }
}
