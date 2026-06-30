namespace SpellbinderTradingCards.Models
{
    public class Condition
    {
        public int ConditionId { get; set; }
        public required string Name { get; set; }
        public ICollection<Card> cards { get; set; } = new List<Card>();
    }
}
