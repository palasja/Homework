using System;

namespace TestGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            var intMyClass = new ContractInfo<int, Organization>();
            var doubleMyClass = new ContractInfo<double, Organization>();

            intMyClass.varTypeTest = 3;
            intMyClass.ShowType(new Organization(22, "FO"));
            
            Console.WriteLine("\n====================\n");

            doubleMyClass.varTypeTest = 0.2;
            var org = doubleMyClass.ShowType(new Organization(22, "FO"));

            Console.WriteLine(org);
        }
    }
}
