using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class changefilelengthtype : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "FileSize",
                table: "ProductImages",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("cc5ffbf0-8013-488c-972a-926a065e69a0"),
                column: "ConcurrencyStamp",
                value: "d7768868-f878-462a-8e1f-f2002390138d");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("d8b58f4a-1e6c-419d-ab13-c7f8a93baf14"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ea454602-781e-4137-8393-635f65f312e4", "AQAAAAEAACcQAAAAEMOM3GQbEpQHst0Hg+ZDLgc2wjVHmJu+3hs3D4pVNtkEMf35AeMOUQqFv6JVD8yo3A==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 7, 7, 22, 34, 1, 980, DateTimeKind.Local).AddTicks(1535));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "FileSize",
                table: "ProductImages",
                type: "int",
                nullable: false,
                oldClrType: typeof(long));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("cc5ffbf0-8013-488c-972a-926a065e69a0"),
                column: "ConcurrencyStamp",
                value: "60c6bbd0-9799-4f63-afb2-8627dafdca27");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("d8b58f4a-1e6c-419d-ab13-c7f8a93baf14"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "18e5ccd2-1720-4908-ba90-ae444fa71e86", "AQAAAAEAACcQAAAAEGKhVGD3EY4Nekin++iCJnFeXnC0yKle7vI096bEfCtR4OaKyHsKc38odFVWE/p0XQ==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 7, 7, 21, 21, 30, 688, DateTimeKind.Local).AddTicks(9103));
        }
    }
}
