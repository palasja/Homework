using System;
using System.Threading;

namespace Task11_3
{
    class Program
    {
        static Mutex mutex = new Mutex();
        static void Main(string[] args)
        {
            Thread[] threads = new Thread[3];

            for (int i = 0; i < threads.Length; i++)
            {
                int num = i;
                threads[i] = new Thread(() => Test(num));
                threads[i].Start();
            }

        }

        static void Test(int num)
        {
            mutex.WaitOne();
            Console.WriteLine($"Start{num}");
            Thread.Sleep(1000);
            Console.WriteLine($"End{num}");
            mutex.ReleaseMutex();
        }
    }
        //Не придумал как проверять что отрабатывает только 1 экземпляр. В Test проверять проще
/*        static void Main(string[] args)
        {
            mutex.WaitOne();
            Console.WriteLine($"App Run");
            mutex.ReleaseMutex();
        }*/
}
