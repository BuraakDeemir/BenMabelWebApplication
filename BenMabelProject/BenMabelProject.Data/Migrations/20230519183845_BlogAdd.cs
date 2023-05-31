using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BenMabelProject.Data.Migrations
{
    public partial class BlogAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Articles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Makale", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ArticleImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArticleId = table.Column<int>(type: "int", nullable: false),
                    Big_FileName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Big_FileType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sml_FileName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sml_FileType = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogResim", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BlogResim_Makale_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "Makale",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_BlogResim_ArticleId",
                table: "BlogResim",
                column: "ArticleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BlogResim");

            migrationBuilder.DropTable(
                name: "Makale");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("8123bd2d-552c-4cdc-a7d3-8b73d44521fd"),
                column: "ConcurrencyStamp",
                value: "428b1ed1-9016-4c89-b690-07309deb0eeb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("9ad926b2-048d-4a4e-83d3-e6a32bfab16a"),
                column: "ConcurrencyStamp",
                value: "d25f1425-abd6-41ad-978f-4348108e4df7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("e59ff37a-4546-48d0-a6d0-b1adb979c6b5"),
                column: "ConcurrencyStamp",
                value: "6f72042f-afae-4c76-b4ce-59c263df39af");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("e88c26e7-383d-457c-982a-c9c9f8bc55b2"),
                column: "ConcurrencyStamp",
                value: "dc41bea1-3d4d-4a3b-9bbc-6c03af3d0d9f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1ddc3b63-d12f-4ae8-b2d1-a9e144c81d07"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "70d99bbd-3f7f-440f-b24c-ce50c93dbd7e", "AQAAAAEAACcQAAAAEIdnCgrNduvMoHSR32o/MBHHdS+hG0BmUbfPN7X6qT9k6DRbQrbQOsxSVZHjjzfylA==", "8e556483-94e0-41c2-b9d6-7a98e539fb62" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("991c240d-593d-4201-8461-56436289d1a4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6c170d0f-674b-4392-b0fe-36a66b3d6d8f", "AQAAAAEAACcQAAAAEJjMizCOJMeBSg3brJErBURHQwFWRsvKcTfXd1TeErrvpSJta2OIqpW51yRlaQLZwA==", "54b873ec-1af3-4b1f-942f-3d10c6fd9efd" });
        }
    }
}
