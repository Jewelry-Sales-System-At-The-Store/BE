using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BusinessObjects.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Counters",
                columns: table => new
                {
                    CounterId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Counters", x => x.CounterId);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Point = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "GoldPrices",
                columns: table => new
                {
                    GoldPriceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BuyPrice = table.Column<float>(type: "real", nullable: false),
                    SellPrice = table.Column<float>(type: "real", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoldPrices", x => x.GoldPriceId);
                });

            migrationBuilder.CreateTable(
                name: "JewelryTypes",
                columns: table => new
                {
                    JewelryTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JewelryTypes", x => x.JewelryTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Materials",
                columns: table => new
                {
                    MaterialId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materials", x => x.MaterialId);
                });

            migrationBuilder.CreateTable(
                name: "Promotions",
                columns: table => new
                {
                    PromotionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApproveManager = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiscountRate = table.Column<double>(type: "float", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Promotions", x => x.PromotionId);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    RoleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.RoleId);
                });

            migrationBuilder.CreateTable(
                name: "StonePrices",
                columns: table => new
                {
                    StonePriceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BuyPrice = table.Column<float>(type: "real", nullable: false),
                    SellPrice = table.Column<float>(type: "real", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StonePrices", x => x.StonePriceId);
                });

            migrationBuilder.CreateTable(
                name: "Jewelries",
                columns: table => new
                {
                    JewelryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JewelryTypeId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Barcode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LaborCost = table.Column<double>(type: "float", nullable: true),
                    IsSold = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jewelries", x => x.JewelryId);
                    table.ForeignKey(
                        name: "FK_Jewelries_JewelryTypes_JewelryTypeId",
                        column: x => x.JewelryTypeId,
                        principalTable: "JewelryTypes",
                        principalColumn: "JewelryTypeId");
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: true),
                    CounterId = table.Column<int>(type: "int", nullable: true),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_Users_Counters_CounterId",
                        column: x => x.CounterId,
                        principalTable: "Counters",
                        principalColumn: "CounterId");
                    table.ForeignKey(
                        name: "FK_Users_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "RoleId");
                });

            migrationBuilder.CreateTable(
                name: "MasterPrices",
                columns: table => new
                {
                    MasterPriceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StonePriceId = table.Column<int>(type: "int", nullable: false),
                    GoldPriceId = table.Column<int>(type: "int", nullable: false),
                    SellOutPrice = table.Column<float>(type: "real", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterPrices", x => x.MasterPriceId);
                    table.ForeignKey(
                        name: "FK_MasterPrices_GoldPrices_GoldPriceId",
                        column: x => x.GoldPriceId,
                        principalTable: "GoldPrices",
                        principalColumn: "GoldPriceId");
                    table.ForeignKey(
                        name: "FK_MasterPrices_StonePrices_StonePriceId",
                        column: x => x.StonePriceId,
                        principalTable: "StonePrices",
                        principalColumn: "StonePriceId");
                });

            migrationBuilder.CreateTable(
                name: "Warranties",
                columns: table => new
                {
                    WarrantyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JewelryId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Warranties", x => x.WarrantyId);
                    table.ForeignKey(
                        name: "FK_Warranties_Jewelries_JewelryId",
                        column: x => x.JewelryId,
                        principalTable: "Jewelries",
                        principalColumn: "JewelryId");
                });

            migrationBuilder.CreateTable(
                name: "Bills",
                columns: table => new
                {
                    BillId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    TotalAmount = table.Column<double>(type: "float", nullable: true),
                    SaleDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bills", x => x.BillId);
                    table.ForeignKey(
                        name: "FK_Bills_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId");
                    table.ForeignKey(
                        name: "FK_Bills_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "Purchases",
                columns: table => new
                {
                    PurchaseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    JewelryId = table.Column<int>(type: "int", nullable: true),
                    PurchaseDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PurchasePrice = table.Column<double>(type: "float", nullable: true),
                    IsBuyBack = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Purchases", x => x.PurchaseId);
                    table.ForeignKey(
                        name: "FK_Purchases_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId");
                    table.ForeignKey(
                        name: "FK_Purchases_Jewelries_JewelryId",
                        column: x => x.JewelryId,
                        principalTable: "Jewelries",
                        principalColumn: "JewelryId");
                    table.ForeignKey(
                        name: "FK_Purchases_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "JewelryMaterials",
                columns: table => new
                {
                    JewelryMaterialId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MasterPriceId = table.Column<int>(type: "int", nullable: false),
                    JewelryId = table.Column<int>(type: "int", nullable: false),
                    MaterialId = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JewelryMaterials", x => x.JewelryMaterialId);
                    table.ForeignKey(
                        name: "FK_JewelryMaterials_Jewelries_JewelryId",
                        column: x => x.JewelryId,
                        principalTable: "Jewelries",
                        principalColumn: "JewelryId");
                    table.ForeignKey(
                        name: "FK_JewelryMaterials_MasterPrices_MasterPriceId",
                        column: x => x.MasterPriceId,
                        principalTable: "MasterPrices",
                        principalColumn: "MasterPriceId");
                    table.ForeignKey(
                        name: "FK_JewelryMaterials_Materials_MaterialId",
                        column: x => x.MaterialId,
                        principalTable: "Materials",
                        principalColumn: "MaterialId");
                });

            migrationBuilder.CreateTable(
                name: "BillJewelries",
                columns: table => new
                {
                    BillJewelryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BillId = table.Column<int>(type: "int", nullable: true),
                    JewelryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillJewelries", x => x.BillJewelryId);
                    table.ForeignKey(
                        name: "FK_BillJewelries_Bills_BillId",
                        column: x => x.BillId,
                        principalTable: "Bills",
                        principalColumn: "BillId");
                    table.ForeignKey(
                        name: "FK_BillJewelries_Jewelries_JewelryId",
                        column: x => x.JewelryId,
                        principalTable: "Jewelries",
                        principalColumn: "JewelryId");
                });

            migrationBuilder.CreateTable(
                name: "BillPromotions",
                columns: table => new
                {
                    BillPromotionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BillId = table.Column<int>(type: "int", nullable: true),
                    PromotionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillPromotions", x => x.BillPromotionId);
                    table.ForeignKey(
                        name: "FK_BillPromotions_Bills_BillId",
                        column: x => x.BillId,
                        principalTable: "Bills",
                        principalColumn: "BillId");
                    table.ForeignKey(
                        name: "FK_BillPromotions_Promotions_PromotionId",
                        column: x => x.PromotionId,
                        principalTable: "Promotions",
                        principalColumn: "PromotionId");
                });

            migrationBuilder.InsertData(
                table: "Counters",
                columns: new[] { "CounterId", "Number" },
                values: new object[,]
                {
                    { 1, 312 },
                    { 2, 231 },
                    { 3, 431 }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Address", "Name", "Phone", "Point" },
                values: new object[,]
                {
                    { 1, "Ha Noi", "Nguyen Van A", "0123456789", null },
                    { 2, "Ha Noi", "Nguyen Van B", "0123456789", null },
                    { 3, "Ha Noi", "Nguyen Van C", "0123456789", null }
                });

            migrationBuilder.InsertData(
                table: "GoldPrices",
                columns: new[] { "GoldPriceId", "BuyPrice", "City", "LastUpdated", "SellPrice", "Type" },
                values: new object[,]
                {
                    { 1, 1000f, "Ha Noi", new DateTime(2024, 6, 7, 22, 15, 47, 340, DateTimeKind.Local).AddTicks(6374), 1200f, "9999" },
                    { 2, 1200f, "Ha Noi", new DateTime(2024, 6, 7, 22, 15, 47, 340, DateTimeKind.Local).AddTicks(6376), 1400f, "SCJ" },
                    { 3, 1400f, "Ha Noi", new DateTime(2024, 6, 7, 22, 15, 47, 340, DateTimeKind.Local).AddTicks(6378), 1600f, "18k" }
                });

            migrationBuilder.InsertData(
                table: "JewelryTypes",
                columns: new[] { "JewelryTypeId", "Name" },
                values: new object[,]
                {
                    { 1, "Vong tay" },
                    { 2, "Nhan" },
                    { 3, "Day chuyen" }
                });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Vang 18k", "Vang" },
                    { 2, "Bac 9999", "Bac" },
                    { 3, "Kim cuong 1 ly", "Kim cuong" }
                });

            migrationBuilder.InsertData(
                table: "Promotions",
                columns: new[] { "PromotionId", "ApproveManager", "Description", "DiscountRate", "EndDate", "StartDate", "Type" },
                values: new object[,]
                {
                    { 1, null, "Giam gia 10%", 1.0, new DateTime(2024, 6, 17, 22, 15, 47, 340, DateTimeKind.Local).AddTicks(6237), new DateTime(2024, 6, 7, 22, 15, 47, 340, DateTimeKind.Local).AddTicks(6224), "Giam gia" },
                    { 2, null, "Giam gia 20%", 2.0, new DateTime(2024, 6, 17, 22, 15, 47, 340, DateTimeKind.Local).AddTicks(6243), new DateTime(2024, 6, 7, 22, 15, 47, 340, DateTimeKind.Local).AddTicks(6243), "Giam gia" },
                    { 3, null, "Giam gia 30%", 3.0, new DateTime(2024, 6, 17, 22, 15, 47, 340, DateTimeKind.Local).AddTicks(6245), new DateTime(2024, 6, 7, 22, 15, 47, 340, DateTimeKind.Local).AddTicks(6245), "Giam gia" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleId", "RoleName" },
                values: new object[,]
                {
                    { 1, "Admin" },
                    { 2, "Manager" },
                    { 3, "Staff" }
                });

            migrationBuilder.InsertData(
                table: "StonePrices",
                columns: new[] { "StonePriceId", "BuyPrice", "City", "LastUpdated", "SellPrice", "Type" },
                values: new object[,]
                {
                    { 1, 300f, "Ha Noi", new DateTime(2024, 6, 7, 22, 15, 47, 340, DateTimeKind.Local).AddTicks(6352), 400f, "Ruby" },
                    { 2, 400f, "Ha Noi", new DateTime(2024, 6, 7, 22, 15, 47, 340, DateTimeKind.Local).AddTicks(6354), 500f, "Sapphire" },
                    { 3, 500f, "Ha Noi", new DateTime(2024, 6, 7, 22, 15, 47, 340, DateTimeKind.Local).AddTicks(6355), 600f, "Emerald" }
                });

            migrationBuilder.InsertData(
                table: "Jewelries",
                columns: new[] { "JewelryId", "Barcode", "IsSold", "JewelryTypeId", "LaborCost", "Name" },
                values: new object[,]
                {
                    { 1, "AVC131", true, 1, 312.0, "Vong tay" },
                    { 2, "SAC132", false, 2, 231.0, "Nhan" },
                    { 3, "SACC3", true, 3, 431.0, "Day chuyen" },
                    { 4, "SFA131", true, 2, 552.0, "Vong tay Xanh" }
                });

            migrationBuilder.InsertData(
                table: "MasterPrices",
                columns: new[] { "MasterPriceId", "Date", "GoldPriceId", "SellOutPrice", "StonePriceId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 7, 22, 15, 47, 340, DateTimeKind.Local).AddTicks(6395), 1, 500f, 1 },
                    { 2, new DateTime(2024, 6, 7, 22, 15, 47, 340, DateTimeKind.Local).AddTicks(6397), 2, 600f, 2 },
                    { 3, new DateTime(2024, 6, 7, 22, 15, 47, 340, DateTimeKind.Local).AddTicks(6398), 3, 512f, 3 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "CounterId", "Email", "Password", "RoleId", "Status", "Username" },
                values: new object[,]
                {
                    { 1, 1, "nghialoe46a2gmail.com", "5678", 1, false, "admin Nghia" },
                    { 2, 2, "JohnDoe@gmail.com", "1234", 2, false, "manager John Doe" },
                    { 3, 3, "Chis@yahho.com", "4321", 3, false, "staff Chis Nguyen" }
                });

            migrationBuilder.InsertData(
                table: "Bills",
                columns: new[] { "BillId", "CustomerId", "SaleDate", "TotalAmount", "UserId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 6, 7, 22, 15, 47, 340, DateTimeKind.Local).AddTicks(6291), 500.0, 1 },
                    { 2, 2, new DateTime(2024, 6, 7, 22, 15, 47, 340, DateTimeKind.Local).AddTicks(6293), 1200.0, 2 }
                });

            migrationBuilder.InsertData(
                table: "JewelryMaterials",
                columns: new[] { "JewelryMaterialId", "JewelryId", "MasterPriceId", "MaterialId", "Weight" },
                values: new object[,]
                {
                    { 1, 1, 2, 1, 300f },
                    { 2, 1, 2, 2, 400f },
                    { 3, 2, 2, 1, 500f },
                    { 4, 2, 2, 2, 500f }
                });

            migrationBuilder.InsertData(
                table: "Purchases",
                columns: new[] { "PurchaseId", "CustomerId", "IsBuyBack", "JewelryId", "PurchaseDate", "PurchasePrice", "UserId" },
                values: new object[,]
                {
                    { 1, 1, 0, 1, new DateTime(2024, 6, 7, 22, 15, 47, 340, DateTimeKind.Local).AddTicks(6418), 500.0, 1 },
                    { 2, 2, 1, 2, new DateTime(2024, 6, 7, 22, 15, 47, 340, DateTimeKind.Local).AddTicks(6420), 300.0, 1 },
                    { 3, 2, 0, 3, new DateTime(2024, 6, 7, 22, 15, 47, 340, DateTimeKind.Local).AddTicks(6422), 1000.0, 1 }
                });

            migrationBuilder.InsertData(
                table: "BillJewelries",
                columns: new[] { "BillJewelryId", "BillId", "JewelryId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 1, 2 },
                    { 3, 2, 3 }
                });

            migrationBuilder.InsertData(
                table: "BillPromotions",
                columns: new[] { "BillPromotionId", "BillId", "PromotionId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BillJewelries_BillId",
                table: "BillJewelries",
                column: "BillId");

            migrationBuilder.CreateIndex(
                name: "IX_BillJewelries_JewelryId",
                table: "BillJewelries",
                column: "JewelryId");

            migrationBuilder.CreateIndex(
                name: "IX_BillPromotions_BillId",
                table: "BillPromotions",
                column: "BillId");

            migrationBuilder.CreateIndex(
                name: "IX_BillPromotions_PromotionId",
                table: "BillPromotions",
                column: "PromotionId");

            migrationBuilder.CreateIndex(
                name: "IX_Bills_CustomerId",
                table: "Bills",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Bills_UserId",
                table: "Bills",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Jewelries_JewelryTypeId",
                table: "Jewelries",
                column: "JewelryTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_JewelryMaterials_JewelryId",
                table: "JewelryMaterials",
                column: "JewelryId");

            migrationBuilder.CreateIndex(
                name: "IX_JewelryMaterials_MasterPriceId",
                table: "JewelryMaterials",
                column: "MasterPriceId");

            migrationBuilder.CreateIndex(
                name: "IX_JewelryMaterials_MaterialId",
                table: "JewelryMaterials",
                column: "MaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_MasterPrices_GoldPriceId",
                table: "MasterPrices",
                column: "GoldPriceId");

            migrationBuilder.CreateIndex(
                name: "IX_MasterPrices_StonePriceId",
                table: "MasterPrices",
                column: "StonePriceId");

            migrationBuilder.CreateIndex(
                name: "IX_Purchases_CustomerId",
                table: "Purchases",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Purchases_JewelryId",
                table: "Purchases",
                column: "JewelryId");

            migrationBuilder.CreateIndex(
                name: "IX_Purchases_UserId",
                table: "Purchases",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_CounterId",
                table: "Users",
                column: "CounterId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Warranties_JewelryId",
                table: "Warranties",
                column: "JewelryId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BillJewelries");

            migrationBuilder.DropTable(
                name: "BillPromotions");

            migrationBuilder.DropTable(
                name: "JewelryMaterials");

            migrationBuilder.DropTable(
                name: "Purchases");

            migrationBuilder.DropTable(
                name: "Warranties");

            migrationBuilder.DropTable(
                name: "Bills");

            migrationBuilder.DropTable(
                name: "Promotions");

            migrationBuilder.DropTable(
                name: "MasterPrices");

            migrationBuilder.DropTable(
                name: "Materials");

            migrationBuilder.DropTable(
                name: "Jewelries");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "GoldPrices");

            migrationBuilder.DropTable(
                name: "StonePrices");

            migrationBuilder.DropTable(
                name: "JewelryTypes");

            migrationBuilder.DropTable(
                name: "Counters");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
