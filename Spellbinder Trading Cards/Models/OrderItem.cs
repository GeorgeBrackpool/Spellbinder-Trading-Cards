using Microsoft.EntityFrameworkCore;

namespace SpellbinderTradingCards.Models
{
    public class OrderItem
    {
        public int OrderItemId { get; set; }
        public int OrderId { get; set; }
        public int CardId { get; set; }
        public int Quantity { get; set; }
        [Precision(10,2)]
        public decimal PriceAtPurchase { get; set; }

        public Card Card { get; set; } = null!;
        public Order Order { get; set; } = null!;

    }
}
