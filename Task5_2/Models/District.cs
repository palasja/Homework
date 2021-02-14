using System;
using System.Collections.Generic;
using System.Text;

namespace Task5_2.Models
{
    class District
    {
        public string Name;
        public City City;

        public District(string name, City city)
        {
            Name = name;
            City = city;
        }
    }
}
