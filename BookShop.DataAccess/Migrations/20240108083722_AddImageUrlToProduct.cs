using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookShop.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddImageUrlToProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3abd86bd-2afc-4e6a-8377-72aa130c005e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3f752e60-03b3-4083-b047-e367a7e9f4ee"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("756c4cdb-fa29-4a83-b417-be928339dcda"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ad44b5ea-7056-4a0a-941f-7a3183f79059"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c7c6688a-78e3-4150-a89a-e0ec76456ad9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dfcf8a8c-69e8-4d26-85c9-97ceb408eaf6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6ec2c2f0-5e7b-4b99-8f9a-5128f4d0bb23"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("aaa3ebe5-d0dc-466d-b74d-f8c3731a52b6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d1174334-844e-4df4-9fa5-f910a532de07"));

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "DisplayOrder", "Name" },
                values: new object[,]
                {
                    { new Guid("2590abb7-7f76-4b68-80eb-e03a33b0d454"), 3, "History" },
                    { new Guid("b123a6de-a61c-4408-b3ba-415be862afaf"), 2, "Action" },
                    { new Guid("c36e057d-2da7-4dc6-8946-1e78b34daa86"), 1, "Scifi" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Author", "CategoryId", "Description", "ISBN", "ImageUrl", "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[,]
                {
                    { new Guid("178d2552-cb4d-44be-b8f5-2073bdc88d09"), "Ron Parker", new Guid("2590abb7-7f76-4b68-80eb-e03a33b0d454"), "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ", "SOTJ1111111101", "", 30.0, 27.0, 20.0, 25.0, "Rock in the Ocean" },
                    { new Guid("5d8de838-6b83-48ce-8449-0ed3514e1d82"), "Julian Button", new Guid("b123a6de-a61c-4408-b3ba-415be862afaf"), "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ", "RITO5555501", "", 55.0, 50.0, 35.0, 40.0, "Vanish in the Sunset" },
                    { new Guid("7c5bef69-408f-42ec-8bf9-e3756c1dafd2"), "Billy Spark", new Guid("c36e057d-2da7-4dc6-8946-1e78b34daa86"), "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ", "SWD9999001", "", 99.0, 90.0, 80.0, 85.0, "Fortune of Time" },
                    { new Guid("884b7e57-71a7-4bd5-a651-535453dbbc43"), "Laura Phantom", new Guid("c36e057d-2da7-4dc6-8946-1e78b34daa86"), "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ", "FOT000000001", "", 25.0, 23.0, 20.0, 22.0, "Leaves and Wonders" },
                    { new Guid("88ec2905-37c4-4aee-bc59-ecf06bda205d"), "Nancy Hoover", new Guid("b123a6de-a61c-4408-b3ba-415be862afaf"), "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ", "CAW777777701", "", 40.0, 30.0, 20.0, 25.0, "Dark Skies" },
                    { new Guid("f75761b2-0ed9-4268-9db0-c46ba762aa67"), "Abby Muscles", new Guid("c36e057d-2da7-4dc6-8946-1e78b34daa86"), "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ", "WS3333333301", "", 70.0, 65.0, 55.0, 60.0, "Cotton Candy" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("178d2552-cb4d-44be-b8f5-2073bdc88d09"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5d8de838-6b83-48ce-8449-0ed3514e1d82"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7c5bef69-408f-42ec-8bf9-e3756c1dafd2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("884b7e57-71a7-4bd5-a651-535453dbbc43"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("88ec2905-37c4-4aee-bc59-ecf06bda205d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f75761b2-0ed9-4268-9db0-c46ba762aa67"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2590abb7-7f76-4b68-80eb-e03a33b0d454"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b123a6de-a61c-4408-b3ba-415be862afaf"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c36e057d-2da7-4dc6-8946-1e78b34daa86"));

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Products");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "DisplayOrder", "Name" },
                values: new object[,]
                {
                    { new Guid("6ec2c2f0-5e7b-4b99-8f9a-5128f4d0bb23"), 1, "Scifi" },
                    { new Guid("aaa3ebe5-d0dc-466d-b74d-f8c3731a52b6"), 3, "History" },
                    { new Guid("d1174334-844e-4df4-9fa5-f910a532de07"), 2, "Action" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Author", "CategoryId", "Description", "ISBN", "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[,]
                {
                    { new Guid("3abd86bd-2afc-4e6a-8377-72aa130c005e"), "Billy Spark", new Guid("6ec2c2f0-5e7b-4b99-8f9a-5128f4d0bb23"), "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ", "SWD9999001", 99.0, 90.0, 80.0, 85.0, "Fortune of Time" },
                    { new Guid("3f752e60-03b3-4083-b047-e367a7e9f4ee"), "Laura Phantom", new Guid("6ec2c2f0-5e7b-4b99-8f9a-5128f4d0bb23"), "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ", "FOT000000001", 25.0, 23.0, 20.0, 22.0, "Leaves and Wonders" },
                    { new Guid("756c4cdb-fa29-4a83-b417-be928339dcda"), "Ron Parker", new Guid("aaa3ebe5-d0dc-466d-b74d-f8c3731a52b6"), "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ", "SOTJ1111111101", 30.0, 27.0, 20.0, 25.0, "Rock in the Ocean" },
                    { new Guid("ad44b5ea-7056-4a0a-941f-7a3183f79059"), "Julian Button", new Guid("d1174334-844e-4df4-9fa5-f910a532de07"), "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ", "RITO5555501", 55.0, 50.0, 35.0, 40.0, "Vanish in the Sunset" },
                    { new Guid("c7c6688a-78e3-4150-a89a-e0ec76456ad9"), "Nancy Hoover", new Guid("d1174334-844e-4df4-9fa5-f910a532de07"), "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ", "CAW777777701", 40.0, 30.0, 20.0, 25.0, "Dark Skies" },
                    { new Guid("dfcf8a8c-69e8-4d26-85c9-97ceb408eaf6"), "Abby Muscles", new Guid("6ec2c2f0-5e7b-4b99-8f9a-5128f4d0bb23"), "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ", "WS3333333301", 70.0, 65.0, 55.0, 60.0, "Cotton Candy" }
                });
        }
    }
}
