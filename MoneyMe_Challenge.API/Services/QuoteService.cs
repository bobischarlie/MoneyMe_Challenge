using AutoMapper;
using MoneyMe_Challenge.API.Services.Interface;
using MoneyMe_Challenge.CORE.Entity;
using MoneyMe_Challenge.CORE.Model;
using MoneyMe_Challenge.DATA.Repository.Interface;

namespace MoneyMe_Challenge.API.Services
{
    public class QuoteService : IQuoteService
    {
        private readonly IQuoteRepository _quoteRepository;
        private readonly IMapper _mapper;
        public QuoteService(IQuoteRepository quoteRepository, IMapper mapper)
        {
            _quoteRepository = quoteRepository;
            _mapper = mapper;
        }
        public async Task<Guid> UpsertAsync(Quote quote)
        {
            var hasQuoteAlready = await _quoteRepository.GetQuoteRequestBefore(quote.FirstName, quote.LastName, quote.DateOfBirth);
            if (hasQuoteAlready == null)
            {
                var quoteEntity = _mapper.Map<QuoteEntity>(quote);
                quoteEntity.Id = Guid.NewGuid();
                await _quoteRepository.AddAsync(quoteEntity);
                return quoteEntity.Id;
            }
            else
            {
                _mapper.Map(quote, hasQuoteAlready);
                await _quoteRepository.UpdateAsync(hasQuoteAlready);
                return hasQuoteAlready.Id;
            }
        }

        public async Task<Quote> GetQuoteAsync(Guid quoteId)
        {
            var quoteEntity = await _quoteRepository.GetByIdAsync(quoteId);
            if (quoteEntity == null)
            {
                return null;
            }
            else
            {
                return _mapper.Map<Quote>(quoteEntity);
            }
        }
    }
}