using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class changeInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Descrioption",
                table: "ServiceInfo",
                newName: "Description");

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

            migrationBuilder.UpdateData(
                table: "ServiceHardwares",
                keyColumn: "Id",
                keyValue: 1,
                column: "ServiceInfoId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "ServiceHardwares",
                keyColumn: "Id",
                keyValue: 2,
                column: "ServiceInfoId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "ServiceHardwares",
                keyColumn: "Id",
                keyValue: 3,
                column: "ServiceInfoId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "ServiceHardwares",
                keyColumn: "Id",
                keyValue: 4,
                column: "ServiceInfoId",
                value: 4);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "ServiceInfo",
                newName: "Descrioption");

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

            migrationBuilder.UpdateData(
                table: "ServiceHardwares",
                keyColumn: "Id",
                keyValue: 1,
                column: "ServiceInfoId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ServiceHardwares",
                keyColumn: "Id",
                keyValue: 2,
                column: "ServiceInfoId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ServiceHardwares",
                keyColumn: "Id",
                keyValue: 3,
                column: "ServiceInfoId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ServiceHardwares",
                keyColumn: "Id",
                keyValue: 4,
                column: "ServiceInfoId",
                value: 2);
        }
    }
}
