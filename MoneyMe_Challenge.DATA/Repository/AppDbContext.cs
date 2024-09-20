using Microsoft.EntityFrameworkCore;
using MoneyMe_Challenge.CORE.Model;

namespace MoneyMe_Challenge.DATA.Repository
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public virtual DbSet<Quote> Quotes { get; set; }

    }
}
