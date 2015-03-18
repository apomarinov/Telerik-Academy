using System;
using System.Threading;

namespace CustomTimerClass
{
    public delegate void TimerDelegate();

    public class CustomTimer
    {
        private int interval;   
        private bool runTimer;
        private TimerDelegate timerDelegate;
        private Thread timerThread;

        public CustomTimer(TimerDelegate timerEvent, int interval)
        {
            this.Interval = interval;
            this.timerDelegate = timerEvent;
            this.runTimer = true;
            this.timerThread = new Thread(new ThreadStart(this.StartTimer));
        }

        public int Interval
        {
            get { return this.interval; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                this.interval = value;
            }
        }

        private void StartTimer()
        {
            while (this.runTimer)
            {
                Thread.Sleep((int)interval);
                timerDelegate();
            }
        }

        public void Start()
        {
            timerThread.Start();
        }

        public void Stop()
        {
            this.runTimer = false;
        }
    }
}