using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaxCalculator.Domain.Models;

namespace TaxCalculator.Data.Configuration
{
    internal class TaxBandConfiguration : IEntityTypeConfiguration<TaxBand>
    {
        public void Configure(EntityTypeBuilder<TaxBand> builder)
        {
            builder.HasData(
                new TaxBand
                {
                    Id = Guid.NewGuid(),
                    BandName = "TaxBandA",
                    LowerLimit = 0,
                    TaxRate = 0,
                    UpperLimit = 5000
                },
                new TaxBand
                {
                    Id = Guid.NewGuid(),
                    BandName = "TaxBandB",
                    LowerLimit = 5000,
                    TaxRate = 20,
                    UpperLimit = 20000
                },
                new TaxBand
                {
                    Id = Guid.NewGuid(),
                    BandName = "TaxBandC",
                    LowerLimit = 20000,
                    TaxRate = 40,
                }
            );
        }
    }
}
