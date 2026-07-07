using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SpellbinderTradingCards.Migrations
{
    /// <inheritdoc />
    public partial class AddConditionSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Conditions",
                columns: new[] { "ConditionId", "Name" },
                values: new object[,]
                {
                    { 1, "Mint" },
                    { 2, "Near Mint" },
                    { 3, "Slightly Played" },
                    { 4, "Moderately Played" },
                    { 5, "Heavily Played" },
                    { 6, "Damaged" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "ConditionId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "ConditionId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "ConditionId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "ConditionId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "ConditionId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "ConditionId",
                keyValue: 6);
        }
    }
}
