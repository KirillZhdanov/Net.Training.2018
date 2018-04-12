using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Timer.Clock;
using static System.Console;
using static System.Threading.Thread;

namespace Timer.Console
{
   public static class Program
    {
        static void Main(string[] args)
        {
            var timer = new Clock();
            var listener1 = new Listener(1);
            var listener2 = new Listener(2);
            WriteLine("Add");
            timer.Dispatcher += listener1.Timing;
            timer.Dispatcher += listener2.Timing;
            timer.RunTimer(5);
            Sleep(10000);
            WriteLine(" Remove first ");
            timer.Dispatcher -= listener1.Timing;
            timer.RunTimer(3);
            Sleep(10000);
            WriteLine(" Remove second ");
            timer.Dispatcher -= listener2.Timing;
            timer.RunTimer(3);
            Sleep(10000);
            ReadKey();
        }

        public static void ShowMessage(string str)
        {
            WriteLine(str);
        }
    }

}
