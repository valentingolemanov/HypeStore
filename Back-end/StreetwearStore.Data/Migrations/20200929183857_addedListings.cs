using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StreetwearStore.Data.Migrations
{
    public partial class addedListings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Offers_Products_ProductId",
                table: "Offers");

            migrationBuilder.DropForeignKey(
                name: "FK_Offers_Sizes_SizeId",
                table: "Offers");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Sizes_SizeId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_SizeId",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Offers",
                table: "Offers");

            migrationBuilder.DropColumn(
                name: "SizeId",
                table: "Products");

            migrationBuilder.RenameTable(
                name: "Offers",
                newName: "Listings");

            migrationBuilder.RenameIndex(
                name: "IX_Offers_SizeId",
                table: "Listings",
                newName: "IX_Listings_SizeId");

            migrationBuilder.RenameIndex(
                name: "IX_Offers_ProductId",
                table: "Listings",
                newName: "IX_Listings_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Listings",
                table: "Listings",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2020, 9, 29, 18, 38, 56, 494, DateTimeKind.Utc).AddTicks(9329));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2020, 9, 29, 18, 38, 56, 495, DateTimeKind.Utc).AddTicks(337));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2020, 9, 29, 18, 38, 56, 495, DateTimeKind.Utc).AddTicks(355));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2020, 9, 29, 18, 38, 56, 495, DateTimeKind.Utc).AddTicks(357));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2020, 9, 29, 18, 38, 56, 495, DateTimeKind.Utc).AddTicks(359));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2020, 9, 29, 18, 38, 56, 495, DateTimeKind.Utc).AddTicks(361));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2020, 9, 29, 18, 38, 56, 495, DateTimeKind.Utc).AddTicks(363));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2020, 9, 29, 18, 38, 56, 495, DateTimeKind.Utc).AddTicks(364));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2020, 9, 29, 18, 38, 56, 495, DateTimeKind.Utc).AddTicks(367));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2020, 9, 29, 18, 38, 56, 495, DateTimeKind.Utc).AddTicks(369));

            migrationBuilder.AddForeignKey(
                name: "FK_Listings_Products_ProductId",
                table: "Listings",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Listings_Sizes_SizeId",
                table: "Listings",
                column: "SizeId",
                principalTable: "Sizes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Listings_Products_ProductId",
                table: "Listings");

            migrationBuilder.DropForeignKey(
                name: "FK_Listings_Sizes_SizeId",
                table: "Listings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Listings",
                table: "Listings");

            migrationBuilder.RenameTable(
                name: "Listings",
                newName: "Offers");

            migrationBuilder.RenameIndex(
                name: "IX_Listings_SizeId",
                table: "Offers",
                newName: "IX_Offers_SizeId");

            migrationBuilder.RenameIndex(
                name: "IX_Listings_ProductId",
                table: "Offers",
                newName: "IX_Offers_ProductId");

            migrationBuilder.AddColumn<int>(
                name: "SizeId",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Offers",
                table: "Offers",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2020, 9, 24, 19, 2, 38, 348, DateTimeKind.Utc).AddTicks(1067));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2020, 9, 24, 19, 2, 38, 348, DateTimeKind.Utc).AddTicks(2086));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2020, 9, 24, 19, 2, 38, 348, DateTimeKind.Utc).AddTicks(2114));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2020, 9, 24, 19, 2, 38, 348, DateTimeKind.Utc).AddTicks(2122));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2020, 9, 24, 19, 2, 38, 348, DateTimeKind.Utc).AddTicks(2127));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2020, 9, 24, 19, 2, 38, 348, DateTimeKind.Utc).AddTicks(2132));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2020, 9, 24, 19, 2, 38, 348, DateTimeKind.Utc).AddTicks(2137));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2020, 9, 24, 19, 2, 38, 348, DateTimeKind.Utc).AddTicks(2142));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2020, 9, 24, 19, 2, 38, 348, DateTimeKind.Utc).AddTicks(2148));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2020, 9, 24, 19, 2, 38, 348, DateTimeKind.Utc).AddTicks(2153));

            migrationBuilder.CreateIndex(
                name: "IX_Products_SizeId",
                table: "Products",
                column: "SizeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Offers_Products_ProductId",
                table: "Offers",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Offers_Sizes_SizeId",
                table: "Offers",
                column: "SizeId",
                principalTable: "Sizes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Sizes_SizeId",
                table: "Products",
                column: "SizeId",
                principalTable: "Sizes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
