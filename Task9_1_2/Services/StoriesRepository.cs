using Task9_1_2.Models;
using System.Collections.Generic;
using System.Linq;

namespace Task9_1_2.Services
{
    public static class StoriesRepository
    {
        public static IEnumerable<Story> GetStories()
        {
            var stories = new List<Story>();

            stories.Add(new Story() { Id = 1, Name = "Naruto", Dedcription = "I will be hokage", AuthorId = 1 });
            stories.Add(new Story() { Id = 2, Name = "Tokio ghoul", Dedcription = "World in harder than we think", AuthorId = 2 });
            stories.Add(new Story() { Id = 3, Name = "Gate", Dedcription = "None", AuthorId = 3 });
            stories.Add(new Story() { Id = 4, Name = "Star Wars", Dedcription = "Don't trust boss", AuthorId = 4 });
            stories.Add(new Story() { Id = 5, Name = "The Lord of the Rings", Dedcription = "Throw the ring into hill", AuthorId = 5 });
            stories.Add(new Story() { Id = 6, Name = "The Hobbit or There and Back Again", Dedcription = "About Bulba Baggins", AuthorId = 5 });
            stories.Add(new Story() { Id = 7, Name = "Harry Potter", Dedcription = "The boy who's alive", AuthorId = 6 });
            stories.Add(new Story() { Id = 8, Name = "Fantastic Beasts and Where to Find Them", Dedcription = "Saver of Fantastic Beasts ", AuthorId = 6 });

            return stories;
        }
    }
}