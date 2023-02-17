using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BasicStoreDemo.Migrations
{
    /// <inheritdoc />
    public partial class ProductUpdateM : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "description",
                table: "products");

            migrationBuilder.RenameColumn(
                name: "discountPrice",
                table: "products",
                newName: "discount_price");

            migrationBuilder.CreateTable(
                name: "product_descreption",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    discreption = table.Column<string>(type: "text", nullable: true),
                    productid = table.Column<Guid>(type: "uuid", nullable: false),
                    ProductDescreptionid = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_product_descreption", x => x.id);
                    table.ForeignKey(
                        name: "FK_product_descreption_product_descreption_ProductDescreptionid",
                        column: x => x.ProductDescreptionid,
                        principalTable: "product_descreption",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_product_descreption_products_productid",
                        column: x => x.productid,
                        principalTable: "products",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_product_descreption_ProductDescreptionid",
                table: "product_descreption",
                column: "ProductDescreptionid");

            migrationBuilder.CreateIndex(
                name: "IX_product_descreption_productid",
                table: "product_descreption",
                column: "productid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "product_descreption");

            migrationBuilder.RenameColumn(
                name: "discount_price",
                table: "products",
                newName: "discountPrice");

            migrationBuilder.AddColumn<List<string>>(
                name: "description",
                table: "products",
                type: "text[]",
                nullable: true);
        }
    }
}
