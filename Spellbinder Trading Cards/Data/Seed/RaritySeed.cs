using Microsoft.EntityFrameworkCore;
using SpellbinderTradingCards.Models;

namespace SpellbinderTradingCards.Data.Seed
{
    public class RaritySeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {

            //ID References for Game Rarities
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
                new Rarity { RarityId = 12, TradingCardGameId = 2, Name = "Common"}
                );
        }
    }
}
