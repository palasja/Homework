using System;
using Task10_1dll;

namespace Task10_3dll
{
    public class Runner10_3
    {
        public void Run()
        {

            Author author = new Author() { Id = 1, FirstName = "Joanne", LastName = "Rowling" };

            SerializationServise.Save(author);

            SerializationServise.Load();
        }
    }
}

