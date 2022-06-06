using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectEditor.Persistence.Migrations
{
    public partial class initial_data_part1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    Updated = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FunctionSetups",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    ProjectId = table.Column<Guid>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    Updated = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FunctionSetups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LocationSetups",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    ProjectId = table.Column<Guid>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    Updated = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocationSetups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Functions",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    NameInSchematic = table.Column<string>(nullable: false),
                    FunctionSetupId = table.Column<Guid>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    Updated = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Functions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Functions_FunctionSetups_FunctionSetupId",
                        column: x => x.FunctionSetupId,
                        principalTable: "FunctionSetups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    NameInSchematic = table.Column<string>(nullable: false),
                    LocationSetupId = table.Column<Guid>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    Updated = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Locations_LocationSetups_LocationSetupId",
                        column: x => x.LocationSetupId,
                        principalTable: "LocationSetups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    CustomerId = table.Column<Guid>(nullable: true),
                    LocationSetupId = table.Column<Guid>(nullable: true),
                    FunctionSetupId = table.Column<Guid>(nullable: true),
                    ProjectManagerName = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    Updated = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true)
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
                    table.ForeignKey(
                        name: "FK_Projects_FunctionSetups_FunctionSetupId",
                        column: x => x.FunctionSetupId,
                        principalTable: "FunctionSetups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Projects_LocationSetups_LocationSetupId",
                        column: x => x.LocationSetupId,
                        principalTable: "LocationSetups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Devices",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    NameInSchematic = table.Column<string>(nullable: true),
                    LocationId = table.Column<Guid>(nullable: true),
                    FunctionId = table.Column<Guid>(nullable: true),
                    ProjectId = table.Column<Guid>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    Updated = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Devices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Devices_Functions_FunctionId",
                        column: x => x.FunctionId,
                        principalTable: "Functions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Devices_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Devices_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Created", "CreatedBy", "Name", "Updated", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("2a81c327-07a9-4b1d-a400-222b785f6481"), new DateTime(2022, 6, 6, 22, 30, 46, 868, DateTimeKind.Local).AddTicks(9158), "Created via DbContext", "DummyCustomer Mani & Friends", null, null },
                    { new Guid("02d2f7a4-8c6e-4f2e-873e-7edc45314939"), new DateTime(2022, 6, 6, 22, 30, 46, 871, DateTimeKind.Local).AddTicks(1881), "Created via DbContext", "DummyCustomer Hudli und Murks", null, null },
                    { new Guid("651dd1b3-5abe-4884-9be8-59338c6165c8"), new DateTime(2022, 6, 6, 22, 30, 46, 871, DateTimeKind.Local).AddTicks(1917), "Created via DbContext", "DummyCustomer Blue Monday", null, null }
                });

            migrationBuilder.InsertData(
                table: "FunctionSetups",
                columns: new[] { "Id", "Created", "CreatedBy", "Name", "ProjectId", "Updated", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("42280b59-961a-4d97-9b5d-b0fcb3eb85fa"), new DateTime(2022, 6, 6, 22, 30, 46, 873, DateTimeKind.Local).AddTicks(905), "Created via DbContext", "Setup for Project ED9C66C8-E2EB-4764-B625-96657B603D25", new Guid("ed9c66c8-e2eb-4764-b625-96657b603d25"), null, null },
                    { new Guid("b00f1038-72d3-44dc-9b49-7cb5cad7c656"), new DateTime(2022, 6, 6, 22, 30, 46, 873, DateTimeKind.Local).AddTicks(1150), "Created via DbContext", "Setup for Project 087B0654-C840-43A2-B827-90D47C5BA041", new Guid("087b0654-c840-43a2-b827-90d47c5ba041"), null, null },
                    { new Guid("7391de1f-3422-426c-a5c8-6695d1be7283"), new DateTime(2022, 6, 6, 22, 30, 46, 873, DateTimeKind.Local).AddTicks(1200), "Created via DbContext", "Setup for Project FE04D159-3CD6-4A19-A53E-48AB4425B5FD", new Guid("fe04d159-3cd6-4a19-a53e-48ab4425b5fd"), null, null }
                });

            migrationBuilder.InsertData(
                table: "LocationSetups",
                columns: new[] { "Id", "Created", "CreatedBy", "Name", "ProjectId", "Updated", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("31e84c75-a86d-481e-8433-22918d2b3a24"), new DateTime(2022, 6, 6, 22, 30, 46, 872, DateTimeKind.Local).AddTicks(6508), "Created via DbContext", "Setup for Project ED9C66C8-E2EB-4764-B625-96657B603D25", new Guid("ed9c66c8-e2eb-4764-b625-96657b603d25"), null, null },
                    { new Guid("7660ceb6-fda5-449e-ba09-9796d00c555f"), new DateTime(2022, 6, 6, 22, 30, 46, 872, DateTimeKind.Local).AddTicks(6801), "Created via DbContext", "Setup for Project 087B0654-C840-43A2-B827-90D47C5BA041", new Guid("087b0654-c840-43a2-b827-90d47c5ba041"), null, null },
                    { new Guid("375b873e-b57f-496f-a919-07f7a462a3c5"), new DateTime(2022, 6, 6, 22, 30, 46, 872, DateTimeKind.Local).AddTicks(6823), "Created via DbContext", "Setup for Project FE04D159-3CD6-4A19-A53E-48AB4425B5FD", new Guid("fe04d159-3cd6-4a19-a53e-48ab4425b5fd"), null, null }
                });

            migrationBuilder.InsertData(
                table: "Functions",
                columns: new[] { "Id", "Created", "CreatedBy", "Description", "FunctionSetupId", "NameInSchematic", "Updated", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("163de71d-3f88-4b0a-aed9-2d03d9d29bae"), new DateTime(2022, 6, 6, 22, 30, 46, 873, DateTimeKind.Local).AddTicks(3384), "Created via DbContext", "hold my beer", new Guid("42280b59-961a-4d97-9b5d-b0fcb3eb85fa"), "=Dummy.hmb", null, null },
                    { new Guid("fa4e431e-efe8-42f3-ba42-ea8c230567ae"), new DateTime(2022, 6, 6, 22, 30, 46, 873, DateTimeKind.Local).AddTicks(3670), "Created via DbContext", "dancing on the table", new Guid("b00f1038-72d3-44dc-9b49-7cb5cad7c656"), "=Dummy.dOtT", null, null },
                    { new Guid("495ac5cd-6c39-401e-b206-ef9f349407a4"), new DateTime(2022, 6, 6, 22, 30, 46, 873, DateTimeKind.Local).AddTicks(3691), "Created via DbContext", "execute supernova", new Guid("7391de1f-3422-426c-a5c8-6695d1be7283"), "=Dummy.SUPER", null, null }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Created", "CreatedBy", "Description", "LocationSetupId", "NameInSchematic", "Updated", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("03e6c2e0-de3b-4dad-9f73-98b26e206f3d"), new DateTime(2022, 6, 6, 22, 30, 46, 872, DateTimeKind.Local).AddTicks(8587), "Created via DbContext", "6 feet under", new Guid("31e84c75-a86d-481e-8433-22918d2b3a24"), "+Dummy.LocA", null, null },
                    { new Guid("c6074116-b961-4232-acb4-2c663ff456c8"), new DateTime(2022, 6, 6, 22, 30, 46, 872, DateTimeKind.Local).AddTicks(8875), "Created via DbContext", "up in sky", new Guid("7660ceb6-fda5-449e-ba09-9796d00c555f"), "+Dummy.LocB", null, null },
                    { new Guid("23d13a3a-245a-4178-8cce-09a9bd28781d"), new DateTime(2022, 6, 6, 22, 30, 46, 872, DateTimeKind.Local).AddTicks(8896), "Created via DbContext", "6 feet under", new Guid("375b873e-b57f-496f-a919-07f7a462a3c5"), "+Dummy.LocC", null, null }
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Created", "CreatedBy", "CustomerId", "Description", "FunctionSetupId", "LocationSetupId", "ProjectManagerName", "Updated", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("ed9c66c8-e2eb-4764-b625-96657b603d25"), new DateTime(2022, 6, 6, 22, 30, 46, 872, DateTimeKind.Local).AddTicks(3586), "Created via DbContext", new Guid("2a81c327-07a9-4b1d-a400-222b785f6481"), "TimeControl 2.1", null, new Guid("31e84c75-a86d-481e-8433-22918d2b3a24"), "Nero", null, null },
                    { new Guid("087b0654-c840-43a2-b827-90d47c5ba041"), new DateTime(2022, 6, 6, 22, 30, 46, 872, DateTimeKind.Local).AddTicks(3901), "Created via DbContext", new Guid("02d2f7a4-8c6e-4f2e-873e-7edc45314939"), "WeatherChanger V1.0", null, new Guid("7660ceb6-fda5-449e-ba09-9796d00c555f"), "Montgomery Burns", null, null },
                    { new Guid("fe04d159-3cd6-4a19-a53e-48ab4425b5fd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Created via DbContext", new Guid("651dd1b3-5abe-4884-9be8-59338c6165c8"), "Water2Wine Vers.A", null, new Guid("375b873e-b57f-496f-a919-07f7a462a3c5"), "Queen Mary", null, null }
                });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Created", "CreatedBy", "Description", "FunctionId", "LocationId", "NameInSchematic", "ProjectId", "Updated", "UpdatedBy" },
                values: new object[] { new Guid("93752f09-7eb5-4d1c-8c25-b744a5c4dbbe"), new DateTime(2022, 6, 6, 22, 30, 46, 873, DateTimeKind.Local).AddTicks(5716), "Created via DbContext", "DummyDevice A via DbContext", null, new Guid("03e6c2e0-de3b-4dad-9f73-98b26e206f3d"), "-K300", new Guid("ed9c66c8-e2eb-4764-b625-96657b603d25"), null, null });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Created", "CreatedBy", "Description", "FunctionId", "LocationId", "NameInSchematic", "ProjectId", "Updated", "UpdatedBy" },
                values: new object[] { new Guid("c5d683d9-f1f2-4c7a-9f3a-857ab00f2105"), new DateTime(2022, 6, 6, 22, 30, 46, 873, DateTimeKind.Local).AddTicks(6011), "Created via DbContext", "DummyDevice B via DbContext", null, new Guid("c6074116-b961-4232-acb4-2c663ff456c8"), "-S200", new Guid("087b0654-c840-43a2-b827-90d47c5ba041"), null, null });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Created", "CreatedBy", "Description", "FunctionId", "LocationId", "NameInSchematic", "ProjectId", "Updated", "UpdatedBy" },
                values: new object[] { new Guid("d4d2cf99-99f1-4e29-b429-c03a6f1ff492"), new DateTime(2022, 6, 6, 22, 30, 46, 873, DateTimeKind.Local).AddTicks(6033), "Created via DbContext", "DummyDevice C via DbContext", null, new Guid("23d13a3a-245a-4178-8cce-09a9bd28781d"), "-K100", new Guid("fe04d159-3cd6-4a19-a53e-48ab4425b5fd"), null, null });

            migrationBuilder.CreateIndex(
                name: "IX_Devices_FunctionId",
                table: "Devices",
                column: "FunctionId");

            migrationBuilder.CreateIndex(
                name: "IX_Devices_LocationId",
                table: "Devices",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Devices_ProjectId",
                table: "Devices",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Functions_FunctionSetupId",
                table: "Functions",
                column: "FunctionSetupId");

            migrationBuilder.CreateIndex(
                name: "IX_Locations_LocationSetupId",
                table: "Locations",
                column: "LocationSetupId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_CustomerId",
                table: "Projects",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_FunctionSetupId",
                table: "Projects",
                column: "FunctionSetupId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_LocationSetupId",
                table: "Projects",
                column: "LocationSetupId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Devices");

            migrationBuilder.DropTable(
                name: "Functions");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "FunctionSetups");

            migrationBuilder.DropTable(
                name: "LocationSetups");
        }
    }
}
