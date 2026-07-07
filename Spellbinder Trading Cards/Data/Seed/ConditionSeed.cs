using Microsoft.EntityFrameworkCore;
using SpellbinderTradingCards.Models;

namespace SpellbinderTradingCards.Data.Seed
{
    public class ConditionSeed
    {
        public static void Seed(ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<Condition>().HasData(
                new Condition { ConditionId = 1, Name = "Mint" },
                new Condition { ConditionId = 2, Name = "Near Mint" },
                new Condition { ConditionId = 3, Name = "Slightly Played" },
                new Condition { ConditionId = 4, Name = "Moderately Played" },
                new Condition { ConditionId = 5, Name = "Heavily Played" },
                new Condition { ConditionId = 6, Name = "Damaged" }
                );
        }
    }
}
