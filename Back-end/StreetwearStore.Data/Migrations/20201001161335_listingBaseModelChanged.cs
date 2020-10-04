using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StreetwearStore.Data.Migrations
{
    public partial class listingBaseModelChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "Listings",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Listings",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfPairs",
                table: "Listings",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2020, 10, 1, 16, 13, 35, 15, DateTimeKind.Utc).AddTicks(8061));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2020, 10, 1, 16, 13, 35, 15, DateTimeKind.Utc).AddTicks(8151));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2020, 10, 1, 16, 13, 35, 15, DateTimeKind.Utc).AddTicks(8155));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2020, 10, 1, 16, 13, 35, 15, DateTimeKind.Utc).AddTicks(8159));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2020, 10, 1, 16, 13, 35, 15, DateTimeKind.Utc).AddTicks(8161));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2020, 10, 1, 16, 13, 35, 15, DateTimeKind.Utc).AddTicks(8163));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2020, 10, 1, 16, 13, 35, 15, DateTimeKind.Utc).AddTicks(8166));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2020, 10, 1, 16, 13, 35, 15, DateTimeKind.Utc).AddTicks(8168));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2020, 10, 1, 16, 13, 35, 15, DateTimeKind.Utc).AddTicks(8171));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2020, 10, 1, 16, 13, 35, 15, DateTimeKind.Utc).AddTicks(8173));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2020, 10, 1, 16, 13, 35, 12, DateTimeKind.Utc).AddTicks(7665));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2020, 10, 1, 16, 13, 35, 12, DateTimeKind.Utc).AddTicks(8861));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2020, 10, 1, 16, 13, 35, 12, DateTimeKind.Utc).AddTicks(8903));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2020, 10, 1, 16, 13, 35, 12, DateTimeKind.Utc).AddTicks(8906));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2020, 10, 1, 16, 13, 35, 12, DateTimeKind.Utc).AddTicks(8909));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2020, 10, 1, 16, 13, 35, 12, DateTimeKind.Utc).AddTicks(8912));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2020, 10, 1, 16, 13, 35, 12, DateTimeKind.Utc).AddTicks(8916));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2020, 10, 1, 16, 13, 35, 12, DateTimeKind.Utc).AddTicks(9023));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2020, 10, 1, 16, 13, 35, 12, DateTimeKind.Utc).AddTicks(9025));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2020, 10, 1, 16, 13, 35, 12, DateTimeKind.Utc).AddTicks(9028));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2020, 10, 1, 16, 13, 35, 12, DateTimeKind.Utc).AddTicks(9030));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2020, 10, 1, 16, 13, 35, 12, DateTimeKind.Utc).AddTicks(9032));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2020, 10, 1, 16, 13, 35, 12, DateTimeKind.Utc).AddTicks(9035));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2020, 10, 1, 16, 13, 35, 12, DateTimeKind.Utc).AddTicks(9037));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2020, 10, 1, 16, 13, 35, 12, DateTimeKind.Utc).AddTicks(9039));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2020, 10, 1, 16, 13, 35, 12, DateTimeKind.Utc).AddTicks(9042));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedOn",
                value: new DateTime(2020, 10, 1, 16, 13, 35, 12, DateTimeKind.Utc).AddTicks(9045));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedOn",
                value: new DateTime(2020, 10, 1, 16, 13, 35, 12, DateTimeKind.Utc).AddTicks(9047));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedOn",
                value: new DateTime(2020, 10, 1, 16, 13, 35, 12, DateTimeKind.Utc).AddTicks(9049));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "Listings");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Listings");

            migrationBuilder.DropColumn(
                name: "NumberOfPairs",
                table: "Listings");

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2020, 9, 29, 19, 15, 40, 650, DateTimeKind.Utc).AddTicks(6814));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2020, 9, 29, 19, 15, 40, 650, DateTimeKind.Utc).AddTicks(6859));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2020, 9, 29, 19, 15, 40, 650, DateTimeKind.Utc).AddTicks(6862));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2020, 9, 29, 19, 15, 40, 650, DateTimeKind.Utc).AddTicks(6864));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2020, 9, 29, 19, 15, 40, 650, DateTimeKind.Utc).AddTicks(6865));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2020, 9, 29, 19, 15, 40, 650, DateTimeKind.Utc).AddTicks(6867));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2020, 9, 29, 19, 15, 40, 650, DateTimeKind.Utc).AddTicks(6869));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2020, 9, 29, 19, 15, 40, 650, DateTimeKind.Utc).AddTicks(6871));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2020, 9, 29, 19, 15, 40, 650, DateTimeKind.Utc).AddTicks(6873));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2020, 9, 29, 19, 15, 40, 650, DateTimeKind.Utc).AddTicks(6874));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2020, 9, 29, 19, 15, 40, 648, DateTimeKind.Utc).AddTicks(9477));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2020, 9, 29, 19, 15, 40, 649, DateTimeKind.Utc).AddTicks(204));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2020, 9, 29, 19, 15, 40, 649, DateTimeKind.Utc).AddTicks(227));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2020, 9, 29, 19, 15, 40, 649, DateTimeKind.Utc).AddTicks(229));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2020, 9, 29, 19, 15, 40, 649, DateTimeKind.Utc).AddTicks(230));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2020, 9, 29, 19, 15, 40, 649, DateTimeKind.Utc).AddTicks(232));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2020, 9, 29, 19, 15, 40, 649, DateTimeKind.Utc).AddTicks(234));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2020, 9, 29, 19, 15, 40, 649, DateTimeKind.Utc).AddTicks(236));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2020, 9, 29, 19, 15, 40, 649, DateTimeKind.Utc).AddTicks(238));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2020, 9, 29, 19, 15, 40, 649, DateTimeKind.Utc).AddTicks(239));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2020, 9, 29, 19, 15, 40, 649, DateTimeKind.Utc).AddTicks(241));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2020, 9, 29, 19, 15, 40, 649, DateTimeKind.Utc).AddTicks(243));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2020, 9, 29, 19, 15, 40, 649, DateTimeKind.Utc).AddTicks(245));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2020, 9, 29, 19, 15, 40, 649, DateTimeKind.Utc).AddTicks(247));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2020, 9, 29, 19, 15, 40, 649, DateTimeKind.Utc).AddTicks(249));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2020, 9, 29, 19, 15, 40, 649, DateTimeKind.Utc).AddTicks(250));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedOn",
                value: new DateTime(2020, 9, 29, 19, 15, 40, 649, DateTimeKind.Utc).AddTicks(252));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedOn",
                value: new DateTime(2020, 9, 29, 19, 15, 40, 649, DateTimeKind.Utc).AddTicks(254));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedOn",
                value: new DateTime(2020, 9, 29, 19, 15, 40, 649, DateTimeKind.Utc).AddTicks(256));
        }
    }
}
