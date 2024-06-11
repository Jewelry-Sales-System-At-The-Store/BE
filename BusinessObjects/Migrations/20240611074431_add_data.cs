using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BusinessObjects.Migrations
{
    /// <inheritdoc />
    public partial class add_data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Counters",
                columns: new[] { "CounterId", "Number" },
                values: new object[,]
                {
                    { "1", 312 },
                    { "2", 231 },
                    { "3", 431 }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Address", "Name", "Phone", "Point" },
                values: new object[,]
                {
                    { "1", "Ha Noi", "Nguyen Van A", "0123456789", null },
                    { "2", "Ha Noi", "Nguyen Van B", "0123456789", null },
                    { "3", "Ha Noi", "Nguyen Van C", "0123456789", null }
                });

            migrationBuilder.InsertData(
                table: "GoldPrices",
                columns: new[] { "GoldPriceId", "BuyPrice", "City", "LastUpdated", "SellPrice", "Type" },
                values: new object[,]
                {
                    { "1", 1000f, "Ha Noi", new DateTime(2024, 6, 11, 14, 44, 30, 927, DateTimeKind.Local).AddTicks(1442), 1200f, "9999" },
                    { "2", 1200f, "Ha Noi", new DateTime(2024, 6, 11, 14, 44, 30, 927, DateTimeKind.Local).AddTicks(1444), 1400f, "SCJ" },
                    { "3", 1400f, "Ha Noi", new DateTime(2024, 6, 11, 14, 44, 30, 927, DateTimeKind.Local).AddTicks(1446), 1600f, "18k" }
                });

            migrationBuilder.InsertData(
                table: "JewelryTypes",
                columns: new[] { "JewelryTypeId", "Name" },
                values: new object[,]
                {
                    { "1", "Vong tay" },
                    { "2", "Nhan" },
                    { "3", "Day chuyen" }
                });

            migrationBuilder.InsertData(
                table: "Promotions",
                columns: new[] { "PromotionId", "ApproveManager", "Description", "DiscountRate", "EndDate", "StartDate", "Type" },
                values: new object[,]
                {
                    { "1", null, "Giam gia 10%", 1.0, new DateTime(2024, 6, 21, 14, 44, 30, 927, DateTimeKind.Local).AddTicks(1327), new DateTime(2024, 6, 11, 14, 44, 30, 927, DateTimeKind.Local).AddTicks(1315), "Giam gia" },
                    { "2", null, "Giam gia 20%", 2.0, new DateTime(2024, 6, 21, 14, 44, 30, 927, DateTimeKind.Local).AddTicks(1334), new DateTime(2024, 6, 11, 14, 44, 30, 927, DateTimeKind.Local).AddTicks(1334), "Giam gia" },
                    { "3", null, "Giam gia 30%", 3.0, new DateTime(2024, 6, 21, 14, 44, 30, 927, DateTimeKind.Local).AddTicks(1337), new DateTime(2024, 6, 11, 14, 44, 30, 927, DateTimeKind.Local).AddTicks(1336), "Giam gia" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleId", "RoleName" },
                values: new object[,]
                {
                    { "1", "Admin" },
                    { "2", "Manager" },
                    { "3", "Staff" }
                });

            migrationBuilder.InsertData(
                table: "StonePrices",
                columns: new[] { "StonePriceId", "BuyPrice", "City", "LastUpdated", "SellPrice", "Type" },
                values: new object[,]
                {
                    { "1", 300f, "Ha Noi", new DateTime(2024, 6, 11, 14, 44, 30, 927, DateTimeKind.Local).AddTicks(1412), 400f, "Ruby" },
                    { "2", 400f, "Ha Noi", new DateTime(2024, 6, 11, 14, 44, 30, 927, DateTimeKind.Local).AddTicks(1421), 500f, "Sapphire" },
                    { "3", 500f, "Ha Noi", new DateTime(2024, 6, 11, 14, 44, 30, 927, DateTimeKind.Local).AddTicks(1423), 600f, "Emerald" }
                });

            migrationBuilder.InsertData(
                table: "Jewelries",
                columns: new[] { "JewelryId", "Barcode", "IsSold", "JewelryTypeId", "LaborCost", "Name" },
                values: new object[,]
                {
                    { "1", "AVC131", true, "1", 312.0, "Vong tay" },
                    { "2", "SAC132", false, "2", 231.0, "Nhan" },
                    { "3", "SACC3", true, "3", 431.0, "Day chuyen" },
                    { "4", "SFA131", true, "2", 552.0, "Vong tay Xanh" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "CounterId", "Email", "Password", "RoleId", "Status", "Username" },
                values: new object[,]
                {
                    { "1", "1", "nghialoe46a2gmail.com", "5678", "1", false, "admin Nghia" },
                    { "2", "2", "JohnDoe@gmail.com", "1234", "2", false, "manager John Doe" },
                    { "3", "3", "Chis@yahho.com", "4321", "3", false, "staff Chis Nguyen" }
                });

            migrationBuilder.InsertData(
                table: "Bills",
                columns: new[] { "BillId", "CounterId", "CustomerId", "SaleDate", "TotalAmount", "UserId" },
                values: new object[,]
                {
                    { "1", null, "1", new DateTime(2024, 6, 11, 14, 44, 30, 927, DateTimeKind.Local).AddTicks(1357), 500.0, "1" },
                    { "2", null, "2", new DateTime(2024, 6, 11, 14, 44, 30, 927, DateTimeKind.Local).AddTicks(1359), 1200.0, "2" }
                });

            migrationBuilder.InsertData(
                table: "Purchases",
                columns: new[] { "PurchaseId", "CustomerId", "IsBuyBack", "JewelryId", "PurchaseDate", "PurchasePrice", "UserId" },
                values: new object[,]
                {
                    { "1", "1", 0, "1", new DateTime(2024, 6, 11, 14, 44, 30, 927, DateTimeKind.Local).AddTicks(1464), 500.0, "1" },
                    { "2", "2", 1, "2", new DateTime(2024, 6, 11, 14, 44, 30, 927, DateTimeKind.Local).AddTicks(1466), 300.0, "1" },
                    { "3", "2", 0, "3", new DateTime(2024, 6, 11, 14, 44, 30, 927, DateTimeKind.Local).AddTicks(1467), 1000.0, "1" }
                });

            migrationBuilder.InsertData(
                table: "BillJewelries",
                columns: new[] { "BillJewelryId", "BillId", "JewelryId" },
                values: new object[,]
                {
                    { "1", "1", "1" },
                    { "2", "1", "2" },
                    { "3", "2", "3" }
                });

            migrationBuilder.InsertData(
                table: "BillPromotions",
                columns: new[] { "BillPromotionId", "BillId", "PromotionId" },
                values: new object[,]
                {
                    { "1", "1", "1" },
                    { "2", "2", "1" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BillJewelries",
                keyColumn: "BillJewelryId",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "BillJewelries",
                keyColumn: "BillJewelryId",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "BillJewelries",
                keyColumn: "BillJewelryId",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "BillPromotions",
                keyColumn: "BillPromotionId",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "BillPromotions",
                keyColumn: "BillPromotionId",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "GoldPrices",
                keyColumn: "GoldPriceId",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "GoldPrices",
                keyColumn: "GoldPriceId",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "GoldPrices",
                keyColumn: "GoldPriceId",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "Jewelries",
                keyColumn: "JewelryId",
                keyValue: "4");

            migrationBuilder.DeleteData(
                table: "Promotions",
                keyColumn: "PromotionId",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "Promotions",
                keyColumn: "PromotionId",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "Purchases",
                keyColumn: "PurchaseId",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "Purchases",
                keyColumn: "PurchaseId",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "Purchases",
                keyColumn: "PurchaseId",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "StonePrices",
                keyColumn: "StonePriceId",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "StonePrices",
                keyColumn: "StonePriceId",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "StonePrices",
                keyColumn: "StonePriceId",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "Bills",
                keyColumn: "BillId",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "Bills",
                keyColumn: "BillId",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "Counters",
                keyColumn: "CounterId",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "Jewelries",
                keyColumn: "JewelryId",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "Jewelries",
                keyColumn: "JewelryId",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "Jewelries",
                keyColumn: "JewelryId",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "Promotions",
                keyColumn: "PromotionId",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "JewelryTypes",
                keyColumn: "JewelryTypeId",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "JewelryTypes",
                keyColumn: "JewelryTypeId",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "JewelryTypes",
                keyColumn: "JewelryTypeId",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "Counters",
                keyColumn: "CounterId",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "Counters",
                keyColumn: "CounterId",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: "2");
        }
    }
}
