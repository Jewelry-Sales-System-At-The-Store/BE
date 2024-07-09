using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusinessObjects.Migrations
{
    /// <inheritdoc />
    public partial class jewelrybill : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Bills",
                keyColumn: "BillId",
                keyValue: "1",
                column: "SaleDate",
                value: new DateTimeOffset(new DateTime(2024, 7, 4, 15, 7, 41, 358, DateTimeKind.Unspecified).AddTicks(3493), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Bills",
                keyColumn: "BillId",
                keyValue: "2",
                column: "SaleDate",
                value: new DateTimeOffset(new DateTime(2024, 7, 4, 15, 7, 41, 358, DateTimeKind.Unspecified).AddTicks(3496), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Gems",
                keyColumn: "GemId",
                keyValue: "1",
                column: "LastUpdated",
                value: new DateTimeOffset(new DateTime(2024, 7, 4, 15, 7, 41, 358, DateTimeKind.Unspecified).AddTicks(3562), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Gems",
                keyColumn: "GemId",
                keyValue: "2",
                column: "LastUpdated",
                value: new DateTimeOffset(new DateTime(2024, 7, 4, 15, 7, 41, 358, DateTimeKind.Unspecified).AddTicks(3566), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Gems",
                keyColumn: "GemId",
                keyValue: "3",
                column: "LastUpdated",
                value: new DateTimeOffset(new DateTime(2024, 7, 4, 15, 7, 41, 358, DateTimeKind.Unspecified).AddTicks(3568), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Golds",
                keyColumn: "GoldId",
                keyValue: "1",
                column: "LastUpdated",
                value: new DateTimeOffset(new DateTime(2024, 7, 4, 15, 7, 41, 358, DateTimeKind.Unspecified).AddTicks(3590), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Golds",
                keyColumn: "GoldId",
                keyValue: "2",
                column: "LastUpdated",
                value: new DateTimeOffset(new DateTime(2024, 7, 4, 15, 7, 41, 358, DateTimeKind.Unspecified).AddTicks(3593), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Golds",
                keyColumn: "GoldId",
                keyValue: "3",
                column: "LastUpdated",
                value: new DateTimeOffset(new DateTime(2024, 7, 4, 15, 7, 41, 358, DateTimeKind.Unspecified).AddTicks(3595), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "PromotionId",
                keyValue: "1",
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 7, 14, 15, 7, 41, 358, DateTimeKind.Unspecified).AddTicks(3458), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 7, 4, 15, 7, 41, 358, DateTimeKind.Unspecified).AddTicks(3431), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "PromotionId",
                keyValue: "2",
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 7, 14, 15, 7, 41, 358, DateTimeKind.Unspecified).AddTicks(3466), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 7, 4, 15, 7, 41, 358, DateTimeKind.Unspecified).AddTicks(3465), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "PromotionId",
                keyValue: "3",
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 7, 14, 15, 7, 41, 358, DateTimeKind.Unspecified).AddTicks(3469), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 7, 4, 15, 7, 41, 358, DateTimeKind.Unspecified).AddTicks(3468), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Purchases",
                keyColumn: "PurchaseId",
                keyValue: "1",
                column: "PurchaseDate",
                value: new DateTimeOffset(new DateTime(2024, 7, 4, 15, 7, 41, 358, DateTimeKind.Unspecified).AddTicks(3614), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Purchases",
                keyColumn: "PurchaseId",
                keyValue: "2",
                column: "PurchaseDate",
                value: new DateTimeOffset(new DateTime(2024, 7, 4, 15, 7, 41, 358, DateTimeKind.Unspecified).AddTicks(3617), new TimeSpan(0, 7, 0, 0, 0)));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Bills",
                keyColumn: "BillId",
                keyValue: "1",
                column: "SaleDate",
                value: new DateTimeOffset(new DateTime(2024, 7, 3, 9, 14, 48, 253, DateTimeKind.Unspecified).AddTicks(2090), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Bills",
                keyColumn: "BillId",
                keyValue: "2",
                column: "SaleDate",
                value: new DateTimeOffset(new DateTime(2024, 7, 3, 9, 14, 48, 253, DateTimeKind.Unspecified).AddTicks(2092), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Gems",
                keyColumn: "GemId",
                keyValue: "1",
                column: "LastUpdated",
                value: new DateTimeOffset(new DateTime(2024, 7, 3, 9, 14, 48, 253, DateTimeKind.Unspecified).AddTicks(2145), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Gems",
                keyColumn: "GemId",
                keyValue: "2",
                column: "LastUpdated",
                value: new DateTimeOffset(new DateTime(2024, 7, 3, 9, 14, 48, 253, DateTimeKind.Unspecified).AddTicks(2153), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Gems",
                keyColumn: "GemId",
                keyValue: "3",
                column: "LastUpdated",
                value: new DateTimeOffset(new DateTime(2024, 7, 3, 9, 14, 48, 253, DateTimeKind.Unspecified).AddTicks(2155), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Golds",
                keyColumn: "GoldId",
                keyValue: "1",
                column: "LastUpdated",
                value: new DateTimeOffset(new DateTime(2024, 7, 3, 9, 14, 48, 253, DateTimeKind.Unspecified).AddTicks(2176), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Golds",
                keyColumn: "GoldId",
                keyValue: "2",
                column: "LastUpdated",
                value: new DateTimeOffset(new DateTime(2024, 7, 3, 9, 14, 48, 253, DateTimeKind.Unspecified).AddTicks(2179), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Golds",
                keyColumn: "GoldId",
                keyValue: "3",
                column: "LastUpdated",
                value: new DateTimeOffset(new DateTime(2024, 7, 3, 9, 14, 48, 253, DateTimeKind.Unspecified).AddTicks(2180), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "PromotionId",
                keyValue: "1",
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 7, 13, 9, 14, 48, 253, DateTimeKind.Unspecified).AddTicks(2057), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 7, 3, 9, 14, 48, 253, DateTimeKind.Unspecified).AddTicks(2029), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "PromotionId",
                keyValue: "2",
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 7, 13, 9, 14, 48, 253, DateTimeKind.Unspecified).AddTicks(2064), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 7, 3, 9, 14, 48, 253, DateTimeKind.Unspecified).AddTicks(2063), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "PromotionId",
                keyValue: "3",
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 7, 13, 9, 14, 48, 253, DateTimeKind.Unspecified).AddTicks(2067), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 7, 3, 9, 14, 48, 253, DateTimeKind.Unspecified).AddTicks(2066), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Purchases",
                keyColumn: "PurchaseId",
                keyValue: "1",
                column: "PurchaseDate",
                value: new DateTimeOffset(new DateTime(2024, 7, 3, 9, 14, 48, 253, DateTimeKind.Unspecified).AddTicks(2200), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Purchases",
                keyColumn: "PurchaseId",
                keyValue: "2",
                column: "PurchaseDate",
                value: new DateTimeOffset(new DateTime(2024, 7, 3, 9, 14, 48, 253, DateTimeKind.Unspecified).AddTicks(2202), new TimeSpan(0, 7, 0, 0, 0)));
        }
    }
}
