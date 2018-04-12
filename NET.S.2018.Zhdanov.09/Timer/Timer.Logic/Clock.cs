using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Threading.Thread;


namespace Timer
{
    public class Clock
    {
        #region Private Fields

        private bool IsStarted;
        private const int timeToSleep = 1000;

        #endregion

        #region Public Method

        public async void RunTimer(int seconds)
        {
            if (IsStarted == true)
                return;

            await Task.Run(() =>
            {
                Sleep(seconds * timeToSleep);
                OnTimeout(this, new TimeLeft(seconds));
                IsStarted = false;
            });
        }

        #endregion

        #region Protected Method

        protected virtual void OnTimeout(object sender, TimeLeft e)
        {
            if(Dispatcher!=null)
            Dispatcher.Invoke(sender, e);
        }

        #endregion

        

        public event EventHandler<TimeLeft> Dispatcher;

        


    }
}
