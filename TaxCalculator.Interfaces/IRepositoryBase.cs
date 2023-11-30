using System.Linq;

namespace TaxCalculator.Interfaces
{
    public interface IRepositoryBase<T>
    {
        IQueryable<T> FindAll(bool trackChanges);
    }
}
