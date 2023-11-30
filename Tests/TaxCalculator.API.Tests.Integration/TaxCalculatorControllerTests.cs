using System.Net.Http.Json;
using Microsoft.AspNetCore.Mvc.Testing;

namespace TaxCalculator.API.Tests.Integration
{
    public class TaxCalculatorControllerTests : IClassFixture<WebApplicationFactory<Program>>, IDisposable
    {
        private readonly WebApplicationFactory<Program> _factory;

        public TaxCalculatorControllerTests(WebApplicationFactory<Program> factory)
        {
            _factory = factory;
        }

        [Fact]
        public async Task CalculateTax_Success_ResultReturned()
        {
            //Arrange
            const string url = "/api/TaxCalculator";
            const string expected = "11000";
            using var client = _factory.CreateClient();
            var data = 40000;

            //Act
            var response = await client.PostAsJsonAsync(url, data);
            var result = await response.Content.ReadAsStringAsync();

            //Assert
            Assert.Equal(expected, result);
        }

        public void Dispose()
        {
            _factory.Dispose();
        }
    }
}