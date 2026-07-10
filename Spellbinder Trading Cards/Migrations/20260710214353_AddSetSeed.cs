using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SpellbinderTradingCards.Migrations
{
    /// <inheritdoc />
    public partial class AddSetSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Sets",
                columns: new[] { "SetId", "Name", "ReleaseDate", "TradingCardGameId" },
                values: new object[,]
                {
                    { 1, "Scarlet & Violet", new DateTime(2023, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 2, "Paldea Evolved", new DateTime(2023, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 3, "Obsidian Flames", new DateTime(2023, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 4, "151", new DateTime(2023, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 5, "Temporal Forces", new DateTime(2024, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 6, "Twilight Masquerade", new DateTime(2024, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 7, "Surging Sparks", new DateTime(2024, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 8, "Phantom Darkness", new DateTime(2008, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 9, "Duelist Alliance", new DateTime(2014, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10, "Maximum Gold", new DateTime(2020, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 11, "Battles of Legend: Crystal Revenge", new DateTime(2022, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 12, "25th Anniversary Rarity Collection", new DateTime(2023, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 13, "Legacy of Destruction", new DateTime(2024, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 14, "Supreme Darkness", new DateTime(2025, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 15, "Modern Horizons", new DateTime(2019, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 16, "The Brothers' War", new DateTime(2022, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 17, "Wilds of Eldraine", new DateTime(2023, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 18, "Murders at Karlov Manor", new DateTime(2024, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 19, "Bloomburrow", new DateTime(2024, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 20, "Duskmourn: House of Horror", new DateTime(2024, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 21, "Foundations", new DateTime(2024, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 22, "Origins", new DateTime(2025, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 23, "Spiritforged", new DateTime(2026, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 24, "Unleashed", new DateTime(2026, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Sets",
                keyColumn: "SetId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Sets",
                keyColumn: "SetId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Sets",
                keyColumn: "SetId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Sets",
                keyColumn: "SetId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Sets",
                keyColumn: "SetId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Sets",
                keyColumn: "SetId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Sets",
                keyColumn: "SetId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Sets",
                keyColumn: "SetId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Sets",
                keyColumn: "SetId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Sets",
                keyColumn: "SetId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Sets",
                keyColumn: "SetId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Sets",
                keyColumn: "SetId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Sets",
                keyColumn: "SetId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Sets",
                keyColumn: "SetId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Sets",
                keyColumn: "SetId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Sets",
                keyColumn: "SetId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Sets",
                keyColumn: "SetId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Sets",
                keyColumn: "SetId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Sets",
                keyColumn: "SetId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Sets",
                keyColumn: "SetId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Sets",
                keyColumn: "SetId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Sets",
                keyColumn: "SetId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Sets",
                keyColumn: "SetId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Sets",
                keyColumn: "SetId",
                keyValue: 24);
        }
    }
}
