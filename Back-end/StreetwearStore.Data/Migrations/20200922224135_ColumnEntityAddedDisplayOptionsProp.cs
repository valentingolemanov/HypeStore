using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StreetwearStore.Data.Migrations
{
    public partial class ColumnEntityAddedDisplayOptionsProp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DisplayCols",
                table: "Collections",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DisplayPositionIndex",
                table: "Collections",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DisplayRows",
                table: "Collections",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "HomeDisplay",
                table: "Collections",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2020, 9, 22, 22, 41, 35, 300, DateTimeKind.Utc).AddTicks(4740));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2020, 9, 22, 22, 41, 35, 300, DateTimeKind.Utc).AddTicks(5910));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2020, 9, 22, 22, 41, 35, 300, DateTimeKind.Utc).AddTicks(5938));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2020, 9, 22, 22, 41, 35, 300, DateTimeKind.Utc).AddTicks(5945));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2020, 9, 22, 22, 41, 35, 300, DateTimeKind.Utc).AddTicks(5947));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2020, 9, 22, 22, 41, 35, 300, DateTimeKind.Utc).AddTicks(5949));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2020, 9, 22, 22, 41, 35, 300, DateTimeKind.Utc).AddTicks(5955));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2020, 9, 22, 22, 41, 35, 300, DateTimeKind.Utc).AddTicks(5960));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2020, 9, 22, 22, 41, 35, 300, DateTimeKind.Utc).AddTicks(5965));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DisplayCols",
                table: "Collections");

            migrationBuilder.DropColumn(
                name: "DisplayPositionIndex",
                table: "Collections");

            migrationBuilder.DropColumn(
                name: "DisplayRows",
                table: "Collections");

            migrationBuilder.DropColumn(
                name: "HomeDisplay",
                table: "Collections");

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2020, 9, 22, 17, 24, 4, 824, DateTimeKind.Utc).AddTicks(5479));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2020, 9, 22, 17, 24, 4, 824, DateTimeKind.Utc).AddTicks(6175));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2020, 9, 22, 17, 24, 4, 824, DateTimeKind.Utc).AddTicks(6192));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2020, 9, 22, 17, 24, 4, 824, DateTimeKind.Utc).AddTicks(6194));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2020, 9, 22, 17, 24, 4, 824, DateTimeKind.Utc).AddTicks(6196));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2020, 9, 22, 17, 24, 4, 824, DateTimeKind.Utc).AddTicks(6198));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2020, 9, 22, 17, 24, 4, 824, DateTimeKind.Utc).AddTicks(6266));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2020, 9, 22, 17, 24, 4, 824, DateTimeKind.Utc).AddTicks(6268));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2020, 9, 22, 17, 24, 4, 824, DateTimeKind.Utc).AddTicks(6270));
        }
    }
}
