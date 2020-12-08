using System;

namespace MoneyExchange.API.Models.Dto
{
    public class ExchangeRateDto
    {
        public int ExchangeRateId { get; set; }

        public DateTime Date { get; set; }

        public float Rate { get; set; }

        public DateTime WhenObtained { get; set; }
    }
}
