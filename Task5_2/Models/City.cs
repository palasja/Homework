using System;
using System.Collections.Generic;
using System.Text;

namespace Task5_2.Models
{
    class City
    {
        public string Name;
        public Neighborhood Neighborhood;

        public City(string name, Neighborhood neighborhood)
        {
            Name = name;
            Neighborhood = neighborhood;
        }
    }
}
