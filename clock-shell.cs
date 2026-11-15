using System;
using System.Diagnostics;
using System.Threading;
namespace Clock
{
    class ClockShell
    {
        static void Main()
        {
            ClockLogic clock1 = new ClockLogic();
            while (true)
            {
                Console.WriteLine("countdown");
                Console.WriteLine("stopwatch");
                Console.WriteLine("exit");
                Console.WriteLine(" ");
                Console.Write("choose: ");
                string? choose = Console.ReadLine()?.ToLower();
                if (choose == "countdown")
                {
                    Console.Write("how much time should i set the time for?: ");
                    if (!int.TryParse(Console.ReadLine(), out clock1.clocktime))
                    {
                        Console.WriteLine("write number");
                    }
                    clock1.ClockAmam1();
                }
                else if (choose == "stopwatch")
                {
                    clock1.clocktime = 0;
                    clock1.ClockAmam2();
                }
                else if (choose == "exit")
                {
                    Console.Clear();
                    return;
                }
                else
                {
                    Console.Clear();
                }
            }
        }
    }
}