using System.ComponentModel.DataAnnotations;

namespace SpellbinderTradingCards.Models
{
    public class Set
    {
        public int SetId { get; set; }
        [MaxLength(450)]
        public required string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int TradingCardGameId { get; set;  }
        public TradingCardGame? TradingCardGame { get; set; }
        
    }
}
