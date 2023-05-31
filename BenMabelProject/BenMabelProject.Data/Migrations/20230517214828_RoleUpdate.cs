using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BenMabelProject.Data.Migrations
{
    public partial class RoleUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("8123bd2d-552c-4cdc-a7d3-8b73d44521fd"),
                columns: new[] { "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "006f83fc-01f1-438d-b617-46d2a7378596", "Rapor Uzmanı", "RAPOR UZMANI" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("9ad926b2-048d-4a4e-83d3-e6a32bfab16a"),
                columns: new[] { "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e62769b6-3ca0-4870-ad36-5d6633846efb", "Finans Uzmanı", "FINANS UZMANI" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("e59ff37a-4546-48d0-a6d0-b1adb979c6b5"),
                columns: new[] { "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f90b9154-cde9-4a15-86e0-0a9d834c5bf2", "Patron", "PATRON" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("e88c26e7-383d-457c-982a-c9c9f8bc55b2"), "652d1a7f-0825-4cf6-90f4-70b6ced01371", "Paketleme", "PAKETLEME" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("e88c26e7-383d-457c-982a-c9c9f8bc55b2"));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("8123bd2d-552c-4cdc-a7d3-8b73d44521fd"),
                columns: new[] { "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ce147f19-65af-4f41-aaf8-046d36c7a87a", "User", "USER" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("9ad926b2-048d-4a4e-83d3-e6a32bfab16a"),
                columns: new[] { "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cd3e3884-1a35-405f-b037-56b16b28f707", "Admin", "ADMIN" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("e59ff37a-4546-48d0-a6d0-b1adb979c6b5"),
                columns: new[] { "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "01d59688-1742-4df1-b913-c46931792066", "SuperAdmin", "SUPERADMIN" });

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
    }
}
