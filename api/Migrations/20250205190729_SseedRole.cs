using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class SseedRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5e2a6095-a422-4329-9c6a-c23e63437cc1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a2511d8a-0b75-4101-9871-0599feff8664");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "38bfcc2b-c840-4784-a2ed-16661bfeeb51", null, "Admin", "ADMIN" },
                    { "58346c67-7f34-42ad-b885-90f7b2bfa77e", null, "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "38bfcc2b-c840-4784-a2ed-16661bfeeb51");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "58346c67-7f34-42ad-b885-90f7b2bfa77e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5e2a6095-a422-4329-9c6a-c23e63437cc1", null, "Admin", "ADMIN" },
                    { "a2511d8a-0b75-4101-9871-0599feff8664", null, "User", "USER" }
                });
        }
    }
}
