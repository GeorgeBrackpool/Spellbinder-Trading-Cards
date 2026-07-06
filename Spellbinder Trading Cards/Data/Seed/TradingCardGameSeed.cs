using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SpellbinderTradingCards.Models;

namespace SpellbinderTradingCards.Data.Seed
{
    public class TradingCardGameSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TradingCardGame>().HasData(
            new TradingCardGame { TradingCardGameId = 1, Name = "Pokemon" },
            new TradingCardGame { TradingCardGameId = 2, Name = "Yu-Gi-Oh" },
            new TradingCardGame { TradingCardGameId = 3, Name = "Magic: The Gathering" },
            new TradingCardGame { TradingCardGameId = 4, Name = "Riftbound" }
            );
        }
       
    }
}
