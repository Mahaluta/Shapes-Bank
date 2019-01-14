using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ThreadTimer
{
    class Program
    {
        
        static Timer TTimer = null;
        static void TickTimer(object state)
        {
            Console.Write("Tick! ");
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId.ToString());
            Thread.Sleep(4000);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Press R to Start the Timer " + "Press H to Stop the Timer" + Environment.NewLine);
            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.KeyChar == 'R' || key.KeyChar == 'r')
                {
                    TTimer = new Timer(new TimerCallback(TickTimer),null,1000,1000);
                }
                else if (key.KeyChar == 'H' || key.KeyChar == 'h')
                {
                    TTimer.Change(
                        Timeout.Infinite,
                        Timeout.Infinite);
                    break;
                }
            }
        }
    }
}