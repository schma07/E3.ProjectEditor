using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectEditor.Persistence.Migrations
{
    public partial class update1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Devices",
                maxLength: 256,
                nullable: false,
                defaultValue: "Unknown",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: new Guid("087b0654-c840-43a2-b827-90d47c5ba041"),
                column: "Name",
                value: "WeatherChanger V1.0");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: new Guid("ed9c66c8-e2eb-4764-b625-96657b603d25"),
                column: "Name",
                value: "TimeControl 2.1");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: new Guid("fe04d159-3cd6-4a19-a53e-48ab4425b5fd"),
                column: "Name",
                value: "Water2Wine Vers.A");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Devices",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 256,
                oldDefaultValue: "Unknown");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: new Guid("087b0654-c840-43a2-b827-90d47c5ba041"),
                column: "Name",
                value: null);

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: new Guid("ed9c66c8-e2eb-4764-b625-96657b603d25"),
                column: "Name",
                value: null);

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: new Guid("fe04d159-3cd6-4a19-a53e-48ab4425b5fd"),
                column: "Name",
                value: null);
        }
    }
}
