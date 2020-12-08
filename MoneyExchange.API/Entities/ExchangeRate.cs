using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneyExchange.API.Entities
{
    public class ExchangeRate
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int ExchangeRateId { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public float Rate { get; set; }

        [Required]
        public DateTime WhenObtained { get; set; }
    }
}
