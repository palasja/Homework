using System;
using System.Collections.Generic;
using System.Linq;
using Task5_2.Models;

namespace Task5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var streets = getAddressList().GroupBy(country => country.District.City.Neighborhood.StreetName);

            foreach (var street in streets)
            {
                Console.WriteLine(street.Key);
            }

        }

        private static List<Country> getAddressList() { 
            return new List<Country>()
            {
                new Country("Belarus", new District("Gomelskaya", new City("Narovlya", new Neighborhood("Narovlyansky", "Kommunisticheskaya", "3")))),
                new Country("Belarus", new District("Gomelskaya", new City("Gomel", new Neighborhood("Gomelskaya", "Kommunisticheskaya", "75-7")))),
                new Country("Belarus", new District("Belarus", new City("Narovlya", new Neighborhood("Narovlyansky", "Meliorativnaya", "43")))),
                new Country("Russia", new District("Moskovskaya", new City("Moskov", new Neighborhood("Center", "Lyalin per.", "43")))),
                new Country("Belarus", new District("Minskaya", new City("Minsk", new Neighborhood("", "Kalvariyskaya", "17")))),
                new Country("France", new District("", new City("Paris", new Neighborhood("", "Napoleon", "32-1")))),
                new Country("German", new District("", new City("Berlin", new Neighborhood("West", "Klara", "18")))),
                new Country("USA", new District("Nevada", new City("Nevada", new Neighborhood("South", "Franklin", "48-7")))),
                new Country("Russia", new District("Tatarstan", new City("Kazan", new Neighborhood("", "Kommunisticheskaya", "6")))),
                new Country("Belarus", new District("Belarus", new City("Verbovichi", new Neighborhood("Narovlyansky", "Kommunarov", "2")))),
            };
        }
    }
}
