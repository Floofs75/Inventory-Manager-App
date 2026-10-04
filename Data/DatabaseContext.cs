using InventoryManager.Core;
using Microsoft.EntityFrameworkCore;

namespace InventoryManager.Data
{
    public class DatabaseContext : DbContext
    {

        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string dbPath = System.IO.Path.Combine(folder, "inventory.db");
            optionsBuilder.UseSqlite($"Data Source={dbPath}");
        }

    }
}
