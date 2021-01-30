using System;
using System.Collections.Generic;
using System.Text;

namespace Task3_1
{
    
    class Organization
    {
        public delegate void OrganizationDelegate();
        public Organization()
        {
        }

        public Organization GetOrganization()
        {
            Console.WriteLine("Call 'Delegate1'");
            return this;
        }

         public OrganizationDelegate Delegate2 = () => Console.WriteLine("Call 'Delegate2'");
    }
}

