using System;
using System.Collections.Generic;
using System.Text;

namespace Task6_2
{
    class CharactersStory
    {
        public string FullName { get; set; }
        public string StoryName { get; set; }
        public string Description { get; set; }

        public CharactersStory(string fullName, string storyName, string description)
        {
            FullName = fullName;
            StoryName = storyName;
            Description = description;
        }
    }
}
