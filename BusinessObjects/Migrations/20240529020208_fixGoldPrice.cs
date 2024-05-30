using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusinessObjects.Migrations
{
    /// <inheritdoc />
    public partial class fixGoldPrice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Counter",
                columns: table => new
                {
                    CounterId = table.Column<int>(type: "int", nullable: false),
                    Number = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Counter__F12879C45357F5DE", x => x.CounterId);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Point = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Customer__A4AE64D82688C284", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "GoldPrice",
                columns: table => new
                {
                    GoldPriceId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Karat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Purity = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BuyPrice = table.Column<long>(type: "bigint", nullable: false),
                    SellPrice = table.Column<long>(type: "bigint", nullable: false),
                    ConversionPrice = table.Column<long>(type: "bigint", nullable: false),
                    Timestamp = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__GoldPrice__C2C7860CE0CA1F4C", x => x.GoldPriceId);
                });

            migrationBuilder.CreateTable(
                name: "JewelryType",
                columns: table => new
                {
                    JewelryTypeId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__JewelryT__7DCE2416537E000D", x => x.JewelryTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Promotion",
                columns: table => new
                {
                    PromotionId = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ApproveManager = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DiscountRate = table.Column<double>(type: "float", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Promotio__52C42FCF36D3DAF7", x => x.PromotionId);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    RoleName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Role__8AFACE1AF3D3B665", x => x.RoleId);
                });

            migrationBuilder.CreateTable(
                name: "Warranty",
                columns: table => new
                {
                    WarrantyId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Warranty__2ED3181357729305", x => x.WarrantyId);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: true),
                    CounterId = table.Column<int>(type: "int", nullable: true),
                    Username = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Password = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__User__1788CC4C022F84D8", x => x.UserId);
                    table.ForeignKey(
                        name: "FK__User__CounterId__5812160E",
                        column: x => x.CounterId,
                        principalTable: "Counter",
                        principalColumn: "CounterId");
                    table.ForeignKey(
                        name: "FK__User__RoleId__571DF1D5",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "RoleId");
                });

            migrationBuilder.CreateTable(
                name: "Jewelry",
                columns: table => new
                {
                    JewelryId = table.Column<int>(type: "int", nullable: false),
                    JewelryTypeId = table.Column<int>(type: "int", nullable: true),
                    WarrantyId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Barcode = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    BasePrice = table.Column<double>(type: "float", nullable: true),
                    Weight = table.Column<double>(type: "float", nullable: true),
                    LaborCost = table.Column<double>(type: "float", nullable: true),
                    StoneCost = table.Column<double>(type: "float", nullable: true),
                    IsSold = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Jewelry__807031D595331C05", x => x.JewelryId);
                    table.ForeignKey(
                        name: "FK__Jewelry__Jewelry__4F7CD00D",
                        column: x => x.JewelryTypeId,
                        principalTable: "JewelryType",
                        principalColumn: "JewelryTypeId");
                    table.ForeignKey(
                        name: "FK__Jewelry__Warrant__4E88ABD4",
                        column: x => x.WarrantyId,
                        principalTable: "Warranty",
                        principalColumn: "WarrantyId");
                });

            migrationBuilder.CreateTable(
                name: "Bill",
                columns: table => new
                {
                    BillId = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    TotalAmount = table.Column<double>(type: "float", nullable: true),
                    SaleDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Bill__11F2FC6A0B5B397C", x => x.BillId);
                    table.ForeignKey(
                        name: "FK__Bill__CustomerId__59063A47",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "CustomerId");
                    table.ForeignKey(
                        name: "FK__Bill__UserId__59FA5E80",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "Purchase",
                columns: table => new
                {
                    PurchaseId = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    JewelryId = table.Column<int>(type: "int", nullable: true),
                    PurchaseDate = table.Column<DateOnly>(type: "date", nullable: true),
                    PurchasePrice = table.Column<double>(type: "float", nullable: true),
                    IsBuyBack = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Purchase__6B0A6BBEA5070B03", x => x.PurchaseId);
                    table.ForeignKey(
                        name: "FK__Purchase__Custom__5629CD9C",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "CustomerId");
                    table.ForeignKey(
                        name: "FK__Purchase__Jewelr__5441852A",
                        column: x => x.JewelryId,
                        principalTable: "Jewelry",
                        principalColumn: "JewelryId");
                    table.ForeignKey(
                        name: "FK__Purchase__UserId__5535A963",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "BillJewelry",
                columns: table => new
                {
                    BillJewelryId = table.Column<int>(type: "int", nullable: false),
                    BillId = table.Column<int>(type: "int", nullable: true),
                    JewelryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__BillJewe__22A11463AA7B6F89", x => x.BillJewelryId);
                    table.ForeignKey(
                        name: "FK__BillJewel__BillI__534D60F1",
                        column: x => x.BillId,
                        principalTable: "Bill",
                        principalColumn: "BillId");
                    table.ForeignKey(
                        name: "FK__BillJewel__Jewel__52593CB8",
                        column: x => x.JewelryId,
                        principalTable: "Jewelry",
                        principalColumn: "JewelryId");
                });

            migrationBuilder.CreateTable(
                name: "BillPromotion",
                columns: table => new
                {
                    BillPromotionId = table.Column<int>(type: "int", nullable: false),
                    BillId = table.Column<int>(type: "int", nullable: true),
                    PromotionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__BillProm__470D21BE61BB07A5", x => x.BillPromotionId);
                    table.ForeignKey(
                        name: "FK__BillPromo__BillI__5165187F",
                        column: x => x.BillId,
                        principalTable: "Bill",
                        principalColumn: "BillId");
                    table.ForeignKey(
                        name: "FK__BillPromo__Promo__5070F446",
                        column: x => x.PromotionId,
                        principalTable: "Promotion",
                        principalColumn: "PromotionId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bill_CustomerId",
                table: "Bill",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Bill_UserId",
                table: "Bill",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_BillJewelry_BillId",
                table: "BillJewelry",
                column: "BillId");

            migrationBuilder.CreateIndex(
                name: "IX_BillJewelry_JewelryId",
                table: "BillJewelry",
                column: "JewelryId");

            migrationBuilder.CreateIndex(
                name: "IX_BillPromotion_BillId",
                table: "BillPromotion",
                column: "BillId");

            migrationBuilder.CreateIndex(
                name: "IX_BillPromotion_PromotionId",
                table: "BillPromotion",
                column: "PromotionId");

            migrationBuilder.CreateIndex(
                name: "IX_Jewelry_JewelryTypeId",
                table: "Jewelry",
                column: "JewelryTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Jewelry_WarrantyId",
                table: "Jewelry",
                column: "WarrantyId");

            migrationBuilder.CreateIndex(
                name: "IX_Purchase_CustomerId",
                table: "Purchase",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Purchase_JewelryId",
                table: "Purchase",
                column: "JewelryId");

            migrationBuilder.CreateIndex(
                name: "IX_Purchase_UserId",
                table: "Purchase",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_User_CounterId",
                table: "User",
                column: "CounterId");

            migrationBuilder.CreateIndex(
                name: "IX_User_RoleId",
                table: "User",
                column: "RoleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BillJewelry");

            migrationBuilder.DropTable(
                name: "BillPromotion");

            migrationBuilder.DropTable(
                name: "GoldPrice");

            migrationBuilder.DropTable(
                name: "Purchase");

            migrationBuilder.DropTable(
                name: "Bill");

            migrationBuilder.DropTable(
                name: "Promotion");

            migrationBuilder.DropTable(
                name: "Jewelry");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "JewelryType");

            migrationBuilder.DropTable(
                name: "Warranty");

            migrationBuilder.DropTable(
                name: "Counter");

            migrationBuilder.DropTable(
                name: "Role");
        }
    }
}
