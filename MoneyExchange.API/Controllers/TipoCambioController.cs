using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MoneyExchange.API.Models.Dto;
using MoneyExchange.API.Services;

namespace MoneyExchange.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoCambioController : ControllerBase
    {
        private readonly IMoneyExchangeService _moneyExchangeService;

        public TipoCambioController(IMoneyExchangeService moneyExchangeService)
        {
            _moneyExchangeService = moneyExchangeService;
        }

        [HttpGet]
        public IEnumerable<ExchangeRateDto> Get()
        {
            return _moneyExchangeService.Get();
        }

        [HttpGet("{exchangeRateId}")]
        public ExchangeRateDto Get(int exchangeRateId)
        {
            return _moneyExchangeService.Get(exchangeRateId);
        }

        [HttpPost]
        public ExchangeRateDto Post([FromBody] ExchangeRateDto exchangeRateDto)
        {            
            return _moneyExchangeService.Add(exchangeRateDto);
        }
    }
}
