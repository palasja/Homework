using System;
using System.Reflection;
using Task10_1dll;

namespace Task10_2dll
{
    public class Runner10_2
    {
        public void Run()
        {
            Type type = new Author().GetType();

            Console.WriteLine("PRIVATE METHOD");
            var methods = type.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly);
            foreach (var method in methods)
                Console.WriteLine(method);
            Console.WriteLine("===============================================");
            Console.WriteLine("MEMBERS");
            var members = type.GetMembers(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);
            foreach (var member in members)
                Console.WriteLine(member);
        }
    }
}
