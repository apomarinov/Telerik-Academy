using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using CustomTimerClass;

//Using delegates write a class Timer that can execute certain method at each t seconds.

class TimerTest
{
    static void Main()
    {
        int i = 0;
        CustomTimer t = new CustomTimer(delegate() { i++; }, 500);

        Console.WriteLine("Start timer result: " + i);
        t.Start();
        Thread.Sleep((int)2000);
        t.Stop();
        Console.WriteLine("Stop timer result: " + i);
    }
}