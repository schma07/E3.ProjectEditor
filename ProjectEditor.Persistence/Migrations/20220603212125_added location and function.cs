using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectEditor.Persistence.Migrations
{
    public partial class addedlocationandfunction : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Timestamp",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "Timestamp",
                table: "Devices");

            migrationBuilder.DropColumn(
                name: "Timestamp",
                table: "Customers");

            migrationBuilder.AddColumn<string>(
                name: "ProjectManagerName",
                table: "Projects",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NameInSchematic",
                table: "Devices",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Functions",
                columns: table => new
                {
                    NameInSchematic = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    Updated = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    ProjectId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Functions", x => x.NameInSchematic);
                    table.ForeignKey(
                        name: "FK_Functions_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    NameInSchematic = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    Updated = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    ProjectId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.NameInSchematic);
                    table.ForeignKey(
                        name: "FK_Locations_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("93752f09-7eb5-4d1c-8c25-b744a5c4dbbe"),
                columns: new[] { "Name", "NameInSchematic" },
                values: new object[] { "DummyDevice A via DbContext", "-K300" });

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("c5d683d9-f1f2-4c7a-9f3a-857ab00f2105"),
                columns: new[] { "Name", "NameInSchematic" },
                values: new object[] { "DummyDevice B via DbContext", "-S200" });

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("d4d2cf99-99f1-4e29-b429-c03a6f1ff492"),
                columns: new[] { "Name", "NameInSchematic" },
                values: new object[] { "DummyDevice C via DbContext", "-K100" });

            migrationBuilder.InsertData(
                table: "Functions",
                columns: new[] { "NameInSchematic", "Created", "CreatedBy", "Description", "ProjectId", "Updated", "UpdatedBy" },
                values: new object[,]
                {
                    { "=Dummy.hmb", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "hold my beer", new Guid("ed9c66c8-e2eb-4764-b625-96657b603d25"), null, null },
                    { "=Dummy.dOtT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "dancing on the table", new Guid("087b0654-c840-43a2-b827-90d47c5ba041"), null, null },
                    { "=Dummy.SUPER", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "execute supernova", new Guid("fe04d159-3cd6-4a19-a53e-48ab4425b5fd"), null, null }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "NameInSchematic", "Created", "CreatedBy", "Description", "ProjectId", "Updated", "UpdatedBy" },
                values: new object[,]
                {
                    { "+Dummy.LocA", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "6 feet under", new Guid("ed9c66c8-e2eb-4764-b625-96657b603d25"), null, null },
                    { "+Dummy.LocB", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "up in sky", new Guid("087b0654-c840-43a2-b827-90d47c5ba041"), null, null },
                    { "+Dummy.LocC", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "6 feet under", new Guid("fe04d159-3cd6-4a19-a53e-48ab4425b5fd"), null, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Functions_ProjectId",
                table: "Functions",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Locations_ProjectId",
                table: "Locations",
                column: "ProjectId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Functions");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropColumn(
                name: "ProjectManagerName",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "NameInSchematic",
                table: "Devices");

            migrationBuilder.AddColumn<byte[]>(
                name: "Timestamp",
                table: "Projects",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Timestamp",
                table: "Devices",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Timestamp",
                table: "Customers",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("93752f09-7eb5-4d1c-8c25-b744a5c4dbbe"),
                column: "Name",
                value: "DummyDevice -K300");

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("c5d683d9-f1f2-4c7a-9f3a-857ab00f2105"),
                column: "Name",
                value: "DummyDevice -S200");

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("d4d2cf99-99f1-4e29-b429-c03a6f1ff492"),
                column: "Name",
                value: "DummyDevice -S450");
        }
    }
}
