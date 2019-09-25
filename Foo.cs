using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading;

public class Foo 
    {
        //private static int counter = 0;
        private ManualResetEvent resetevent1 = new ManualResetEvent(false);
        private ManualResetEvent resetevent2 = new ManualResetEvent(false);

        public Foo() { }

        public void First(Action printFirst)
        {
            printFirst();
            //counter++;
            resetevent1.Set();
        }

        public void Second(Action printSecond)
        {
            resetevent1.WaitOne();
            //while (counter < 1) continue;
            printSecond();
            resetevent2.Set();
            //counter++;
        }

        public void Third(Action printThird)
        {
            resetevent2.WaitOne();
            //while (counter < 2) continue;
            printThird();
        }
    }
