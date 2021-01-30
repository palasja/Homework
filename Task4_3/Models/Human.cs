using System;
using System.Collections.Generic;
using System.Text;

namespace Task4_3
{
    class Human
    {
        public Human(Cat cat)
        {
            cat.WakeUpEvent += () => Console.WriteLine($"{this.GetType()} : Kitty!!!");
        }
    }
}
