using Microsoft.AspNetCore.Mvc;
using TaxCalculator.Interfaces;

namespace TaxCalculator.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TaxCalculatorController : ControllerBase
    {
        private readonly ITaxCalculatorService _taxCalculatorService;
        private readonly ILogger<TaxCalculatorController> _logger;

        public TaxCalculatorController(ITaxCalculatorService taxCalculatorService,
            ILogger<TaxCalculatorController> logger)
        {
            _taxCalculatorService = taxCalculatorService;
            _logger = logger;
        }

        [HttpPost]
        public async Task<IActionResult> CalculateTax([FromBody] decimal salary)
        {
            var tax = await _taxCalculatorService.CalculateTax(salary);

            return Ok(tax);
        }
    }
}