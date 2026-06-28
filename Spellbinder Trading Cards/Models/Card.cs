using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Spellbinder_Trading_Cards.Models
{
    //https://learn.microsoft.com/en-us/dotnet/framework/data/adonet/sql-server-data-type-mappings
    // The question mark after string indicates that the property is nullable
    public class Card
    {
        public int CardId { get; set; }
        public required string Name { get; set; }
        public decimal Price { get; set; }
        public string? ImageUrl { get; set; }
        public int BrandId { get; set; }
        public string? Description { get; set; }
        public int RarityId { get; set; }
        public int ConditionId { get; set; }
        public int SetId { get; set; }
        public int StockQuantity { get; set; }
        public DateTime CreatedDate { get; set; }


    }
}
