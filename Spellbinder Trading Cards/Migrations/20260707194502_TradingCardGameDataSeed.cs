using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SpellbinderTradingCards.Migrations
{
    /// <inheritdoc />
    public partial class TradingCardGameDataSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TradingCardGames",
                columns: new[] { "TradingCardGameId", "Name" },
                values: new object[,]
                {
                    { 1, "Pokemon" },
                    { 2, "Yu-Gi-Oh" },
                    { 3, "Magic: The Gathering" },
                    { 4, "Riftbound" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TradingCardGames",
                keyColumn: "TradingCardGameId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TradingCardGames",
                keyColumn: "TradingCardGameId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TradingCardGames",
                keyColumn: "TradingCardGameId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TradingCardGames",
                keyColumn: "TradingCardGameId",
                keyValue: 4);
        }
    }
}
