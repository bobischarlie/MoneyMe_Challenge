using MoneyMe_Challenge.CORE.Entity;

namespace MoneyMe_Challenge.DATA.Repository.Interface
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        Task<T> GetByIdAsync(Guid id);
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
    }
}
