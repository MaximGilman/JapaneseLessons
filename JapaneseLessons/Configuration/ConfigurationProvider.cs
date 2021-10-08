using JapaneseLessons.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace JapaneseLessons.Configuration
{
    public class ConfigurationProvider
    {
        public static ServiceCollection ConfigureServices(string connectionString)
        {
            var services = new ServiceCollection();
            services.AddDbContext<MyLessonsContext>(
                contextLifetime: ServiceLifetime.Scoped,
                optionsAction: options => options.UseNpgsql(connectionString));
            return services;
        }
    }
}