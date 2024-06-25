using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusinessObjects.Migrations
{
    /// <inheritdoc />
    public partial class init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Bills",
                keyColumn: "BillId",
                keyValue: "1",
                column: "SaleDate",
                value: new DateTimeOffset(new DateTime(2024, 6, 22, 20, 20, 11, 875, DateTimeKind.Unspecified).AddTicks(4494), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Bills",
                keyColumn: "BillId",
                keyValue: "2",
                column: "SaleDate",
                value: new DateTimeOffset(new DateTime(2024, 6, 22, 20, 20, 11, 875, DateTimeKind.Unspecified).AddTicks(4496), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Gems",
                keyColumn: "GemId",
                keyValue: "1",
                column: "LastUpdated",
                value: new DateTimeOffset(new DateTime(2024, 6, 22, 20, 20, 11, 875, DateTimeKind.Unspecified).AddTicks(4551), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Gems",
                keyColumn: "GemId",
                keyValue: "2",
                column: "LastUpdated",
                value: new DateTimeOffset(new DateTime(2024, 6, 22, 20, 20, 11, 875, DateTimeKind.Unspecified).AddTicks(4553), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Gems",
                keyColumn: "GemId",
                keyValue: "3",
                column: "LastUpdated",
                value: new DateTimeOffset(new DateTime(2024, 6, 22, 20, 20, 11, 875, DateTimeKind.Unspecified).AddTicks(4555), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Golds",
                keyColumn: "GoldId",
                keyValue: "1",
                column: "LastUpdated",
                value: new DateTimeOffset(new DateTime(2024, 6, 22, 20, 20, 11, 875, DateTimeKind.Unspecified).AddTicks(4582), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Golds",
                keyColumn: "GoldId",
                keyValue: "2",
                column: "LastUpdated",
                value: new DateTimeOffset(new DateTime(2024, 6, 22, 20, 20, 11, 875, DateTimeKind.Unspecified).AddTicks(4585), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Golds",
                keyColumn: "GoldId",
                keyValue: "3",
                column: "LastUpdated",
                value: new DateTimeOffset(new DateTime(2024, 6, 22, 20, 20, 11, 875, DateTimeKind.Unspecified).AddTicks(4587), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "PromotionId",
                keyValue: "1",
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 7, 2, 20, 20, 11, 875, DateTimeKind.Unspecified).AddTicks(4462), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 22, 20, 20, 11, 875, DateTimeKind.Unspecified).AddTicks(4436), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "PromotionId",
                keyValue: "2",
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 7, 2, 20, 20, 11, 875, DateTimeKind.Unspecified).AddTicks(4468), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 22, 20, 20, 11, 875, DateTimeKind.Unspecified).AddTicks(4467), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "PromotionId",
                keyValue: "3",
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 7, 2, 20, 20, 11, 875, DateTimeKind.Unspecified).AddTicks(4471), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 22, 20, 20, 11, 875, DateTimeKind.Unspecified).AddTicks(4470), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Purchases",
                keyColumn: "PurchaseId",
                keyValue: "1",
                column: "PurchaseDate",
                value: new DateTimeOffset(new DateTime(2024, 6, 22, 20, 20, 11, 875, DateTimeKind.Unspecified).AddTicks(4612), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Purchases",
                keyColumn: "PurchaseId",
                keyValue: "2",
                column: "PurchaseDate",
                value: new DateTimeOffset(new DateTime(2024, 6, 22, 20, 20, 11, 875, DateTimeKind.Unspecified).AddTicks(4614), new TimeSpan(0, 7, 0, 0, 0)));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Bills",
                keyColumn: "BillId",
                keyValue: "1",
                column: "SaleDate",
                value: new DateTimeOffset(new DateTime(2024, 6, 22, 10, 31, 14, 484, DateTimeKind.Unspecified).AddTicks(7262), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Bills",
                keyColumn: "BillId",
                keyValue: "2",
                column: "SaleDate",
                value: new DateTimeOffset(new DateTime(2024, 6, 22, 10, 31, 14, 484, DateTimeKind.Unspecified).AddTicks(7265), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Gems",
                keyColumn: "GemId",
                keyValue: "1",
                column: "LastUpdated",
                value: new DateTimeOffset(new DateTime(2024, 6, 22, 10, 31, 14, 484, DateTimeKind.Unspecified).AddTicks(7319), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Gems",
                keyColumn: "GemId",
                keyValue: "2",
                column: "LastUpdated",
                value: new DateTimeOffset(new DateTime(2024, 6, 22, 10, 31, 14, 484, DateTimeKind.Unspecified).AddTicks(7321), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Gems",
                keyColumn: "GemId",
                keyValue: "3",
                column: "LastUpdated",
                value: new DateTimeOffset(new DateTime(2024, 6, 22, 10, 31, 14, 484, DateTimeKind.Unspecified).AddTicks(7323), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Golds",
                keyColumn: "GoldId",
                keyValue: "1",
                column: "LastUpdated",
                value: new DateTimeOffset(new DateTime(2024, 6, 22, 10, 31, 14, 484, DateTimeKind.Unspecified).AddTicks(7348), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Golds",
                keyColumn: "GoldId",
                keyValue: "2",
                column: "LastUpdated",
                value: new DateTimeOffset(new DateTime(2024, 6, 22, 10, 31, 14, 484, DateTimeKind.Unspecified).AddTicks(7350), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Golds",
                keyColumn: "GoldId",
                keyValue: "3",
                column: "LastUpdated",
                value: new DateTimeOffset(new DateTime(2024, 6, 22, 10, 31, 14, 484, DateTimeKind.Unspecified).AddTicks(7352), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "PromotionId",
                keyValue: "1",
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 7, 2, 10, 31, 14, 484, DateTimeKind.Unspecified).AddTicks(7230), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 22, 10, 31, 14, 484, DateTimeKind.Unspecified).AddTicks(7201), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "PromotionId",
                keyValue: "2",
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 7, 2, 10, 31, 14, 484, DateTimeKind.Unspecified).AddTicks(7240), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 22, 10, 31, 14, 484, DateTimeKind.Unspecified).AddTicks(7239), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "PromotionId",
                keyValue: "3",
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 7, 2, 10, 31, 14, 484, DateTimeKind.Unspecified).AddTicks(7243), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 22, 10, 31, 14, 484, DateTimeKind.Unspecified).AddTicks(7242), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Purchases",
                keyColumn: "PurchaseId",
                keyValue: "1",
                column: "PurchaseDate",
                value: new DateTimeOffset(new DateTime(2024, 6, 22, 10, 31, 14, 484, DateTimeKind.Unspecified).AddTicks(7373), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Purchases",
                keyColumn: "PurchaseId",
                keyValue: "2",
                column: "PurchaseDate",
                value: new DateTimeOffset(new DateTime(2024, 6, 22, 10, 31, 14, 484, DateTimeKind.Unspecified).AddTicks(7376), new TimeSpan(0, 7, 0, 0, 0)));
        }
    }
}
