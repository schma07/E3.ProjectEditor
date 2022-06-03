using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectEditor.Persistence.Migrations
{
    public partial class addedlocationandfunctionwithcorrections : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("02d2f7a4-8c6e-4f2e-873e-7edc45314939"),
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2022, 6, 3, 23, 48, 44, 174, DateTimeKind.Local).AddTicks(64), "Created via DbContext" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("2a81c327-07a9-4b1d-a400-222b785f6481"),
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2022, 6, 3, 23, 48, 44, 170, DateTimeKind.Local).AddTicks(4156), "Created via DbContext" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("651dd1b3-5abe-4884-9be8-59338c6165c8"),
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2022, 6, 3, 23, 48, 44, 174, DateTimeKind.Local).AddTicks(107), "Created via DbContext" });

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("93752f09-7eb5-4d1c-8c25-b744a5c4dbbe"),
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2022, 6, 3, 23, 48, 44, 175, DateTimeKind.Local).AddTicks(8978), "Created via DbContext" });

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("c5d683d9-f1f2-4c7a-9f3a-857ab00f2105"),
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2022, 6, 3, 23, 48, 44, 175, DateTimeKind.Local).AddTicks(9276), "Created via DbContext" });

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("d4d2cf99-99f1-4e29-b429-c03a6f1ff492"),
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2022, 6, 3, 23, 48, 44, 175, DateTimeKind.Local).AddTicks(9296), "Created via DbContext" });

            migrationBuilder.UpdateData(
                table: "Functions",
                keyColumn: "NameInSchematic",
                keyValue: "=Dummy.dOtT",
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2022, 6, 3, 23, 48, 44, 175, DateTimeKind.Local).AddTicks(7191), "Created via DbContext" });

            migrationBuilder.UpdateData(
                table: "Functions",
                keyColumn: "NameInSchematic",
                keyValue: "=Dummy.hmb",
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2022, 6, 3, 23, 48, 44, 175, DateTimeKind.Local).AddTicks(6906), "Created via DbContext" });

            migrationBuilder.UpdateData(
                table: "Functions",
                keyColumn: "NameInSchematic",
                keyValue: "=Dummy.SUPER",
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2022, 6, 3, 23, 48, 44, 175, DateTimeKind.Local).AddTicks(7208), "Created via DbContext" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "NameInSchematic",
                keyValue: "+Dummy.LocA",
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2022, 6, 3, 23, 48, 44, 175, DateTimeKind.Local).AddTicks(5244), "Created via DbContext" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "NameInSchematic",
                keyValue: "+Dummy.LocB",
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2022, 6, 3, 23, 48, 44, 175, DateTimeKind.Local).AddTicks(5548), "Created via DbContext" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "NameInSchematic",
                keyValue: "+Dummy.LocC",
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(2022, 6, 3, 23, 48, 44, 175, DateTimeKind.Local).AddTicks(5567), "Created via DbContext" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: new Guid("087b0654-c840-43a2-b827-90d47c5ba041"),
                columns: new[] { "Created", "CreatedBy", "ProjectManagerName" },
                values: new object[] { new DateTime(2022, 6, 3, 23, 48, 44, 175, DateTimeKind.Local).AddTicks(3930), "Created via DbContext", "Montgomery Burns" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: new Guid("ed9c66c8-e2eb-4764-b625-96657b603d25"),
                columns: new[] { "Created", "CreatedBy", "ProjectManagerName" },
                values: new object[] { new DateTime(2022, 6, 3, 23, 48, 44, 175, DateTimeKind.Local).AddTicks(3583), "Created via DbContext", "Nero" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: new Guid("fe04d159-3cd6-4a19-a53e-48ab4425b5fd"),
                columns: new[] { "CreatedBy", "ProjectManagerName" },
                values: new object[] { "Created via DbContext", "Queen Mary" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("02d2f7a4-8c6e-4f2e-873e-7edc45314939"),
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("2a81c327-07a9-4b1d-a400-222b785f6481"),
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("651dd1b3-5abe-4884-9be8-59338c6165c8"),
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("93752f09-7eb5-4d1c-8c25-b744a5c4dbbe"),
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("c5d683d9-f1f2-4c7a-9f3a-857ab00f2105"),
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("d4d2cf99-99f1-4e29-b429-c03a6f1ff492"),
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Functions",
                keyColumn: "NameInSchematic",
                keyValue: "=Dummy.dOtT",
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Functions",
                keyColumn: "NameInSchematic",
                keyValue: "=Dummy.hmb",
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Functions",
                keyColumn: "NameInSchematic",
                keyValue: "=Dummy.SUPER",
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "NameInSchematic",
                keyValue: "+Dummy.LocA",
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "NameInSchematic",
                keyValue: "+Dummy.LocB",
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "NameInSchematic",
                keyValue: "+Dummy.LocC",
                columns: new[] { "Created", "CreatedBy" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: new Guid("087b0654-c840-43a2-b827-90d47c5ba041"),
                columns: new[] { "Created", "CreatedBy", "ProjectManagerName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: new Guid("ed9c66c8-e2eb-4764-b625-96657b603d25"),
                columns: new[] { "Created", "CreatedBy", "ProjectManagerName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: new Guid("fe04d159-3cd6-4a19-a53e-48ab4425b5fd"),
                columns: new[] { "CreatedBy", "ProjectManagerName" },
                values: new object[] { null, null });
        }
    }
}
