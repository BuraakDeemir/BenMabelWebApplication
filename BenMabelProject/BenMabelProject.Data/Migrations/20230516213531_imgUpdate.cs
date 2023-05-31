using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BenMabelProject.Data.Migrations
{
    public partial class imgUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Img_4",
                table: "ProductImgs",
                newName: "Img_4_FileType");

            migrationBuilder.RenameColumn(
                name: "Img_3",
                table: "ProductImgs",
                newName: "Img_4_FileName");

            migrationBuilder.RenameColumn(
                name: "Img_2",
                table: "ProductImgs",
                newName: "Img_3_FileType");

            migrationBuilder.RenameColumn(
                name: "Img_1",
                table: "ProductImgs",
                newName: "Img_3_FileName");

            migrationBuilder.AddColumn<string>(
                name: "Img_1_FileName",
                table: "ProductImgs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Img_1_FileType",
                table: "ProductImgs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Img_2_FileName",
                table: "ProductImgs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Img_2_FileType",
                table: "ProductImgs",
                type: "nvarchar(max)",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Img_1_FileName",
                table: "ProductImgs");

            migrationBuilder.DropColumn(
                name: "Img_1_FileType",
                table: "ProductImgs");

            migrationBuilder.DropColumn(
                name: "Img_2_FileName",
                table: "ProductImgs");

            migrationBuilder.DropColumn(
                name: "Img_2_FileType",
                table: "ProductImgs");

            migrationBuilder.RenameColumn(
                name: "Img_4_FileType",
                table: "ProductImgs",
                newName: "Img_4");

            migrationBuilder.RenameColumn(
                name: "Img_4_FileName",
                table: "ProductImgs",
                newName: "Img_3");

            migrationBuilder.RenameColumn(
                name: "Img_3_FileType",
                table: "ProductImgs",
                newName: "Img_2");

            migrationBuilder.RenameColumn(
                name: "Img_3_FileName",
                table: "ProductImgs",
                newName: "Img_1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("8123bd2d-552c-4cdc-a7d3-8b73d44521fd"),
                column: "ConcurrencyStamp",
                value: "69f21ec2-3f3b-4175-9c00-5286083e1e45");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("9ad926b2-048d-4a4e-83d3-e6a32bfab16a"),
                column: "ConcurrencyStamp",
                value: "58fab9a0-c8c5-4e7f-9d7b-c2f529a8983e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("e59ff37a-4546-48d0-a6d0-b1adb979c6b5"),
                column: "ConcurrencyStamp",
                value: "c577a057-4b49-45f6-91f3-5b0dd231310c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1ddc3b63-d12f-4ae8-b2d1-a9e144c81d07"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f970f96e-f91a-4f5d-9056-af339a6d6025", "AQAAAAEAACcQAAAAEL1ZNsKghZprBgo/gYYLQ0ogawTJt12wmaeyYWhH+RnWRHVRg3KDBeeovIj1qnxZTQ==", "41122873-dcc4-4547-8ee2-d865a9a2df2c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("991c240d-593d-4201-8461-56436289d1a4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "26441218-9abf-4364-8acb-ad3b26d2f1d6", "AQAAAAEAACcQAAAAELneEqfNS7eWw0udSyC70vMSIx9JDAO3nfAY81bp80w0JHHfZT7rvwaxFXi2dlbv7Q==", "f28f0f31-0d39-4bb7-9dc5-72d2ee8ec435" });
        }
    }
}
