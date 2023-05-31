using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BenMabelProject.Data.Migrations
{
    public partial class Adet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Adet",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Adet",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("00b258bc-7991-4ff1-a277-2b56e27e8a97"),
                column: "ConcurrencyStamp",
                value: "40df51a9-52b9-454d-8605-573ee0665039");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("8123bd2d-552c-4cdc-a7d3-8b73d44521fd"),
                column: "ConcurrencyStamp",
                value: "042a494e-bf85-4e9b-8f08-c036e809e574");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("9ad926b2-048d-4a4e-83d3-e6a32bfab16a"),
                column: "ConcurrencyStamp",
                value: "4d0b6c2e-1576-4a67-b459-592d91586f92");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("e59ff37a-4546-48d0-a6d0-b1adb979c6b5"),
                column: "ConcurrencyStamp",
                value: "d02ad6f6-c8e3-44c2-a477-11cf74326cc5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("e88c26e7-383d-457c-982a-c9c9f8bc55b2"),
                column: "ConcurrencyStamp",
                value: "864b9183-966d-447a-8066-b3f9beb79abd");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1ddc3b63-d12f-4ae8-b2d1-a9e144c81d07"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b831e44c-8f51-491a-80ea-bea8ddf09f6c", "AQAAAAEAACcQAAAAEEco5VEeJiak7xVSmtD/FlPN7q9F67h1MCqs/pHEDTjZtzmMgKxdiM+sDPTmAMo7lw==", "b43afcbc-f5c7-46d4-8f9d-cbde65582dbf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("991c240d-593d-4201-8461-56436289d1a4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5c5ec2df-3b3d-4cb2-93f2-54b4671f2f12", "AQAAAAEAACcQAAAAEP19STiA18hUuOcXvBskZez0IbltjBPbCjrmUubkNB1anESOneFnlyX76o+hvs9sww==", "ea39709d-3b0e-4982-bf25-70b550da9e92" });
        }
    }
}
