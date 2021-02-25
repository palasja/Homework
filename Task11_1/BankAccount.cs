using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Task11_1
{
    class BankAccount
    {
        /*[ThreadStatic]*/
        public static double _balance;
        public static object locker = new object();

        public double getBalance() { return _balance; }
        public void Debet(object sum)
        {
            lock(locker) {
                _balance += (double) sum;
                Console.WriteLine($"sum = {sum}; balance = {_balance}");
            }
            Thread.Sleep(1000);
        }

        public void Credit(object obj)
        {
            double sum = (double)obj;
            lock (locker)
            {
                if (_balance + sum >= 0)
                {
                    _balance += sum;
                    Console.WriteLine($"sum = {sum}; balance = {_balance}");
                }
                else
                {
                    Console.WriteLine($"Can't {_balance} {sum}");
                }
            }
        }
    }
}
