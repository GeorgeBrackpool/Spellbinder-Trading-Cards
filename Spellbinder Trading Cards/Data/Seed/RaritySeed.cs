using Microsoft.EntityFrameworkCore;
using SpellbinderTradingCards.Models;

namespace SpellbinderTradingCards.Data.Seed
{
    public class RaritySeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {

            // ID References for Game Rarities
            // 1, Name = "Pokemon", 2, Name = "Yu-Gi-Oh", 3, Name = "Magic: The Gathering", 4, Name = "Riftbound"
            modelBuilder.Entity<Rarity>().HasData(
                //Pokemon
                new Rarity { RarityId = 1, TradingCardGameId = 1, Name = "Common" },
                new Rarity { RarityId = 2, TradingCardGameId = 1, Name = "Uncommon" },
                new Rarity { RarityId = 3, TradingCardGameId = 1, Name = "Rare" },
                new Rarity { RarityId = 4, TradingCardGameId = 1, Name = "Promo" },
                new Rarity { RarityId = 5, TradingCardGameId = 1, Name = "Double Rare" },
                new Rarity { RarityId = 6, TradingCardGameId = 1, Name = "Ultra Rare" },
                new Rarity { RarityId = 7, TradingCardGameId = 1, Name = "Illustration Rare" },
                new Rarity { RarityId = 8, TradingCardGameId = 1, Name = "Special Illustration rare" },
                new Rarity { RarityId = 9, TradingCardGameId = 1, Name = "Hyper Rare" },
                new Rarity { RarityId = 10, TradingCardGameId = 1, Name = "Mega Hyper Rare" },
                new Rarity { RarityId = 11, TradingCardGameId = 1, Name = "Mega Attack Rare" },
                // Yu-Gi-Oh https://totalcards.net/blogs/yugioh/how-to-identify-yu-gi-oh-card-rarities
                new Rarity { RarityId = 12, TradingCardGameId = 2, Name = "Common"},
                new Rarity { RarityId = 13, TradingCardGameId = 2, Name = "Rare"},
                new Rarity { RarityId = 14, TradingCardGameId = 2, Name = "Super Rare" },
                new Rarity { RarityId = 15, TradingCardGameId = 2, Name = "Secret Rare" },
                new Rarity { RarityId = 16, TradingCardGameId = 2, Name = "Ultra Rare" },
                new Rarity { RarityId = 17, TradingCardGameId = 2, Name = "Ultimate Rare" },
                new Rarity { RarityId = 18, TradingCardGameId = 2, Name = "Ghost Rare" },
                new Rarity { RarityId = 19, TradingCardGameId = 2, Name = "Gold Rare" },
                new Rarity { RarityId = 20, TradingCardGameId = 2, Name = "Collector's Rare" },
                new Rarity { RarityId = 21, TradingCardGameId = 2, Name = "Starlight Rare" },
                new Rarity { RarityId = 22, TradingCardGameId = 2, Name = "Prismatic Secret Rare" },
                new Rarity { RarityId = 23, TradingCardGameId = 2, Name = "Platinum Secret Rare" },
                new Rarity { RarityId = 24, TradingCardGameId = 2, Name = "Quarter Century Secret Rare" },
                // Magic: The Gathering
                new Rarity { RarityId = 25, TradingCardGameId = 3, Name = "Common" },
                new Rarity { RarityId = 26, TradingCardGameId = 3, Name = "Uncommon" },
                new Rarity { RarityId = 27, TradingCardGameId = 3, Name = "Rare" },
                new Rarity { RarityId = 28, TradingCardGameId = 3, Name = "Mythic Rare" },
                // Riftbound
                new Rarity { RarityId = 29, TradingCardGameId = 4, Name = "Common" },
                new Rarity { RarityId = 30, TradingCardGameId = 4, Name = "Uncommon" },
                new Rarity { RarityId = 31, TradingCardGameId = 4, Name = "Rare" },
                new Rarity { RarityId = 32, TradingCardGameId = 4, Name = "Epic" },
                new Rarity { RarityId = 33, TradingCardGameId = 4, Name = "Overnumbered" },
                new Rarity { RarityId = 34, TradingCardGameId = 4, Name = "Alternate Art" }

                );
        }
    }
}
