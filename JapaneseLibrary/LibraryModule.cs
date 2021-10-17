using JapaneseLibrary.Context;
using JapaneseLibrary.Models;
using JapaneseLibrary.Repositories;
using JapaneseLibrary.Services;
using JapaneseLibrary.UseCases.User;
using JapaneseLibrary.UseCases.Word;
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

            services.AddScoped<WordProducer>();

            services.AddScoped<GetUser>();
            services.AddScoped<CreateUser>();
            services.AddScoped<GetUsers>();

            services.AddScoped<GetWords>();
            services.AddScoped<CreateWord>();
            services.AddScoped<EditWord>();

            services.AddDbContext<MyLessonsContext>(
                contextLifetime: ServiceLifetime.Scoped,
                optionsAction: options => options.UseNpgsql(Configuration.GetConnectionString("local")));
        }
    }
}
