using System;
using System.Collections.Generic;
using System.Text;

namespace Task5_2.Models
{
    class Country
    {
        public string Name;
        public District District;

        public Country(string name, District district)
        {
            Name = name;
            District = district;
        }

        public override string ToString()
        {
            return $"{Name}, {District.Name}, {District.City.Name}, {District.City.Neighborhood.Name}, " +
                $"{District.City.Neighborhood.StreetName} : {District.City.Neighborhood.HouseNumber}";
        }
    }
}
