using System.ComponentModel.DataAnnotations;

namespace SpellbinderTradingCards.Models
{
    public class Rarity
    {
        public int RarityId { get; set; }
        [MaxLength(450)]
        public required string Name { get; set; }
        public ICollection<Card> cards { get; set; } = new List<Card>();
    }
}
