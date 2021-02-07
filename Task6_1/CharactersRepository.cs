using System.Collections.Generic;

namespace Task6_1
{
    public static class CharactersRepository
    {
        public static IEnumerable<Character> GetCharacters()
        {
            var characters = new List<Character>();

            characters.Add(new Character("Naruto", "Uzumaki", true, 14, 1, "Naruto"));
            characters.Add(new Character("Kushina", "Uzumaki", false, 25, 1, "Naruto"));
            characters.Add(new Character("Ken", "Kaneki", true, 20, 2, "Tokio ghoul"));
            characters.Add(new Character("Rory", "Merkury", false, 961, 3, "Gate"));
            characters.Add(new Character("Yōji ", "Itami", true, 37, 3, "Gate"));
            characters.Add(new Character("Anakin", "Skywalker", true, 29, 4, "Star Wars"));
            characters.Add(new Character("Frodo", "Begins", true, 47, 5, "The Lord of the Rings"));
            characters.Add(new Character("Bulba", "Bagins", true, 100, 5, "The Lord of the Rings"));
            characters.Add(new Character("Harry", "Potter", true, 17, 6, "Harry Potter"));
            characters.Add(new Character("Sersya", "Lanister", false, 45, 7, "Game of the Throne"));
            characters.Add(new Character("Arya", "Stark", false, 14, 7, "Game of the Throne"));

            return characters;
        }
    }
}