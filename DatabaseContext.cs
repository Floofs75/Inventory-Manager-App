using Microsoft.EntityFrameworkCore;

namespace InventoryManager
{
    public class DatabaseContext : DbContext
    {

        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = inventory.db");
        }

    }
}
