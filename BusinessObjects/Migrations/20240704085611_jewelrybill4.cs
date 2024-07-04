﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusinessObjects.Migrations
{
    /// <inheritdoc />
    public partial class jewelrybill4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                column: "PurchaseDate",
                value: new DateTimeOffset(new DateTime(2024, 7, 4, 15, 56, 11, 166, DateTimeKind.Unspecified).AddTicks(8575), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Purchases",
                keyColumn: "PurchaseId",
                keyValue: "2",
                column: "PurchaseDate",
                value: new DateTimeOffset(new DateTime(2024, 7, 4, 15, 56, 11, 166, DateTimeKind.Unspecified).AddTicks(8578), new TimeSpan(0, 7, 0, 0, 0)));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Bills",
                keyColumn: "BillId",
                keyValue: "1",
                column: "SaleDate",
                value: new DateTimeOffset(new DateTime(2024, 7, 4, 15, 54, 32, 454, DateTimeKind.Unspecified).AddTicks(948), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Bills",
                keyColumn: "BillId",
                keyValue: "2",
                column: "SaleDate",
                value: new DateTimeOffset(new DateTime(2024, 7, 4, 15, 54, 32, 454, DateTimeKind.Unspecified).AddTicks(952), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Gems",
                keyColumn: "GemId",
                keyValue: "1",
                column: "LastUpdated",
                value: new DateTimeOffset(new DateTime(2024, 7, 4, 15, 54, 32, 454, DateTimeKind.Unspecified).AddTicks(1017), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Gems",
                keyColumn: "GemId",
                keyValue: "2",
                column: "LastUpdated",
                value: new DateTimeOffset(new DateTime(2024, 7, 4, 15, 54, 32, 454, DateTimeKind.Unspecified).AddTicks(1020), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Gems",
                keyColumn: "GemId",
                keyValue: "3",
                column: "LastUpdated",
                value: new DateTimeOffset(new DateTime(2024, 7, 4, 15, 54, 32, 454, DateTimeKind.Unspecified).AddTicks(1022), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Golds",
                keyColumn: "GoldId",
                keyValue: "1",
                column: "LastUpdated",
                value: new DateTimeOffset(new DateTime(2024, 7, 4, 15, 54, 32, 454, DateTimeKind.Unspecified).AddTicks(1042), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Golds",
                keyColumn: "GoldId",
                keyValue: "2",
                column: "LastUpdated",
                value: new DateTimeOffset(new DateTime(2024, 7, 4, 15, 54, 32, 454, DateTimeKind.Unspecified).AddTicks(1044), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Golds",
                keyColumn: "GoldId",
                keyValue: "3",
                column: "LastUpdated",
                value: new DateTimeOffset(new DateTime(2024, 7, 4, 15, 54, 32, 454, DateTimeKind.Unspecified).AddTicks(1046), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "PromotionId",
                keyValue: "1",
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 7, 14, 15, 54, 32, 454, DateTimeKind.Unspecified).AddTicks(913), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 7, 4, 15, 54, 32, 454, DateTimeKind.Unspecified).AddTicks(882), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "PromotionId",
                keyValue: "2",
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 7, 14, 15, 54, 32, 454, DateTimeKind.Unspecified).AddTicks(922), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 7, 4, 15, 54, 32, 454, DateTimeKind.Unspecified).AddTicks(921), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "PromotionId",
                keyValue: "3",
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 7, 14, 15, 54, 32, 454, DateTimeKind.Unspecified).AddTicks(925), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 7, 4, 15, 54, 32, 454, DateTimeKind.Unspecified).AddTicks(924), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Purchases",
                keyColumn: "PurchaseId",
                keyValue: "1",
                column: "PurchaseDate",
                value: new DateTimeOffset(new DateTime(2024, 7, 4, 15, 54, 32, 454, DateTimeKind.Unspecified).AddTicks(1066), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Purchases",
                keyColumn: "PurchaseId",
                keyValue: "2",
                column: "PurchaseDate",
                value: new DateTimeOffset(new DateTime(2024, 7, 4, 15, 54, 32, 454, DateTimeKind.Unspecified).AddTicks(1068), new TimeSpan(0, 7, 0, 0, 0)));
        }
    }
}