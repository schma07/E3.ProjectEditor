using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectEditor.Persistence.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Projects",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Projects");

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("93752f09-7eb5-4d1c-8c25-b744a5c4dbbe"),
                column: "Name",
                value: "Star Trek Discovery Season 1");

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("c5d683d9-f1f2-4c7a-9f3a-857ab00f2105"),
                column: "Name",
                value: "Stirb langsam");

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("d4d2cf99-99f1-4e29-b429-c03a6f1ff492"),
                column: "Name",
                value: "Titanic");
        }
    }
}
