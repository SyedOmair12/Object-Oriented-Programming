using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using NUnit.Framework;
using NUnit.Framework.Interfaces;

namespace Counter_Clock
{
    class Program
    {
        static void Main(string[] args)
        {
            ClockClass myClock = new ClockClass();
            while (true)
            {
                myClock.Ticking();
                Console.Clear();
                Console.Write("\r{0:00}:{1:00}:{2:00}", myClock.HH, myClock.MM, myClock.SS);
                if (Console.ReadLine() == "")
                {
                    Console.Clear();
                    myClock.ResetClock();
                }
            }
        }
    }
}
