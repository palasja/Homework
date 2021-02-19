using System;
using System.Reflection;

namespace Task9_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var methods = new MyClass().GetType().GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);

            foreach (var method in methods)
                foreach (var attr in method.GetCustomAttributes(true))
                    if (attr.GetType() == typeof(TestAttribute)) 
                    {
                        Console.WriteLine(method.Name);
                        var testAttribute = (TestAttribute)attr;
                        Console.WriteLine($"{testAttribute.name} - {testAttribute.Success}");
                    }
        }
    }
}
