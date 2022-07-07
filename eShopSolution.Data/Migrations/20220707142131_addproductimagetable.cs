using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class addproductimagetable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 6, 23, 7, 10, 113, DateTimeKind.Local).AddTicks(2755));

            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(nullable: false),
                    ImagePath = table.Column<string>(maxLength: 200, nullable: false),
                    Caption = table.Column<string>(maxLength: 200, nullable: true),
                    IsDefault = table.Column<bool>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    SortOrder = table.Column<int>(nullable: false),
                    FileSize = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductImages_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImages",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 6, 23, 7, 10, 113, DateTimeKind.Local).AddTicks(2755),
                oldClrType: typeof(DateTime));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("cc5ffbf0-8013-488c-972a-926a065e69a0"),
                column: "ConcurrencyStamp",
                value: "191c2f0b-78b8-41e7-aa49-d931da85bb67");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("d8b58f4a-1e6c-419d-ab13-c7f8a93baf14"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "605e9710-a505-408f-9f8d-ead7e3ae59c0", "AQAAAAEAACcQAAAAEF8s2QDmMmVIuSbgGzMRCgY4MyTuc2+itE/M/0ZEr/mQuA090eqootdR+H++IwiozA==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 7, 6, 23, 7, 10, 126, DateTimeKind.Local).AddTicks(1588));
        }
    }
}
