using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BasicStoreDemo.Migrations
{
    /// <inheritdoc />
    public partial class UpdateProductFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("7d412c54-3c37-4ef6-a147-ab67dffe006f"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("fea0e837-b292-43a0-a9b5-9332af97db7c"));

            migrationBuilder.RenameColumn(
                name: "imageUrl",
                table: "products",
                newName: "image_url");

            migrationBuilder.InsertData(
                table: "products",
                columns: new[] { "id", "discount_price", "image_url", "name", "price", "ratting" },
                values: new object[,]
                {
                    { new Guid("303771a3-27ec-418a-95cf-2df20dc63fa4"), 599f, "Second Image url", "Second Test Product", 650f, 4.3f },
                    { new Guid("af79df13-74e4-460a-ac74-1b1f094eb917"), 98f, "First Image URL", "First Test Product", 120f, 2f }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("303771a3-27ec-418a-95cf-2df20dc63fa4"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("af79df13-74e4-460a-ac74-1b1f094eb917"));

            migrationBuilder.RenameColumn(
                name: "image_url",
                table: "products",
                newName: "imageUrl");

            migrationBuilder.InsertData(
                table: "products",
                columns: new[] { "id", "discount_price", "imageUrl", "name", "price", "ratting" },
                values: new object[,]
                {
                    { new Guid("7d412c54-3c37-4ef6-a147-ab67dffe006f"), 98f, "First Image URL", "First Test Product", 120f, 2f },
                    { new Guid("fea0e837-b292-43a0-a9b5-9332af97db7c"), 599f, "Second Image url", "Second Test Product", 650f, 4.3f }
                });
        }
    }
}
