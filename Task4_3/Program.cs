using System;

namespace Task4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();

            Mouse mouse = new Mouse(cat);
            Human human = new Human(cat);
            Dog dog = new Dog(cat);

            cat.WakeUp();
        }
    }
}
