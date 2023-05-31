using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BenMabelProject.Data.Migrations
{
    public partial class smlContent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SmlContent",
                table: "Articles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("8123bd2d-552c-4cdc-a7d3-8b73d44521fd"),
                column: "ConcurrencyStamp",
                value: "328be422-65b4-4f58-b3b7-57452f039edc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("9ad926b2-048d-4a4e-83d3-e6a32bfab16a"),
                column: "ConcurrencyStamp",
                value: "80686a0f-ad38-4b98-9abc-f584260634b2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("e59ff37a-4546-48d0-a6d0-b1adb979c6b5"),
                column: "ConcurrencyStamp",
                value: "bf88a894-1ada-4e99-82e7-22adfcde8dbd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("e88c26e7-383d-457c-982a-c9c9f8bc55b2"),
                column: "ConcurrencyStamp",
                value: "5f55d30d-b598-490a-8e25-7e5c1b30cecc");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1ddc3b63-d12f-4ae8-b2d1-a9e144c81d07"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "961aa3d5-8c31-4d1e-8138-4d9f20c64e21", "AQAAAAEAACcQAAAAEEJ5mlQheZ6mqU7G6Ys3mQPdOoQ5fn7yfT0i4ZuPk76DiWv6tjXT4L34BKQBCyv2OQ==", "8a35b71b-fc89-422d-a663-51b05049179e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("991c240d-593d-4201-8461-56436289d1a4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6561292d-f238-400b-975b-2f0a8493b420", "AQAAAAEAACcQAAAAEFLSGAbeIhl240m1yTlWVKXNMrPiYSuI/yRwiq2GhJLpysCReahxNbmTYrrW8GwI0g==", "82b77ca9-24d6-421f-8e10-9e70373386c2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SmlContent",
                table: "Articles");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("8123bd2d-552c-4cdc-a7d3-8b73d44521fd"),
                column: "ConcurrencyStamp",
                value: "11e17323-4c17-4583-895d-c5aba30f0c40");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("9ad926b2-048d-4a4e-83d3-e6a32bfab16a"),
                column: "ConcurrencyStamp",
                value: "14ced64c-02fa-4cc5-9893-7c242392195a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("e59ff37a-4546-48d0-a6d0-b1adb979c6b5"),
                column: "ConcurrencyStamp",
                value: "18a1f1df-6349-4b4e-8d17-14b9d89ff2cd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("e88c26e7-383d-457c-982a-c9c9f8bc55b2"),
                column: "ConcurrencyStamp",
                value: "9551bc03-13e6-4ecd-801b-c76850b60cab");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1ddc3b63-d12f-4ae8-b2d1-a9e144c81d07"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d95b6f41-1ba2-4016-a8e3-3dacc457290d", "AQAAAAEAACcQAAAAEEvZp0AYXzG7xQ7b76+sR3TLtJDUpjjNXFschwZQiY8lAtu1g/j18copm1OMYMOLlA==", "c9ff535e-ad75-4015-a465-75fc1d99aba2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("991c240d-593d-4201-8461-56436289d1a4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8b8075e3-fe40-4aa6-8301-4d25bc8ada2f", "AQAAAAEAACcQAAAAEKD0HGLvuoIetxvfjIbjt88J+QCGq0fI6MU6KMn0sEDuAHgVVc2EN4SnXFtfZZtNEw==", "8c89dc34-590b-4151-ab3a-b8c1c7e1edd5" });
        }
    }
}
