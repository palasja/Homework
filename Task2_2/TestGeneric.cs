using System;
using System.Collections.Generic;
using System.Text;

namespace TestGeneric
{
    class ContractInfo <T,R> where T:struct where R :Organization
    {
        public T varTypeTest ;

        public R ShowType(R arg) {
            Console.WriteLine($"{varTypeTest} type generic is {typeof(T)}");
            Console.WriteLine($"{arg} type second generic is {typeof(R)}");
            return arg;
        }

    }
}
