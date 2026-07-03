using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SpellbinderTradingCards.Models
{
    //https://learn.microsoft.com/en-us/dotnet/framework/data/adonet/sql-server-data-type-mappings
    // The question mark after string indicates that the property is nullable
    public class Card
    {
        public int CardId { get; set; }

        [MaxLength(100)]
        public required string Name { get; set; }
        [Precision(10,2)]
        public decimal Price { get; set; }
        [MaxLength(500)]
        public string? ImageUrl { get; set; }
        public int BrandId { get; set; }
        public Brand Brand { get; set; } = null!;
        [MaxLength(500)]
        public string? Description { get; set; }
        public int RarityId { get; set; }
        public Rarity Rarity { get; set; } = null!;
        public int ConditionId { get; set; }
        public Condition Condition { get; set; } = null!;
        public ICollection<OrderItem> OrderItem { get; set; } = new List<OrderItem>();
        public ICollection<CartItem> CartItem { get; set; } = new List<CartItem>();

        public int SetId { get; set; }
        public Set Set { get; set; } = null!;
        public int StockQuantity { get; set; }
        public DateTime CreatedDate { get; set; }


    }
}
