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
    class ClockClass
    {
        Timer T = new Timer();
        private CounterClass _hour = new CounterClass("Hours");
        private CounterClass _minute = new CounterClass("Minutes");
        private CounterClass _second = new CounterClass("Seconds");

        public int HH
        {
            get
            {
                return _hour.Value;
            }
        }

        public int MM
        {
            get
            {
                return _minute.Value;
            }
        }

        public int SS
        {
            get
            {
                return _second.Value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0}:{1}:{2}", HH, MM, SS);
        }

        public void Ticking()
        {
            _second.Increment();

            if (SS >= 60)
                {
                _second.Reset();
                _minute.Increment();

                if (MM >= 60)
                {
                    _minute.Reset();
                    _hour.Increment();

                    if (HH >= 24)
                    {
                        ResetClock();
                    }
                }
            }
        }

        public void ResetClock()
        {
            _hour.Reset();
            _minute.Reset();
            _second.Reset();
        }
    }
}
