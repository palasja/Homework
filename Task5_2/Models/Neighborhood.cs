using System;
using System.Collections.Generic;
using System.Text;

namespace Task5_2.Models
{
    class Neighborhood
    {
        public string Name;
        public string StreetName;
        public string HouseNumber;

        public Neighborhood(string name, string streetName, string houseNumber)
        {
            Name = name;
            StreetName = streetName;
            HouseNumber = houseNumber;
        }
    }
}
