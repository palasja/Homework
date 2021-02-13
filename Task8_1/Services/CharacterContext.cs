using Task8_1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Task8_1.Services
{
    class CharacterContext : DbContext
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
            modelBuilder.Entity<Author>().HasData(
                 new Author[]
            {
                new Author { Id=1, Name="Masashu Kishimito", StoryId=1},
                new Author { Id=2, Name="Sui Isida", StoryId=2},
                new Author { Id=3, Name="Yanai Takumi", StoryId=3},
                new Author { Id=4, Name="George Lucas", StoryId=4},
                new Author { Id=5, Name="George R.R. Tolkien", StoryId=5},
                new Author { Id=6, Name="Joanne Rowling", StoryId=6}
            });
        }
    }
}
