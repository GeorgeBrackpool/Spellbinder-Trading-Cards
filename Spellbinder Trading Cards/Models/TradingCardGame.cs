using System.ComponentModel.DataAnnotations;

namespace SpellbinderTradingCards.Models
{
    public class TradingCardGame
    {
        public int TradingCardGameId { get; set; }
        [MaxLength(100)]
        public required string Name { get; set; }
        public ICollection<Rarity> Rarities { get; set; } = new List<Rarity>();
        public ICollection<Set> Sets { get; set; } = new List<Set>();

    }
}
