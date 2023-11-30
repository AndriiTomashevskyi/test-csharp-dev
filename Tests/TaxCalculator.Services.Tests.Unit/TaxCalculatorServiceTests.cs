using Moq;
using TaxCalculator.Domain.Models;
using TaxCalculator.Interfaces;

namespace TaxCalculator.Services.Tests.Unit
{
    public class TaxCalculatorServiceTests
    {
        [Theory]
        [InlineData(0, 0)]
        [InlineData(-1, 0)]
        [InlineData(5000, 0)]
        [InlineData(10000, 1000)]
        [InlineData(40000, 11000)]
        public async void CalculateTax_Success_TaxCalculated(decimal salary, decimal expected)
        {
            //Arrange
            var mockTaxBandRepository = new Mock<ITaxBandRepository>();
            mockTaxBandRepository.Setup(r => r.GetAllTaxBands(false))
                .Returns(Task.FromResult<IEnumerable<TaxBand>>(new List<TaxBand>
                {
                    new() { LowerLimit = 0, UpperLimit = 5000, TaxRate = 0 },
                    new() { LowerLimit = 5000, UpperLimit = 20000, TaxRate = 20 },
                    new() { LowerLimit = 20000, TaxRate = 40 }
                }));
            var service = new TaxCalculatorService(mockTaxBandRepository.Object);

            //Act
            var actual = await service.CalculateTax(salary);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}