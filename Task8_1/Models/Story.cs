using System;
using System.Collections.Generic;
using System.Text;

namespace Task8_1.Models
{
    public class Story
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Dedcription { get; set; }

        public List<Character> Characters { get; set; }

        public int? AuthorId { get; set; }
        public Author Author { get; set; }


    }
}
