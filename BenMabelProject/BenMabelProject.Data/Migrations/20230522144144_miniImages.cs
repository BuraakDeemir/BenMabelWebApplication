using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BenMabelProject.Data.Migrations
{
    public partial class miniImages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ArticleImages_ArticleId",
                table: "ArticleImages");

            migrationBuilder.AddColumn<string>(
                name: "Img_1_Sml_FileName",
                table: "ProductImgs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Img_1_Sml_FileType",
                table: "ProductImgs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Img_2_Sml_FileName",
                table: "ProductImgs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Img_2_Sml_FileType",
                table: "ProductImgs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Img_3_Sml_FileName",
                table: "ProductImgs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Img_3_Sml_FileType",
                table: "ProductImgs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Img_4_Sml_FileName",
                table: "ProductImgs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Img_4_Sml_FileType",
                table: "ProductImgs",
                type: "nvarchar(max)",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_ArticleImages_ArticleId",
                table: "ArticleImages",
                column: "ArticleId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ArticleImages_ArticleId",
                table: "ArticleImages");

            migrationBuilder.DropColumn(
                name: "Img_1_Sml_FileName",
                table: "ProductImgs");

            migrationBuilder.DropColumn(
                name: "Img_1_Sml_FileType",
                table: "ProductImgs");

            migrationBuilder.DropColumn(
                name: "Img_2_Sml_FileName",
                table: "ProductImgs");

            migrationBuilder.DropColumn(
                name: "Img_2_Sml_FileType",
                table: "ProductImgs");

            migrationBuilder.DropColumn(
                name: "Img_3_Sml_FileName",
                table: "ProductImgs");

            migrationBuilder.DropColumn(
                name: "Img_3_Sml_FileType",
                table: "ProductImgs");

            migrationBuilder.DropColumn(
                name: "Img_4_Sml_FileName",
                table: "ProductImgs");

            migrationBuilder.DropColumn(
                name: "Img_4_Sml_FileType",
                table: "ProductImgs");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("8123bd2d-552c-4cdc-a7d3-8b73d44521fd"),
                column: "ConcurrencyStamp",
                value: "21c96812-e71b-4b38-9435-cac33ef90462");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("9ad926b2-048d-4a4e-83d3-e6a32bfab16a"),
                column: "ConcurrencyStamp",
                value: "f73ed57b-a8e3-4df5-85f0-b5458cac1734");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("e59ff37a-4546-48d0-a6d0-b1adb979c6b5"),
                column: "ConcurrencyStamp",
                value: "46a780c8-b510-45ec-8821-a200f8b255a4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("e88c26e7-383d-457c-982a-c9c9f8bc55b2"),
                column: "ConcurrencyStamp",
                value: "e0bab55d-e2d4-40be-a783-2bfe07936e01");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1ddc3b63-d12f-4ae8-b2d1-a9e144c81d07"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2d1da47d-5672-4289-a100-cc49d3b69119", "AQAAAAEAACcQAAAAEKq9zJUQPNKKaTIe/2wLNMyJj7fg8LRvz39ODVLHXxBOIh7GqxTWCPaMma50B+GvKw==", "502f4778-4375-4336-8982-1b125deecdd5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("991c240d-593d-4201-8461-56436289d1a4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7a0fa279-58a5-4bcb-8b07-90582b64ce01", "AQAAAAEAACcQAAAAEP12XmFdOBM86EEvxL1xc3JuUQmCXC0zQYJgPJ2NLcaET5gbu0ZJaZJLnH9iqBRPjQ==", "94e6df85-3f41-491b-82e5-d3eaf133dadd" });

            migrationBuilder.CreateIndex(
                name: "IX_ArticleImages_ArticleId",
                table: "ArticleImages",
                column: "ArticleId");
        }
    }
}
