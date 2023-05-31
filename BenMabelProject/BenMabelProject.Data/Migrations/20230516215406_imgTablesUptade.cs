using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BenMabelProject.Data.Migrations
{
    public partial class imgTablesUptade : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ImageType_1",
                table: "ProductImgs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ImageType_2",
                table: "ProductImgs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ImageType_3",
                table: "ProductImgs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ImageType_4",
                table: "ProductImgs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("8123bd2d-552c-4cdc-a7d3-8b73d44521fd"),
                column: "ConcurrencyStamp",
                value: "e2efd085-22bf-4ae5-a9e8-48ee00455b11");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("9ad926b2-048d-4a4e-83d3-e6a32bfab16a"),
                column: "ConcurrencyStamp",
                value: "5b182b20-3b3a-4b20-a596-21ad0c1870d4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("e59ff37a-4546-48d0-a6d0-b1adb979c6b5"),
                column: "ConcurrencyStamp",
                value: "92afe8f8-265d-4683-a6f4-db9fea78113a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1ddc3b63-d12f-4ae8-b2d1-a9e144c81d07"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "05122270-ab18-4efd-9513-637c5b8c9b29", "AQAAAAEAACcQAAAAECrGURPsgUTvCTWFEYx2No5zECqHpHWSyxTCc+HJ6gMvcWDZEno5FriOtri2GJKrLg==", "d02f24b8-b5d4-4212-a9a0-a54439cbf3f4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("991c240d-593d-4201-8461-56436289d1a4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e735ac5d-2e36-48a3-bb10-959196de5d4b", "AQAAAAEAACcQAAAAEO7RhYL5CPbti9fuBk+8VsEfbw+DfEYaio+rQBujkiwsVXBo1M7PHMcI3UWgDyeL4g==", "86d31f8c-431a-47a8-9c83-17bfdcee5aeb" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageType_1",
                table: "ProductImgs");

            migrationBuilder.DropColumn(
                name: "ImageType_2",
                table: "ProductImgs");

            migrationBuilder.DropColumn(
                name: "ImageType_3",
                table: "ProductImgs");

            migrationBuilder.DropColumn(
                name: "ImageType_4",
                table: "ProductImgs");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("8123bd2d-552c-4cdc-a7d3-8b73d44521fd"),
                column: "ConcurrencyStamp",
                value: "dc0b8e3f-a2d5-4aa3-b275-9884cd37a132");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("9ad926b2-048d-4a4e-83d3-e6a32bfab16a"),
                column: "ConcurrencyStamp",
                value: "d507fabe-1671-414e-aa08-8886b8cddfed");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("e59ff37a-4546-48d0-a6d0-b1adb979c6b5"),
                column: "ConcurrencyStamp",
                value: "54206a39-3204-4584-a3da-0be5a02b594c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1ddc3b63-d12f-4ae8-b2d1-a9e144c81d07"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ba74f6f4-8119-47f7-a0ba-40f989c93218", "AQAAAAEAACcQAAAAECg0MncUDM+AArPfnkMB/Z+8JFvqndWLWPBjbN+SVNCV8du8UHjaagYeVC68j+NQ7A==", "fc668b90-5dbf-4b54-8814-d7e979927870" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("991c240d-593d-4201-8461-56436289d1a4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3fa3cb64-3b4e-4dde-a2d8-b2b329b8bc35", "AQAAAAEAACcQAAAAEIR0iLHc8chb2e/e4+MaWb1DFGAovf2Jtrj/zHuAjxMJ+UnElOw08MIEKrcotSxTFQ==", "a83af256-51a6-455f-9e2a-1276646c7dca" });
        }
    }
}
