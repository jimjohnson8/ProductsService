using Microsoft.EntityFrameworkCore;
using ProductsService.Models;

namespace ProductsService.Data
{
    // The ProductContext class represents the Entity Framework Core database context for the application.
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options) {}
        public DbSet<Product> Products { get; set; } = null!;
    }
}
