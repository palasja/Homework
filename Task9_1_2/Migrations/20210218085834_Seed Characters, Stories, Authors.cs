using Microsoft.EntityFrameworkCore.Migrations;

namespace Task9_1_2.Migrations
{
    public partial class SeedCharactersStoriesAuthors : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Author",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Author", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Stories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dedcription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AuthorId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Stories_Author_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Author",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<bool>(type: "bit", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    StoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Characters_Stories_StoryId",
                        column: x => x.StoryId,
                        principalTable: "Stories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "Masashu", "Kishimito" },
                    { 2, "Sui", "Isida" },
                    { 3, "Yanai", "Takumi" },
                    { 4, "George", "Lucas" },
                    { 5, "George", "R.R. Tolkien" },
                    { 6, "Joanne", "Rowling" }
                });

            migrationBuilder.InsertData(
                table: "Stories",
                columns: new[] { "Id", "AuthorId", "Dedcription", "Name" },
                values: new object[,]
                {
                    { 1, 1, "I will be hokage", "Naruto" },
                    { 2, 2, "World in harder than we think", "Tokio ghoul" },
                    { 3, 3, "None", "Gate" },
                    { 4, 4, "Don't trust boss", "Star Wars" },
                    { 5, 5, "Throw the ring into hill", "The Lord of the Rings" },
                    { 6, 5, "About Bulba Baggins", "The Hobbit or There and Back Again" },
                    { 7, 6, "The boy who's alive", "Harry Potter" },
                    { 8, 6, "Saver of Fantastic Beasts ", "Fantastic Beasts and Where to Find Them" }
                });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "Id", "Age", "FirstName", "Gender", "LastName", "StoryId" },
                values: new object[,]
                {
                    { 1, 14, "Naruto", true, "Uzumaki", 1 },
                    { 2, 25, "Kushina", false, "Uzumaki", 1 },
                    { 3, 20, "Ken", true, "Kaneki", 2 },
                    { 4, 961, "Rory", false, "Merkury", 3 },
                    { 5, 37, "Yōji ", true, "Itami", 3 },
                    { 6, 29, "Anakin", true, "Skywalker", 4 },
                    { 7, 47, "Frodo", true, "Begins", 5 },
                    { 8, 100, "Bulba", true, "Bagins", 6 },
                    { 9, 17, "Harry", true, "Potter", 7 },
                    { 10, 24, "Newt", true, "Scamander", 8 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Characters_StoryId",
                table: "Characters",
                column: "StoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Stories_AuthorId",
                table: "Stories",
                column: "AuthorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Characters");

            migrationBuilder.DropTable(
                name: "Stories");

            migrationBuilder.DropTable(
                name: "Author");
        }
    }
}
