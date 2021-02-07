using System;
using System.Linq;

namespace Task6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var anonims = CharactersRepository.GetCharacters().Select(character => new { PersonDescription = character.ToString() });

            foreach (var desc in anonims)
            {
                Console.WriteLine(desc.PersonDescription);
            }
        }
    }
}
