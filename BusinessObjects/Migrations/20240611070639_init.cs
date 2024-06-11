using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

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
                    CounterId = table.Column<string>(type: "NVARCHAR(20)", nullable: false),
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
                    CustomerId = table.Column<string>(type: "NVARCHAR(20)", nullable: false),
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
                    GoldPriceId = table.Column<string>(type: "NVARCHAR(20)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BuyPrice = table.Column<float>(type: "real", nullable: false),
                    SellPrice = table.Column<float>(type: "real", nullable: false),
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
                    JewelryTypeId = table.Column<string>(type: "NVARCHAR(20)", nullable: false),
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
                    PromotionId = table.Column<string>(type: "NVARCHAR(20)", nullable: false),
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
                    RoleId = table.Column<string>(type: "NVARCHAR(20)", nullable: false),
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
                    StonePriceId = table.Column<string>(type: "NVARCHAR(20)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BuyPrice = table.Column<float>(type: "real", nullable: false),
                    SellPrice = table.Column<float>(type: "real", nullable: false),
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
                    JewelryId = table.Column<string>(type: "NVARCHAR(20)", nullable: false),
                    JewelryTypeId = table.Column<string>(type: "NVARCHAR(20)", nullable: true),
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
                    UserId = table.Column<string>(type: "NVARCHAR(20)", nullable: false),
                    RoleId = table.Column<string>(type: "NVARCHAR(20)", nullable: true),
                    CounterId = table.Column<string>(type: "NVARCHAR(20)", nullable: true),
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
                    MasterPriceId = table.Column<string>(type: "NVARCHAR(20)", nullable: false),
                    StonePriceId = table.Column<string>(type: "NVARCHAR(20)", nullable: true),
                    GoldPriceId = table.Column<string>(type: "NVARCHAR(20)", nullable: true),
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
                    JewelryId = table.Column<string>(type: "NVARCHAR(20)", nullable: true),
                    GoldPriceId = table.Column<string>(type: "NVARCHAR(20)", nullable: true),
                    StonePriceId = table.Column<string>(type: "NVARCHAR(20)", nullable: true),
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
                    WarrantyId = table.Column<string>(type: "NVARCHAR(20)", nullable: false),
                    JewelryId = table.Column<string>(type: "NVARCHAR(20)", nullable: true),
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
                    BillId = table.Column<string>(type: "NVARCHAR(20)", nullable: false),
                    CustomerId = table.Column<string>(type: "NVARCHAR(20)", nullable: true),
                    UserId = table.Column<string>(type: "NVARCHAR(20)", nullable: true),
                    CounterId = table.Column<string>(type: "NVARCHAR(20)", nullable: true),
                    TotalAmount = table.Column<double>(type: "float", nullable: true),
                    SaleDate = table.Column<DateTime>(type: "datetime2", nullable: true)
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
                    PurchaseId = table.Column<string>(type: "NVARCHAR(20)", nullable: false),
                    CustomerId = table.Column<string>(type: "NVARCHAR(20)", nullable: true),
                    UserId = table.Column<string>(type: "NVARCHAR(20)", nullable: true),
                    JewelryId = table.Column<string>(type: "NVARCHAR(20)", nullable: true),
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
                name: "BillJewelries",
                columns: table => new
                {
                    BillJewelryId = table.Column<string>(type: "NVARCHAR(20)", nullable: false),
                    BillId = table.Column<string>(type: "NVARCHAR(20)", nullable: true),
                    JewelryId = table.Column<string>(type: "NVARCHAR(20)", nullable: true)
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
                    BillPromotionId = table.Column<string>(type: "NVARCHAR(20)", nullable: false),
                    BillId = table.Column<string>(type: "NVARCHAR(20)", nullable: true),
                    PromotionId = table.Column<string>(type: "NVARCHAR(20)", nullable: true)
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
