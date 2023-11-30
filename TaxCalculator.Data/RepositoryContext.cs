using Microsoft.EntityFrameworkCore;
using TaxCalculator.Data.Configuration;
using TaxCalculator.Domain.Models;

namespace TaxCalculator.Data
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
            => modelBuilder.ApplyConfiguration(new TaxBandConfiguration());

        public DbSet<TaxBand> TaxBands { get; set; }
    }
}
