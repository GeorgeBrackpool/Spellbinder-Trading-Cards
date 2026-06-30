namespace SpellbinderTradingCards.Models
{
    public class CartItem
    {
        public int CartItemId { get; set; }
        public int CartId { get; set; }
        public ShoppingCart ShoppingCart { get; set; } = null!;
        public int CardId { get; set; }
        public Card Card { get; set; } = null!;
        public int Quantity { get; set; }

        
    }
}
