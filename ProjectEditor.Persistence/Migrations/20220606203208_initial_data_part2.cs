using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectEditor.Persistence.Migrations
{
    public partial class initial_data_part2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("02d2f7a4-8c6e-4f2e-873e-7edc45314939"),
                column: "Created",
                value: new DateTime(2022, 6, 6, 22, 32, 8, 467, DateTimeKind.Local).AddTicks(2872));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("2a81c327-07a9-4b1d-a400-222b785f6481"),
                column: "Created",
                value: new DateTime(2022, 6, 6, 22, 32, 8, 465, DateTimeKind.Local).AddTicks(781));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("651dd1b3-5abe-4884-9be8-59338c6165c8"),
                column: "Created",
                value: new DateTime(2022, 6, 6, 22, 32, 8, 467, DateTimeKind.Local).AddTicks(2912));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("93752f09-7eb5-4d1c-8c25-b744a5c4dbbe"),
                columns: new[] { "Created", "FunctionId" },
                values: new object[] { new DateTime(2022, 6, 6, 22, 32, 8, 469, DateTimeKind.Local).AddTicks(8113), new Guid("163de71d-3f88-4b0a-aed9-2d03d9d29bae") });

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("c5d683d9-f1f2-4c7a-9f3a-857ab00f2105"),
                columns: new[] { "Created", "FunctionId" },
                values: new object[] { new DateTime(2022, 6, 6, 22, 32, 8, 469, DateTimeKind.Local).AddTicks(8527), new Guid("fa4e431e-efe8-42f3-ba42-ea8c230567ae") });

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("d4d2cf99-99f1-4e29-b429-c03a6f1ff492"),
                columns: new[] { "Created", "FunctionId" },
                values: new object[] { new DateTime(2022, 6, 6, 22, 32, 8, 469, DateTimeKind.Local).AddTicks(8548), new Guid("495ac5cd-6c39-401e-b206-ef9f349407a4") });

            migrationBuilder.UpdateData(
                table: "FunctionSetups",
                keyColumn: "Id",
                keyValue: new Guid("42280b59-961a-4d97-9b5d-b0fcb3eb85fa"),
                column: "Created",
                value: new DateTime(2022, 6, 6, 22, 32, 8, 469, DateTimeKind.Local).AddTicks(2764));

            migrationBuilder.UpdateData(
                table: "FunctionSetups",
                keyColumn: "Id",
                keyValue: new Guid("7391de1f-3422-426c-a5c8-6695d1be7283"),
                column: "Created",
                value: new DateTime(2022, 6, 6, 22, 32, 8, 469, DateTimeKind.Local).AddTicks(3022));

            migrationBuilder.UpdateData(
                table: "FunctionSetups",
                keyColumn: "Id",
                keyValue: new Guid("b00f1038-72d3-44dc-9b49-7cb5cad7c656"),
                column: "Created",
                value: new DateTime(2022, 6, 6, 22, 32, 8, 469, DateTimeKind.Local).AddTicks(3007));

            migrationBuilder.UpdateData(
                table: "Functions",
                keyColumn: "Id",
                keyValue: new Guid("163de71d-3f88-4b0a-aed9-2d03d9d29bae"),
                column: "Created",
                value: new DateTime(2022, 6, 6, 22, 32, 8, 469, DateTimeKind.Local).AddTicks(5648));

            migrationBuilder.UpdateData(
                table: "Functions",
                keyColumn: "Id",
                keyValue: new Guid("495ac5cd-6c39-401e-b206-ef9f349407a4"),
                column: "Created",
                value: new DateTime(2022, 6, 6, 22, 32, 8, 469, DateTimeKind.Local).AddTicks(5959));

            migrationBuilder.UpdateData(
                table: "Functions",
                keyColumn: "Id",
                keyValue: new Guid("fa4e431e-efe8-42f3-ba42-ea8c230567ae"),
                column: "Created",
                value: new DateTime(2022, 6, 6, 22, 32, 8, 469, DateTimeKind.Local).AddTicks(5939));

            migrationBuilder.UpdateData(
                table: "LocationSetups",
                keyColumn: "Id",
                keyValue: new Guid("31e84c75-a86d-481e-8433-22918d2b3a24"),
                column: "Created",
                value: new DateTime(2022, 6, 6, 22, 32, 8, 468, DateTimeKind.Local).AddTicks(8148));

            migrationBuilder.UpdateData(
                table: "LocationSetups",
                keyColumn: "Id",
                keyValue: new Guid("375b873e-b57f-496f-a919-07f7a462a3c5"),
                column: "Created",
                value: new DateTime(2022, 6, 6, 22, 32, 8, 468, DateTimeKind.Local).AddTicks(8601));

            migrationBuilder.UpdateData(
                table: "LocationSetups",
                keyColumn: "Id",
                keyValue: new Guid("7660ceb6-fda5-449e-ba09-9796d00c555f"),
                column: "Created",
                value: new DateTime(2022, 6, 6, 22, 32, 8, 468, DateTimeKind.Local).AddTicks(8578));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("03e6c2e0-de3b-4dad-9f73-98b26e206f3d"),
                column: "Created",
                value: new DateTime(2022, 6, 6, 22, 32, 8, 469, DateTimeKind.Local).AddTicks(372));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("23d13a3a-245a-4178-8cce-09a9bd28781d"),
                column: "Created",
                value: new DateTime(2022, 6, 6, 22, 32, 8, 469, DateTimeKind.Local).AddTicks(718));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("c6074116-b961-4232-acb4-2c663ff456c8"),
                column: "Created",
                value: new DateTime(2022, 6, 6, 22, 32, 8, 469, DateTimeKind.Local).AddTicks(696));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: new Guid("087b0654-c840-43a2-b827-90d47c5ba041"),
                column: "Created",
                value: new DateTime(2022, 6, 6, 22, 32, 8, 468, DateTimeKind.Local).AddTicks(5783));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: new Guid("ed9c66c8-e2eb-4764-b625-96657b603d25"),
                column: "Created",
                value: new DateTime(2022, 6, 6, 22, 32, 8, 468, DateTimeKind.Local).AddTicks(5456));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("02d2f7a4-8c6e-4f2e-873e-7edc45314939"),
                column: "Created",
                value: new DateTime(2022, 6, 6, 22, 30, 46, 871, DateTimeKind.Local).AddTicks(1881));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("2a81c327-07a9-4b1d-a400-222b785f6481"),
                column: "Created",
                value: new DateTime(2022, 6, 6, 22, 30, 46, 868, DateTimeKind.Local).AddTicks(9158));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("651dd1b3-5abe-4884-9be8-59338c6165c8"),
                column: "Created",
                value: new DateTime(2022, 6, 6, 22, 30, 46, 871, DateTimeKind.Local).AddTicks(1917));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("93752f09-7eb5-4d1c-8c25-b744a5c4dbbe"),
                columns: new[] { "Created", "FunctionId" },
                values: new object[] { new DateTime(2022, 6, 6, 22, 30, 46, 873, DateTimeKind.Local).AddTicks(5716), null });

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("c5d683d9-f1f2-4c7a-9f3a-857ab00f2105"),
                columns: new[] { "Created", "FunctionId" },
                values: new object[] { new DateTime(2022, 6, 6, 22, 30, 46, 873, DateTimeKind.Local).AddTicks(6011), null });

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("d4d2cf99-99f1-4e29-b429-c03a6f1ff492"),
                columns: new[] { "Created", "FunctionId" },
                values: new object[] { new DateTime(2022, 6, 6, 22, 30, 46, 873, DateTimeKind.Local).AddTicks(6033), null });

            migrationBuilder.UpdateData(
                table: "FunctionSetups",
                keyColumn: "Id",
                keyValue: new Guid("42280b59-961a-4d97-9b5d-b0fcb3eb85fa"),
                column: "Created",
                value: new DateTime(2022, 6, 6, 22, 30, 46, 873, DateTimeKind.Local).AddTicks(905));

            migrationBuilder.UpdateData(
                table: "FunctionSetups",
                keyColumn: "Id",
                keyValue: new Guid("7391de1f-3422-426c-a5c8-6695d1be7283"),
                column: "Created",
                value: new DateTime(2022, 6, 6, 22, 30, 46, 873, DateTimeKind.Local).AddTicks(1200));

            migrationBuilder.UpdateData(
                table: "FunctionSetups",
                keyColumn: "Id",
                keyValue: new Guid("b00f1038-72d3-44dc-9b49-7cb5cad7c656"),
                column: "Created",
                value: new DateTime(2022, 6, 6, 22, 30, 46, 873, DateTimeKind.Local).AddTicks(1150));

            migrationBuilder.UpdateData(
                table: "Functions",
                keyColumn: "Id",
                keyValue: new Guid("163de71d-3f88-4b0a-aed9-2d03d9d29bae"),
                column: "Created",
                value: new DateTime(2022, 6, 6, 22, 30, 46, 873, DateTimeKind.Local).AddTicks(3384));

            migrationBuilder.UpdateData(
                table: "Functions",
                keyColumn: "Id",
                keyValue: new Guid("495ac5cd-6c39-401e-b206-ef9f349407a4"),
                column: "Created",
                value: new DateTime(2022, 6, 6, 22, 30, 46, 873, DateTimeKind.Local).AddTicks(3691));

            migrationBuilder.UpdateData(
                table: "Functions",
                keyColumn: "Id",
                keyValue: new Guid("fa4e431e-efe8-42f3-ba42-ea8c230567ae"),
                column: "Created",
                value: new DateTime(2022, 6, 6, 22, 30, 46, 873, DateTimeKind.Local).AddTicks(3670));

            migrationBuilder.UpdateData(
                table: "LocationSetups",
                keyColumn: "Id",
                keyValue: new Guid("31e84c75-a86d-481e-8433-22918d2b3a24"),
                column: "Created",
                value: new DateTime(2022, 6, 6, 22, 30, 46, 872, DateTimeKind.Local).AddTicks(6508));

            migrationBuilder.UpdateData(
                table: "LocationSetups",
                keyColumn: "Id",
                keyValue: new Guid("375b873e-b57f-496f-a919-07f7a462a3c5"),
                column: "Created",
                value: new DateTime(2022, 6, 6, 22, 30, 46, 872, DateTimeKind.Local).AddTicks(6823));

            migrationBuilder.UpdateData(
                table: "LocationSetups",
                keyColumn: "Id",
                keyValue: new Guid("7660ceb6-fda5-449e-ba09-9796d00c555f"),
                column: "Created",
                value: new DateTime(2022, 6, 6, 22, 30, 46, 872, DateTimeKind.Local).AddTicks(6801));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("03e6c2e0-de3b-4dad-9f73-98b26e206f3d"),
                column: "Created",
                value: new DateTime(2022, 6, 6, 22, 30, 46, 872, DateTimeKind.Local).AddTicks(8587));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("23d13a3a-245a-4178-8cce-09a9bd28781d"),
                column: "Created",
                value: new DateTime(2022, 6, 6, 22, 30, 46, 872, DateTimeKind.Local).AddTicks(8896));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("c6074116-b961-4232-acb4-2c663ff456c8"),
                column: "Created",
                value: new DateTime(2022, 6, 6, 22, 30, 46, 872, DateTimeKind.Local).AddTicks(8875));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: new Guid("087b0654-c840-43a2-b827-90d47c5ba041"),
                column: "Created",
                value: new DateTime(2022, 6, 6, 22, 30, 46, 872, DateTimeKind.Local).AddTicks(3901));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: new Guid("ed9c66c8-e2eb-4764-b625-96657b603d25"),
                column: "Created",
                value: new DateTime(2022, 6, 6, 22, 30, 46, 872, DateTimeKind.Local).AddTicks(3586));
        }
    }
}
