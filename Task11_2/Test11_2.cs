using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Task11_2
{
    public class Test11_2
    {
        public void First()
        {
            Console.Write("First");
        }
        public void Second()
        {
            Thread.Sleep(100);
            Console.Write("Second");
        }
        public void Third()
        {
            Thread.Sleep(1000);
            Console.Write("Third");
        }
    }
}
