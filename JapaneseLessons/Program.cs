using JapaneseLessons.Forms;
using JapaneseLessons.Models;
using JapaneseLessons.Repositories;
using JapaneseLessons.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using JapaneseLessons.Forms.Users;

namespace JapaneseLessons
{
    static class Program
    {
        public static IServiceProvider ServiceProvider { get; set; }
        static void ConfigureServices()
        {
            var services = new ServiceCollection();
            services.AddScoped<IRepository<Word>, Repository<Word>>();
            services.AddScoped<IRepository<Try>, Repository<Try>>();
            services.AddScoped<IRepository<DefaultUser>, Repository<DefaultUser>>();
            services.AddScoped<IRepository<User>, Repository<User>>();

            services.AddSingleton<WordProducer>();

            services.AddSingleton<CreateUserForm>();

            ServiceProvider = services.BuildServiceProvider();
        }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        private static async Task Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ConfigureServices();

            var mainForm = await MainForm.CreateFormAsync();
            Application.Run(mainForm);
        }
    }
}
