using EFCoreDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCoreDemo.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
         
        }
        public DbSet<ShopItem>? ShopItems { get; set; }
        public DbSet<Shop> Shops { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            if(!Shops.Any())
            {
                Shops.Add(new Shop()
                {
                    Name = "Default Shop"
                });
                SaveChanges();
            }   
        }
    }
}
