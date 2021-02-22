using System;
using System.Collections.Generic;
using System.Text;

namespace Task10_1dll
{
    
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Property, AllowMultiple =true)]
    class AuthorAttribute : Attribute
    {
        public AuthorAttribute(int num, string desc)
        {
            Num = num;
            Desc = desc;
        }

        public int Num { get; set; }
        public string Desc { get; set; }
    }
}
