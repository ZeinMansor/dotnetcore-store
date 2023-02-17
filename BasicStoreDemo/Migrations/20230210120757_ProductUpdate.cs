using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BasicStoreDemo.Migrations
{
    /// <inheritdoc />
    public partial class ProductUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_product_descreption_product_descreption_ProductDescreptionid",
                table: "product_descreption");

            migrationBuilder.DropIndex(
                name: "IX_product_descreption_ProductDescreptionid",
                table: "product_descreption");

            migrationBuilder.DropColumn(
                name: "ProductDescreptionid",
                table: "product_descreption");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ProductDescreptionid",
                table: "product_descreption",
                type: "uuid",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_product_descreption_ProductDescreptionid",
                table: "product_descreption",
                column: "ProductDescreptionid");

            migrationBuilder.AddForeignKey(
                name: "FK_product_descreption_product_descreption_ProductDescreptionid",
                table: "product_descreption",
                column: "ProductDescreptionid",
                principalTable: "product_descreption",
                principalColumn: "id");
        }
    }
}
