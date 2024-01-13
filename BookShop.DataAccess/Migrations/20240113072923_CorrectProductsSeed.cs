using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookShop.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class CorrectProductsSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("33a8176c-188f-4867-93a3-39e8e02d7595"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4c05df22-a1b9-413d-9a6e-58dca344a785"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6dc75a0f-c612-4294-8ab5-8b4708b15e8d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8e2792ef-149a-40c7-b67a-9dd727fa28fa"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9f8f2e8a-0612-4e45-bb6c-1851db4e0912"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bd5bab71-c20a-45cd-9071-c2a66a86aaa5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("52c350ea-be8d-4bdd-8d07-339a101d8f5c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7d9285b8-f3f9-4d3f-b133-4aad59f3efce"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7f6da5a6-3469-4b8f-8f26-852b3560436b"));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "DisplayOrder", "Name" },
                values: new object[,]
                {
                    { new Guid("2e390356-b884-4faa-a463-f0a05b13eae1"), 2, "Action" },
                    { new Guid("38f8fca2-6858-4263-8111-312124bf6a36"), 1, "Scifi" },
                    { new Guid("4437550d-5de3-4a81-aeae-14822035df37"), 3, "History" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Author", "CategoryId", "Description", "ISBN", "ImageUrl", "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[,]
                {
                    { new Guid("08b8b2ac-34c2-47d1-a53f-fde13cf9fea2"), "Ron Parker", new Guid("4437550d-5de3-4a81-aeae-14822035df37"), "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ", "SOTJ1111111101", "", 30000.0, 27000.0, 20000.0, 25000.0, "Rock in the Ocean" },
                    { new Guid("3695c071-b35b-4799-a51e-8e2433e5f648"), "Nancy Hoover", new Guid("2e390356-b884-4faa-a463-f0a05b13eae1"), "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ", "CAW777777701", "", 40000.0, 30000.0, 20000.0, 25000.0, "Dark Skies" },
                    { new Guid("74563eae-65e6-406e-a707-b3890dd03a0b"), "Abby Muscles", new Guid("38f8fca2-6858-4263-8111-312124bf6a36"), "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ", "WS3333333301", "", 70000.0, 65000.0, 55000.0, 60000.0, "Cotton Candy" },
                    { new Guid("b40ccdc7-9bf6-46f5-9c86-8da409d15ce6"), "Laura Phantom", new Guid("38f8fca2-6858-4263-8111-312124bf6a36"), "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ", "FOT000000001", "", 25000.0, 23000.0, 20000.0, 22000.0, "Leaves and Wonders" },
                    { new Guid("d1b90f36-fbec-4bf6-967e-42bfb2eb89b7"), "Julian Button", new Guid("2e390356-b884-4faa-a463-f0a05b13eae1"), "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ", "RITO5555501", "", 55000.0, 50000.0, 35000.0, 40000.0, "Vanish in the Sunset" },
                    { new Guid("f4de052f-6fec-4327-a237-a3f83435abc8"), "Billy Spark", new Guid("38f8fca2-6858-4263-8111-312124bf6a36"), "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ", "SWD9999001", "", 99000.0, 90000.0, 80000.0, 85000.0, "Fortune of Time" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("08b8b2ac-34c2-47d1-a53f-fde13cf9fea2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3695c071-b35b-4799-a51e-8e2433e5f648"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("74563eae-65e6-406e-a707-b3890dd03a0b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b40ccdc7-9bf6-46f5-9c86-8da409d15ce6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d1b90f36-fbec-4bf6-967e-42bfb2eb89b7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f4de052f-6fec-4327-a237-a3f83435abc8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2e390356-b884-4faa-a463-f0a05b13eae1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("38f8fca2-6858-4263-8111-312124bf6a36"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4437550d-5de3-4a81-aeae-14822035df37"));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "DisplayOrder", "Name" },
                values: new object[,]
                {
                    { new Guid("52c350ea-be8d-4bdd-8d07-339a101d8f5c"), 1, "Scifi" },
                    { new Guid("7d9285b8-f3f9-4d3f-b133-4aad59f3efce"), 3, "History" },
                    { new Guid("7f6da5a6-3469-4b8f-8f26-852b3560436b"), 2, "Action" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Author", "CategoryId", "Description", "ISBN", "ImageUrl", "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[,]
                {
                    { new Guid("33a8176c-188f-4867-93a3-39e8e02d7595"), "Ron Parker", new Guid("7d9285b8-f3f9-4d3f-b133-4aad59f3efce"), "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ", "SOTJ1111111101", "", 30.0, 27.0, 20.0, 25.0, "Rock in the Ocean" },
                    { new Guid("4c05df22-a1b9-413d-9a6e-58dca344a785"), "Abby Muscles", new Guid("52c350ea-be8d-4bdd-8d07-339a101d8f5c"), "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ", "WS3333333301", "", 70.0, 65.0, 55.0, 60.0, "Cotton Candy" },
                    { new Guid("6dc75a0f-c612-4294-8ab5-8b4708b15e8d"), "Billy Spark", new Guid("52c350ea-be8d-4bdd-8d07-339a101d8f5c"), "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ", "SWD9999001", "", 99.0, 90.0, 80.0, 85.0, "Fortune of Time" },
                    { new Guid("8e2792ef-149a-40c7-b67a-9dd727fa28fa"), "Laura Phantom", new Guid("52c350ea-be8d-4bdd-8d07-339a101d8f5c"), "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ", "FOT000000001", "", 25.0, 23.0, 20.0, 22.0, "Leaves and Wonders" },
                    { new Guid("9f8f2e8a-0612-4e45-bb6c-1851db4e0912"), "Nancy Hoover", new Guid("7f6da5a6-3469-4b8f-8f26-852b3560436b"), "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ", "CAW777777701", "", 40.0, 30.0, 20.0, 25.0, "Dark Skies" },
                    { new Guid("bd5bab71-c20a-45cd-9071-c2a66a86aaa5"), "Julian Button", new Guid("7f6da5a6-3469-4b8f-8f26-852b3560436b"), "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ", "RITO5555501", "", 55.0, 50.0, 35.0, 40.0, "Vanish in the Sunset" }
                });
        }
    }
}
