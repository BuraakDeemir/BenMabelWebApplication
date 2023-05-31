using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BenMabelProject.Data.Migrations
{
    public partial class CateegoryTag : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CategoryTag",
                table: "Category",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoryTag",
                table: "Category");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("8123bd2d-552c-4cdc-a7d3-8b73d44521fd"),
                column: "ConcurrencyStamp",
                value: "006f83fc-01f1-438d-b617-46d2a7378596");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("9ad926b2-048d-4a4e-83d3-e6a32bfab16a"),
                column: "ConcurrencyStamp",
                value: "e62769b6-3ca0-4870-ad36-5d6633846efb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("e59ff37a-4546-48d0-a6d0-b1adb979c6b5"),
                column: "ConcurrencyStamp",
                value: "f90b9154-cde9-4a15-86e0-0a9d834c5bf2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("e88c26e7-383d-457c-982a-c9c9f8bc55b2"),
                column: "ConcurrencyStamp",
                value: "652d1a7f-0825-4cf6-90f4-70b6ced01371");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1ddc3b63-d12f-4ae8-b2d1-a9e144c81d07"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0b1e1c10-ac9a-42e6-b672-e049b5e2a096", "AQAAAAEAACcQAAAAEBoMGYh/xgPP4hKoghF/SE6R39DXyQeiQLTJ2tWggD2PBB1CplxrZ+pvqpZNZZe2gw==", "715d4b1c-9110-4b14-bfba-7899cfb5d73e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("991c240d-593d-4201-8461-56436289d1a4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ba1e6b7f-d6c8-4905-83ad-9252dad2ea93", "AQAAAAEAACcQAAAAELEySKpzM88fXJy9J4PSngtwk48gXC3PCgWyjjzjbwVtettiVnST/Dhx3tUC+25drQ==", "abd425ab-5b17-483e-a5ba-34cc695231ca" });
        }
    }
}
