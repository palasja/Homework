using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task11_2
{
    class Caller
    {
        Test11_2 test = new Test11_2();
        public void Call123()
        {
            Thread thread1 = new Thread(test.First);
            Thread thread2 = new Thread(test.Second);
            Thread thread3 = new Thread(test.Third);
            thread1.Start();
            thread2.Start();
            thread3.Start();

        }
        public void Call213()
        {
            Thread thread1 = new Thread(test.First);
            Thread thread2 = new Thread(test.Second);
            Thread thread3 = new Thread(test.Third);
            thread2.Start();
            thread1.Start();
            thread3.Start();
        }
        public void Call231()
        {
            Thread thread1 = new Thread(test.First);
            Thread thread2 = new Thread(test.Second);
            Thread thread3 = new Thread(test.Third);
            thread2.Start();
            thread3.Start();
            thread1.Start();
        }
        public void Call321()
        {
            Thread thread1 = new Thread(test.First);
            Thread thread2 = new Thread(test.Second);
            Thread thread3 = new Thread(test.Third);
            thread3.Start();
            thread2.Start();
            thread1.Start();

        }
    }
}
