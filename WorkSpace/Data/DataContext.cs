#nullable disable
using Microsoft.EntityFrameworkCore;
using WorkSpace.Entities;

namespace WorkSpace.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options) { }

        public DbSet<Product> Products { get; set; }
    }
}
