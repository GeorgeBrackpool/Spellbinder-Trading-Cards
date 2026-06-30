namespace SpellbinderTradingCards.Models
{
    public class Set
    {
        public int SetId { get; set; }
        public required string Name { get; set; }
        public ICollection<Card> cards { get; set; } = new List<Card>();
    }
}
