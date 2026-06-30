namespace SpellbinderTradingCards.Models
{
    public class Brand
    {
        public int BrandId { get; set; }
        public required string Name { get; set; }

        public ICollection<Card> cards { get; set; } = new List<Card>();
    }
}
