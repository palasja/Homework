using System;

namespace Task10_1dll
{
    [Author(1, "Author have fuill name ")]
    [Author(2, "Use AuthorNick for nickname ")]
    public class Author
    {
        public int Id { get; set; }
        [Author(3, "Property save name")]
        public string FirstName { get; set; }
        [Author(4, "Property save lastname")]
        public string LastName { get; set; }

        public Author()
        {
        }

        public Author(int id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }

        public void Hi()
        {
            Console.WriteLine($"Hi from {FirstName} {LastName}");
        }
        private void Bye()
        {
            Console.WriteLine($"Bye {FirstName} {LastName}");
        }
    }
}
