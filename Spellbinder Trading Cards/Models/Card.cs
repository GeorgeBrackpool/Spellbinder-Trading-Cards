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
        public required string ImageUrl { get; set; }
        [NotMapped]
        public string? ImageFileName { get; set; }
        public int TradingCardGameId { get; set; }
        public TradingCardGame? TradingCardGame { get; set; }
        [MaxLength(500)]
        public string? Description { get; set; }
        public int RarityId { get; set; }
        public Rarity? Rarity { get; set; }
        public int ConditionId { get; set; }
        public Condition? Condition { get; set; }
        public ICollection<OrderItem> OrderItem { get; set; } = new List<OrderItem>();
        public ICollection<CartItem> CartItem { get; set; } = new List<CartItem>();

        public int SetId { get; set; }
        public Set? Set { get; set; }
        public int StockQuantity { get; set; }
        public DateTime CreatedDate { get; set; }


    }
}
