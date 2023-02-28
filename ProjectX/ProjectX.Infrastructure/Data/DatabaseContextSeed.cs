using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ProjectX.Core.Entities;

namespace ProjectX.Infrastructure.Data
{
    public class DatabaseContextSeed
    {
        public static async Task SeedAsync(IServiceProvider serviceProvider, int? retry = 0)
        {
            using (var context = new DatabaseContext(serviceProvider.GetRequiredService<DbContextOptions<DatabaseContext>>()))
            {
                int retryForAvailability = retry.Value;

                try
                {
                    // TODO: Only run this if using a real database
                    context.Database.Migrate();
                    context.Database.EnsureCreated();
                    // **

                    if (!context.Masters.Any())
                    {
                        context.Masters.AddRange(GetPreconfiguredMasters());
                        await context.SaveChangesAsync();
                    }
                }
                catch (Exception)
                {
                    if (retryForAvailability < 10)
                    {
                        retryForAvailability++;
                        // add ILoggerFactory as parameter
                        //var log = loggerFactory.CreateLogger<DatabaseContextSeed>();
                        //log.LogError(exception.Message);
                        await SeedAsync(serviceProvider, retryForAvailability);
                    }

                    throw;
                }
            }
        }

        private static IEnumerable<Master> GetPreconfiguredMasters()
        {
            return new List<Master>()
            {
                new Master() { Name = "Валентина", Surname = "Щербакова", MiddleName = "Юрьевна"},
                new Master() { Name = "Анастасия", Surname = "Экснер", MiddleName = "Юрьевна"}

            };
        }
    }
}
