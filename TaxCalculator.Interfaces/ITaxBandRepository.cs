using System.Collections.Generic;
using System.Threading.Tasks;
using TaxCalculator.Domain.Models;

namespace TaxCalculator.Interfaces
{
    public interface ITaxBandRepository
    {
       Task< IEnumerable<TaxBand>> GetAllTaxBands(bool trackChanges);
    }
}
