using EFCoreDemo.Entities;
using Microsoft.EntityFrameworkCore;

namespace EFCoreDemo.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)

        {
            if (!Shops.Any())
            {
                Shops.Add(new Shop()
                {
                    Name = "Default Shop"
                });
                SaveChanges();
            }
        }


        public DbSet<ShopItem>? ShopItems { get; set; }
        public DbSet<Shop>? Shops { get; set; }


    }
}
