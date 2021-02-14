using Task8_1.Models;
using System.Collections.Generic;
using System.Linq;
using Task8_1.Services;

namespace Task8_1
{
    public static class StoriesRepository
    {
        public static IEnumerable<Story> GetStories()
        {
            var stories = new List<Story>();

            stories.Add(new Story() { Name = "Naruto", Dedcription = "I will be hokage" });
            stories.Add(new Story() { Name = "Tokio ghoul", Dedcription = "World in harder than we think" });
            stories.Add(new Story() { Name = "Gate", Dedcription = "None" });
            stories.Add(new Story() { Name = "Star Wars", Dedcription = "Don't trust boss" });
            stories.Add(new Story() { Name = "The Lord of the Rings", Dedcription = "Throw the ring into hill" });
            stories.Add(new Story() { Name = "The Hobbit or There and Back Again", Dedcription = "About Bulba Baggins" });
            stories.Add(new Story() { Name = "Harry Potter", Dedcription = "The boy who's alive" });
            stories.Add(new Story() { Name = "Fantastic Beasts and Where to Find Them", Dedcription = "Saver of Fantastic Beasts " });

            return stories;
        }

        public static void InsertAuthor(CharacterContext context)
        {
            context.Stories.Where(s => s.Name == "Naruto").FirstOrDefault().AuthorId = 1;
            context.Stories.Where(s => s.Name == "Tokio ghoul").FirstOrDefault().AuthorId = 2;
            context.Stories.Where(s => s.Name == "Gate").FirstOrDefault().AuthorId = 3;
            context.Stories.Where(s => s.Name == "Star Wars").FirstOrDefault().AuthorId = 4;
            context.Stories.Where(s => s.Name == "The Lord of the Rings" ).FirstOrDefault().AuthorId = 5;
            context.Stories.Where(s => s.Name == "The Hobbit or There and Back Again").FirstOrDefault().AuthorId = 5;
            context.Stories.Where(s => s.Name == "Harry Potter").FirstOrDefault().AuthorId = 6;
            context.Stories.Where(s => s.Name == "Fantastic Beasts and Where to Find Them").FirstOrDefault().AuthorId = 6;
        }
    }
}