using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectEditor.Persistence.Migrations
{
    public partial class finalincludinglocationsandfunctions_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Locations",
                table: "Locations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Functions",
                table: "Functions");

            migrationBuilder.DeleteData(
                table: "Functions",
                keyColumn: "NameInSchematic",
                keyValue: "=Dummy.dOtT");

            migrationBuilder.DeleteData(
                table: "Functions",
                keyColumn: "NameInSchematic",
                keyValue: "=Dummy.hmb");

            migrationBuilder.DeleteData(
                table: "Functions",
                keyColumn: "NameInSchematic",
                keyValue: "=Dummy.SUPER");

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "NameInSchematic",
                keyValue: "+Dummy.LocA");

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "NameInSchematic",
                keyValue: "+Dummy.LocB");

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "NameInSchematic",
                keyValue: "+Dummy.LocC");

            migrationBuilder.AlterColumn<string>(
                name: "NameInSchematic",
                table: "Locations",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "Locations",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<string>(
                name: "NameInSchematic",
                table: "Functions",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "Functions",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Locations",
                table: "Locations",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Functions",
                table: "Functions",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("02d2f7a4-8c6e-4f2e-873e-7edc45314939"),
                column: "Created",
                value: new DateTime(2022, 6, 4, 0, 19, 18, 445, DateTimeKind.Local).AddTicks(7240));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("2a81c327-07a9-4b1d-a400-222b785f6481"),
                column: "Created",
                value: new DateTime(2022, 6, 4, 0, 19, 18, 443, DateTimeKind.Local).AddTicks(7647));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("651dd1b3-5abe-4884-9be8-59338c6165c8"),
                column: "Created",
                value: new DateTime(2022, 6, 4, 0, 19, 18, 445, DateTimeKind.Local).AddTicks(7278));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("93752f09-7eb5-4d1c-8c25-b744a5c4dbbe"),
                column: "Created",
                value: new DateTime(2022, 6, 4, 0, 19, 18, 447, DateTimeKind.Local).AddTicks(6037));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("c5d683d9-f1f2-4c7a-9f3a-857ab00f2105"),
                column: "Created",
                value: new DateTime(2022, 6, 4, 0, 19, 18, 447, DateTimeKind.Local).AddTicks(6327));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("d4d2cf99-99f1-4e29-b429-c03a6f1ff492"),
                column: "Created",
                value: new DateTime(2022, 6, 4, 0, 19, 18, 447, DateTimeKind.Local).AddTicks(6347));

            migrationBuilder.InsertData(
                table: "Functions",
                columns: new[] { "Id", "Created", "CreatedBy", "Description", "NameInSchematic", "ProjectId", "Updated", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("163de71d-3f88-4b0a-aed9-2d03d9d29bae"), new DateTime(2022, 6, 4, 0, 19, 18, 447, DateTimeKind.Local).AddTicks(3599), "Created via DbContext", "hold my beer", "=Dummy.hmb", new Guid("ed9c66c8-e2eb-4764-b625-96657b603d25"), null, null },
                    { new Guid("fa4e431e-efe8-42f3-ba42-ea8c230567ae"), new DateTime(2022, 6, 4, 0, 19, 18, 447, DateTimeKind.Local).AddTicks(3885), "Created via DbContext", "dancing on the table", "=Dummy.dOtT", new Guid("087b0654-c840-43a2-b827-90d47c5ba041"), null, null },
                    { new Guid("495ac5cd-6c39-401e-b206-ef9f349407a4"), new DateTime(2022, 6, 4, 0, 19, 18, 447, DateTimeKind.Local).AddTicks(3904), "Created via DbContext", "execute supernova", "=Dummy.SUPER", new Guid("fe04d159-3cd6-4a19-a53e-48ab4425b5fd"), null, null }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Created", "CreatedBy", "Description", "NameInSchematic", "ProjectId", "Updated", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("03e6c2e0-de3b-4dad-9f73-98b26e206f3d"), new DateTime(2022, 6, 4, 0, 19, 18, 447, DateTimeKind.Local).AddTicks(1767), "Created via DbContext", "6 feet under", "+Dummy.LocA", new Guid("ed9c66c8-e2eb-4764-b625-96657b603d25"), null, null },
                    { new Guid("c6074116-b961-4232-acb4-2c663ff456c8"), new DateTime(2022, 6, 4, 0, 19, 18, 447, DateTimeKind.Local).AddTicks(2062), "Created via DbContext", "up in sky", "+Dummy.LocB", new Guid("087b0654-c840-43a2-b827-90d47c5ba041"), null, null },
                    { new Guid("23d13a3a-245a-4178-8cce-09a9bd28781d"), new DateTime(2022, 6, 4, 0, 19, 18, 447, DateTimeKind.Local).AddTicks(2091), "Created via DbContext", "6 feet under", "+Dummy.LocC", new Guid("fe04d159-3cd6-4a19-a53e-48ab4425b5fd"), null, null }
                });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: new Guid("087b0654-c840-43a2-b827-90d47c5ba041"),
                column: "Created",
                value: new DateTime(2022, 6, 4, 0, 19, 18, 447, DateTimeKind.Local).AddTicks(239));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: new Guid("ed9c66c8-e2eb-4764-b625-96657b603d25"),
                column: "Created",
                value: new DateTime(2022, 6, 4, 0, 19, 18, 446, DateTimeKind.Local).AddTicks(9913));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Locations",
                table: "Locations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Functions",
                table: "Functions");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Functions");

            migrationBuilder.AlterColumn<string>(
                name: "NameInSchematic",
                table: "Locations",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "NameInSchematic",
                table: "Functions",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Locations",
                table: "Locations",
                column: "NameInSchematic");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Functions",
                table: "Functions",
                column: "NameInSchematic");

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
    }
}
