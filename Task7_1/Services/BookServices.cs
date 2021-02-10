using System;
using System.Collections.Generic;
using System.Text;

namespace Task7_1.Services
{
    static class BookServices
    {
        public static List<Book> GetBooks()
        {
            return new List<Book>() {
                new Book(){ Name = "Игра престолов", Author = "Дж Р Р Марти"},
                new Book(){ Name = "Гарри Поттер", Author = "Джоан Роулинг"},
                new Book(){ Name = "Война и мир", Author = "Толстой Л Н"},
            };
        }

    }
}
