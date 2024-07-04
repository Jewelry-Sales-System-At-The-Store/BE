using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusinessObjects.Migrations
{
    /// <inheritdoc />
    public partial class jewelrybill2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                value: new DateTimeOffset(new DateTime(2024, 7, 4, 15, 10, 35, 409, DateTimeKind.Unspecified).AddTicks(7856), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Bills",
                keyColumn: "BillId",
                keyValue: "2",
                column: "SaleDate",
                value: new DateTimeOffset(new DateTime(2024, 7, 4, 15, 10, 35, 409, DateTimeKind.Unspecified).AddTicks(7859), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Gems",
                keyColumn: "GemId",
                keyValue: "1",
                column: "LastUpdated",
                value: new DateTimeOffset(new DateTime(2024, 7, 4, 15, 10, 35, 409, DateTimeKind.Unspecified).AddTicks(7913), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Gems",
                keyColumn: "GemId",
                keyValue: "2",
                column: "LastUpdated",
                value: new DateTimeOffset(new DateTime(2024, 7, 4, 15, 10, 35, 409, DateTimeKind.Unspecified).AddTicks(7916), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Gems",
                keyColumn: "GemId",
                keyValue: "3",
                column: "LastUpdated",
                value: new DateTimeOffset(new DateTime(2024, 7, 4, 15, 10, 35, 409, DateTimeKind.Unspecified).AddTicks(7918), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Golds",
                keyColumn: "GoldId",
                keyValue: "1",
                column: "LastUpdated",
                value: new DateTimeOffset(new DateTime(2024, 7, 4, 15, 10, 35, 409, DateTimeKind.Unspecified).AddTicks(7937), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Golds",
                keyColumn: "GoldId",
                keyValue: "2",
                column: "LastUpdated",
                value: new DateTimeOffset(new DateTime(2024, 7, 4, 15, 10, 35, 409, DateTimeKind.Unspecified).AddTicks(7939), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Golds",
                keyColumn: "GoldId",
                keyValue: "3",
                column: "LastUpdated",
                value: new DateTimeOffset(new DateTime(2024, 7, 4, 15, 10, 35, 409, DateTimeKind.Unspecified).AddTicks(7941), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "PromotionId",
                keyValue: "1",
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 7, 14, 15, 10, 35, 409, DateTimeKind.Unspecified).AddTicks(7811), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 7, 4, 15, 10, 35, 409, DateTimeKind.Unspecified).AddTicks(7783), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "PromotionId",
                keyValue: "2",
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 7, 14, 15, 10, 35, 409, DateTimeKind.Unspecified).AddTicks(7828), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 7, 4, 15, 10, 35, 409, DateTimeKind.Unspecified).AddTicks(7827), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "PromotionId",
                keyValue: "3",
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 7, 14, 15, 10, 35, 409, DateTimeKind.Unspecified).AddTicks(7831), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 7, 4, 15, 10, 35, 409, DateTimeKind.Unspecified).AddTicks(7830), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Purchases",
                keyColumn: "PurchaseId",
                keyValue: "1",
                columns: new[] { "BillJewelryId", "PurchaseDate" },
                values: new object[] { null, new DateTimeOffset(new DateTime(2024, 7, 4, 15, 10, 35, 409, DateTimeKind.Unspecified).AddTicks(7962), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Purchases",
                keyColumn: "PurchaseId",
                keyValue: "2",
                columns: new[] { "BillJewelryId", "PurchaseDate" },
                values: new object[] { null, new DateTimeOffset(new DateTime(2024, 7, 4, 15, 10, 35, 409, DateTimeKind.Unspecified).AddTicks(7965), new TimeSpan(0, 7, 0, 0, 0)) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BillJewelryId",
                table: "Purchases");

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
    }
}
