using Microsoft.EntityFrameworkCore;
using MoneyMe_Challenge.CORE.Entity;

namespace MoneyMe_Challenge.DATA.Repository
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public virtual DbSet<QuoteEntity> Quote { get; set; }

    }
}
