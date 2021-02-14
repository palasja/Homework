using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Task8_1.Services;

namespace Task8_1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new CharacterContext())
            {
                /*                context.Stories.AddRange(StoriesRepository.GetStories());
                                context.SaveChanges();
                                context.Characters.AddRange(CharactersRepository.GetCharacters());
                                context.SaveChanges();*/

                StoriesRepository.InsertAuthor(context);
                context.SaveChanges();

                var characters = context.Characters.Include(c => c.Story).ThenInclude(s => s.Author).ToList();


                foreach (var character in characters)
                {
                    Console.WriteLine($"" +
                        $"{character.FirstName} {character.LastName}\t " +
                        $"{character.Story.Name}\t "+ 
                        $"{character.Story.Author.Name}");
                }

            }

        }
    }
}
