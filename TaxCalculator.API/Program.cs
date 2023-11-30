using NLog.Web;
using TaxCalculator.API.Extensions;
using TaxCalculator.Data;
using TaxCalculator.Interfaces;
using TaxCalculator.Services;

namespace TaxCalculator.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.ConfigureCors();

            builder.Services.ConfigureSqlContext(builder.Configuration);

            builder.Services.ConfigureRepositoryManager();

            builder.Services.AddScoped<ITaxBandRepository, TaxBandRepository>();
            builder.Services.AddScoped<ITaxCalculatorService, TaxCalculatorService>();

            builder.Services.AddControllers();

            builder.Host.UseNLog();

            var app = builder.Build();

            var loggerFactory = app.Services.GetRequiredService<ILoggerFactory>();
            var logger = loggerFactory.CreateLogger(nameof(ExceptionMiddlewareExtensions));
            app.ConfigureExceptionHandler(logger);

            // Configure the HTTP request pipeline.
            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.UseCors("CorsPolicy");

            app.MapControllers();

            app.Run();
        }
    }
}