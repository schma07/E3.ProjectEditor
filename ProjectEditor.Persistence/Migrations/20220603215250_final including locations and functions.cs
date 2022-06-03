using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectEditor.Persistence.Migrations
{
    public partial class finalincludinglocationsandfunctions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("02d2f7a4-8c6e-4f2e-873e-7edc45314939"),
                column: "Created",
                value: new DateTime(2022, 6, 3, 23, 52, 50, 402, DateTimeKind.Local).AddTicks(1325));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("2a81c327-07a9-4b1d-a400-222b785f6481"),
                column: "Created",
                value: new DateTime(2022, 6, 3, 23, 52, 50, 400, DateTimeKind.Local).AddTicks(2296));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("651dd1b3-5abe-4884-9be8-59338c6165c8"),
                column: "Created",
                value: new DateTime(2022, 6, 3, 23, 52, 50, 402, DateTimeKind.Local).AddTicks(1357));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("93752f09-7eb5-4d1c-8c25-b744a5c4dbbe"),
                column: "Created",
                value: new DateTime(2022, 6, 3, 23, 52, 50, 403, DateTimeKind.Local).AddTicks(8659));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("c5d683d9-f1f2-4c7a-9f3a-857ab00f2105"),
                column: "Created",
                value: new DateTime(2022, 6, 3, 23, 52, 50, 403, DateTimeKind.Local).AddTicks(8942));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("d4d2cf99-99f1-4e29-b429-c03a6f1ff492"),
                column: "Created",
                value: new DateTime(2022, 6, 3, 23, 52, 50, 403, DateTimeKind.Local).AddTicks(8963));

            migrationBuilder.UpdateData(
                table: "Functions",
                keyColumn: "NameInSchematic",
                keyValue: "=Dummy.dOtT",
                column: "Created",
                value: new DateTime(2022, 6, 3, 23, 52, 50, 403, DateTimeKind.Local).AddTicks(6842));

            migrationBuilder.UpdateData(
                table: "Functions",
                keyColumn: "NameInSchematic",
                keyValue: "=Dummy.hmb",
                column: "Created",
                value: new DateTime(2022, 6, 3, 23, 52, 50, 403, DateTimeKind.Local).AddTicks(6569));

            migrationBuilder.UpdateData(
                table: "Functions",
                keyColumn: "NameInSchematic",
                keyValue: "=Dummy.SUPER",
                column: "Created",
                value: new DateTime(2022, 6, 3, 23, 52, 50, 403, DateTimeKind.Local).AddTicks(6858));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "NameInSchematic",
                keyValue: "+Dummy.LocA",
                column: "Created",
                value: new DateTime(2022, 6, 3, 23, 52, 50, 403, DateTimeKind.Local).AddTicks(4640));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "NameInSchematic",
                keyValue: "+Dummy.LocB",
                column: "Created",
                value: new DateTime(2022, 6, 3, 23, 52, 50, 403, DateTimeKind.Local).AddTicks(5220));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "NameInSchematic",
                keyValue: "+Dummy.LocC",
                column: "Created",
                value: new DateTime(2022, 6, 3, 23, 52, 50, 403, DateTimeKind.Local).AddTicks(5241));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: new Guid("087b0654-c840-43a2-b827-90d47c5ba041"),
                column: "Created",
                value: new DateTime(2022, 6, 3, 23, 52, 50, 403, DateTimeKind.Local).AddTicks(3476));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: new Guid("ed9c66c8-e2eb-4764-b625-96657b603d25"),
                column: "Created",
                value: new DateTime(2022, 6, 3, 23, 52, 50, 403, DateTimeKind.Local).AddTicks(3166));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("02d2f7a4-8c6e-4f2e-873e-7edc45314939"),
                column: "Created",
                value: new DateTime(2022, 6, 3, 23, 48, 44, 174, DateTimeKind.Local).AddTicks(64));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("2a81c327-07a9-4b1d-a400-222b785f6481"),
                column: "Created",
                value: new DateTime(2022, 6, 3, 23, 48, 44, 170, DateTimeKind.Local).AddTicks(4156));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("651dd1b3-5abe-4884-9be8-59338c6165c8"),
                column: "Created",
                value: new DateTime(2022, 6, 3, 23, 48, 44, 174, DateTimeKind.Local).AddTicks(107));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("93752f09-7eb5-4d1c-8c25-b744a5c4dbbe"),
                column: "Created",
                value: new DateTime(2022, 6, 3, 23, 48, 44, 175, DateTimeKind.Local).AddTicks(8978));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("c5d683d9-f1f2-4c7a-9f3a-857ab00f2105"),
                column: "Created",
                value: new DateTime(2022, 6, 3, 23, 48, 44, 175, DateTimeKind.Local).AddTicks(9276));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("d4d2cf99-99f1-4e29-b429-c03a6f1ff492"),
                column: "Created",
                value: new DateTime(2022, 6, 3, 23, 48, 44, 175, DateTimeKind.Local).AddTicks(9296));

            migrationBuilder.UpdateData(
                table: "Functions",
                keyColumn: "NameInSchematic",
                keyValue: "=Dummy.dOtT",
                column: "Created",
                value: new DateTime(2022, 6, 3, 23, 48, 44, 175, DateTimeKind.Local).AddTicks(7191));

            migrationBuilder.UpdateData(
                table: "Functions",
                keyColumn: "NameInSchematic",
                keyValue: "=Dummy.hmb",
                column: "Created",
                value: new DateTime(2022, 6, 3, 23, 48, 44, 175, DateTimeKind.Local).AddTicks(6906));

            migrationBuilder.UpdateData(
                table: "Functions",
                keyColumn: "NameInSchematic",
                keyValue: "=Dummy.SUPER",
                column: "Created",
                value: new DateTime(2022, 6, 3, 23, 48, 44, 175, DateTimeKind.Local).AddTicks(7208));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "NameInSchematic",
                keyValue: "+Dummy.LocA",
                column: "Created",
                value: new DateTime(2022, 6, 3, 23, 48, 44, 175, DateTimeKind.Local).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "NameInSchematic",
                keyValue: "+Dummy.LocB",
                column: "Created",
                value: new DateTime(2022, 6, 3, 23, 48, 44, 175, DateTimeKind.Local).AddTicks(5548));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "NameInSchematic",
                keyValue: "+Dummy.LocC",
                column: "Created",
                value: new DateTime(2022, 6, 3, 23, 48, 44, 175, DateTimeKind.Local).AddTicks(5567));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: new Guid("087b0654-c840-43a2-b827-90d47c5ba041"),
                column: "Created",
                value: new DateTime(2022, 6, 3, 23, 48, 44, 175, DateTimeKind.Local).AddTicks(3930));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: new Guid("ed9c66c8-e2eb-4764-b625-96657b603d25"),
                column: "Created",
                value: new DateTime(2022, 6, 3, 23, 48, 44, 175, DateTimeKind.Local).AddTicks(3583));
        }
    }
}
