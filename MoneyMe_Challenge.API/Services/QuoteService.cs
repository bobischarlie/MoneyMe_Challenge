using AutoMapper;
using MoneyMe_Challenge.API.Services.Interface;
using MoneyMe_Challenge.CORE.Contracts;
using MoneyMe_Challenge.CORE.Entity;
using MoneyMe_Challenge.CORE.Model;
using MoneyMe_Challenge.DATA.Repository.Interface;

namespace MoneyMe_Challenge.API.Services
{
    public class QuoteService : IQuoteService
    {
        private readonly IQuoteRepository _quoteRepository;
        private readonly IMapper _mapper;
        private readonly IConfiguration _config;
        public QuoteService(IQuoteRepository quoteRepository, IMapper mapper)
        {
            _quoteRepository = quoteRepository;
            _mapper = mapper;
        }
        public async Task<Guid> UpsertQuoteRequestAsync(QuoteRequestContract quote)
        {
            var hasQuoteAlready = await _quoteRepository.GetQuoteRequestBeforeAsync(quote.FirstName, quote.LastName, quote.DateOfBirth);
            var returnId = new Guid();
            if (hasQuoteAlready == null)
            {
                var quoteEntity = _mapper.Map<QuoteEntity>(quote);
                quoteEntity.Id = Guid.NewGuid();
                await _quoteRepository.AddAsync(quoteEntity);
                returnId = quoteEntity.Id;
            }
            else
            {
                _mapper.Map(quote, hasQuoteAlready);
                await _quoteRepository.UpdateAsync(hasQuoteAlready);
                returnId = hasQuoteAlready.Id;
            }
            return returnId;
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

        public async Task<Quote> UpdateApplicationStatus(Quote quote)
        {
            var toUpdateQuote = await _quoteRepository.GetAppliedQuotationsByIdAsync(quote.Id);
            if (toUpdateQuote == null)
            {
                return null;
            }
            var mappedQuote = _mapper.Map(quote, toUpdateQuote);
            await _quoteRepository.UpdateAsync(mappedQuote);

            return _mapper.Map<Quote>(quote);
        }
    }
}