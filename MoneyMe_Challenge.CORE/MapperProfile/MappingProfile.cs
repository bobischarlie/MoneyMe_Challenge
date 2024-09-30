using AutoMapper;
using MoneyMe_Challenge.CORE.Contracts;
using MoneyMe_Challenge.CORE.Entity;
using MoneyMe_Challenge.CORE.Model;

namespace MoneyMe_Challenge.CORE.MapperProfile
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Quote, QuoteEntity>()
            .ReverseMap();

            CreateMap<Blacklist, BlacklistEntity>()
            .ReverseMap();

            CreateMap<QuoteRequestContract, QuoteEntity>() 
            .ReverseMap();

            CreateMap<QuoteRequestContract, Quote>()
            .ReverseMap();
        }
    }
}
