using CafeCore.Models.Models;
using Microsoft.EntityFrameworkCore;

namespace CafeCore.Data.Context;

public class ProductContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    

    public ProductContext(DbContextOptions<ProductContext> options)
        : base(options)
    {
        Database.EnsureCreated();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        
    }
}