using JapaneseLibrary.Context;
using JapaneseLibrary.Models;
using JapaneseLibrary.Repositories;
using JapaneseLibrary.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Utils;

namespace JapaneseLibrary
{
    public class LibraryModule : Module
    {
        public override void Load(IServiceCollection services)
        {
            services.AddScoped<IRepository<Word>, Repository<Word>>();
            services.AddScoped<IRepository<Try>, Repository<Try>>();
            services.AddScoped<IRepository<DefaultUser>, Repository<DefaultUser>>();
            services.AddScoped<IRepository<User>, Repository<User>>();

            services.AddSingleton<WordProducer>();

            services.AddDbContext<MyLessonsContext>(
                contextLifetime: ServiceLifetime.Scoped,
                optionsAction: options => options.UseNpgsql(Configuration.GetConnectionString("local")));
        }
    }
}
