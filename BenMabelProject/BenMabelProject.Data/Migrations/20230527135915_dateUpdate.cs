using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BenMabelProject.Data.Migrations
{
    public partial class dateUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ShippingDate",
                table: "OrderSituations",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "PreparationDate",
                table: "OrderSituations",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeliveredDate",
                table: "OrderSituations",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ApprovalDate",
                table: "OrderSituations",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("00b258bc-7991-4ff1-a277-2b56e27e8a97"),
                column: "ConcurrencyStamp",
                value: "f8db5988-3317-48a7-b108-0cf77f94291c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("8123bd2d-552c-4cdc-a7d3-8b73d44521fd"),
                column: "ConcurrencyStamp",
                value: "9a2139c4-4edb-433f-a068-b9aee08619de");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("9ad926b2-048d-4a4e-83d3-e6a32bfab16a"),
                column: "ConcurrencyStamp",
                value: "6253bb9a-a886-4ca3-9ea5-2fa0da312741");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("e59ff37a-4546-48d0-a6d0-b1adb979c6b5"),
                column: "ConcurrencyStamp",
                value: "08f151a7-b5f5-47ca-ad01-1f78dffd79a9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("e88c26e7-383d-457c-982a-c9c9f8bc55b2"),
                column: "ConcurrencyStamp",
                value: "2cedb645-334e-4162-9708-1b13a2f2c56e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1ddc3b63-d12f-4ae8-b2d1-a9e144c81d07"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0ec5fdf2-8cfc-4038-ad46-395114489eb6", "AQAAAAEAACcQAAAAEIp/Ma69CLVPsyzc/FXcwO37+SWM0njIi/Doa2n5LvqHI7ssQf5gKcwBkj31UokG7g==", "b007434b-63de-4ddd-aa6f-5e2c7b302635" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("991c240d-593d-4201-8461-56436289d1a4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ac0df40b-62d4-4f55-8c9f-8d7c3f797da9", "AQAAAAEAACcQAAAAEJXiCW8Rft2Xr2G1+REKcaGSJa+zDcJ0vyF9RXWZ8k/RHBRiCvFsZtSco90U/diPSA==", "f06c222a-7b4b-4744-b627-71ee00f84791" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ShippingDate",
                table: "OrderSituations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "PreparationDate",
                table: "OrderSituations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeliveredDate",
                table: "OrderSituations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ApprovalDate",
                table: "OrderSituations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

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
    }
}
