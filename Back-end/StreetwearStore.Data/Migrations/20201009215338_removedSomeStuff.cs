using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StreetwearStore.Data.Migrations
{
    public partial class removedSomeStuff : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Listings");

            migrationBuilder.DropTable(
                name: "ProductCollections");

            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.CreateTable(
                name: "ListingsCollections",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false),
                    CollectionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListingsCollections", x => new { x.ProductId, x.CollectionId });
                    table.ForeignKey(
                        name: "FK_ListingsCollections_Collections_CollectionId",
                        column: x => x.CollectionId,
                        principalTable: "Collections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ListingsCollections_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_ListingsCollections_CollectionId",
                table: "ListingsCollections",
                column: "CollectionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ListingsCollections");

            migrationBuilder.CreateTable(
                name: "Listings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Condition = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NumberOfPairs = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    SizeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Listings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Listings_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Listings_Sizes_SizeId",
                        column: x => x.SizeId,
                        principalTable: "Sizes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductCollections",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    CollectionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCollections", x => new { x.ProductId, x.CollectionId });
                    table.ForeignKey(
                        name: "FK_ProductCollections_Collections_CollectionId",
                        column: x => x.CollectionId,
                        principalTable: "Collections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductCollections_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductImages_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2020, 10, 8, 11, 43, 36, 969, DateTimeKind.Utc).AddTicks(4230));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2020, 10, 8, 11, 43, 36, 969, DateTimeKind.Utc).AddTicks(4306));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2020, 10, 8, 11, 43, 36, 969, DateTimeKind.Utc).AddTicks(4311));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2020, 10, 8, 11, 43, 36, 969, DateTimeKind.Utc).AddTicks(4314));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2020, 10, 8, 11, 43, 36, 969, DateTimeKind.Utc).AddTicks(4317));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2020, 10, 8, 11, 43, 36, 969, DateTimeKind.Utc).AddTicks(4320));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2020, 10, 8, 11, 43, 36, 969, DateTimeKind.Utc).AddTicks(4322));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2020, 10, 8, 11, 43, 36, 969, DateTimeKind.Utc).AddTicks(4325));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2020, 10, 8, 11, 43, 36, 969, DateTimeKind.Utc).AddTicks(4416));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2020, 10, 8, 11, 43, 36, 969, DateTimeKind.Utc).AddTicks(4419));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2020, 10, 8, 11, 43, 36, 966, DateTimeKind.Utc).AddTicks(5179));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2020, 10, 8, 11, 43, 36, 966, DateTimeKind.Utc).AddTicks(6426));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2020, 10, 8, 11, 43, 36, 966, DateTimeKind.Utc).AddTicks(6462));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2020, 10, 8, 11, 43, 36, 966, DateTimeKind.Utc).AddTicks(6466));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2020, 10, 8, 11, 43, 36, 966, DateTimeKind.Utc).AddTicks(6468));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2020, 10, 8, 11, 43, 36, 966, DateTimeKind.Utc).AddTicks(6471));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2020, 10, 8, 11, 43, 36, 966, DateTimeKind.Utc).AddTicks(6474));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2020, 10, 8, 11, 43, 36, 966, DateTimeKind.Utc).AddTicks(6477));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2020, 10, 8, 11, 43, 36, 966, DateTimeKind.Utc).AddTicks(6479));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2020, 10, 8, 11, 43, 36, 966, DateTimeKind.Utc).AddTicks(6482));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2020, 10, 8, 11, 43, 36, 966, DateTimeKind.Utc).AddTicks(6484));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2020, 10, 8, 11, 43, 36, 966, DateTimeKind.Utc).AddTicks(6488));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2020, 10, 8, 11, 43, 36, 966, DateTimeKind.Utc).AddTicks(6494));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2020, 10, 8, 11, 43, 36, 966, DateTimeKind.Utc).AddTicks(6498));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2020, 10, 8, 11, 43, 36, 966, DateTimeKind.Utc).AddTicks(6501));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2020, 10, 8, 11, 43, 36, 966, DateTimeKind.Utc).AddTicks(6505));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedOn",
                value: new DateTime(2020, 10, 8, 11, 43, 36, 966, DateTimeKind.Utc).AddTicks(6510));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedOn",
                value: new DateTime(2020, 10, 8, 11, 43, 36, 966, DateTimeKind.Utc).AddTicks(6514));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedOn",
                value: new DateTime(2020, 10, 8, 11, 43, 36, 966, DateTimeKind.Utc).AddTicks(6519));

            migrationBuilder.CreateIndex(
                name: "IX_Listings_ProductId",
                table: "Listings",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Listings_SizeId",
                table: "Listings",
                column: "SizeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCollections_CollectionId",
                table: "ProductCollections",
                column: "CollectionId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImages",
                column: "ProductId");
        }
    }
}
