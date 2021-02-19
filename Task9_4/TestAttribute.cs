using System;
using System.Collections.Generic;
using System.Text;

namespace Task9_4
{
    [AttributeUsage(AttributeTargets.Method)]
    class TestAttribute : Attribute
    {
        public string name;

        public TestAttribute(string name)
        {
            this.name = name;
        }

        public bool Success { get; set; }
    }
}
