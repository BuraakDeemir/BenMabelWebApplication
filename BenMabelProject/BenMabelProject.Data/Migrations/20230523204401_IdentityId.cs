using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BenMabelProject.Data.Migrations
{
    public partial class IdentityId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "IdentityId",
                table: "Person",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdentityId",
                table: "Person");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("00b258bc-7991-4ff1-a277-2b56e27e8a97"),
                column: "ConcurrencyStamp",
                value: "3bcb5c89-ebc0-4920-9d7c-d9dbadef80ef");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("8123bd2d-552c-4cdc-a7d3-8b73d44521fd"),
                column: "ConcurrencyStamp",
                value: "e9b03f4a-a911-469c-af3f-81f200005225");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("9ad926b2-048d-4a4e-83d3-e6a32bfab16a"),
                column: "ConcurrencyStamp",
                value: "f225fbfb-42ad-4350-8484-0c36f1a736a7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("e59ff37a-4546-48d0-a6d0-b1adb979c6b5"),
                column: "ConcurrencyStamp",
                value: "c45309b5-f9ce-4332-83aa-5cfcdee08f22");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("e88c26e7-383d-457c-982a-c9c9f8bc55b2"),
                column: "ConcurrencyStamp",
                value: "adaf5bcd-0314-4fab-a2ee-2ae9225d2c8d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1ddc3b63-d12f-4ae8-b2d1-a9e144c81d07"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2ae80351-5125-4403-9a3b-0aeecbbf674a", "AQAAAAEAACcQAAAAEM+ANGupxcw92Yox9sxHG1/qgOHXW4bwviMbz1qldPsYqAyID0NijKziA+wlNdnR4A==", "68b34bd5-7104-4fa5-bb04-9974d3dc6d68" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("991c240d-593d-4201-8461-56436289d1a4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "23a10351-4ca1-4bcc-8d29-488baea6beb1", "AQAAAAEAACcQAAAAEGcmoMzfXx3/3w2Wom74DEtqAGATczDIpBZMrSQqAWQhN5LRg5meCvyRxtWcIfmABA==", "1c9a6db7-2be3-4672-988a-f4d05e1a95e3" });
        }
    }
}
