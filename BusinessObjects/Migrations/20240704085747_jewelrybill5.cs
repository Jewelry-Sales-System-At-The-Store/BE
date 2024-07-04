using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusinessObjects.Migrations
{
    /// <inheritdoc />
    public partial class jewelrybill5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BillJewelryId",
                table: "Purchases");

            migrationBuilder.UpdateData(
                table: "Bills",
                keyColumn: "BillId",
                keyValue: "1",
                column: "SaleDate",
                value: new DateTimeOffset(new DateTime(2024, 7, 4, 15, 57, 47, 201, DateTimeKind.Unspecified).AddTicks(3329), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Bills",
                keyColumn: "BillId",
                keyValue: "2",
                column: "SaleDate",
                value: new DateTimeOffset(new DateTime(2024, 7, 4, 15, 57, 47, 201, DateTimeKind.Unspecified).AddTicks(3332), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Gems",
                keyColumn: "GemId",
                keyValue: "1",
                column: "LastUpdated",
                value: new DateTimeOffset(new DateTime(2024, 7, 4, 15, 57, 47, 201, DateTimeKind.Unspecified).AddTicks(3384), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Gems",
                keyColumn: "GemId",
                keyValue: "2",
                column: "LastUpdated",
                value: new DateTimeOffset(new DateTime(2024, 7, 4, 15, 57, 47, 201, DateTimeKind.Unspecified).AddTicks(3388), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Gems",
                keyColumn: "GemId",
                keyValue: "3",
                column: "LastUpdated",
                value: new DateTimeOffset(new DateTime(2024, 7, 4, 15, 57, 47, 201, DateTimeKind.Unspecified).AddTicks(3398), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Golds",
                keyColumn: "GoldId",
                keyValue: "1",
                column: "LastUpdated",
                value: new DateTimeOffset(new DateTime(2024, 7, 4, 15, 57, 47, 201, DateTimeKind.Unspecified).AddTicks(3418), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Golds",
                keyColumn: "GoldId",
                keyValue: "2",
                column: "LastUpdated",
                value: new DateTimeOffset(new DateTime(2024, 7, 4, 15, 57, 47, 201, DateTimeKind.Unspecified).AddTicks(3421), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Golds",
                keyColumn: "GoldId",
                keyValue: "3",
                column: "LastUpdated",
                value: new DateTimeOffset(new DateTime(2024, 7, 4, 15, 57, 47, 201, DateTimeKind.Unspecified).AddTicks(3423), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "PromotionId",
                keyValue: "1",
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 7, 14, 15, 57, 47, 201, DateTimeKind.Unspecified).AddTicks(3296), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 7, 4, 15, 57, 47, 201, DateTimeKind.Unspecified).AddTicks(3268), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "PromotionId",
                keyValue: "2",
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 7, 14, 15, 57, 47, 201, DateTimeKind.Unspecified).AddTicks(3303), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 7, 4, 15, 57, 47, 201, DateTimeKind.Unspecified).AddTicks(3302), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "PromotionId",
                keyValue: "3",
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 7, 14, 15, 57, 47, 201, DateTimeKind.Unspecified).AddTicks(3307), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 7, 4, 15, 57, 47, 201, DateTimeKind.Unspecified).AddTicks(3306), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Purchases",
                keyColumn: "PurchaseId",
                keyValue: "1",
                column: "PurchaseDate",
                value: new DateTimeOffset(new DateTime(2024, 7, 4, 15, 57, 47, 201, DateTimeKind.Unspecified).AddTicks(3442), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Purchases",
                keyColumn: "PurchaseId",
                keyValue: "2",
                column: "PurchaseDate",
                value: new DateTimeOffset(new DateTime(2024, 7, 4, 15, 57, 47, 201, DateTimeKind.Unspecified).AddTicks(3445), new TimeSpan(0, 7, 0, 0, 0)));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BillJewelryId",
                table: "Purchases",
                type: "text",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Bills",
                keyColumn: "BillId",
                keyValue: "1",
                column: "SaleDate",
                value: new DateTimeOffset(new DateTime(2024, 7, 4, 15, 56, 11, 166, DateTimeKind.Unspecified).AddTicks(8311), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Bills",
                keyColumn: "BillId",
                keyValue: "2",
                column: "SaleDate",
                value: new DateTimeOffset(new DateTime(2024, 7, 4, 15, 56, 11, 166, DateTimeKind.Unspecified).AddTicks(8314), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Gems",
                keyColumn: "GemId",
                keyValue: "1",
                column: "LastUpdated",
                value: new DateTimeOffset(new DateTime(2024, 7, 4, 15, 56, 11, 166, DateTimeKind.Unspecified).AddTicks(8373), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Gems",
                keyColumn: "GemId",
                keyValue: "2",
                column: "LastUpdated",
                value: new DateTimeOffset(new DateTime(2024, 7, 4, 15, 56, 11, 166, DateTimeKind.Unspecified).AddTicks(8381), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Gems",
                keyColumn: "GemId",
                keyValue: "3",
                column: "LastUpdated",
                value: new DateTimeOffset(new DateTime(2024, 7, 4, 15, 56, 11, 166, DateTimeKind.Unspecified).AddTicks(8383), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Golds",
                keyColumn: "GoldId",
                keyValue: "1",
                column: "LastUpdated",
                value: new DateTimeOffset(new DateTime(2024, 7, 4, 15, 56, 11, 166, DateTimeKind.Unspecified).AddTicks(8404), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Golds",
                keyColumn: "GoldId",
                keyValue: "2",
                column: "LastUpdated",
                value: new DateTimeOffset(new DateTime(2024, 7, 4, 15, 56, 11, 166, DateTimeKind.Unspecified).AddTicks(8407), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Golds",
                keyColumn: "GoldId",
                keyValue: "3",
                column: "LastUpdated",
                value: new DateTimeOffset(new DateTime(2024, 7, 4, 15, 56, 11, 166, DateTimeKind.Unspecified).AddTicks(8409), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "PromotionId",
                keyValue: "1",
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 7, 14, 15, 56, 11, 166, DateTimeKind.Unspecified).AddTicks(8263), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 7, 4, 15, 56, 11, 166, DateTimeKind.Unspecified).AddTicks(8234), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "PromotionId",
                keyValue: "2",
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 7, 14, 15, 56, 11, 166, DateTimeKind.Unspecified).AddTicks(8273), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 7, 4, 15, 56, 11, 166, DateTimeKind.Unspecified).AddTicks(8272), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "PromotionId",
                keyValue: "3",
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 7, 14, 15, 56, 11, 166, DateTimeKind.Unspecified).AddTicks(8277), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 7, 4, 15, 56, 11, 166, DateTimeKind.Unspecified).AddTicks(8275), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Purchases",
                keyColumn: "PurchaseId",
                keyValue: "1",
                columns: new[] { "BillJewelryId", "PurchaseDate" },
                values: new object[] { null, new DateTimeOffset(new DateTime(2024, 7, 4, 15, 56, 11, 166, DateTimeKind.Unspecified).AddTicks(8575), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Purchases",
                keyColumn: "PurchaseId",
                keyValue: "2",
                columns: new[] { "BillJewelryId", "PurchaseDate" },
                values: new object[] { null, new DateTimeOffset(new DateTime(2024, 7, 4, 15, 56, 11, 166, DateTimeKind.Unspecified).AddTicks(8578), new TimeSpan(0, 7, 0, 0, 0)) });
        }
    }
}
