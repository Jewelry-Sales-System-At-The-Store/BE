using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusinessObjects.Migrations
{
    /// <inheritdoc />
    public partial class fixGoldpricetable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ConversionPrice",
                table: "GoldPrice");

            migrationBuilder.DropColumn(
                name: "Purity",
                table: "GoldPrice");

            migrationBuilder.RenameColumn(
                name: "UpdateTime",
                table: "GoldPrice",
                newName: "LastUpdated");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "GoldPrice",
                newName: "Type");

            migrationBuilder.RenameColumn(
                name: "Karat",
                table: "GoldPrice",
                newName: "City");

            migrationBuilder.RenameColumn(
                name: "GoldPriceId",
                table: "GoldPrice",
                newName: "Id");

            migrationBuilder.AlterColumn<decimal>(
                name: "SellPrice",
                table: "GoldPrice",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<decimal>(
                name: "BuyPrice",
                table: "GoldPrice",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Type",
                table: "GoldPrice",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "LastUpdated",
                table: "GoldPrice",
                newName: "UpdateTime");

            migrationBuilder.RenameColumn(
                name: "City",
                table: "GoldPrice",
                newName: "Karat");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "GoldPrice",
                newName: "GoldPriceId");

            migrationBuilder.AlterColumn<long>(
                name: "SellPrice",
                table: "GoldPrice",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<long>(
                name: "BuyPrice",
                table: "GoldPrice",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AddColumn<long>(
                name: "ConversionPrice",
                table: "GoldPrice",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<decimal>(
                name: "Purity",
                table: "GoldPrice",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
