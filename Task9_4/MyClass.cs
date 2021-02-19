using System;
using System.Collections.Generic;
using System.Text;

namespace Task9_4
{
    public class MyClass
    {
        [Test("Private", Success = true)]
        private void PrivateMethod() 
        {
            Console.WriteLine("I private method");
        }
        [Test("Public", Success = true)]
        public void PublicMecthod()
        {
            Console.WriteLine("I public methods");
        }
    }
}
