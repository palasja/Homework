using Task8_1.Models;
using System.Collections.Generic;

namespace Task8_1
{
    public static class CharactersRepository
    {
        public static IEnumerable<Character> GetCharacters()
        {
            var characters = new List<Character>();

            characters.Add(new Character() { FirstName = "Naruto", LastName = "Uzumaki", Gender = true, Age = 14, StoryId = 1 });
            characters.Add(new Character() { FirstName = "Kushina", LastName = "Uzumaki", Gender = false, Age = 25, StoryId = 1 });
            characters.Add(new Character() { FirstName = "Ken", LastName = "Kaneki", Gender = true, Age = 20, StoryId = 2 });
            characters.Add(new Character() { FirstName = "Rory", LastName = "Merkury", Gender = false, Age = 961, StoryId = 3 });
            characters.Add(new Character() { FirstName = "Yōji ", LastName = "Itami", Gender = true, Age = 37, StoryId = 3 });
            characters.Add(new Character() { FirstName = "Anakin", LastName = "Skywalker", Gender = true, Age = 29, StoryId = 4 });
            characters.Add(new Character() { FirstName = "Frodo", LastName = "Begins", Gender = true, Age = 47, StoryId = 5 });
            characters.Add(new Character() { FirstName = "Bulba", LastName = "Bagins", Gender = true, Age = 100, StoryId = 5 });
            characters.Add(new Character() { FirstName = "Harry", LastName = "Potter", Gender = true, Age = 17, StoryId = 6 });

            return characters;
        }
    }
}