using System.ComponentModel.DataAnnotations;

namespace SpellbinderTradingCards.Models
{
    public class Set
    {
        public int SetId { get; set; }
        [MaxLength(450)]
        public required string Name { get; set; }
        public ICollection<Card> cards { get; set; } = new List<Card>();
    }
}
