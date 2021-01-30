using System;

namespace Task4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Mouse mouse = new Mouse();
            Cat cat = new Cat();
            Human human = new Human();
            Dog dog = new Dog();

            cat.WakeUpEvent += mouse.SeeCat;
            cat.WakeUpEvent += human.SeeCat;
            cat.WakeUpEvent += dog.SeeCat;

            cat.WakeUp();
        }
    }
}
