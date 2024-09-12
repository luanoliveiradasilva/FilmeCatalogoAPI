using app.Infrastructure;
using Microsoft.Extensions.DependencyInjection;

namespace App.Tests.Integration
{
    public class DatabaseInitializer
    {
        public static void CreateDbForTest(IServiceProvider serviceProvider)
        {
            using (var scope = serviceProvider.CreateScope())
            {
                var provider = scope.ServiceProvider;

                var db = provider.GetRequiredService<FilmesNetDbContext>();

                db.Database.EnsureCreated();
            }
        }
    }
}