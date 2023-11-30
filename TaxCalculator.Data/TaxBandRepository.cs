using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using TaxCalculator.Domain.Models;
using TaxCalculator.Interfaces;

namespace TaxCalculator.Data
{
    public class TaxBandRepository : RepositoryBase<TaxBand>, ITaxBandRepository
    {
        public TaxBandRepository(RepositoryContext repositoryContext)
            : base(repositoryContext) { }

        public async Task<IEnumerable<TaxBand>> GetAllTaxBands(bool trackChanges)
        {
            return await FindAll(trackChanges).ToListAsync();
        }
    }
}
