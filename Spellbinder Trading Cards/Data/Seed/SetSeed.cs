using Microsoft.EntityFrameworkCore;
using SpellbinderTradingCards.Models;

namespace SpellbinderTradingCards.Data.Seed
{
    public class SetSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Set>().HasData(
            // Pokemon   
            new Set { SetId = 1, Name = "Scarlet & Violet", TradingCardGameId = 1, ReleaseDate = new DateTime(2023, 3, 31) },
            new Set { SetId = 2, Name = "Paldea Evolved", TradingCardGameId = 1, ReleaseDate = new DateTime(2023, 6, 9) },
            new Set { SetId = 3, Name = "Obsidian Flames", TradingCardGameId = 1, ReleaseDate = new DateTime(2023, 8, 11) },
            new Set { SetId = 4, Name = "151", TradingCardGameId = 1, ReleaseDate = new DateTime(2023, 9, 22) },
            new Set { SetId = 5, Name = "Temporal Forces", TradingCardGameId = 1, ReleaseDate = new DateTime(2024, 3, 22) },
            new Set { SetId = 6, Name = "Twilight Masquerade", TradingCardGameId = 1, ReleaseDate = new DateTime(2024, 5, 24) },
            new Set { SetId = 7, Name = "Surging Sparks", TradingCardGameId = 1, ReleaseDate = new DateTime(2024, 11, 8) },
            // Yu-Gi-Oh
            new Set { SetId = 8, Name = "Phantom Darkness", TradingCardGameId = 2, ReleaseDate = new DateTime(2008, 2, 13) },
            new Set { SetId = 9, Name = "Duelist Alliance", TradingCardGameId = 2, ReleaseDate = new DateTime(2014, 8, 15) },
            new Set { SetId = 10, Name = "Maximum Gold", TradingCardGameId = 2, ReleaseDate = new DateTime(2020, 11, 13) },
            new Set { SetId = 11, Name = "Battles of Legend: Crystal Revenge", TradingCardGameId = 2, ReleaseDate = new DateTime(2022, 11, 18) },
            new Set { SetId = 12, Name = "25th Anniversary Rarity Collection", TradingCardGameId = 2, ReleaseDate = new DateTime(2023, 11, 3) },
            new Set { SetId = 13, Name = "Legacy of Destruction", TradingCardGameId = 2, ReleaseDate = new DateTime(2024, 4, 26) },
            new Set { SetId = 14, Name = "Supreme Darkness", TradingCardGameId = 2, ReleaseDate = new DateTime(2025, 1, 24) },
            // Magic: The Gathering
            new Set { SetId = 15, Name = "Modern Horizons", TradingCardGameId = 3, ReleaseDate = new DateTime(2019, 6, 14) },
            new Set { SetId = 16, Name = "The Brothers' War", TradingCardGameId = 3, ReleaseDate = new DateTime(2022, 11, 18) },
            new Set { SetId = 17, Name = "Wilds of Eldraine", TradingCardGameId = 3, ReleaseDate = new DateTime(2023, 9, 8) },
            new Set { SetId = 18, Name = "Murders at Karlov Manor", TradingCardGameId = 3, ReleaseDate = new DateTime(2024, 2, 9) },
            new Set { SetId = 19, Name = "Bloomburrow", TradingCardGameId = 3, ReleaseDate = new DateTime(2024, 8, 2) },
            new Set { SetId = 20, Name = "Duskmourn: House of Horror", TradingCardGameId = 3, ReleaseDate = new DateTime(2024, 9, 27) },
            new Set { SetId = 21, Name = "Foundations", TradingCardGameId = 3, ReleaseDate = new DateTime(2024, 11, 15) },
            //Riftbound
            new Set { SetId = 22, Name = "Origins", TradingCardGameId = 4, ReleaseDate = new DateTime(2025, 10, 31) },
            new Set { SetId = 23, Name = "Spiritforged", TradingCardGameId = 4, ReleaseDate = new DateTime(2026, 2, 13) },
            new Set { SetId = 24, Name = "Unleashed", TradingCardGameId = 4, ReleaseDate = new DateTime(2026, 5, 8) }
                );
        }
    }
}
