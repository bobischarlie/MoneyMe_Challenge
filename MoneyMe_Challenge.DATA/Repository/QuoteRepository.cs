using Microsoft.EntityFrameworkCore;
using MoneyMe_Challenge.CORE.Entity;
using MoneyMe_Challenge.CORE.Enum;
using MoneyMe_Challenge.DATA.Repository.Interface;

namespace MoneyMe_Challenge.DATA.Repository
{
    public class QuoteRepository : GenericRepository<QuoteEntity>, IQuoteRepository
    {
        private AppDbContext _appDbContext;
        public QuoteRepository(AppDbContext context) : base(context)
        {
            _appDbContext = context;
        }

        public async Task<QuoteEntity> GetQuoteRequestBeforeAsync(string firstName, string lastName, DateOnly dateOfBirth)
        {
            var quoteEntity = await _appDbContext.Quote
                 .Where(q => q.FirstName == firstName && q.LastName == lastName && q.DateOfBirth == dateOfBirth 
                 && q.Status == ApplicationStatus.Applied)
                 .FirstOrDefaultAsync();
            if (quoteEntity == null)
            {
                return null;
            }
            return quoteEntity;
        }

        public async Task<QuoteEntity> GetAppliedQuotationsByIdAsync(Guid guid)
        {
            var quoteEntity = await _appDbContext.Quote
                .Where(q => q.Id == guid && (q.Status != ApplicationStatus.Declined || q.Status != ApplicationStatus.Approved))
                .FirstOrDefaultAsync();
            if(quoteEntity == null)
            {
                return null;
            }
            return quoteEntity;
        }

    }
}