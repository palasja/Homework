using System;
using System.Collections.Generic;
using System.Text;

namespace TestGeneric
{
    class Organization 
    {
        public Organization(int unp, string name)
        {
            Unp = unp;
            Name = name;
        }

        public int Unp { get; set; }
        public string Name { get; set; }
        
        public override String ToString() 
        {
            return $"{{ {Unp}: {Name} }}";
        }
    }
}
