using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BenMabelProject.Data.Migrations
{
    public partial class RoleAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("00b258bc-7991-4ff1-a277-2b56e27e8a97"), "3bcb5c89-ebc0-4920-9d7c-d9dbadef80ef", "Customer", "CUSTOMER" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("00b258bc-7991-4ff1-a277-2b56e27e8a97"));

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
    }
}
