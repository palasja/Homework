using System;
using Task7_1.Services;

namespace Task7_1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new BookContext())
            {
                var books = BookServices.GetBooks();

                foreach (var book in books)
                {
                    context.Add(book);
                }

                context.SaveChanges();

                foreach (var c in context.Books)
                    Console.WriteLine($"Id: {c.Id},  \tName: {c.Name} \tAuthor: {c.Author} ");
            }
            
        }
    }
}
