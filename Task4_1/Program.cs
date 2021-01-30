using System;

namespace Task3_1
{
    delegate Organization Delegate1();
    class Program
    {
        static void Main(string[] args)
        {
            Organization organization = new Organization();
            Delegate1 Delegate1 = organization.GetOrganization;
            Delegate1().Delegate2();
            
        }
    }
}
