using System;
using System.Threading.Tasks;
using TaxCalculator.Interfaces;

namespace TaxCalculator.Services
{
    public class TaxCalculatorService : ITaxCalculatorService
    {
        private readonly ITaxBandRepository _taxBandRepository;

        public TaxCalculatorService(ITaxBandRepository taxBandRepository)
        {
            _taxBandRepository = taxBandRepository;
        }

        public async Task<decimal> CalculateTax(decimal salary)
        {
            if (salary <= 0) return 0;

            decimal tax = 0;
            var taxBands = await _taxBandRepository.GetAllTaxBands(trackChanges: false);

            foreach (var band in taxBands)
            {
                if (salary > band.LowerLimit)
                {
                    var taxableIncome =
                        band.UpperLimit.HasValue ?
                            Math.Min(salary - band.LowerLimit, band.UpperLimit.Value - band.LowerLimit) :
                            salary - band.LowerLimit;
                    tax += taxableIncome * band.TaxRate / 100;
                }
            }

            return tax;
        }
    }
}
