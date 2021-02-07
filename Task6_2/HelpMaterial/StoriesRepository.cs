using System.Collections.Generic;

namespace Task6_2
{
    public static class StoriesRepository
    {
        public static IEnumerable<Story> GetStories()
        {
            var stories = new List<Story>();

            stories.Add(new Story(1, "Naruto", "I will be hokage"));
            stories.Add(new Story(2, "Tokio ghoul", "World in harder than we think"));
            stories.Add(new Story(3, "Gate", "None"));
            stories.Add(new Story(4, "Star Wars", "Don't trust boss"));
            stories.Add(new Story(5, "The Lord of the Rings", "Throw the ring into hill"));
            stories.Add(new Story(6, "Harry Potter", "The boy who's alive"));

            return stories;
        }
    }
}