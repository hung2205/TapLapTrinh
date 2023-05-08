using Microsoft.EntityFrameworkCore;

namespace TapLapTrinh.Models
{
    public class ApplicationtestDBContext : DbContext
    {
        public ApplicationtestDBContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Category> Categorys { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
    }
}
