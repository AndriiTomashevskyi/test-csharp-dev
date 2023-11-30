using System.Threading.Tasks;

namespace TaxCalculator.Interfaces
{
    public interface ITaxCalculatorService
    {
        Task<decimal> CalculateTax(decimal salary);
    }
}
