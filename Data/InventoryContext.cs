using Microsoft.EntityFrameworkCore;
using InventoryApi.Models;

namespace InventoryApi.Data
{
    public class InventoryContext : DbContext
    {
        public InventoryContext(DbContextOptions<InventoryContext> options) : base(options) { }
        public DbSet<Item> Items { get; set; }
    }
}