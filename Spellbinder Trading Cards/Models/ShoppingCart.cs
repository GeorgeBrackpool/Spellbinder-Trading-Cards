using Microsoft.AspNetCore.Identity;
using SpellbinderTradingCards.Data;

namespace SpellbinderTradingCards.Models
{
    public class ShoppingCart
    {
        public int ShoppingCartId { get; set; }
        public required string UserId { get; set; }
        public required ApplicationUser User { get; set; }
        public ICollection<CartItem> CartItems { get; set; } = new List<CartItem>();

    }
}
