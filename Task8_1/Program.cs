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
            var context = new CharacterContext();
            /*            context.Stories.AddRange(StoriesRepository.GetStories());
                        context.SaveChanges();
                        context.Characters.AddRange(CharactersRepository.GetCharacters());
                        context.SaveChanges();*/


            var characters = context.Characters.Include(c => c.Story).Where(s => s.Id == context.).ToList();
            var Authors = context.Author.Include(s => s.Story).ToList();


            foreach (var character in characters)
            {
                Console.WriteLine($"{character.FirstName} {character.LastName}\t {character.Story?.Name}\t {character.Story.Authors.Name}");
            }

            foreach (var author in Authors)
            {
                
                Console.WriteLine($"{author.Name} {author.Story.Name}\t {author.Story?.Characters.Fir}\t {character.Story.Authors.ToString()}");
            }
        }
    }
}
