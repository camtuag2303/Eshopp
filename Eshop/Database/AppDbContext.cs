using Eshop.Database.Configs;
using Eshop.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace Eshop.Database
{
    public class AppDbContext:DbContext
    {
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<Product> Products { get; set; }
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // goi class cau hinh
            modelBuilder.ApplyConfiguration(new ProductCategoryConfig());
            modelBuilder.ApplyConfiguration(new ProductConfig());
        }
    }
}
