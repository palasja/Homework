using Task8_1.Models;
using System.Collections.Generic;

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
            stories.Add(new Story() { Name = "Harry Potter", Dedcription = "The boy who's alive" });

            return stories;
        }
    }
}