using System;
using System.Threading;

namespace Task11_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var caller = new Caller();

            //caller.Call123();
            caller.Call213();
            //caller.Call231();
            //caller.Call321();

            Console.Read();
        }
    }
}
