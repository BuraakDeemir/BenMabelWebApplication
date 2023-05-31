using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BenMabelProject.Data.Migrations
{
    public partial class imgTablesUptade2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                value: "ce147f19-65af-4f41-aaf8-046d36c7a87a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("9ad926b2-048d-4a4e-83d3-e6a32bfab16a"),
                column: "ConcurrencyStamp",
                value: "cd3e3884-1a35-405f-b037-56b16b28f707");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("e59ff37a-4546-48d0-a6d0-b1adb979c6b5"),
                column: "ConcurrencyStamp",
                value: "01d59688-1742-4df1-b913-c46931792066");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1ddc3b63-d12f-4ae8-b2d1-a9e144c81d07"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "69ecb23f-5d24-4ecf-a457-a29d92a8d618", "AQAAAAEAACcQAAAAEJo4pWTmGcydSRDpP7OTrJrj6sv5uOiKv4pvgShtkV2oocKGDuC3m7EwqT1Axm+c4g==", "3f86063a-bc11-48bb-9fde-88871ac05268" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("991c240d-593d-4201-8461-56436289d1a4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bec11f59-53c7-41dc-88d0-78de46ff1621", "AQAAAAEAACcQAAAAECuOAXN/d4sjMs/zHJhb8GddC2slRxGcC29I/iBHL0XypIMs6LZNNd17Wf07w52FWw==", "83153af0-2db9-45a7-9c7c-7858c3acee6c" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
