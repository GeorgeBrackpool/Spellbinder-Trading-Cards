using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SpellbinderTradingCards.Data;
using System.ComponentModel.DataAnnotations;

namespace SpellbinderTradingCards.Models
{
    public class Order
    {
        public int OrderId {  get; set; }
        public required string UserId { get; set; }
        public required ApplicationUser User { get; set; }
        public DateTime OrderDate { get; set; }
        [Precision(10,2)]
        public decimal TotalPrice { get; set; }
        [Unicode(false)]
        [MaxLength(50)]
        public required string Status { get; set; }

        public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

    }
}
