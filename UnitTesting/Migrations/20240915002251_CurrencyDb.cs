using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UnitTesting.Migrations
{
    /// <inheritdoc />
    public partial class CurrencyDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Currency",
                table: "CurrencyConversions");

            migrationBuilder.RenameColumn(
                name: "ConvertedAmount",
                table: "CurrencyConversions",
                newName: "UsdAmount");

            migrationBuilder.AddColumn<decimal>(
                name: "EuroAmount",
                table: "CurrencyConversions",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "GbpAmount",
                table: "CurrencyConversions",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "JpyAmount",
                table: "CurrencyConversions",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<DateTime>(
                name: "Timestamp",
                table: "CurrencyConversions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EuroAmount",
                table: "CurrencyConversions");

            migrationBuilder.DropColumn(
                name: "GbpAmount",
                table: "CurrencyConversions");

            migrationBuilder.DropColumn(
                name: "JpyAmount",
                table: "CurrencyConversions");

            migrationBuilder.DropColumn(
                name: "Timestamp",
                table: "CurrencyConversions");

            migrationBuilder.RenameColumn(
                name: "UsdAmount",
                table: "CurrencyConversions",
                newName: "ConvertedAmount");

            migrationBuilder.AddColumn<string>(
                name: "Currency",
                table: "CurrencyConversions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
