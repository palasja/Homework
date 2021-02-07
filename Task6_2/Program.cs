using System;
using System.Linq;

namespace Task6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var stories = StoriesRepository.GetStories();
            var characters = CharactersRepository.GetCharacters();


            var joinResult = from characater in characters
                             join story in stories
                             on characater.StoryId equals story.Id into characterStory
                             from story in characterStory.DefaultIfEmpty()
                             select new
                             {
                                 characater.FirstName,
                                 characater.LastName,
                                 StoryName = story == null ? "No story" : story.Name
                             };

            var join = from character in characters
                       join  story in stories
                       on character.StoryId equals story.Id into characterStories
                       from characterStory in characterStories.DefaultIfEmpty()
                       select new CharactersStory(character.FirstName +" "+ character.LastName, characterStory?.Name, characterStory?.Description);

            foreach (var characterStory in join)
            {
                if (characterStory.StoryName != null)
                {
                    Console.WriteLine($"{characterStory.FullName} from {characterStory.StoryName}. It tell {characterStory.Description}");
                }
                else 
                {
                    Console.WriteLine($"{characterStory.FullName}");
                }
                    
            }
        }
    }
}
