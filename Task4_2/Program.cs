using System;

namespace ConsoleApp1
{
    
    class Program
    {
        delegate R Delegate1<R, T>(T arg);
        static void Main(string[] args)
        {
            Delegate1 <string, int> testDelegate = (arg) => $"Arg = {arg}";
            Console.WriteLine(testDelegate(8));
        }
    }
}
