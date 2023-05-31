using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BenMabelProject.Data.Migrations
{
    public partial class BlogAdd2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BlogResim_Makale_ArticleId",
                table: "BlogResim");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Makale",
                table: "Makale");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BlogResim",
                table: "BlogResim");

            migrationBuilder.RenameTable(
                name: "Makale",
                newName: "Articles");

            migrationBuilder.RenameTable(
                name: "BlogResim",
                newName: "ArticleImages");

            migrationBuilder.RenameIndex(
                name: "IX_BlogResim_ArticleId",
                table: "ArticleImages",
                newName: "IX_ArticleImages_ArticleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Articles",
                table: "Articles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ArticleImages",
                table: "ArticleImages",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_ArticleImages_Articles_ArticleId",
                table: "ArticleImages",
                column: "ArticleId",
                principalTable: "Articles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ArticleImages_Articles_ArticleId",
                table: "ArticleImages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Articles",
                table: "Articles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ArticleImages",
                table: "ArticleImages");

            migrationBuilder.RenameTable(
                name: "Articles",
                newName: "Makale");

            migrationBuilder.RenameTable(
                name: "ArticleImages",
                newName: "BlogResim");

            migrationBuilder.RenameIndex(
                name: "IX_ArticleImages_ArticleId",
                table: "BlogResim",
                newName: "IX_BlogResim_ArticleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Makale",
                table: "Makale",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BlogResim",
                table: "BlogResim",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("8123bd2d-552c-4cdc-a7d3-8b73d44521fd"),
                column: "ConcurrencyStamp",
                value: "d6f5f9af-8648-4afb-a99f-0a45bdffd037");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("9ad926b2-048d-4a4e-83d3-e6a32bfab16a"),
                column: "ConcurrencyStamp",
                value: "d153b466-0b50-487a-ae25-56360cdf78e7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("e59ff37a-4546-48d0-a6d0-b1adb979c6b5"),
                column: "ConcurrencyStamp",
                value: "aa1053ab-94c4-4a36-b7e9-fbceb3ce3815");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("e88c26e7-383d-457c-982a-c9c9f8bc55b2"),
                column: "ConcurrencyStamp",
                value: "50359fd6-05ca-4c3a-9c7e-da01dc720282");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1ddc3b63-d12f-4ae8-b2d1-a9e144c81d07"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8fd46d79-07d9-4aeb-84e8-aecb65eb9a56", "AQAAAAEAACcQAAAAEGr2ne3o25uRnoZ250EqM5KABamgmrMa5tywErTtH69tSOnq4UsyTggWs7LrcjpdYA==", "1797fad1-096b-4206-80ef-0668ff48d576" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("991c240d-593d-4201-8461-56436289d1a4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "922c27e8-e8f0-45b6-9a4a-82ab60d186b5", "AQAAAAEAACcQAAAAEAPHDqtkFRElUq+u6SXzgj6XLIG/hOTR67W/Slr4wct+u5EigNJvwWDmsUX3t40+oQ==", "2ad3fe0a-27d4-4142-ba7f-9eceb6b6b4a3" });

            migrationBuilder.AddForeignKey(
                name: "FK_BlogResim_Makale_ArticleId",
                table: "BlogResim",
                column: "ArticleId",
                principalTable: "Makale",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
