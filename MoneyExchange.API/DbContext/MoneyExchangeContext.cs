using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MoneyExchange.API.Entities;
using System;

namespace MoneyExchange.API.DbContext
{
    public class MoneyExchangeContext : IdentityDbContext
    {
        public MoneyExchangeContext(DbContextOptions<MoneyExchangeContext> options)
            :base(options)
        {

        }

        public DbSet<ExchangeRate> ExchangeRates { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ExchangeRate>().HasIndex(er => er.ExchangeRateId);

            // Seed the DB
            modelBuilder.Entity<ExchangeRate>().HasData(

                new ExchangeRate() {
                    ExchangeRateId = 1,
                    Date = DateTime.Now,
                    Rate = 6.66F,
                    WhenObtained = DateTime.Now
                },
                new ExchangeRate() {
                    ExchangeRateId = 2,
                    Date = DateTime.Now,
                    Rate = 6.66F,
                    WhenObtained = DateTime.Now
                },
                new ExchangeRate()
                {
                    ExchangeRateId = 3,
                    Date = DateTime.Now,
                    Rate = 6.66F,
                    WhenObtained = DateTime.Now
                },
                new ExchangeRate()
                {
                    ExchangeRateId = 4,
                    Date = DateTime.Now,
                    Rate = 6.66F,
                    WhenObtained = DateTime.Now
                },
                new ExchangeRate()
                {
                    ExchangeRateId = 5,
                    Date = DateTime.Now,
                    Rate = 6.66F,
                    WhenObtained = DateTime.Now
                }
            );

            base.OnModelCreating(modelBuilder);
        }
    }
}
