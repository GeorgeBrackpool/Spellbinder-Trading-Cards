using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SpellbinderTradingCards.Migrations
{
    /// <inheritdoc />
    public partial class AddRaritySeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Rarities",
                columns: new[] { "RarityId", "Name", "TradingCardGameId" },
                values: new object[,]
                {
                    { 1, "Common", 1 },
                    { 2, "Uncommon", 1 },
                    { 3, "Rare", 1 },
                    { 4, "Promo", 1 },
                    { 5, "Double Rare", 1 },
                    { 6, "Ultra Rare", 1 },
                    { 7, "Illustration Rare", 1 },
                    { 8, "Special Illustration rare", 1 },
                    { 9, "Hyper Rare", 1 },
                    { 10, "Mega Hyper Rare", 1 },
                    { 11, "Mega Attack Rare", 1 },
                    { 12, "Common", 2 },
                    { 13, "Rare", 2 },
                    { 14, "Super Rare", 2 },
                    { 15, "Secret Rare", 2 },
                    { 16, "Ultra Rare", 2 },
                    { 17, "Ultimate Rare", 2 },
                    { 18, "Ghost Rare", 2 },
                    { 19, "Gold Rare", 2 },
                    { 20, "Collector's Rare", 2 },
                    { 21, "Starlight Rare", 2 },
                    { 22, "Prismatic Secret Rare", 2 },
                    { 23, "Platinum Secret Rare", 2 },
                    { 24, "Quarter Century Secret Rare", 2 },
                    { 25, "Common", 3 },
                    { 26, "Uncommon", 3 },
                    { 27, "Rare", 3 },
                    { 28, "Mythic Rare", 3 },
                    { 29, "Common", 4 },
                    { 30, "Uncommon", 4 },
                    { 31, "Rare", 4 },
                    { 32, "Epic", 4 },
                    { 33, "Overnumbered", 4 },
                    { 34, "Alternate Art", 4 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rarities",
                keyColumn: "RarityId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Rarities",
                keyColumn: "RarityId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Rarities",
                keyColumn: "RarityId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Rarities",
                keyColumn: "RarityId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Rarities",
                keyColumn: "RarityId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Rarities",
                keyColumn: "RarityId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Rarities",
                keyColumn: "RarityId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Rarities",
                keyColumn: "RarityId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Rarities",
                keyColumn: "RarityId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Rarities",
                keyColumn: "RarityId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Rarities",
                keyColumn: "RarityId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Rarities",
                keyColumn: "RarityId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Rarities",
                keyColumn: "RarityId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Rarities",
                keyColumn: "RarityId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Rarities",
                keyColumn: "RarityId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Rarities",
                keyColumn: "RarityId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Rarities",
                keyColumn: "RarityId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Rarities",
                keyColumn: "RarityId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Rarities",
                keyColumn: "RarityId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Rarities",
                keyColumn: "RarityId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Rarities",
                keyColumn: "RarityId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Rarities",
                keyColumn: "RarityId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Rarities",
                keyColumn: "RarityId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Rarities",
                keyColumn: "RarityId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Rarities",
                keyColumn: "RarityId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Rarities",
                keyColumn: "RarityId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Rarities",
                keyColumn: "RarityId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Rarities",
                keyColumn: "RarityId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Rarities",
                keyColumn: "RarityId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Rarities",
                keyColumn: "RarityId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Rarities",
                keyColumn: "RarityId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Rarities",
                keyColumn: "RarityId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Rarities",
                keyColumn: "RarityId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Rarities",
                keyColumn: "RarityId",
                keyValue: 34);
        }
    }
}
