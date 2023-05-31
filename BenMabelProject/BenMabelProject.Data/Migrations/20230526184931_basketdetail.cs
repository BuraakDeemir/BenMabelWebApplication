using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BenMabelProject.Data.Migrations
{
    public partial class basketdetail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProductName",
                table: "BasketDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("00b258bc-7991-4ff1-a277-2b56e27e8a97"),
                column: "ConcurrencyStamp",
                value: "4628a4ee-85da-4436-8dee-b53bb4f1d58a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("8123bd2d-552c-4cdc-a7d3-8b73d44521fd"),
                column: "ConcurrencyStamp",
                value: "0734531d-601f-41d9-a2eb-1a54b662d904");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("9ad926b2-048d-4a4e-83d3-e6a32bfab16a"),
                column: "ConcurrencyStamp",
                value: "e7b02b4b-6df8-4d4f-ab54-5876a658a3ea");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("e59ff37a-4546-48d0-a6d0-b1adb979c6b5"),
                column: "ConcurrencyStamp",
                value: "f03876f2-63d3-41e4-bafd-96cd37cb9e61");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("e88c26e7-383d-457c-982a-c9c9f8bc55b2"),
                column: "ConcurrencyStamp",
                value: "96b3a790-4957-4d6d-9ffc-a1fe627fec24");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1ddc3b63-d12f-4ae8-b2d1-a9e144c81d07"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "def0ba37-615c-47e1-82b2-d65c2aece131", "AQAAAAEAACcQAAAAEACqeXnvnsWHsG4RF63eVeuqgGTgzVuoGBNXO4j7RxGhMbnv8piSkEF/rACLZg5OVA==", "eb296407-ed53-42d7-ab35-f5ea65dddaf9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("991c240d-593d-4201-8461-56436289d1a4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8acddcae-341f-4d80-bf34-2a855843c6eb", "AQAAAAEAACcQAAAAEFZlJbDVKXCKZM/VM29I9+oBL4fuMEmnvMCep3di2vXAwTO2bYySlYcH5foe1l9Q9Q==", "d2c1bbac-7e56-4c62-8e99-68ca55140603" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductName",
                table: "BasketDetails");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("00b258bc-7991-4ff1-a277-2b56e27e8a97"),
                column: "ConcurrencyStamp",
                value: "7f142668-700f-4c97-b8f7-1baba9452cb7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("8123bd2d-552c-4cdc-a7d3-8b73d44521fd"),
                column: "ConcurrencyStamp",
                value: "26554385-f35b-4fcb-b16e-a3ffaf0b0fcd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("9ad926b2-048d-4a4e-83d3-e6a32bfab16a"),
                column: "ConcurrencyStamp",
                value: "9ba7273c-a4ed-49dc-bfb8-7a074c448b82");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("e59ff37a-4546-48d0-a6d0-b1adb979c6b5"),
                column: "ConcurrencyStamp",
                value: "51f2e681-8446-4371-afee-4096e461e564");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("e88c26e7-383d-457c-982a-c9c9f8bc55b2"),
                column: "ConcurrencyStamp",
                value: "7a1cb671-4aca-409a-a4a5-256b2313c0fe");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1ddc3b63-d12f-4ae8-b2d1-a9e144c81d07"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "adcd6720-6b8c-431b-822f-76088e2d9a2a", "AQAAAAEAACcQAAAAEMoccWIkQj1PYYv+iiEtwsqXL5aahrmsd+IvZ9iMsspcf+pI6oZXZesuyxYB73NRfg==", "470b2fb2-0382-41bb-9302-5f331a7e14b8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("991c240d-593d-4201-8461-56436289d1a4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "77d3e39c-8622-4424-b449-f08401298d61", "AQAAAAEAACcQAAAAEARy47JK443+ubn8f3Do99Wof5R8biZDgnzplZ0+92AroxPlYevwq0sOanjxPiy12w==", "b33cda17-7ff5-40d9-bfc0-a0cd9eb6ff5d" });
        }
    }
}
