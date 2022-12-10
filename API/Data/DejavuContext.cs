using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DejavuContext : DbContext
    {
        public DejavuContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
