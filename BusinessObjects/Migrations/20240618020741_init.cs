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
                    CounterId = table.Column<string>(type: "varchar(20)", nullable: false),
                    Number = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Counters", x => x.CounterId);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<string>(type: "varchar(20)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Point = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "Gems",
                columns: table => new
                {
                    GemId = table.Column<string>(type: "varchar(20)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BuyPrice = table.Column<float>(type: "real", nullable: false),
                    SellPrice = table.Column<float>(type: "real", nullable: false),
                    LastUpdated = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gems", x => x.GemId);
                });

            migrationBuilder.CreateTable(
                name: "Golds",
                columns: table => new
                {
                    GoldId = table.Column<string>(type: "varchar(20)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BuyPrice = table.Column<float>(type: "real", nullable: false),
                    SellPrice = table.Column<float>(type: "real", nullable: false),
                    LastUpdated = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Golds", x => x.GoldId);
                });

            migrationBuilder.CreateTable(
                name: "JewelryTypes",
                columns: table => new
                {
                    JewelryTypeId = table.Column<string>(type: "varchar(20)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JewelryTypes", x => x.JewelryTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Promotions",
                columns: table => new
                {
                    PromotionId = table.Column<string>(type: "varchar(20)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApproveManager = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiscountRate = table.Column<double>(type: "float", nullable: true),
                    StartDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    EndDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Promotions", x => x.PromotionId);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    RoleId = table.Column<string>(type: "varchar(20)", nullable: false),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.RoleId);
                });

            migrationBuilder.CreateTable(
                name: "Jewelries",
                columns: table => new
                {
                    JewelryId = table.Column<string>(type: "varchar(20)", nullable: false),
                    JewelryTypeId = table.Column<string>(type: "varchar(20)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Barcode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LaborCost = table.Column<double>(type: "float", nullable: true),
                    IsSold = table.Column<bool>(type: "bit", nullable: true),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
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
                    UserId = table.Column<string>(type: "varchar(20)", nullable: false),
                    RoleId = table.Column<string>(type: "varchar(20)", nullable: true),
                    CounterId = table.Column<string>(type: "varchar(20)", nullable: true),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
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
                name: "JewelryMaterials",
                columns: table => new
                {
                    JewelryMaterialId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    JewelryId = table.Column<string>(type: "varchar(20)", nullable: true),
                    GoldPriceId = table.Column<string>(type: "varchar(20)", nullable: true),
                    StonePriceId = table.Column<string>(type: "varchar(20)", nullable: true),
                    GoldQuantity = table.Column<float>(type: "real", nullable: false),
                    StoneQuantity = table.Column<float>(type: "real", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JewelryMaterials", x => x.JewelryMaterialId);
                    table.ForeignKey(
                        name: "FK_JewelryMaterials_Gems_StonePriceId",
                        column: x => x.StonePriceId,
                        principalTable: "Gems",
                        principalColumn: "GemId");
                    table.ForeignKey(
                        name: "FK_JewelryMaterials_Golds_GoldPriceId",
                        column: x => x.GoldPriceId,
                        principalTable: "Golds",
                        principalColumn: "GoldId");
                    table.ForeignKey(
                        name: "FK_JewelryMaterials_Jewelries_JewelryId",
                        column: x => x.JewelryId,
                        principalTable: "Jewelries",
                        principalColumn: "JewelryId");
                });

            migrationBuilder.CreateTable(
                name: "Warranties",
                columns: table => new
                {
                    WarrantyId = table.Column<string>(type: "varchar(20)", nullable: false),
                    JewelryId = table.Column<string>(type: "varchar(20)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EndDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
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
                    BillId = table.Column<string>(type: "varchar(20)", nullable: false),
                    CustomerId = table.Column<string>(type: "varchar(20)", nullable: true),
                    UserId = table.Column<string>(type: "varchar(20)", nullable: true),
                    CounterId = table.Column<string>(type: "varchar(20)", nullable: true),
                    TotalAmount = table.Column<double>(type: "float", nullable: true),
                    SaleDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bills", x => x.BillId);
                    table.ForeignKey(
                        name: "FK_Bills_Counters_CounterId",
                        column: x => x.CounterId,
                        principalTable: "Counters",
                        principalColumn: "CounterId");
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
                    PurchaseId = table.Column<string>(type: "varchar(20)", nullable: false),
                    CustomerId = table.Column<string>(type: "varchar(20)", nullable: true),
                    UserId = table.Column<string>(type: "varchar(20)", nullable: true),
                    JewelryId = table.Column<string>(type: "varchar(20)", nullable: true),
                    PurchaseDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
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
                name: "BillJewelries",
                columns: table => new
                {
                    BillJewelryId = table.Column<string>(type: "varchar(20)", nullable: false),
                    BillId = table.Column<string>(type: "varchar(20)", nullable: true),
                    JewelryId = table.Column<string>(type: "varchar(20)", nullable: true),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
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
                    BillPromotionId = table.Column<string>(type: "varchar(20)", nullable: false),
                    BillId = table.Column<string>(type: "varchar(20)", nullable: true),
                    PromotionId = table.Column<string>(type: "varchar(20)", nullable: true),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
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
                columns: new[] { "CounterId", "CreatedAt", "Number", "UpdatedAt" },
                values: new object[,]
                {
                    { "1", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 312, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { "2", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 231, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { "3", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 431, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Address", "CreatedAt", "Name", "Phone", "Point", "UpdatedAt" },
                values: new object[,]
                {
                    { "1", "Ha Noi", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Nguyen Van A", "0123456789", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { "2", "Ha Noi", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Nguyen Van B", "0123456789", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { "3", "Ha Noi", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Nguyen Van C", "0123456789", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "Gems",
                columns: new[] { "GemId", "BuyPrice", "City", "LastUpdated", "SellPrice", "Type" },
                values: new object[,]
                {
                    { "1", 300f, "Ha Noi", new DateTimeOffset(new DateTime(2024, 6, 18, 9, 7, 40, 396, DateTimeKind.Unspecified).AddTicks(2757), new TimeSpan(0, 7, 0, 0, 0)), 400f, "Ruby" },
                    { "2", 400f, "Ha Noi", new DateTimeOffset(new DateTime(2024, 6, 18, 9, 7, 40, 396, DateTimeKind.Unspecified).AddTicks(2761), new TimeSpan(0, 7, 0, 0, 0)), 500f, "Sapphire" },
                    { "3", 500f, "Ha Noi", new DateTimeOffset(new DateTime(2024, 6, 18, 9, 7, 40, 396, DateTimeKind.Unspecified).AddTicks(2763), new TimeSpan(0, 7, 0, 0, 0)), 600f, "Emerald" }
                });

            migrationBuilder.InsertData(
                table: "Golds",
                columns: new[] { "GoldId", "BuyPrice", "City", "LastUpdated", "SellPrice", "Type" },
                values: new object[,]
                {
                    { "1", 1000f, "Ha Noi", new DateTimeOffset(new DateTime(2024, 6, 18, 9, 7, 40, 396, DateTimeKind.Unspecified).AddTicks(2797), new TimeSpan(0, 7, 0, 0, 0)), 1200f, "9999" },
                    { "2", 1200f, "Ha Noi", new DateTimeOffset(new DateTime(2024, 6, 18, 9, 7, 40, 396, DateTimeKind.Unspecified).AddTicks(2801), new TimeSpan(0, 7, 0, 0, 0)), 1400f, "SCJ" },
                    { "3", 1400f, "Ha Noi", new DateTimeOffset(new DateTime(2024, 6, 18, 9, 7, 40, 396, DateTimeKind.Unspecified).AddTicks(2804), new TimeSpan(0, 7, 0, 0, 0)), 1600f, "18k" }
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
                    { "1", null, "Giam gia 10%", 1.0, new DateTimeOffset(new DateTime(2024, 6, 28, 9, 7, 40, 396, DateTimeKind.Unspecified).AddTicks(2613), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 18, 9, 7, 40, 396, DateTimeKind.Unspecified).AddTicks(2579), new TimeSpan(0, 7, 0, 0, 0)), "Giam gia" },
                    { "2", null, "Giam gia 20%", 2.0, new DateTimeOffset(new DateTime(2024, 6, 28, 9, 7, 40, 396, DateTimeKind.Unspecified).AddTicks(2621), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 18, 9, 7, 40, 396, DateTimeKind.Unspecified).AddTicks(2619), new TimeSpan(0, 7, 0, 0, 0)), "Giam gia" },
                    { "3", null, "Giam gia 30%", 3.0, new DateTimeOffset(new DateTime(2024, 6, 28, 9, 7, 40, 396, DateTimeKind.Unspecified).AddTicks(2626), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 18, 9, 7, 40, 396, DateTimeKind.Unspecified).AddTicks(2624), new TimeSpan(0, 7, 0, 0, 0)), "Giam gia" }
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
                table: "Jewelries",
                columns: new[] { "JewelryId", "Barcode", "CreatedAt", "IsSold", "JewelryTypeId", "LaborCost", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { "1", "AVC131", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), true, "1", 312.0, "Vong tay", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { "2", "SAC132", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, "2", 231.0, "Nhan", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "CounterId", "CreatedAt", "Email", "FullName", "Gender", "Password", "PhoneNumber", "RoleId", "Status", "UpdatedAt", "Username" },
                values: new object[,]
                {
                    { "1", "1", null, "nghialoe46a2gmail.com", null, null, "5678", null, "1", false, null, "admin Nghia" },
                    { "2", "2", null, "JohnDoe@gmail.com", null, null, "1234", null, "2", false, null, "manager John Doe" },
                    { "3", "3", null, "Chis@yahho.com", null, null, "4321", null, "3", false, null, "staff Chis Nguyen" }
                });

            migrationBuilder.InsertData(
                table: "Bills",
                columns: new[] { "BillId", "CounterId", "CreatedAt", "CustomerId", "SaleDate", "TotalAmount", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { "1", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "1", new DateTimeOffset(new DateTime(2024, 6, 18, 9, 7, 40, 396, DateTimeKind.Unspecified).AddTicks(2659), new TimeSpan(0, 7, 0, 0, 0)), 500.0, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "1" },
                    { "2", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "2", new DateTimeOffset(new DateTime(2024, 6, 18, 9, 7, 40, 396, DateTimeKind.Unspecified).AddTicks(2663), new TimeSpan(0, 7, 0, 0, 0)), 1200.0, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "2" }
                });

            migrationBuilder.InsertData(
                table: "JewelryMaterials",
                columns: new[] { "JewelryMaterialId", "CreatedAt", "GoldPriceId", "GoldQuantity", "JewelryId", "StonePriceId", "StoneQuantity", "UpdatedAt" },
                values: new object[,]
                {
                    { "1", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "1", 30f, "1", "1", 1f, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { "2", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "2", 20f, "2", "2", 1f, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "Purchases",
                columns: new[] { "PurchaseId", "CustomerId", "IsBuyBack", "JewelryId", "PurchaseDate", "PurchasePrice", "UserId" },
                values: new object[,]
                {
                    { "1", "1", 0, "1", new DateTimeOffset(new DateTime(2024, 6, 18, 9, 7, 40, 396, DateTimeKind.Unspecified).AddTicks(2837), new TimeSpan(0, 7, 0, 0, 0)), 500.0, "1" },
                    { "2", "2", 1, "2", new DateTimeOffset(new DateTime(2024, 6, 18, 9, 7, 40, 396, DateTimeKind.Unspecified).AddTicks(2840), new TimeSpan(0, 7, 0, 0, 0)), 300.0, "1" }
                });

            migrationBuilder.InsertData(
                table: "BillJewelries",
                columns: new[] { "BillJewelryId", "BillId", "CreatedAt", "JewelryId", "UpdatedAt" },
                values: new object[,]
                {
                    { "1", "1", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "1", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { "2", "1", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "2", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "BillPromotions",
                columns: new[] { "BillPromotionId", "BillId", "CreatedAt", "PromotionId", "UpdatedAt" },
                values: new object[,]
                {
                    { "1", "1", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "1", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { "2", "2", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "1", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) }
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
                name: "IX_Bills_CounterId",
                table: "Bills",
                column: "CounterId");

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
                name: "IX_JewelryMaterials_GoldPriceId",
                table: "JewelryMaterials",
                column: "GoldPriceId");

            migrationBuilder.CreateIndex(
                name: "IX_JewelryMaterials_JewelryId",
                table: "JewelryMaterials",
                column: "JewelryId");

            migrationBuilder.CreateIndex(
                name: "IX_JewelryMaterials_StonePriceId",
                table: "JewelryMaterials",
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
                unique: true,
                filter: "[JewelryId] IS NOT NULL");
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
                name: "Gems");

            migrationBuilder.DropTable(
                name: "Golds");

            migrationBuilder.DropTable(
                name: "Jewelries");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "JewelryTypes");

            migrationBuilder.DropTable(
                name: "Counters");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
