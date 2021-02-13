﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Task8_1.Models
{
    public class Author
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public int StoryId { get; set; }
        public Story Story { get; set; }
    }
}
