using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TaxCalculator.API.Migrations
{
    /// <inheritdoc />
    public partial class InitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TaxBands",
                columns: new[] { "Id", "BandName", "LowerLimit", "TaxRate", "UpperLimit" },
                values: new object[,]
                {
                    { new Guid("049ad191-2b58-4864-ab00-026a789163a0"), "TaxBandB", 5000, 20, 20000 },
                    { new Guid("13c9c3cd-ea43-447d-a563-9908837f86ba"), "TaxBandA", 0, 0, 5000 },
                    { new Guid("7c5e4143-a4ce-4c1c-aa8e-a727a01d7c68"), "TaxBandC", 20000, 40, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TaxBands",
                keyColumn: "Id",
                keyValue: new Guid("049ad191-2b58-4864-ab00-026a789163a0"));

            migrationBuilder.DeleteData(
                table: "TaxBands",
                keyColumn: "Id",
                keyValue: new Guid("13c9c3cd-ea43-447d-a563-9908837f86ba"));

            migrationBuilder.DeleteData(
                table: "TaxBands",
                keyColumn: "Id",
                keyValue: new Guid("7c5e4143-a4ce-4c1c-aa8e-a727a01d7c68"));
        }
    }
}
