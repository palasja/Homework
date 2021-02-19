using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Task9_1_2.Models
{
    [Index(nameof(FirstName), nameof(LastName))]
    public class Author
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Story> Story { get; set; }
    }
}
