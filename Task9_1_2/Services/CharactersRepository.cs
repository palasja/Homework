using System.Collections.Generic;
using Task9_1_2.Models;

namespace Task9_1_2.Services
{
    public static class CharactersRepository
    {
        public static IEnumerable<Character> GetCharacters()
        {
            var characters = new List<Character>();

            characters.Add(new Character() { Id = 1, FirstName = "Naruto", LastName = "Uzumaki", Gender = true, Age = 14, StoryId = 1 });
            characters.Add(new Character() { Id = 2, FirstName = "Kushina", LastName = "Uzumaki", Gender = false, Age = 25, StoryId = 1 });
            characters.Add(new Character() { Id = 3, FirstName = "Ken", LastName = "Kaneki", Gender = true, Age = 20, StoryId = 2 });
            characters.Add(new Character() { Id = 4, FirstName = "Rory", LastName = "Merkury", Gender = false, Age = 961, StoryId = 3 });
            characters.Add(new Character() { Id = 5, FirstName = "Yōji ", LastName = "Itami", Gender = true, Age = 37, StoryId = 3 });
            characters.Add(new Character() { Id = 6, FirstName = "Anakin", LastName = "Skywalker", Gender = true, Age = 29, StoryId = 4 });
            characters.Add(new Character() { Id = 7, FirstName = "Frodo", LastName = "Begins", Gender = true, Age = 47, StoryId = 5 });
            characters.Add(new Character() { Id = 8, FirstName = "Bulba", LastName = "Bagins", Gender = true, Age = 100, StoryId = 6 });
            characters.Add(new Character() { Id = 9, FirstName = "Harry", LastName = "Potter", Gender = true, Age = 17, StoryId = 7 });
            characters.Add(new Character() { Id = 10, FirstName = "Newt", LastName = "Scamander", Gender = true, Age = 24, StoryId = 8 });
            

            return characters;
        }

    }
}