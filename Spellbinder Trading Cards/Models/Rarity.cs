namespace SpellbinderTradingCards.Models
{
    public class Rarity
    {
        public int RarityId { get; set; }
        public required string Name { get; set; }
        public ICollection<Card> cards { get; set; } = new List<Card>();
    }
}
