using EFCoreDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCoreDemo.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
         
        }

        public DbSet<ShopItem> ShopItems { get; set; }

        public DbSet<Shop> Shop { get; set; }
    }
}
