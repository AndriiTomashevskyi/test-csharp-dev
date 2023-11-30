using System.Threading.Tasks;
using TaxCalculator.Interfaces;

namespace TaxCalculator.Data
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _repositoryContext;
        private ITaxBandRepository _taxBandRepository;

        public RepositoryManager(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
        }

        public ITaxBandRepository TaxBand => _taxBandRepository ?? (_taxBandRepository = new TaxBandRepository(_repositoryContext));

        public Task Save() => _repositoryContext.SaveChangesAsync();
    }
}
