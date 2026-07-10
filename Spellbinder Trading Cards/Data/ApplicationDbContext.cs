using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SpellbinderTradingCards.Data.Seed;
using SpellbinderTradingCards.Models;

namespace SpellbinderTradingCards.Data;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
    
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
       
    }
    public DbSet<TradingCardGame> TradingCardGames { get; set; }
    public DbSet<Card> Cards { get; set; }
    public DbSet<CartItem> CartItems { get; set; }
    public DbSet<Condition> Conditions { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderItem> OrderItems { get; set; }
    public DbSet<Rarity> Rarities { get; set; }
    public DbSet<Set> Sets { get; set; }
    public DbSet<ShoppingCart> ShoppingCarts { get; set; }

    //TODO: Update ERD and Data dictionary,  create view model to show data from this in view. https://stackoverflow.com/questions/11064316/what-is-viewmodel-in-mvc
    // Data seeding reference https://learn.microsoft.com/en-us/ef/core/modeling/data-seeding

    protected override void OnModelCreating(ModelBuilder modelBuilder)
     {
         // Call the base Identity configuration first(e.g. users), then apply custom model configuration (e.g. seeded lookup data).
         base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Set>()
       .HasOne(s => s.TradingCardGame)
       .WithMany(t => t.Sets)
       .HasForeignKey(s => s.TradingCardGameId)
       .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Rarity>()
            .HasOne(r => r.TradingCardGame)
            .WithMany(t => t.Rarities)
            .HasForeignKey(r => r.TradingCardGameId)
            .OnDelete(DeleteBehavior.Restrict);

        TradingCardGameSeed.Seed(modelBuilder);
        ConditionSeed.Seed(modelBuilder);
        RaritySeed.Seed(modelBuilder);
        SetSeed.Seed(modelBuilder);

     }
}