using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FrontToBack.Migrations
{
    public partial class deletecolumnToproductImagetable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductImages_ProductImages_ProductImageId",
                table: "ProductImages");

            migrationBuilder.DropIndex(
                name: "IX_ProductImages_ProductImageId",
                table: "ProductImages");

            migrationBuilder.DropColumn(
                name: "ProductImageId",
                table: "ProductImages");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImages",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImages_Products_ProductId",
                table: "ProductImages",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductImages_Products_ProductId",
                table: "ProductImages");

            migrationBuilder.DropIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImages");

            migrationBuilder.AddColumn<Guid>(
                name: "ProductImageId",
                table: "ProductImages",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductImageId",
                table: "ProductImages",
                column: "ProductImageId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImages_ProductImages_ProductImageId",
                table: "ProductImages",
                column: "ProductImageId",
                principalTable: "ProductImages",
                principalColumn: "Id");
        }
    }
}
