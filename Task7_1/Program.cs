using System;
using Task7_1.Services;

namespace Task7_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new BookContext();
            var books = BookServices.GetBooks();

            foreach (var book in books)
            {
                context.Add(book);
            }

            context.SaveChanges();
        }
    }
}
