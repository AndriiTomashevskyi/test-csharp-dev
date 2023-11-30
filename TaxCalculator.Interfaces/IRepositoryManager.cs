using System.Threading.Tasks;

namespace TaxCalculator.Interfaces
{
    public interface IRepositoryManager
    {
        ITaxBandRepository TaxBand { get; }
        Task Save();
    }
}
