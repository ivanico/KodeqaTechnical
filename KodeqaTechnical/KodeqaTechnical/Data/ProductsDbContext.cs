using KodeqaTechnical.Models;
using Microsoft.EntityFrameworkCore;

namespace KodeqaTechnical.Data
{
    public class ProductsDbContext : DbContext
    {
        public ProductsDbContext(DbContextOptions<ProductsDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
