using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StreetwearStore.Data.Migrations
{
    public partial class AddedListingImageEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ListingImages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    Url = table.Column<string>(nullable: true),
                    ListingId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListingImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ListingImages_Products_ListingId",
                        column: x => x.ListingId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2020, 10, 20, 20, 23, 50, 463, DateTimeKind.Utc).AddTicks(8787));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2020, 10, 20, 20, 23, 50, 463, DateTimeKind.Utc).AddTicks(8857));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2020, 10, 20, 20, 23, 50, 463, DateTimeKind.Utc).AddTicks(8860));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2020, 10, 20, 20, 23, 50, 463, DateTimeKind.Utc).AddTicks(8862));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2020, 10, 20, 20, 23, 50, 463, DateTimeKind.Utc).AddTicks(8864));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2020, 10, 20, 20, 23, 50, 463, DateTimeKind.Utc).AddTicks(8866));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2020, 10, 20, 20, 23, 50, 463, DateTimeKind.Utc).AddTicks(8868));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2020, 10, 20, 20, 23, 50, 463, DateTimeKind.Utc).AddTicks(8870));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2020, 10, 20, 20, 23, 50, 463, DateTimeKind.Utc).AddTicks(8872));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2020, 10, 20, 20, 23, 50, 463, DateTimeKind.Utc).AddTicks(8873));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2020, 10, 20, 20, 23, 50, 461, DateTimeKind.Utc).AddTicks(9628));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2020, 10, 20, 20, 23, 50, 462, DateTimeKind.Utc).AddTicks(358));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2020, 10, 20, 20, 23, 50, 462, DateTimeKind.Utc).AddTicks(373));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2020, 10, 20, 20, 23, 50, 462, DateTimeKind.Utc).AddTicks(375));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2020, 10, 20, 20, 23, 50, 462, DateTimeKind.Utc).AddTicks(376));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2020, 10, 20, 20, 23, 50, 462, DateTimeKind.Utc).AddTicks(378));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2020, 10, 20, 20, 23, 50, 462, DateTimeKind.Utc).AddTicks(379));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2020, 10, 20, 20, 23, 50, 462, DateTimeKind.Utc).AddTicks(381));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2020, 10, 20, 20, 23, 50, 462, DateTimeKind.Utc).AddTicks(382));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2020, 10, 20, 20, 23, 50, 462, DateTimeKind.Utc).AddTicks(383));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2020, 10, 20, 20, 23, 50, 462, DateTimeKind.Utc).AddTicks(385));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2020, 10, 20, 20, 23, 50, 462, DateTimeKind.Utc).AddTicks(387));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2020, 10, 20, 20, 23, 50, 462, DateTimeKind.Utc).AddTicks(388));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2020, 10, 20, 20, 23, 50, 462, DateTimeKind.Utc).AddTicks(389));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2020, 10, 20, 20, 23, 50, 462, DateTimeKind.Utc).AddTicks(391));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2020, 10, 20, 20, 23, 50, 462, DateTimeKind.Utc).AddTicks(392));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedOn",
                value: new DateTime(2020, 10, 20, 20, 23, 50, 462, DateTimeKind.Utc).AddTicks(394));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedOn",
                value: new DateTime(2020, 10, 20, 20, 23, 50, 462, DateTimeKind.Utc).AddTicks(395));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedOn",
                value: new DateTime(2020, 10, 20, 20, 23, 50, 462, DateTimeKind.Utc).AddTicks(397));

            migrationBuilder.CreateIndex(
                name: "IX_ListingImages_ListingId",
                table: "ListingImages",
                column: "ListingId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ListingImages");

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2020, 10, 9, 21, 53, 37, 864, DateTimeKind.Utc).AddTicks(4093));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2020, 10, 9, 21, 53, 37, 864, DateTimeKind.Utc).AddTicks(4147));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2020, 10, 9, 21, 53, 37, 864, DateTimeKind.Utc).AddTicks(4150));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2020, 10, 9, 21, 53, 37, 864, DateTimeKind.Utc).AddTicks(4152));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2020, 10, 9, 21, 53, 37, 864, DateTimeKind.Utc).AddTicks(4154));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2020, 10, 9, 21, 53, 37, 864, DateTimeKind.Utc).AddTicks(4156));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2020, 10, 9, 21, 53, 37, 864, DateTimeKind.Utc).AddTicks(4158));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2020, 10, 9, 21, 53, 37, 864, DateTimeKind.Utc).AddTicks(4160));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2020, 10, 9, 21, 53, 37, 864, DateTimeKind.Utc).AddTicks(4162));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2020, 10, 9, 21, 53, 37, 864, DateTimeKind.Utc).AddTicks(4163));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2020, 10, 9, 21, 53, 37, 862, DateTimeKind.Utc).AddTicks(7651));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2020, 10, 9, 21, 53, 37, 862, DateTimeKind.Utc).AddTicks(8356));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2020, 10, 9, 21, 53, 37, 862, DateTimeKind.Utc).AddTicks(8370));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2020, 10, 9, 21, 53, 37, 862, DateTimeKind.Utc).AddTicks(8372));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2020, 10, 9, 21, 53, 37, 862, DateTimeKind.Utc).AddTicks(8393));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2020, 10, 9, 21, 53, 37, 862, DateTimeKind.Utc).AddTicks(8395));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2020, 10, 9, 21, 53, 37, 862, DateTimeKind.Utc).AddTicks(8396));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2020, 10, 9, 21, 53, 37, 862, DateTimeKind.Utc).AddTicks(8397));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2020, 10, 9, 21, 53, 37, 862, DateTimeKind.Utc).AddTicks(8399));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2020, 10, 9, 21, 53, 37, 862, DateTimeKind.Utc).AddTicks(8400));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2020, 10, 9, 21, 53, 37, 862, DateTimeKind.Utc).AddTicks(8402));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2020, 10, 9, 21, 53, 37, 862, DateTimeKind.Utc).AddTicks(8404));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2020, 10, 9, 21, 53, 37, 862, DateTimeKind.Utc).AddTicks(8405));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2020, 10, 9, 21, 53, 37, 862, DateTimeKind.Utc).AddTicks(8407));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2020, 10, 9, 21, 53, 37, 862, DateTimeKind.Utc).AddTicks(8409));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2020, 10, 9, 21, 53, 37, 862, DateTimeKind.Utc).AddTicks(8410));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedOn",
                value: new DateTime(2020, 10, 9, 21, 53, 37, 862, DateTimeKind.Utc).AddTicks(8411));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedOn",
                value: new DateTime(2020, 10, 9, 21, 53, 37, 862, DateTimeKind.Utc).AddTicks(8413));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedOn",
                value: new DateTime(2020, 10, 9, 21, 53, 37, 862, DateTimeKind.Utc).AddTicks(8414));
        }
    }
}
