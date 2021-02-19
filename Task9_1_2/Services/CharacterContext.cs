using Task9_1_2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Task9_1_2.Services
{
    public class CharacterContext : DbContext
    {
        public DbSet<Character> Characters { get; set; }
        public DbSet<Story> Stories{ get; set; }
        public DbSet<Author> Author { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appconfig.json").Build();
            optionsBuilder.UseSqlServer(config.GetConnectionString("ConnectionStrings"));

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Story>().HasData(StoriesRepository.GetStories() );
            modelBuilder.Entity<Character>().HasData(CharactersRepository.GetCharacters());
            modelBuilder.Entity<Author>().HasData(AuthorsRepository.GetAuthors());

            modelBuilder.Entity<Character>().Property(c => c.FirstName).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Character>().Property(c => c.LastName).IsRequired().HasMaxLength(50);
        }
    }
}
