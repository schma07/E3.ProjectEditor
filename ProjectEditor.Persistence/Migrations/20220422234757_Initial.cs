using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectEditor.Persistence.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CustomerId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Projects_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Devices",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    ProjectId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Devices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Devices_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("2a81c327-07a9-4b1d-a400-222b785f6481"), "DummyCustomer Mani & Friends" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("02d2f7a4-8c6e-4f2e-873e-7edc45314939"), "DummyCustomer Hudli und Murks" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("651dd1b3-5abe-4884-9be8-59338c6165c8"), "DummyCustomer Blue Monday" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "CustomerId" },
                values: new object[] { new Guid("ed9c66c8-e2eb-4764-b625-96657b603d25"), new Guid("2a81c327-07a9-4b1d-a400-222b785f6481") });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "CustomerId" },
                values: new object[] { new Guid("087b0654-c840-43a2-b827-90d47c5ba041"), new Guid("02d2f7a4-8c6e-4f2e-873e-7edc45314939") });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "CustomerId" },
                values: new object[] { new Guid("fe04d159-3cd6-4a19-a53e-48ab4425b5fd"), new Guid("651dd1b3-5abe-4884-9be8-59338c6165c8") });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "ProjectId" },
                values: new object[] { new Guid("93752f09-7eb5-4d1c-8c25-b744a5c4dbbe"), "Star Trek Discovery Season 1", new Guid("ed9c66c8-e2eb-4764-b625-96657b603d25") });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "ProjectId" },
                values: new object[] { new Guid("c5d683d9-f1f2-4c7a-9f3a-857ab00f2105"), "Stirb langsam", new Guid("087b0654-c840-43a2-b827-90d47c5ba041") });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "ProjectId" },
                values: new object[] { new Guid("d4d2cf99-99f1-4e29-b429-c03a6f1ff492"), "Titanic", new Guid("fe04d159-3cd6-4a19-a53e-48ab4425b5fd") });

            migrationBuilder.CreateIndex(
                name: "IX_Devices_ProjectId",
                table: "Devices",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_CustomerId",
                table: "Projects",
                column: "CustomerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Devices");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
