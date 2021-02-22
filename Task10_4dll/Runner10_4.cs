using System;
using System.Reflection;
using Task10_1dll;

namespace Task10_4dll
{
    public class Runner10_4
    {
        public void Run()
        {
            try
            {
                Assembly asm = Assembly.Load("Task10_1dll");

                Type t = asm.GetType("Task10_1dll.Author", true, true);

                Author author = (Author) Activator.CreateInstance(t, new object[] { 1, "Joanne", "Rowling" });
                author.Hi();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Task10_1dll.Author not found {ex.Message}");
            }
        }
    }
}
