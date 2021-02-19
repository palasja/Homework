using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Task9_1_2.Services;

namespace Task9_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new CharacterContext())
            {
                var characters = context.Characters.Include(c => c.Story).ThenInclude(s => s.Author).ToList();

                foreach (var character in characters)
                {
                    Console.WriteLine($"" +
                        $"{character.FirstName} {character.LastName}\n\t " +
                        $"{character.Story.Name}\n\t\t " + 
                        $"{character.Story.Author.FirstName} {character.Story.Author.LastName}");
                }

            }

        }
    }
}
