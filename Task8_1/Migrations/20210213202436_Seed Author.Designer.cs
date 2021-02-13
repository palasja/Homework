﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Task8_1.Services;

namespace Task8_1.Migrations
{
    [DbContext(typeof(CharacterContext))]
    [Migration("20210213202436_Seed Author")]
    partial class SeedAuthor
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Task8_1.Models.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StoryId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StoryId");

                    b.ToTable("Author");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Masashu Kishimito",
                            StoryId = 1
                        },
                        new
                        {
                            Id = 2,
                            Name = "Sui Isida",
                            StoryId = 2
                        },
                        new
                        {
                            Id = 3,
                            Name = "Yanai Takumi",
                            StoryId = 3
                        },
                        new
                        {
                            Id = 4,
                            Name = "George Lucas",
                            StoryId = 4
                        },
                        new
                        {
                            Id = 5,
                            Name = "George R.R. Tolkien",
                            StoryId = 5
                        },
                        new
                        {
                            Id = 6,
                            Name = "Joanne Rowling",
                            StoryId = 6
                        });
                });

            modelBuilder.Entity("Task8_1.Models.Character", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Gender")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StoryId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StoryId");

                    b.ToTable("Characters");
                });

            modelBuilder.Entity("Task8_1.Models.Story", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Dedcription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Stories");
                });

            modelBuilder.Entity("Task8_1.Models.Author", b =>
                {
                    b.HasOne("Task8_1.Models.Story", "Story")
                        .WithMany("Authors")
                        .HasForeignKey("StoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Story");
                });

            modelBuilder.Entity("Task8_1.Models.Character", b =>
                {
                    b.HasOne("Task8_1.Models.Story", "Story")
                        .WithMany("Characters")
                        .HasForeignKey("StoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Story");
                });

            modelBuilder.Entity("Task8_1.Models.Story", b =>
                {
                    b.Navigation("Authors");

                    b.Navigation("Characters");
                });
#pragma warning restore 612, 618
        }
    }
}
