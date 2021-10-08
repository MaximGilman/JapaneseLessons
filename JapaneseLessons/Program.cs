using JapaneseLessons.Forms;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JapaneseLessons
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        private static async Task Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var mainForm = await MainForm.CreateFormAsync();
            Application.Run(mainForm);
        }
    }
}
