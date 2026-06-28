namespace Spellbinder_Trading_Cards.Models
{
    public class CartItem
    {
        public int CartItemId { get; set; }
        public int CartId { get; set; }
        public int CardId { get; set; }
        public int Quantity { get; set; }
    }
}
