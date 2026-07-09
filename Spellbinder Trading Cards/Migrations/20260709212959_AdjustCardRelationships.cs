using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SpellbinderTradingCards.Migrations
{
    /// <inheritdoc />
    public partial class AdjustCardRelationships : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cards_TradingCardGames_TradingCardGameId",
                table: "Cards");

            migrationBuilder.DropIndex(
                name: "IX_Cards_TradingCardGameId",
                table: "Cards");

            migrationBuilder.DropColumn(
                name: "TradingCardGameId",
                table: "Cards");

            migrationBuilder.AddColumn<int>(
                name: "TradingCardGameId",
                table: "Sets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Sets_TradingCardGameId",
                table: "Sets",
                column: "TradingCardGameId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sets_TradingCardGames_TradingCardGameId",
                table: "Sets",
                column: "TradingCardGameId",
                principalTable: "TradingCardGames",
                principalColumn: "TradingCardGameId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sets_TradingCardGames_TradingCardGameId",
                table: "Sets");

            migrationBuilder.DropIndex(
                name: "IX_Sets_TradingCardGameId",
                table: "Sets");

            migrationBuilder.DropColumn(
                name: "TradingCardGameId",
                table: "Sets");

            migrationBuilder.AddColumn<int>(
                name: "TradingCardGameId",
                table: "Cards",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Cards_TradingCardGameId",
                table: "Cards",
                column: "TradingCardGameId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_TradingCardGames_TradingCardGameId",
                table: "Cards",
                column: "TradingCardGameId",
                principalTable: "TradingCardGames",
                principalColumn: "TradingCardGameId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
