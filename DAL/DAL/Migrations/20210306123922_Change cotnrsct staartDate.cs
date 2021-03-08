using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class ChangecotnrsctstaartDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SatartDate",
                table: "Contracts",
                newName: "StartDate");

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2021, 3, 6, 15, 39, 22, 159, DateTimeKind.Local).AddTicks(2565), new DateTime(2021, 3, 6, 15, 39, 22, 157, DateTimeKind.Local).AddTicks(7763) });

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2021, 3, 6, 15, 39, 22, 159, DateTimeKind.Local).AddTicks(3690), new DateTime(2021, 3, 6, 15, 39, 22, 159, DateTimeKind.Local).AddTicks(3677) });

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2021, 3, 6, 15, 39, 22, 159, DateTimeKind.Local).AddTicks(3709), new DateTime(2021, 3, 6, 15, 39, 22, 159, DateTimeKind.Local).AddTicks(3707) });

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2021, 3, 6, 15, 39, 22, 159, DateTimeKind.Local).AddTicks(3712), new DateTime(2021, 3, 6, 15, 39, 22, 159, DateTimeKind.Local).AddTicks(3711) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StartDate",
                table: "Contracts",
                newName: "SatartDate");

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "SatartDate" },
                values: new object[] { new DateTime(2021, 3, 6, 11, 27, 8, 129, DateTimeKind.Local).AddTicks(5921), new DateTime(2021, 3, 6, 11, 27, 8, 127, DateTimeKind.Local).AddTicks(5707) });

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "SatartDate" },
                values: new object[] { new DateTime(2021, 3, 6, 11, 27, 8, 129, DateTimeKind.Local).AddTicks(7107), new DateTime(2021, 3, 6, 11, 27, 8, 129, DateTimeKind.Local).AddTicks(7089) });

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "SatartDate" },
                values: new object[] { new DateTime(2021, 3, 6, 11, 27, 8, 129, DateTimeKind.Local).AddTicks(7128), new DateTime(2021, 3, 6, 11, 27, 8, 129, DateTimeKind.Local).AddTicks(7127) });

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "SatartDate" },
                values: new object[] { new DateTime(2021, 3, 6, 11, 27, 8, 129, DateTimeKind.Local).AddTicks(7132), new DateTime(2021, 3, 6, 11, 27, 8, 129, DateTimeKind.Local).AddTicks(7130) });
        }
    }
}
