using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookShop.Migrations
{
    /// <inheritdoc />
    public partial class SeedCategoryTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "DisplayOrder", "Name" },
                values: new object[,]
                {
                    { new Guid("2040d72a-3170-479a-ac24-b78c3da4e9b3"), 0, "Action" },
                    { new Guid("70aa909a-481b-46a0-a2eb-25ce9b3dbb71"), 0, "History" },
                    { new Guid("db319eba-3215-496f-ae62-e0fab967467d"), 0, "Scifi" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2040d72a-3170-479a-ac24-b78c3da4e9b3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("70aa909a-481b-46a0-a2eb-25ce9b3dbb71"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("db319eba-3215-496f-ae62-e0fab967467d"));
        }
    }
}
