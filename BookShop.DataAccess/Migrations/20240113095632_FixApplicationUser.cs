using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookShop.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class FixApplicationUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "DisplayOrder", "Name" },
                values: new object[,]
                {
                    { new Guid("1be874e6-f930-42a9-b7ff-2957318eaac7"), 1, "Scifi" },
                    { new Guid("890cd36f-df26-4eac-a403-4ef841c950b2"), 3, "History" },
                    { new Guid("a503cb7e-6974-434f-a1cf-2ba0ffa0439f"), 2, "Action" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Author", "CategoryId", "Description", "ISBN", "ImageUrl", "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[,]
                {
                    { new Guid("1cb8e2b6-4bd2-4c50-9ecd-3e945510dd9f"), "Nancy Hoover", new Guid("a503cb7e-6974-434f-a1cf-2ba0ffa0439f"), "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ", "CAW777777701", "", 40000.0, 30000.0, 20000.0, 25000.0, "Dark Skies" },
                    { new Guid("35452e29-df65-4ac6-b41a-faf04fdbfc98"), "Laura Phantom", new Guid("1be874e6-f930-42a9-b7ff-2957318eaac7"), "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ", "FOT000000001", "", 25000.0, 23000.0, 20000.0, 22000.0, "Leaves and Wonders" },
                    { new Guid("4cf1238d-33be-434a-bc79-99255d73eef9"), "Ron Parker", new Guid("890cd36f-df26-4eac-a403-4ef841c950b2"), "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ", "SOTJ1111111101", "", 30000.0, 27000.0, 20000.0, 25000.0, "Rock in the Ocean" },
                    { new Guid("6f9c4a55-a4c5-4c81-b417-9eb105722952"), "Abby Muscles", new Guid("1be874e6-f930-42a9-b7ff-2957318eaac7"), "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ", "WS3333333301", "", 70000.0, 65000.0, 55000.0, 60000.0, "Cotton Candy" },
                    { new Guid("a3ecee5a-11b3-44a1-a784-6f5c763fdc69"), "Julian Button", new Guid("a503cb7e-6974-434f-a1cf-2ba0ffa0439f"), "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ", "RITO5555501", "", 55000.0, 50000.0, 35000.0, 40000.0, "Vanish in the Sunset" },
                    { new Guid("c174d420-c98c-493d-a0fa-e01375b53eac"), "Billy Spark", new Guid("1be874e6-f930-42a9-b7ff-2957318eaac7"), "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ", "SWD9999001", "", 99000.0, 90000.0, 80000.0, 85000.0, "Fortune of Time" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1cb8e2b6-4bd2-4c50-9ecd-3e945510dd9f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("35452e29-df65-4ac6-b41a-faf04fdbfc98"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4cf1238d-33be-434a-bc79-99255d73eef9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6f9c4a55-a4c5-4c81-b417-9eb105722952"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a3ecee5a-11b3-44a1-a784-6f5c763fdc69"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c174d420-c98c-493d-a0fa-e01375b53eac"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1be874e6-f930-42a9-b7ff-2957318eaac7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("890cd36f-df26-4eac-a403-4ef841c950b2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a503cb7e-6974-434f-a1cf-2ba0ffa0439f"));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<int>(
                name: "Name",
                table: "AspNetUsers",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

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
    }
}
