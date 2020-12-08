using AutoMapper;
using MoneyExchange.API.Entities;
using MoneyExchange.API.Models.Dto;

namespace MoneyExchange.API.Mappers
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<ExchangeRate, ExchangeRateDto>().ReverseMap();
        }
    }
}
