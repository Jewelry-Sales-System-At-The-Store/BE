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
                    CustomerId = table.Column<string>(type: "varchar(20)", nullable: false),
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
                    GoldPriceId = table.Column<string>(type: "varchar(20)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BuyPrice = table.Column<float>(type: "real", nullable: false),
                    SellPrice = table.Column<float>(type: "real", nullable: false),
                    LastUpdated = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoldPrices", x => x.GoldPriceId);
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
                name: "StonePrices",
                columns: table => new
                {
                    StonePriceId = table.Column<string>(type: "varchar(20)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BuyPrice = table.Column<float>(type: "real", nullable: false),
                    SellPrice = table.Column<float>(type: "real", nullable: false),
                    LastUpdated = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StonePrices", x => x.StonePriceId);
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
                    UserId = table.Column<string>(type: "varchar(20)", nullable: false),
                    RoleId = table.Column<string>(type: "varchar(20)", nullable: true),
                    CounterId = table.Column<string>(type: "varchar(20)", nullable: true),
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
                    MasterPriceId = table.Column<string>(type: "varchar(20)", nullable: false),
                    StonePriceId = table.Column<string>(type: "varchar(20)", nullable: true),
                    GoldPriceId = table.Column<string>(type: "varchar(20)", nullable: true),
                    GoldStorePrice = table.Column<float>(type: "real", nullable: false),
                    StoneStorePrice = table.Column<float>(type: "real", nullable: false)
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
                name: "JewelryMaterials",
                columns: table => new
                {
                    JewelryMaterialId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    JewelryId = table.Column<string>(type: "varchar(20)", nullable: true),
                    GoldPriceId = table.Column<string>(type: "varchar(20)", nullable: true),
                    StonePriceId = table.Column<string>(type: "varchar(20)", nullable: true),
                    GoldQuantity = table.Column<float>(type: "real", nullable: false),
                    StoneQuantity = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JewelryMaterials", x => x.JewelryMaterialId);
                    table.ForeignKey(
                        name: "FK_JewelryMaterials_GoldPrices_GoldPriceId",
                        column: x => x.GoldPriceId,
                        principalTable: "GoldPrices",
                        principalColumn: "GoldPriceId");
                    table.ForeignKey(
                        name: "FK_JewelryMaterials_Jewelries_JewelryId",
                        column: x => x.JewelryId,
                        principalTable: "Jewelries",
                        principalColumn: "JewelryId");
                    table.ForeignKey(
                        name: "FK_JewelryMaterials_StonePrices_StonePriceId",
                        column: x => x.StonePriceId,
                        principalTable: "StonePrices",
                        principalColumn: "StonePriceId");
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
                    SaleDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
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
                    JewelryId = table.Column<string>(type: "varchar(20)", nullable: true)
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
                    PromotionId = table.Column<string>(type: "varchar(20)", nullable: true)
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
                    { "1", 1000f, "Ha Noi", new DateTimeOffset(new DateTime(2024, 6, 14, 18, 46, 39, 881, DateTimeKind.Unspecified).AddTicks(7662), new TimeSpan(0, 7, 0, 0, 0)), 1200f, "9999" },
                    { "2", 1200f, "Ha Noi", new DateTimeOffset(new DateTime(2024, 6, 14, 18, 46, 39, 881, DateTimeKind.Unspecified).AddTicks(7664), new TimeSpan(0, 7, 0, 0, 0)), 1400f, "SCJ" },
                    { "3", 1400f, "Ha Noi", new DateTimeOffset(new DateTime(2024, 6, 14, 18, 46, 39, 881, DateTimeKind.Unspecified).AddTicks(7666), new TimeSpan(0, 7, 0, 0, 0)), 1600f, "18k" }
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
                    { "1", null, "Giam gia 10%", 1.0, new DateTimeOffset(new DateTime(2024, 6, 24, 18, 46, 39, 881, DateTimeKind.Unspecified).AddTicks(7535), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 14, 18, 46, 39, 881, DateTimeKind.Unspecified).AddTicks(7507), new TimeSpan(0, 7, 0, 0, 0)), "Giam gia" },
                    { "2", null, "Giam gia 20%", 2.0, new DateTimeOffset(new DateTime(2024, 6, 24, 18, 46, 39, 881, DateTimeKind.Unspecified).AddTicks(7541), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 14, 18, 46, 39, 881, DateTimeKind.Unspecified).AddTicks(7540), new TimeSpan(0, 7, 0, 0, 0)), "Giam gia" },
                    { "3", null, "Giam gia 30%", 3.0, new DateTimeOffset(new DateTime(2024, 6, 24, 18, 46, 39, 881, DateTimeKind.Unspecified).AddTicks(7544), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 14, 18, 46, 39, 881, DateTimeKind.Unspecified).AddTicks(7543), new TimeSpan(0, 7, 0, 0, 0)), "Giam gia" }
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
                    { "1", 300f, "Ha Noi", new DateTimeOffset(new DateTime(2024, 6, 14, 18, 46, 39, 881, DateTimeKind.Unspecified).AddTicks(7637), new TimeSpan(0, 7, 0, 0, 0)), 400f, "Ruby" },
                    { "2", 400f, "Ha Noi", new DateTimeOffset(new DateTime(2024, 6, 14, 18, 46, 39, 881, DateTimeKind.Unspecified).AddTicks(7639), new TimeSpan(0, 7, 0, 0, 0)), 500f, "Sapphire" },
                    { "3", 500f, "Ha Noi", new DateTimeOffset(new DateTime(2024, 6, 14, 18, 46, 39, 881, DateTimeKind.Unspecified).AddTicks(7641), new TimeSpan(0, 7, 0, 0, 0)), 600f, "Emerald" }
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
                    { "1", null, "1", new DateTimeOffset(new DateTime(2024, 6, 14, 18, 46, 39, 881, DateTimeKind.Unspecified).AddTicks(7568), new TimeSpan(0, 7, 0, 0, 0)), 500.0, "1" },
                    { "2", null, "2", new DateTimeOffset(new DateTime(2024, 6, 14, 18, 46, 39, 881, DateTimeKind.Unspecified).AddTicks(7571), new TimeSpan(0, 7, 0, 0, 0)), 1200.0, "2" }
                });

            migrationBuilder.InsertData(
                table: "Purchases",
                columns: new[] { "PurchaseId", "CustomerId", "IsBuyBack", "JewelryId", "PurchaseDate", "PurchasePrice", "UserId" },
                values: new object[,]
                {
                    { "1", "1", 0, "1", new DateTimeOffset(new DateTime(2024, 6, 14, 18, 46, 39, 881, DateTimeKind.Unspecified).AddTicks(7686), new TimeSpan(0, 7, 0, 0, 0)), 500.0, "1" },
                    { "2", "2", 1, "2", new DateTimeOffset(new DateTime(2024, 6, 14, 18, 46, 39, 881, DateTimeKind.Unspecified).AddTicks(7688), new TimeSpan(0, 7, 0, 0, 0)), 300.0, "1" },
                    { "3", "2", 0, "3", new DateTimeOffset(new DateTime(2024, 6, 14, 18, 46, 39, 881, DateTimeKind.Unspecified).AddTicks(7690), new TimeSpan(0, 7, 0, 0, 0)), 1000.0, "1" }
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
                name: "MasterPrices");

            migrationBuilder.DropTable(
                name: "Purchases");

            migrationBuilder.DropTable(
                name: "Warranties");

            migrationBuilder.DropTable(
                name: "Bills");

            migrationBuilder.DropTable(
                name: "Promotions");

            migrationBuilder.DropTable(
                name: "GoldPrices");

            migrationBuilder.DropTable(
                name: "StonePrices");

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
