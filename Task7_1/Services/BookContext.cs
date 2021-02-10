
using Microsoft.EntityFrameworkCore;
using System;
using System.Configuration;

namespace Task7_1
{
     class BookContext : DbContext
    {
        public DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-D4T5739\\SQLEXPRESS;Initial Catalog=Task7;Integrated Security=SSPI;");
        }
    }
}
