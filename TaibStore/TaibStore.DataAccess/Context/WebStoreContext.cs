using Microsoft.EntityFrameworkCore;
using TaibStore.Model.Models;

namespace TaibStore.DataAccess.Context
{
    public class WebStoreContext : DbContext
    {
        public DbSet<BasketPosition> BasketPositions { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderPosition> OrderPositions { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }

        public WebStoreContext(DbContextOptions<WebStoreContext> options)
            : base(options) { }
    }
}
