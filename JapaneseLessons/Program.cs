using JapaneseLessons.Forms;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using JapaneseLessons.Forms.Users;
using JapaneseLibrary;
using Microsoft.Extensions.Configuration;
using Utils.Extensions;

namespace JapaneseLessons
{
    static class Program
    {
        public static IConfiguration Configuration;
        public static IServiceProvider ServiceProvider { get; set; }
        static void ConfigureServices()
        {
            var services = new ServiceCollection();
            var builder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            Configuration = builder.Build();

            services.RegisterModule<LibraryModule>(Configuration);

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
