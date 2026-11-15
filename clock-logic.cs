using System;
using System.Threading;
namespace Clock
{
    class ClockLogic
    {
        public int clocktime;
        public void ClockAmam1()
        {
            while (clocktime >= 1)
            {
                int clocktime2 = clocktime -= 1;
                Console.Clear();
                Console.WriteLine($"{clocktime2 + 1} sec");
                Thread.Sleep(1000);
            }
        }
        public void ClockAmam2()
        {
            while (clocktime >= 0)
            {
                int clocktime2 = clocktime += 1;
                Console.Clear();
                Console.WriteLine($"{clocktime2} sec");
                Thread.Sleep(1000);
            }
        }
    }
}