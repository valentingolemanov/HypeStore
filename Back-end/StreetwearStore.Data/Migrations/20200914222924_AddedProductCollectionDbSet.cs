using Microsoft.EntityFrameworkCore.Migrations;

namespace StreetwearStore.Data.Migrations
{
    public partial class AddedProductCollectionDbSet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Collections_CollectionId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_CollectionId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CollectionId",
                table: "Products");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Collections",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Collections",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ProductCollections",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false),
                    CollectionId = table.Column<int>(nullable: false)
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

            migrationBuilder.CreateIndex(
                name: "IX_ProductCollections_CollectionId",
                table: "ProductCollections",
                column: "CollectionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductCollections");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Collections");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Collections");

            migrationBuilder.AddColumn<int>(
                name: "CollectionId",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_CollectionId",
                table: "Products",
                column: "CollectionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Collections_CollectionId",
                table: "Products",
                column: "CollectionId",
                principalTable: "Collections",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
