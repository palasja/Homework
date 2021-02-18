using System;
using System.Collections.Generic;
using System.Text;
using Task9_1_2.Models;

namespace Task9_1_2.Services
{
    class AuthorsRepository
    {
        public static IEnumerable<Author> GetAuthors()
        {
            var authors = new List<Author>();

            authors.Add(new Author { Id = 1, FirstName = "Masashu", LastName = "Kishimito" });
            authors.Add(new Author { Id = 2, FirstName = "Sui", LastName = "Isida" });
            authors.Add(new Author { Id = 3, FirstName = "Yanai", LastName = "Takumi" });
            authors.Add(new Author { Id = 4, FirstName = "George", LastName = "Lucas" });
            authors.Add(new Author { Id = 5, FirstName = "George", LastName = "R.R. Tolkien" });
            authors.Add(new Author { Id = 6, FirstName = "Joanne", LastName = "Rowling" });

            return authors;
        }
    }
}
