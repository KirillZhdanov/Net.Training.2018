using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Timer.Console.Program;


namespace Timer.Console
{
    class Listener
    {

        

        public int Number;

        
        /// <summary>
        /// Listener
        /// </summary>
        /// <param name="number"></param>
        public Listener(int number)
        {
            Number = number;
        }

        

        #region Public Method

        public void Timing(object sender, TimeLeft e)
        {
           ShowMessage($"Listener {Number}: Start timer\n\tSender: {sender}\n\tSeconds: {e.Seconds} timeleft.");
        }

        #endregion

    }
}
