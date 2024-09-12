using System.Data.Common;
using app.Infrastructure;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace App.Tests.Integration
{
    public class CustomWebApplicationFactory<TProgram> : WebApplicationFactory<TProgram> where TProgram : class
    {
        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            builder.ConfigureServices(services =>
            {
                var dbContextDescriptor = services.SingleOrDefault(
                    a => a.ServiceType == typeof(DbContextOptions<FilmesNetDbContext>));

                if (dbContextDescriptor != null)
                    services.Remove(dbContextDescriptor);

                var dbConnectionDescriptor = services.SingleOrDefault(
                    a => a.ServiceType == typeof(DbConnection));

                if (dbConnectionDescriptor != null)
                    services.Remove(dbConnectionDescriptor);

                services.AddDbContext<FilmesNetDbContext>(options =>
                {
                    options.UseInMemoryDatabase("InMemoryDbForTesting");
                });

                var sp = services.BuildServiceProvider();

                DatabaseInitializer.CreateDbForTest(sp);
            });
        }
    }
}