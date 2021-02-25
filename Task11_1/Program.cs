using System;
using System.Threading;

namespace Task11_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread[] threads = new Thread[10];
            for (int i = 0; i < 10; i+=2)
            {
                int operation = i;
                threads[i] = new Thread(() => new BankAccount().Debet((Double)operation));
            }
            for (int i = 1; i < 10; i+=2)
            {
                int operation = i;
                threads[i] = new Thread(() => new BankAccount().Credit((Double)operation * (-1)));
            }
            for (int i = 0; i < 10; i++)
            {
                threads[i].Start();
            }
            Console.ReadLine();
        }
    }
}
/*
 1. Создайте класс BankAccount с полем _balance и методами Credit и Debit для изменения баланса.
Создайте несколько экземпляров класса в разных потоках и производите вызов методов Credit и Debit.
Сделайте так чтоб баланс изменялся корректно. Весь по синхронизации между потоками должен находится внутри класса BankAccount.
 */