using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class _123 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "SatartDate" },
                values: new object[] { new DateTime(2021, 3, 4, 20, 2, 6, 897, DateTimeKind.Local).AddTicks(4499), new DateTime(2021, 3, 4, 20, 2, 6, 895, DateTimeKind.Local).AddTicks(5657) });

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "SatartDate" },
                values: new object[] { new DateTime(2021, 3, 4, 20, 2, 6, 897, DateTimeKind.Local).AddTicks(5656), new DateTime(2021, 3, 4, 20, 2, 6, 897, DateTimeKind.Local).AddTicks(5642) });

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "SatartDate" },
                values: new object[] { new DateTime(2021, 3, 4, 20, 2, 6, 897, DateTimeKind.Local).AddTicks(5679), new DateTime(2021, 3, 4, 20, 2, 6, 897, DateTimeKind.Local).AddTicks(5677) });

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "SatartDate" },
                values: new object[] { new DateTime(2021, 3, 4, 20, 2, 6, 897, DateTimeKind.Local).AddTicks(5683), new DateTime(2021, 3, 4, 20, 2, 6, 897, DateTimeKind.Local).AddTicks(5681) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "SatartDate" },
                values: new object[] { new DateTime(2021, 3, 2, 16, 5, 27, 982, DateTimeKind.Local).AddTicks(5019), new DateTime(2021, 3, 2, 16, 5, 27, 981, DateTimeKind.Local).AddTicks(5795) });

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "SatartDate" },
                values: new object[] { new DateTime(2021, 3, 2, 16, 5, 27, 982, DateTimeKind.Local).AddTicks(5688), new DateTime(2021, 3, 2, 16, 5, 27, 982, DateTimeKind.Local).AddTicks(5679) });

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "SatartDate" },
                values: new object[] { new DateTime(2021, 3, 2, 16, 5, 27, 982, DateTimeKind.Local).AddTicks(5701), new DateTime(2021, 3, 2, 16, 5, 27, 982, DateTimeKind.Local).AddTicks(5700) });

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "SatartDate" },
                values: new object[] { new DateTime(2021, 3, 2, 16, 5, 27, 982, DateTimeKind.Local).AddTicks(5704), new DateTime(2021, 3, 2, 16, 5, 27, 982, DateTimeKind.Local).AddTicks(5703) });
        }
    }
}
