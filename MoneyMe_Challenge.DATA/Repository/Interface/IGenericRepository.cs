using MoneyMe_Challenge.CORE.Entity;

namespace MoneyMe_Challenge.DATA.Repository.Interface
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        Task AddAsync(T entity);
    }
}
