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
        public async Task Add(Quote quote)
        {
            var quoteEntity = _mapper.Map<QuoteEntity>(quote);
            await _quoteRepository.AddAsync(quoteEntity);
        }
    }
}
