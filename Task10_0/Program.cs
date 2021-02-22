using System;
using Task10_2dll;
using Task10_3dll;
using Task10_4dll;

namespace Task10_0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task2");
            Runner10_2 task2 = new Runner10_2();
            task2.Run();

            Console.WriteLine("\nTask3");
            Runner10_3 task3 = new Runner10_3();
            task3.Run();

            Console.WriteLine("\nTask4");
            Runner10_4 task4 = new Runner10_4();
            task4.Run();
        }
    }
}
