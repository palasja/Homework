using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class add : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Areas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SimpleName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Areas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ServiceInfo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MainCost = table.Column<double>(type: "float", nullable: false),
                    AdditionalCost = table.Column<double>(type: "float", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Organizations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Smdo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AreaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organizations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Organizations_Areas_AreaId",
                        column: x => x.AreaId,
                        principalTable: "Areas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Contracts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    OrganizationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contracts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contracts_Organizations_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MobilePhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrganizationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.Id);
                    table.ForeignKey(
                        name: "FK_People_Organizations_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ServiceHardwares",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServerCount = table.Column<int>(type: "int", nullable: false),
                    WorkplaceCount = table.Column<int>(type: "int", nullable: false),
                    ServiceInfoId = table.Column<int>(type: "int", nullable: false),
                    ContractId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceHardwares", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ServiceHardwares_Contracts_ContractId",
                        column: x => x.ContractId,
                        principalTable: "Contracts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ServiceHardwares_ServiceInfo_ServiceInfoId",
                        column: x => x.ServiceInfoId,
                        principalTable: "ServiceInfo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ServiceSoftwares",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MainPlaceCount = table.Column<int>(type: "int", nullable: false),
                    AdditionalPlaceCount = table.Column<int>(type: "int", nullable: false),
                    ServiceInfoId = table.Column<int>(type: "int", nullable: false),
                    ContractId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceSoftwares", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ServiceSoftwares_Contracts_ContractId",
                        column: x => x.ContractId,
                        principalTable: "Contracts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ServiceSoftwares_ServiceInfo_ServiceInfoId",
                        column: x => x.ServiceInfoId,
                        principalTable: "ServiceInfo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Areas",
                columns: new[] { "Id", "FullName", "SimpleName" },
                values: new object[,]
                {
                    { 1, "Гомельская область", "Гомель обл" },
                    { 2, "Мозырский район", "Мозырь" },
                    { 3, "Наровлянский район", "Наровля" },
                    { 4, "город Минск", "Минск" }
                });

            migrationBuilder.InsertData(
                table: "ServiceInfo",
                columns: new[] { "Id", "AdditionalCost", "Description", "MainCost", "Name" },
                values: new object[,]
                {
                    { 1, 15.300000000000001, "Консультации, удалённая поддержка. При необходимости выезд к клиенту", 23.5, "Обслуживание КлиентТК" },
                    { 2, 14.199999999999999, "Установкаю, консультации, удалённая поддержка. При необходимости выезд к клиенту.", 19.300000000000001, "Обслуживание ГРС" },
                    { 3, 26.300000000000001, "Обслуживание техники. Ежемесечная проверка с диагностикой на месте эксплуатации.", 32.159999999999997, "Сопровождение вычислительно техники" },
                    { 4, 21.600000000000001, "Удалённое бслуживание техники без выезда на место", 25.859999999999999, "Удалённое сопровождение вычислительно техники" }
                });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Address", "AreaId", "Email", "FullName", "Name", "Smdo" },
                values: new object[,]
                {
                    { 1, "ул Ленина 18", 1, "GomelOblFu@gomel.by", "Областное финансовое упрвление", "Обл ФУ", "Org1235" },
                    { 2, "д. Лесовики 3", 2, "NPZ@npz.by", "Мозырский нефтеперерабатывающий завод", "НПЗ", "Org48693" },
                    { 3, "ул фабричная 1", 3, "Korovka@korovka.by", "ОАО Красный Мозырянин", "Красный мозырянин", null },
                    { 4, "ул Коммунистическая 4", 3, "Narovlya@roo.gomel.by", "Районный отдел образования", "Роо", null },
                    { 5, "ул Заводская 85/4", 4, "Keramin@keramin.by", "ЗАО Керамин", "Керамин", null }
                });

            migrationBuilder.InsertData(
                table: "Contracts",
                columns: new[] { "Id", "EndDate", "Number", "OrganizationId", "StartDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 3, 10, 19, 18, 58, 412, DateTimeKind.Local).AddTicks(4248), "12-123/ВК6", 1, new DateTime(2021, 3, 10, 19, 18, 58, 411, DateTimeKind.Local).AddTicks(725) },
                    { 2, new DateTime(2021, 3, 10, 19, 18, 58, 412, DateTimeKind.Local).AddTicks(5465), "12-1/ГК6", 2, new DateTime(2021, 3, 10, 19, 18, 58, 412, DateTimeKind.Local).AddTicks(5451) },
                    { 3, new DateTime(2021, 3, 10, 19, 18, 58, 412, DateTimeKind.Local).AddTicks(5485), "33-4/НК-6", 3, new DateTime(2021, 3, 10, 19, 18, 58, 412, DateTimeKind.Local).AddTicks(5483) },
                    { 4, new DateTime(2021, 3, 10, 19, 18, 58, 412, DateTimeKind.Local).AddTicks(5489), "4484/ОИ-6", 4, new DateTime(2021, 3, 10, 19, 18, 58, 412, DateTimeKind.Local).AddTicks(5488) }
                });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "MiddleName", "MobilePhone", "OrganizationId", "Phone", "Position" },
                values: new object[,]
                {
                    { 1, "KovalchukAV@gomel.by", "Алёна", "Ковальчук", "Витальевна", null, 1, "80232-23-56-84", "Главный экономист" },
                    { 2, "PesokovVI@npz.by", "Валерий", "Песоков", "Игнатьевич", null, 2, "80236-34-52-68", "Главный специалист" },
                    { 3, null, "Василий", "Фонрос", "Иванович", null, 3, "802355-4-58-22", null },
                    { 4, null, "Анастасия", "Катонова", "Васильвна", null, 4, "802355-4-26-84", "Главный бухгалтер" },
                    { 5, "BulbaII@keramin.by", "Ирина", "Бульба", "Игнатьевна", null, 5, "8017-45-78-32", null }
                });

            migrationBuilder.InsertData(
                table: "ServiceHardwares",
                columns: new[] { "Id", "ContractId", "ServerCount", "ServiceInfoId", "WorkplaceCount" },
                values: new object[,]
                {
                    { 1, 1, 0, 3, 2 },
                    { 2, 2, 0, 4, 5 },
                    { 4, 3, 1, 4, 2 },
                    { 3, 4, 1, 3, 5 }
                });

            migrationBuilder.InsertData(
                table: "ServiceSoftwares",
                columns: new[] { "Id", "AdditionalPlaceCount", "ContractId", "MainPlaceCount", "ServiceInfoId" },
                values: new object[,]
                {
                    { 1, 0, 1, 1, 1 },
                    { 2, 0, 2, 1, 2 },
                    { 3, 1, 3, 1, 1 },
                    { 4, 0, 4, 1, 2 },
                    { 5, 1, 4, 0, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_OrganizationId",
                table: "Contracts",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_Organizations_AreaId",
                table: "Organizations",
                column: "AreaId");

            migrationBuilder.CreateIndex(
                name: "IX_People_OrganizationId",
                table: "People",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceHardwares_ContractId",
                table: "ServiceHardwares",
                column: "ContractId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceHardwares_ServiceInfoId",
                table: "ServiceHardwares",
                column: "ServiceInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceSoftwares_ContractId",
                table: "ServiceSoftwares",
                column: "ContractId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceSoftwares_ServiceInfoId",
                table: "ServiceSoftwares",
                column: "ServiceInfoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "People");

            migrationBuilder.DropTable(
                name: "ServiceHardwares");

            migrationBuilder.DropTable(
                name: "ServiceSoftwares");

            migrationBuilder.DropTable(
                name: "Contracts");

            migrationBuilder.DropTable(
                name: "ServiceInfo");

            migrationBuilder.DropTable(
                name: "Organizations");

            migrationBuilder.DropTable(
                name: "Areas");
        }
    }
}
