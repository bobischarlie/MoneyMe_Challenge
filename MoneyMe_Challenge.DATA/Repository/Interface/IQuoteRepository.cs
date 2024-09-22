using MoneyMe_Challenge.CORE.Entity;
using MoneyMe_Challenge.CORE.Model;

namespace MoneyMe_Challenge.DATA.Repository.Interface
{
    public interface IQuoteRepository : IGenericRepository<QuoteEntity>
    {
        Task<QuoteEntity> GetQuoteRequestBefore(string firstName, string lastName, DateOnly dateOfBirth);
    }
}
