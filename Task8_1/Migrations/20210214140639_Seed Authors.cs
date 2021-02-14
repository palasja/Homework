using Microsoft.EntityFrameworkCore.Migrations;

namespace Task8_1.Migrations
{
    public partial class SeedAuthors : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AuthorId",
                table: "Stories",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Author",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Author", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Masashu Kishimito" },
                    { 2, "Sui Isida" },
                    { 3, "Yanai Takumi" },
                    { 4, "George Lucas" },
                    { 5, "George R.R. Tolkien" },
                    { 6, "Joanne Rowling" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Stories_AuthorId",
                table: "Stories",
                column: "AuthorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Stories_Author_AuthorId",
                table: "Stories",
                column: "AuthorId",
                principalTable: "Author",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stories_Author_AuthorId",
                table: "Stories");

            migrationBuilder.DropTable(
                name: "Author");

            migrationBuilder.DropIndex(
                name: "IX_Stories_AuthorId",
                table: "Stories");

            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "Stories");
        }
    }
}
