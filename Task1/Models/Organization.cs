using System;
using System.Collections.Generic;
using System.Text;

namespace Task1.Models
{
    class Organization : IKey
    {
        public Organization(int unp, string name)
        {
            Unp = unp;
            Name = name;
        }

        public int Unp { get; set; }
        public string Name { get; set; }
        

        public string GetFullName()
        {
            return $"{Unp}  {Name}";
        }
    }
}
