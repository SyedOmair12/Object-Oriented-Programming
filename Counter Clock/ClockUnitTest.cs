using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Interfaces;

namespace Counter_Clock
{
   
    class ClockUnitTest
    {
        [SetUp]
        public void SetUp()
        {
            ClockClass myClock = new ClockClass();
            CounterClass myCounter = new CounterClass("Counter");
        }
        [Test]
        public void IncrementTest()
        {
            CounterClass myCounter = new CounterClass("1st Counter");
            myCounter.Increment();
            myCounter.Increment();
            myCounter.Increment();
            Assert.AreEqual(3, myCounter.Value);
        }

        [Test]
        public void ResetTest()
        {
            CounterClass myCounter = new CounterClass("1st Counter");
            myCounter.Reset();
            Assert.AreEqual(0, myCounter.Value);
        }

        [Test]
        public void ValueTest()
        {
            CounterClass myCounter = new CounterClass("1st Counter");
            myCounter.Value = 5;
            Assert.AreNotEqual(10, myCounter.Value);
        }

        [Test]
        public void Test_Second_Clock()
        {
            ClockClass myClock = new ClockClass();
            for (int z = 0; z < 60; z++)
            {
                myClock.Ticking();
            }
            Assert.AreEqual(myClock.SS, 0);
        }



        [Test]
        public void Test_Minute_Clock()
        {
            ClockClass myClock = new ClockClass();
            for (int z = 0; z < 60; z++)
            {
                myClock.Ticking();
            }
            Assert.AreEqual(myClock.MM, 1);
        }


        [Test]
        public void Test_Hour_Clock()
        {
            ClockClass myClock = new ClockClass();
            for (int z = 0; z < 24; z++)
            {
                myClock.Ticking();
            }
            Assert.AreEqual(myClock.HH, 0);
        }

        [Test]
        public void ClockTest()
        {
            ClockClass myClock = new ClockClass();
            for (int z = 0; z < 4350; z++)
            {
                myClock.Ticking();
            }
            Assert.AreEqual("1:12:30", myClock.ToString());
        }



    }
}
