using Microsoft.EntityFrameworkCore;
using MultiLingualEcommerceAPI.Models;

namespace MultiLingualEcommerceAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Product> Products { get; set; }
    }
}
