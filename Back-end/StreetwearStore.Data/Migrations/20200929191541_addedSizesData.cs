using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StreetwearStore.Data.Migrations
{
    public partial class addedSizesData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "Id", "CM", "ClothSize", "CreatedOn", "DeletedOn", "EU", "Gender", "Inches", "IsDeleted", "ModifiedOn", "UK", "US" },
                values: new object[,]
                {
                    { 19, 0.0, 0, new DateTime(2020, 9, 29, 19, 15, 40, 649, DateTimeKind.Utc).AddTicks(256), null, 50.5, 0, 0.0, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 15.0, 16.0 },
                    { 18, 0.0, 0, new DateTime(2020, 9, 29, 19, 15, 40, 649, DateTimeKind.Utc).AddTicks(254), null, 49.5, 0, 0.0, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 14.0, 15.0 },
                    { 17, 0.0, 0, new DateTime(2020, 9, 29, 19, 15, 40, 649, DateTimeKind.Utc).AddTicks(252), null, 49.0, 0, 0.0, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 13.5, 14.5 },
                    { 16, 0.0, 0, new DateTime(2020, 9, 29, 19, 15, 40, 649, DateTimeKind.Utc).AddTicks(250), null, 48.5, 0, 0.0, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 13.0, 14.0 },
                    { 15, 0.0, 0, new DateTime(2020, 9, 29, 19, 15, 40, 649, DateTimeKind.Utc).AddTicks(249), null, 48.0, 0, 0.0, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 12.5, 13.5 },
                    { 13, 0.0, 0, new DateTime(2020, 9, 29, 19, 15, 40, 649, DateTimeKind.Utc).AddTicks(245), null, 47.0, 0, 0.0, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.5, 12.5 },
                    { 12, 0.0, 0, new DateTime(2020, 9, 29, 19, 15, 40, 649, DateTimeKind.Utc).AddTicks(243), null, 46.0, 0, 0.0, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.0, 12.0 },
                    { 11, 0.0, 0, new DateTime(2020, 9, 29, 19, 15, 40, 649, DateTimeKind.Utc).AddTicks(241), null, 45.5, 0, 0.0, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.5, 11.5 },
                    { 10, 0.0, 0, new DateTime(2020, 9, 29, 19, 15, 40, 649, DateTimeKind.Utc).AddTicks(239), null, 45.0, 0, 0.0, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.0, 11.0 },
                    { 9, 0.0, 0, new DateTime(2020, 9, 29, 19, 15, 40, 649, DateTimeKind.Utc).AddTicks(238), null, 44.5, 0, 0.0, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.5, 10.5 },
                    { 8, 0.0, 0, new DateTime(2020, 9, 29, 19, 15, 40, 649, DateTimeKind.Utc).AddTicks(236), null, 44.0, 0, 0.0, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.0, 10.0 },
                    { 7, 0.0, 0, new DateTime(2020, 9, 29, 19, 15, 40, 649, DateTimeKind.Utc).AddTicks(234), null, 43.0, 0, 0.0, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.5, 9.5 },
                    { 6, 0.0, 0, new DateTime(2020, 9, 29, 19, 15, 40, 649, DateTimeKind.Utc).AddTicks(232), null, 42.5, 0, 0.0, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.0, 9.0 },
                    { 5, 0.0, 0, new DateTime(2020, 9, 29, 19, 15, 40, 649, DateTimeKind.Utc).AddTicks(230), null, 42.0, 0, 0.0, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.5, 8.5 },
                    { 4, 0.0, 0, new DateTime(2020, 9, 29, 19, 15, 40, 649, DateTimeKind.Utc).AddTicks(229), null, 41.0, 0, 0.0, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.0, 8.0 },
                    { 3, 0.0, 0, new DateTime(2020, 9, 29, 19, 15, 40, 649, DateTimeKind.Utc).AddTicks(227), null, 40.5, 0, 0.0, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.5, 7.5 },
                    { 2, 0.0, 0, new DateTime(2020, 9, 29, 19, 15, 40, 649, DateTimeKind.Utc).AddTicks(204), null, 39.0, 0, 0.0, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.0, 6.5 },
                    { 14, 0.0, 0, new DateTime(2020, 9, 29, 19, 15, 40, 649, DateTimeKind.Utc).AddTicks(247), null, 47.5, 0, 0.0, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 12.0, 13.0 },
                    { 1, 0.0, 0, new DateTime(2020, 9, 29, 19, 15, 40, 648, DateTimeKind.Utc).AddTicks(9477), null, 38.5, 0, 0.0, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.5, 6.0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 19);

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
        }
    }
}
