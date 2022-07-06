using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class SeedIdentityUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 6, 23, 7, 10, 113, DateTimeKind.Local).AddTicks(2755),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 6, 22, 48, 51, 869, DateTimeKind.Local).AddTicks(2961));

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("cc5ffbf0-8013-488c-972a-926a065e69a0"), "191c2f0b-78b8-41e7-aa49-d931da85bb67", "Administrator role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("cc5ffbf0-8013-488c-972a-926a065e69a0"), new Guid("d8b58f4a-1e6c-419d-ab13-c7f8a93baf14") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("d8b58f4a-1e6c-419d-ab13-c7f8a93baf14"), 0, "605e9710-a505-408f-9f8d-ead7e3ae59c0", new DateTime(2020, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "tedu.international@gmail.com", true, "Toan", "Bach", false, null, "tedu.international@gmail.com", "admin", "AQAAAAEAACcQAAAAEF8s2QDmMmVIuSbgGzMRCgY4MyTuc2+itE/M/0ZEr/mQuA090eqootdR+H++IwiozA==", null, false, "", false, "admin" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 7, 6, 23, 7, 10, 126, DateTimeKind.Local).AddTicks(1588));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("cc5ffbf0-8013-488c-972a-926a065e69a0"));

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("cc5ffbf0-8013-488c-972a-926a065e69a0"), new Guid("d8b58f4a-1e6c-419d-ab13-c7f8a93baf14") });

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("d8b58f4a-1e6c-419d-ab13-c7f8a93baf14"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 6, 22, 48, 51, 869, DateTimeKind.Local).AddTicks(2961),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 7, 6, 23, 7, 10, 113, DateTimeKind.Local).AddTicks(2755));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 7, 6, 22, 48, 51, 892, DateTimeKind.Local).AddTicks(352));
        }
    }
}
