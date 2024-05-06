using ApplicationCore.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class EShopDbContext : IdentityDbContext<ApplicationUser>
    {
        public EShopDbContext(DbContextOptions<EShopDbContext> options) :
            base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var conn = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build()
                .GetConnectionString("EShopDb");
            optionsBuilder.UseSqlServer(conn);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Cascade;
            }
        }

        public DbSet<Address> Address { get; set; }
        public DbSet<ApplicationUser> ApplicationUser { get; set; }
        public DbSet<CategoryVariation> CategoryVariation { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<ProductCategory> ProductCategory { get; set; }
        public DbSet<ProductVariationValue> ProductVariationValue { get; set; }
        public DbSet<Promotion> Promotion { get; set; }
        public DbSet<PromotionDetail> PromotionDetail { get; set; }
        public DbSet<Region> Region { get; set; }
        public DbSet<Review> Review { get; set; }
        public DbSet<Shipper> Shipper { get; set; }
        public DbSet<ShipperRegion> ShipperRegion { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItem { get; set; }
        public DbSet<UserAddress> UserAddress { get; set; }
        public DbSet<VariationValue> VariationValue { get; set; }
    }
}