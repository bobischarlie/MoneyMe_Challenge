using MoneyMe_Challenge.CORE.Entity;

namespace MoneyMe_Challenge.DATA.Repository.Interface
{
    public interface IQuoteRepository : IGenericRepository<QuoteEntity>
    {
        Task<QuoteEntity> GetQuoteRequestBeforeAsync(string firstName, string lastName, DateOnly dateOfBirth);
        Task<QuoteEntity> GetAppliedQuotationsByIdAsync(Guid guid);
    }
}
