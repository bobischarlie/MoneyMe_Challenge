using Microsoft.EntityFrameworkCore;
using MoneyMe_Challenge.CORE.Entity;
using MoneyMe_Challenge.DATA.Repository.Interface;

namespace MoneyMe_Challenge.DATA.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private readonly AppDbContext _context;
        private readonly DbSet<T> _dbSet;
        public GenericRepository(AppDbContext context) 
        { 
            _context = context; 
            _dbSet = _context.Set<T>();
        }
        public async Task AddAsync(T entity)
        {
           await _dbSet.AddAsync(entity);
           await _context.SaveChangesAsync();
        }
    }
}
