using Microsoft.EntityFrameworkCore.Migrations;

namespace Task8_1.Migrations
{
    public partial class SeedAuthor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "Id", "Name", "StoryId" },
                values: new object[,]
                {
                    { 1, "Masashu Kishimito", 1 },
                    { 2, "Sui Isida", 2 },
                    { 3, "Yanai Takumi", 3 },
                    { 4, "George Lucas", 4 },
                    { 5, "George R.R. Tolkien", 5 },
                    { 6, "Joanne Rowling", 6 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
